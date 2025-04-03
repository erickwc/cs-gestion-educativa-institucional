using CS_Proyecto.CapaNegocio;
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
    public partial class Nuevo_nie_temporal : Form
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
        public Nuevo_nie_temporal()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        CN_Alumnos cn_alumnos = new CN_Alumnos();
        ValidarCampos validar = new ValidarCampos();
        private void btn_cancelar__Click(object sender, EventArgs e)
        {
            this.Close();
            Atributos_Alumno.GuardarConNieTemporal = "NoTieneNieTemporal";
            Atributos_Alumno.NieTemporal = null;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                cn_alumnos.ObtenerUltimoNieTemporal();
                //string NumeroNieObtenido = Atributos_Alumno.NieTemporal;
                //int NumeroNieNuevo = Convert.ToInt32(NumeroNieObtenido) + 1;
                //Atributos_Alumno.NieTemporal = Convert.ToString(NumeroNieNuevo);
                Atributos_Alumno.GuardarConNieTemporal = "TieneNieTemporal";

                btn_registrar.Enabled = false;
                Panel.Visible = false;
                Atributos_Alumno.NIE = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }


        private void txt_nie_temporal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Nuevo_nie_temporal_Load(object sender, EventArgs e)
        {
            cn_alumnos.ObtenerUltimoNieTemporal();
            lbl_nie_temporal.Text = Atributos_Alumno.NieTemporal;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
