using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Dashboard;
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
    public partial class Cancelar_matricula : Form
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

        public Cancelar_matricula()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        Dashboard_Main dashboard_Main = Application.OpenForms["Dashboard_Main"] as Dashboard_Main;
        LimpiarVariables limpiarvar = new LimpiarVariables();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();


        private void btn_continuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Dashboard.Dashboard_controles), "Dashboard");
            limpiarvar.LimpiarVariablesMatriculaAlumno();
            this.Close();
        }
    }
}
