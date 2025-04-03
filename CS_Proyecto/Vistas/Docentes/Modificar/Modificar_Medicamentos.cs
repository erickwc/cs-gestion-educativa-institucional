using CS_Proyecto.Atributos;                    
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Docentes.Modificar
{
    public partial class Modificar_Medicamentos : Form
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

        public Modificar_Medicamentos()
        {
            InitializeComponent();

            dvg_med_docentes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dvg_med_docentes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dvg_med_docentes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            guna2AnimateWindow1.SetAnimateWindow(this);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        ValidarCampos validar = new ValidarCampos();
        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        int IdMedicamento;
        string estadoform = "Guardar";
        ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();

        private void txt_medicamento_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.NombreMedicamento = txt_medicamento.Text;
            validar.EstadoTextBoxOpcional(txt_medicamento);
        }

        private void txt_dosis_medicamento_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.Dosis = txt_dosis_medicamento.Text;
            validar.EstadoTextBoxOpcional(txt_dosis_medicamento);
        }

        private void txt_frecuencia_medicamento_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.Frecuencia = txt_frecuencia_medicamento.Text;
            validar.EstadoTextBoxOpcional(txt_frecuencia_medicamento);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(estadoform=="Guardar")
                {
                    CN_Empleado cN_Empleado = new CN_Empleado();
                    cN_Empleado.insertarMedicamentosDocentes(txt_medicamento.Text, txt_dosis_medicamento.Text, txt_frecuencia_medicamento.Text, Atributos_Empleado.IdDocente);
                    poblarMedicamentos();
                    txt_medicamento.Text = String.Empty;
                    txt_dosis_medicamento.Text = String.Empty;
                    txt_frecuencia_medicamento.Text = String.Empty;
                    estadoform = "Guardar";
                    btn_guardar.Text = "Agregar";
                    panel_tabla.Visible = true;
                    btn_nueva_medicamento.Visible = true;

                }
                else if (estadoform == "Editar")
                {
                    CN_Empleado cN_Empleado = new CN_Empleado();
                    cN_Empleado.modificarMedicamentos(txt_medicamento.Text, txt_dosis_medicamento.Text, txt_frecuencia_medicamento.Text, Atributos_Empleado.IdDocente, IdMedicamento);
                    poblarMedicamentos();
                    txt_medicamento.Text = String.Empty;
                    txt_dosis_medicamento.Text = String.Empty;
                    txt_frecuencia_medicamento.Text = String.Empty;
                    IdMedicamento = -1;
                    estadoform = "Guardar";
                    panel_tabla.Visible = true;
                    btn_nueva_medicamento.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            panel_tabla.Visible = true;
            btn_nueva_medicamento.Visible = true;
            separador.Visible = true;
            separador2.Visible = true;
        }

        private void añadirBtnEditarTabla()
        {
            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonEditarEnDataGrid(dvg_med_docentes);
            dvg_med_docentes.Columns["ImagenColumna"].DisplayIndex = 4;
            dvg_med_docentes.Columns["ImagenColumna"].Width = 90;

            DataGridViewColumn columnaImagen = dvg_med_docentes.Columns["ImagenColumna"];
            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;
            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.TopLeft;
        }

        private void añadirBtnEliminarTabla()
        {
            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonEliminarEnDataGrid(dvg_med_docentes);
            dvg_med_docentes.Columns["ImagenColumnaEliminar"].DisplayIndex = 3;
            dvg_med_docentes.Columns["ImagenColumnaEliminar"].Width = 100;

            DataGridViewColumn columnaImagen = dvg_med_docentes.Columns["ImagenColumnaEliminar"];
            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;
            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.TopLeft;

        }

        private void poblarMedicamentos()
        {
            CN_Empleado cn_empleado = new CN_Empleado();
            dvg_med_docentes.DataSource = cn_empleado.buscarMedicamentosEditarDocente(Atributos_Empleado.IdDocente);
            dvg_med_docentes.Columns["IdDetalleMedicamentosDocente"].Visible = false;
        }

        private void AjustarColumnas()
        {
            dvg_med_docentes.Columns["IdDetalleMedicamentosDocente"].Visible = false;
            dvg_med_docentes.Columns["Nombre Medicamento"].Width = 300;
            dvg_med_docentes.Columns["Dosis"].Width = 300;
        }

        private void Modificar_Medicamentos_Load(object sender, EventArgs e)
        {
            poblarMedicamentos();
            añadirBtnEditarTabla();
            añadirBtnEliminarTabla();
            AjustarColumnas();
        }

        private void actualizarform_Tick(object sender, EventArgs e)
        {
            if (
               !string.IsNullOrWhiteSpace(txt_dosis_medicamento.Text)
               && !string.IsNullOrWhiteSpace(txt_frecuencia_medicamento.Text)
               && !string.IsNullOrWhiteSpace(txt_medicamento.Text)
               )
            {
                btn_guardar.Visible = true;
            }
            else
            {
                btn_guardar.Visible = false;
            }
            this.Invalidate();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            panel_tabla.Visible = true;
            btn_nueva_medicamento.Visible = true;
            separador.Visible = true;
            separador2.Visible = true;
        }

        private void btn_nueva_medicamento_Click(object sender, EventArgs e)
        {
            panel_tabla.Visible = false;
            btn_nueva_medicamento.Visible = false;
            separador.Visible = false;
            separador2.Visible = false;
        }

        private void btn_regresar_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvg_medicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void dvg_med_docentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_med_docentes.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    panel_tabla.Visible = false;
                    btn_nueva_medicamento.Visible = false;
                    separador.Visible = false;
                    separador2.Visible = false;
                    DataGridViewRow dr = dvg_med_docentes.Rows[e.RowIndex];
                    txt_medicamento.Text = dr.Cells["Nombre Medicamento"].Value.ToString();
                    txt_dosis_medicamento.Text = dr.Cells["Dosis"].Value.ToString();
                    txt_frecuencia_medicamento.Text = dr.Cells["Frecuenca"].Value.ToString();
                    IdMedicamento = Convert.ToInt32(dr.Cells["IdDetalleMedicamentosDocente"].Value);
                    estadoform = "Editar";
                    btn_guardar.Text = "Guardar Cambios";
                  
                    validar.EstadoTextBox(txt_medicamento);
                    validar.EstadoTextBox(txt_dosis_medicamento);
                    validar.EstadoTextBox(txt_frecuencia_medicamento);
                }
            }
            else if (e.ColumnIndex == dvg_med_docentes.Columns["ImagenColumnaEliminar"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dvg_med_docentes.Rows[e.RowIndex];
                    IdMedicamento = Convert.ToInt32(dr.Cells["IdDetalleMedicamentosDocente"].Value);
                    Atributos_Empleado.IdMedicamento = Convert.ToInt32(IdMedicamento);

                    using (EliminarMedicamentoDocente eliminar = new EliminarMedicamentoDocente())
                    {
                        fondo.Oscurecer(eliminar);
                    }
                    poblarMedicamentos();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void separador_Click(object sender, EventArgs e)
        {

        }

        private void separador2_Click(object sender, EventArgs e)
        {

        }
    }
}
