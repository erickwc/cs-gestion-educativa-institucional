using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Dashboard;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using CS_Proyecto.Vistas.OscurecerFondo;
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

namespace CS_Proyecto.Vistas.Editar_Matricula
{
    public partial class Afecciones : Form
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
        public Afecciones()
        {
            InitializeComponent();
            dgv_afecciones.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_afecciones.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dgv_afecciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            guna2AnimateWindow1.SetAnimateWindow(this);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        ValidarCampos validar = new ValidarCampos();
        CN_Alumnos cn_alumnos = new CN_Alumnos();
        LimpiarVariables limpiar = new LimpiarVariables();
        ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();

        private string IdAfeccion = null;
        private string AccionBtn = "Guardar";

        private void AjustarTamañoColumnas()
        {
            dgv_afecciones.Columns["IdAfeccion"].Visible = false;
            dgv_afecciones.Columns["Tipo"].Width = 300;
            dgv_afecciones.Columns["Afección"].Width = 300;
        }

        private void AjustarFilas()
        {
            dgv_afecciones.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_afecciones.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dgv_afecciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void Afecciones_Load(object sender, EventArgs e)
        {
            MostrarAfeccionesDelAlumnoSeleccionado();
            añadirBtnEditarTabla();
            añadirBtnEliminarTabla();
            AjustarTamañoColumnas();
            AjustarFilas();
        }

        private void MostrarAfeccionesDelAlumnoSeleccionado()
        {
            //Instancia para llenar la tabla
            CN_Alumnos cn_alumnos = new CN_Alumnos(); ;
            dgv_afecciones.DataSource = cn_alumnos.ConsultarAfeccionesAlumnoPorId(Atributos_Alumno.IdAlumno);

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dgv_afecciones.Columns["Afección"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_afecciones.Columns["Tipo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_afecciones.Columns["Procedimiento"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_afecciones.Columns["IdAfeccion"].Visible = false;
        }

        private void añadirBtnEditarTabla()
        {
            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonEditarEnDataGrid(dgv_afecciones);
            dgv_afecciones.Columns["ImagenColumna"].DisplayIndex = 4;
            dgv_afecciones.Columns["ImagenColumna"].Width = 90;

            DataGridViewColumn columnaImagen = dgv_afecciones.Columns["ImagenColumna"];
            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;
            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.TopLeft;
        }

        private void añadirBtnEliminarTabla()
        {
            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonEliminarEnDataGrid(dgv_afecciones);
            dgv_afecciones.Columns["ImagenColumnaEliminar"].DisplayIndex = 4;
            dgv_afecciones.Columns["ImagenColumnaEliminar"].Width = 100;

            DataGridViewColumn columnaImagen = dgv_afecciones.Columns["ImagenColumnaEliminar"];
            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;
            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.TopLeft;
        }


        private void txt_afeccion_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.NombreAfeccion = txt_afeccion.Text;
            validar.EstadoTextBox(txt_afeccion);
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (AccionBtn == "Editar")
                {
                    cn_alumnos.ModificarAfecciones(
                    Atributos_Alumno.NombreAfeccion,
                    Atributos_Alumno.TipoAfeccion,
                    Atributos_Alumno.ProcedimientoMedico,
                    Convert.ToInt32(IdAfeccion)
                    );

                    MostrarAfeccionesDelAlumnoSeleccionado();
                    LimpiarTextbox();
                    limpiar.limpiarVarMedicamento();
                    ValidarTextboxOpcional();
                    AccionBtn = "Guardar";
                    btn_guardar.Text = "Agregar Afección";
                }
                else if(AccionBtn == "Guardar")
                {
                    cn_alumnos.InsertarInfecciones(
                    Atributos_Alumno.NombreAfeccion,
                    Atributos_Alumno.TipoAfeccion,
                    Atributos_Alumno.ProcedimientoMedico,
                    Atributos_Alumno.IdAlumno
                    );

                    MostrarAfeccionesDelAlumnoSeleccionado();
                    LimpiarTextbox();
                    limpiar.limpiarVarMedicamento();
                    ValidarTextboxOpcional();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            panel_tabla.Visible = true;
            btn_nueva_afeccion.Visible = true;
            separador.Visible = true;
            separador2.Visible = true;
        }

        private void ValidarTextboxOpcional()
        {
            validar.EstadoTextBoxOpcional(txt_afeccion);
            validar.EstadoTextBoxOpcional(txt_procedimiento);
            validar.EstadoTextBoxOpcional(txt_tipo);
        }

        private void LimpiarTextbox()
        {
            txt_afeccion.Text = String.Empty;
            txt_procedimiento.Text = String.Empty;
            txt_tipo.Text = String.Empty;
        }

        private void dgv_afecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            panel_tabla.Visible = true;
            btn_nueva_afeccion.Visible = true;
            separador.Visible = true;
            separador2.Visible = true;
        }

        private void txt_procedimiento_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.ProcedimientoMedico = txt_procedimiento.Text;
            validar.EstadoTextBox(txt_procedimiento);
        }

        private void txt_tipo_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.TipoAfeccion = txt_tipo.Text;
            validar.EstadoTextBox(txt_tipo);
        }

        private void ActualizarForm_Tick(object sender, EventArgs e)
        {
            if (
                !string.IsNullOrWhiteSpace(Atributos_Alumno.NombreAfeccion)
                && !string.IsNullOrWhiteSpace(Atributos_Alumno.TipoAfeccion)
                && !string.IsNullOrWhiteSpace(Atributos_Alumno.ProcedimientoMedico)
                )
            {
                btn_guardar.Visible = true;
            }
            else
            {
                btn_guardar.Visible = false;
            }
        }

        private void btn_nueva_afeccion_Click(object sender, EventArgs e)
        {
            panel_tabla.Visible = false;
            btn_nueva_afeccion.Visible = false;
            separador.Visible = false;
            separador2.Visible = false;
        }

        private void btn_regresar_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_afecciones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_afecciones.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    panel_tabla.Visible = false;
                    btn_nueva_afeccion.Visible = false;
                    separador.Visible = false;
                    separador2.Visible = false;

                    DataGridViewRow dr = dgv_afecciones.Rows[e.RowIndex];
                    txt_procedimiento.Text = dr.Cells["Procedimiento"].Value.ToString();
                    txt_afeccion.Text = dr.Cells["Afección"].Value.ToString();
                    txt_tipo.Text = dr.Cells["Tipo"].Value.ToString();
                    IdAfeccion = dr.Cells["IdAfeccion"].Value.ToString();
                    AccionBtn = "Editar";
                    btn_guardar.Text = "Guardar Cambios";
                }
            }
            else if (e.ColumnIndex == dgv_afecciones.Columns["ImagenColumnaEliminar"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgv_afecciones.Rows[e.RowIndex];
                    IdAfeccion = dr.Cells["IdAfeccion"].Value.ToString();
                    Atributos_Alumno.IdAfeccion = Convert.ToInt32(IdAfeccion);

                    using (EliminarAfeccionAlumno eliminar = new EliminarAfeccionAlumno())
                    {
                        fondo.Oscurecer(eliminar);
                    }

                    MostrarAfeccionesDelAlumnoSeleccionado();
                }
            }
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

        private void panel_tabla_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
