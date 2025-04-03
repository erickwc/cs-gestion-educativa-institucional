using CS_Proyecto.Vistas.Dashboard;
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

namespace CS_Proyecto.Vistas.Alertas
{
    public partial class Registro_exitoso : Form
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

        public Registro_exitoso()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        ClasesVista.NavegarEntreFormularios navegar = new ClasesVista.NavegarEntreFormularios();

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
           navegar.AbrirFormEnPanel(typeof(Vistas.Dashboard.Dashboard_controles), "Dashboard");
        }

        private void btn_anadir_info_medica_Click(object sender, EventArgs e)
        {
            this.Close();
            navegar.AbrirFormEnPanel(typeof(Vistas.Formulario_Matricula.Target_seccion_medica), "Información Medica");
        }
    }
}
