using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using CS_Proyecto.Vistas.OscurecerFondo;
using iTextSharp.text;
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
    public partial class Modificar_Afecciones : Form
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

        public Modificar_Afecciones()
        {
            InitializeComponent();

            AjustarFilas();

            guna2AnimateWindow1.SetAnimateWindow(this);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void AjustarFilas()
        {
            dvg_afecciones_docentes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dvg_afecciones_docentes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dvg_afecciones_docentes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        int IdInformacionMedica;
        string estadoform = "Guardar";
        ValidarCampos validar = new ValidarCampos();
        ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();

        private void añadirBtnEliminarTabla()
        {
            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonEliminarEnDataGrid(dvg_afecciones_docentes);
            dvg_afecciones_docentes.Columns["ImagenColumnaEliminar"].DisplayIndex = 4;
            dvg_afecciones_docentes.Columns["ImagenColumnaEliminar"].Width = 100;

            DataGridViewColumn columnaImagen = dvg_afecciones_docentes.Columns["ImagenColumnaEliminar"];
            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;
            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.TopLeft;
        }

        private void mostrarAfeccionesDocente()
        {
            CN_Empleado cn_empleado = new CN_Empleado();
            dvg_afecciones_docentes.DataSource = cn_empleado.mostrarAfeccionesDocentes(Atributos_Empleado.IdDocente);
           
        }

        private void AjustarTamañoColumnas()
        {
            dvg_afecciones_docentes.Columns["IdInformacionMedicaDocente"].Visible = false;
            dvg_afecciones_docentes.Columns["Tipo"].Width = 300;
            dvg_afecciones_docentes.Columns["Afeccion"].Width = 300;
        }

        private void añadirBtnEditarTabla()
        {
            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonEditarEnDataGrid(dvg_afecciones_docentes);
            dvg_afecciones_docentes.Columns["ImagenColumna"].DisplayIndex = 5;
            dvg_afecciones_docentes.Columns["ImagenColumna"].Width = 90;

            DataGridViewColumn columnaImagen = dvg_afecciones_docentes.Columns["ImagenColumna"];
            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;
            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.TopLeft;
        }


        private void Modificar_Afecciones_Load(object sender, EventArgs e)
        {
            mostrarAfeccionesDocente();
            AjustarTamañoColumnas();
            añadirBtnEliminarTabla();
            añadirBtnEditarTabla();
            AjustarFilas();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_afecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           
        }

        private void ActualizarForm_Tick(object sender, EventArgs e)
        {
            if (
              !string.IsNullOrWhiteSpace(txt_afeccion.Text)
              && !string.IsNullOrWhiteSpace(txt_procedimiento.Text)
              && !string.IsNullOrWhiteSpace(txt_tipo.Text)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_regresar_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_afecciones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvg_afecciones_docentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_afecciones_docentes.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    panel_tabla.Visible = false;
                    btn_nueva_afeccion.Visible = false;
                    separador.Visible = false;
                    separador2.Visible = false;
                    DataGridViewRow dr = dvg_afecciones_docentes.Rows[e.RowIndex];
                    txt_afeccion.Text = dr.Cells["Afeccion"].Value.ToString();
                    txt_procedimiento.Text = dr.Cells["Procedimiento"].Value.ToString();
                    txt_tipo.Text = dr.Cells["Tipo"].Value.ToString();
                    IdInformacionMedica = Convert.ToInt32(dr.Cells["IdInformacionMedicaDocente"].Value);
                    estadoform = "Editar";
                    btn_guardar.Text = "Guardar Cambios";
                  
                    validar.EstadoTextBox(txt_procedimiento);
                    validar.EstadoTextBox(txt_afeccion);
                    validar.EstadoTextBox(txt_tipo);

                }
            }
            else if (e.ColumnIndex == dvg_afecciones_docentes.Columns["ImagenColumnaEliminar"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dvg_afecciones_docentes.Rows[e.RowIndex];
                    IdInformacionMedica = Convert.ToInt32(dr.Cells["IdInformacionMedicaDocente"].Value);
                    Atributos_Empleado.IdAfeccion = Convert.ToInt32(IdInformacionMedica);

                    using (EliminarAfeccionDocente eliminar = new EliminarAfeccionDocente())
                    {
                        fondo.Oscurecer(eliminar);
                    }
                    mostrarAfeccionesDocente();
                }
            }
        }

        private void btn_nueva_afeccion_Click(object sender, EventArgs e)
        {
            panel_tabla.Visible = false;
            btn_nueva_afeccion.Visible = false;
            separador.Visible = false;
            separador2.Visible = false;
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (estadoform == "Guardar")
                {
                    CN_Empleado cN_Empleado = new CN_Empleado();
                    cN_Empleado.insertarAfeccionesDocentes(txt_afeccion.Text, txt_tipo.Text, txt_procedimiento.Text, Atributos_Empleado.IdDocente);
                    mostrarAfeccionesDocente();
                    txt_tipo.Text = String.Empty;
                    txt_afeccion.Text = String.Empty;
                    txt_procedimiento.Text = String.Empty;
                    panel_tabla.Visible = true;
                    btn_nueva_afeccion.Visible = true;
                    AjustarFilas();
                }
                else if (estadoform == "Editar")
                {
                    CN_Empleado cN_Empleado = new CN_Empleado();
                    cN_Empleado.modificarAfeccionesDocentes(txt_afeccion.Text, txt_tipo.Text, txt_procedimiento.Text, IdInformacionMedica);
                    mostrarAfeccionesDocente();
                    txt_tipo.Text = String.Empty;
                    txt_afeccion.Text = String.Empty;
                    txt_procedimiento.Text = String.Empty;
                    estadoform = "Guardar";
                    panel_tabla.Visible = true;
                    btn_nueva_afeccion.Visible = true;
                    AjustarFilas();
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            panel_tabla.Visible = true;
            btn_nueva_afeccion.Visible = true;
            separador.Visible = true;
            separador2.Visible = true;
        }

        private void txt_afeccion_TextChanged_1(object sender, EventArgs e)
        {
            validar.EstadoTextBoxOpcional(txt_afeccion);
        }

        private void txt_tipo_TextChanged_1(object sender, EventArgs e)
        {
            validar.EstadoTextBoxOpcional(txt_tipo);
        }

        private void txt_procedimiento_TextChanged_1(object sender, EventArgs e)
        {
            validar.EstadoTextBoxOpcional(txt_procedimiento);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
