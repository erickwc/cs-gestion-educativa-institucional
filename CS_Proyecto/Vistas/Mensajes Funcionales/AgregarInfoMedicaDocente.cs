using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Dashboard;
using CS_Proyecto.Vistas.Docentes;
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
    public partial class AgregarInfoMedicaDocente : Form
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
        public AgregarInfoMedicaDocente()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Dashboard_Docente), "Empleados");
        }

        private void btn_info_medica_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Agregar_Docente_Informacion_Medica), "Informacion Medica Empleados");
        }
    }
}
