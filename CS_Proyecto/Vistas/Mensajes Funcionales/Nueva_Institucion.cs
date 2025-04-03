using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Formulario_Matricula;
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

namespace CS_Proyecto.Vistas.Mensajes_Funcionales
{
    public partial class Nueva_Institucion : Form
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
        public Nueva_Institucion()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        CapaNegocio.CN_Alumnos cN_Alumnos = new CapaNegocio.CN_Alumnos();
        ValidarCampos validar = new ValidarCampos();
        string datobusqueda;

        private void btn_cancelar__Click(object sender, EventArgs e)
        {
            this.Close();
            txt_institucion.Text = String.Empty;
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                btn_guardar.Enabled = false;
                cN_Alumnos.InsertaInstitucion(txt_institucion.Text);
                txt_institucion.Text = String.Empty;
                Panel_Ingresar.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void txt_institucion_TextChanged(object sender, EventArgs e)
        {
            ActualizarBtn();

            datobusqueda = txt_institucion.Text;
            CD_Alumnos alumnos = new CD_Alumnos();

            bool busqueda = alumnos.BuscarInstitucionesVentana(datobusqueda);

            if (busqueda)
            {
                if (txt_institucion.Text == String.Empty)
                {
                    validar.EstadoTextBox(txt_institucion);
                    lbl_error.Visible = false;
                }
                else
                {
                    btn_guardar.Visible = false;
                    lbl_error.Visible = true;
                    validar.EstadoTextBoxIncorrecto(txt_institucion);
                }
            }
             else
            {
                lbl_error.Visible = false;
                validar.EstadoTextBoxOpcional(txt_institucion);
            }
        }

        private void Nueva_Institucion_Load(object sender, EventArgs e)
        {
            ActualizarBtn();
           
        }

        private void ActualizarBtn()
        {
            if (txt_institucion.Text == "")
            {
                btn_guardar.Visible = false;
            }
            else
            {
                btn_guardar.Visible = true;
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_institucion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_guardar.PerformClick();
            }
        }

    }
}
