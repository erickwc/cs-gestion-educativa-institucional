using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CS_Proyecto.Vistas.Mensajes_Funcionales
{
    public partial class EliminarAfeccionDocente : Form
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
        public EliminarAfeccionDocente()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        CN_Empleado empleado = new CN_Empleado();

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            empleado.eliminarAfeccionesDocentes(Atributos_Empleado.IdAfeccion);
            Atributos_Empleado.IdAfeccion=0;
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarAfeccionDocente_Load(object sender, EventArgs e)
        {

        }
    }
}
