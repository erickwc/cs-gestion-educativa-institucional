using CS_Proyecto.CapaNegocio;
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

namespace CS_Proyecto.Vistas.Desactivar_Alumnos
{
    public partial class Desactivacion_part4 : Form
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
        public Desactivacion_part4()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        private void btn_finalizar_desactivacion_Click(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == Atributos_Login.Contraseña)
            {
                Vistas.Desactivar_Alumnos.Desactivacion_part5 desactivacion_Part5 = new Vistas.Desactivar_Alumnos.Desactivacion_part5();
                desactivacion_Part5.ShowDialog();
                this.Hide();
            }
            else
            {
                lbl_no_coincide.Visible = true;
                txt_contraseña.FillColor = Color.FromArgb(255, 243, 243);
                txt_contraseña.BorderColor = Color.FromArgb(230, 57, 70);
                txt_contraseña.FocusedState.BorderColor = Color.FromArgb(230, 57, 70);
                txt_contraseña.HoverState.BorderColor = Color.FromArgb(230, 57, 70);
                txt_contraseña.IconRight = Properties.Resources.Incompleto;
                txt_contraseña.IconRightSize = new Size(15, 15);
                txt_contraseña.IconRightOffset = new Point(10, 0);
                txt_contraseña.ForeColor = Color.FromArgb(230, 57, 70);
            }
           
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {
            txt_contraseña.FillColor = Color.FromArgb(243, 255, 243);
            txt_contraseña.BorderColor = Color.FromArgb(91, 163, 35);
            txt_contraseña.FocusedState.BorderColor = Color.FromArgb(91, 163, 35);
            txt_contraseña.HoverState.BorderColor = Color.FromArgb(91, 163, 35);
            txt_contraseña.ForeColor = Color.FromArgb(36, 114, 23);
            txt_contraseña.IconRight = Properties.Resources.Completo;
            txt_contraseña.IconRightSize = new Size(15, 15);
            txt_contraseña.IconRightOffset = new Point(10, 0);
            lbl_no_coincide.Visible = false;
        }
    }
}
