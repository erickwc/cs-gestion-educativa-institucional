using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.Vistas.ClasesVista;
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
    public partial class NuevaNacionalidad : Form
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
        public NuevaNacionalidad()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }


        CD_Alumnos cd_Alumnos = new CD_Alumnos();
        ValidarCampos validar = new ValidarCampos();

        private void btn_cancelar__Click(object sender, EventArgs e)
        {
            this.Close();
            txt_nacionalidad.Text = String.Empty;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                btn_guardar.Enabled = false;
                cd_Alumnos.InsertarNacionalidad(txt_nacionalidad.Text);
                txt_nacionalidad.Text = String.Empty;
                Panel_Ingresar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void txt_nacionalidad_TextChanged(object sender, EventArgs e)
        {
            ActualizarBtn();

            CD_Alumnos alumnos = new CD_Alumnos();

            bool busqueda = alumnos.BuscarNacionalidadesVentana(txt_nacionalidad.Text);

            if (busqueda)
            {
                if (txt_nacionalidad.Text == String.Empty)
                {
                    validar.EstadoTextBox(txt_nacionalidad);
                    lbl_error.Visible = false;
                }
                else
                {
                    btn_guardar.Visible = false;
                    lbl_error.Visible = true;
                    validar.EstadoTextBoxIncorrecto(txt_nacionalidad);
                }
            }
            else
            {
                lbl_error.Visible = false;
                validar.EstadoTextBoxOpcional(txt_nacionalidad);
            }
        }

        private void NuevaNacionalidad_Load(object sender, EventArgs e)
        {
            ActualizarBtn();
        }

        private void ActualizarBtn()
        {
            if (txt_nacionalidad.Text == "")
            {
                btn_guardar.Visible = false;
            }
            else
            {
                btn_guardar.Visible = true;
            }
        }

        private void txt_nacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_guardar.PerformClick();
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
