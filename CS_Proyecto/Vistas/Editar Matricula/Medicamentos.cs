using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CS_Proyecto.Vistas.OscurecerFondo;
using CS_Proyecto.Vistas.Mensajes_Funcionales;

namespace CS_Proyecto.Vistas.Editar_Matricula
{
    public partial class Medicamentos : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Medicamentos()
        {
            InitializeComponent();

            dvg_med_alum.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dvg_med_alum.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dvg_med_alum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            guna2AnimateWindow1.SetAnimateWindow(this);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private string AccionBtn = "Guardar";
        private string IdMedicamento;

        ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
        CN_Alumnos cn_alumnos = new CN_Alumnos();
        ValidarCampos validar = new ValidarCampos();
        LimpiarVariables limpiar = new LimpiarVariables();

        private void AjustarFilas()
        {
            dvg_med_alum.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dvg_med_alum.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dvg_med_alum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void añadirBtnEditarTabla()
        {
            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonEditarEnDataGrid(dvg_med_alum);
            dvg_med_alum.Columns["ImagenColumna"].DisplayIndex = 4;
            dvg_med_alum.Columns["ImagenColumna"].Width = 90;

            DataGridViewColumn columnaImagen = dvg_med_alum.Columns["ImagenColumna"];
            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;
            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.TopLeft;
        }

        private void añadirBtnEliminarTabla()
        {
            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonEliminarEnDataGrid(dvg_med_alum);
            dvg_med_alum.Columns["ImagenColumnaEliminar"].DisplayIndex = 4;
            dvg_med_alum.Columns["ImagenColumnaEliminar"].Width = 100;

            DataGridViewColumn columnaImagen = dvg_med_alum.Columns["ImagenColumnaEliminar"];
            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;
            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.TopLeft;

        }

        private void MostrarMedicamentosDelAlumnoSeleccionado()
        {
            //Instancia para llenar la tabla
            CN_Alumnos cn_alumnos = new CN_Alumnos(); ;
            dvg_med_alum.DataSource = cn_alumnos.ConsultarMedicamentosAlumnoPorId(Atributos_Alumno.IdAlumno);
        }

        private void AjustarColumnas()
        {
            dvg_med_alum.Columns["IdMedicamento"].Visible = false;
            dvg_med_alum.Columns["Medicamento"].Width = 300;
            dvg_med_alum.Columns["Dosis"].Width = 300;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (AccionBtn == "Guardar")
                {
                    cn_alumnos.InsertarMedicamento(
                    Atributos_Alumno.NombreMedicamento,
                    Atributos_Alumno.Dosis,
                    Atributos_Alumno.Frecuencia,
                    Atributos_Alumno.IdAlumno
                    );

                    MostrarMedicamentosDelAlumnoSeleccionado();
                    LimpiarTextbox();
                    limpiar.limpiarVarMedicamento();
                    ValidarTextboxOpcional();
                   
                    panel_tabla.Visible = true;
                    btn_nueva_medicamento.Visible = true;

                }
                else if (AccionBtn == "Editar")
                {
                    cn_alumnos.ModificarMedicamento(
                    Atributos_Alumno.NombreMedicamento,
                    Atributos_Alumno.Dosis,
                    Atributos_Alumno.Frecuencia,
                    Convert.ToInt32(IdMedicamento)
                    );

                    MostrarMedicamentosDelAlumnoSeleccionado();
                    LimpiarTextbox();
                    limpiar.limpiarVarMedicamento();
                    AccionBtn = "Guardar";
                    ValidarTextboxOpcional();

                    AccionBtn = "Guardar";
                    btn_guardar.Text = "Agregar";
                    panel_tabla.Visible = true;
                    btn_nueva_medicamento.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidarTextboxOpcional()
        {
            validar.EstadoTextBoxOpcional(txt_dosis_medicamento);
            validar.EstadoTextBoxOpcional(txt_medicamento);
            validar.EstadoTextBoxOpcional(txt_frecuencia_medicamento);
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {
            MostrarMedicamentosDelAlumnoSeleccionado();
            añadirBtnEditarTabla();
            añadirBtnEliminarTabla();
            AjustarColumnas();
            AjustarFilas();
        }

        private void LimpiarTextbox()
        {
            txt_frecuencia_medicamento.Text = String.Empty;
            txt_medicamento.Text = String.Empty;
            txt_dosis_medicamento.Text = String.Empty;
        }

        private void dgv_medicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void txt_medicamento_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.NombreMedicamento = txt_medicamento.Text;
            validar.EstadoTextBoxOpcional(txt_medicamento);
        }

        private void txt_dosis_medicamento_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.Dosis = txt_dosis_medicamento.Text;
            validar.EstadoTextBoxOpcional(txt_dosis_medicamento);
        }

        private void txt_frecuencia_medicamento_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.Frecuencia = txt_frecuencia_medicamento.Text;
            validar.EstadoTextBoxOpcional(txt_frecuencia_medicamento);
        }

        private void ActualizarForm_Tick(object sender, EventArgs e)
        {
            if (
                  !string.IsNullOrWhiteSpace(Atributos_Alumno.NombreMedicamento)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.Frecuencia)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.Dosis)
                  )
            {
                btn_guardar.Visible = true;
            }
            else
            {
                btn_guardar.Visible = false;
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            panel_tabla.Visible = true;
            btn_nueva_medicamento.Visible = true;
            separador.Visible = true;
            separador2.Visible = true;
        }

        private void btn_regresar_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void separador_Click(object sender, EventArgs e)
        {

        }

        private void separador2_Click(object sender, EventArgs e)
        {

        }

        private void btn_nueva_medicamento_Click(object sender, EventArgs e)
        {
            panel_tabla.Visible = false;
            btn_nueva_medicamento.Visible = false;
            separador.Visible = false;
            separador2.Visible = false;
        }

        private void dvg_med_alum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_med_alum.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    panel_tabla.Visible = false;
                    btn_nueva_medicamento.Visible = false;
                    separador.Visible = false;
                    separador2.Visible = false;
                    DataGridViewRow dr = dvg_med_alum.Rows[e.RowIndex];
                    txt_dosis_medicamento.Text = dr.Cells["Dosis"].Value.ToString();
                    txt_medicamento.Text = dr.Cells["Medicamento"].Value.ToString();
                    txt_frecuencia_medicamento.Text = dr.Cells["Frecuencia"].Value.ToString();
                    IdMedicamento = dr.Cells["IdMedicamento"].Value.ToString();
                    AccionBtn = "Editar";
                    btn_guardar.Text = "Guardar Cambios";

                }
            }
            else if (e.ColumnIndex == dvg_med_alum.Columns["ImagenColumnaEliminar"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dvg_med_alum.Rows[e.RowIndex];
                    IdMedicamento = dr.Cells["IdMedicamento"].Value.ToString();

                    using (EliminarMedicamentoAlumno eliminar = new EliminarMedicamentoAlumno())
                    {
                        fondo.Oscurecer(eliminar);
                    }

                    MostrarMedicamentosDelAlumnoSeleccionado();

                }
            }
        }
    }
}
