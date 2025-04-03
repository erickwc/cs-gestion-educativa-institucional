using CS_Proyecto.Atributos;
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
    public partial class AgregadoEditadoSeccion : Form
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


        public AgregadoEditadoSeccion()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        private void InformacionAlerta()
        {
            if (Atributos_seccion.EstadoFormulario == "Guardar")
            {
                lbl_titulo.Text = "¡Se agrego la sección exitosamente!";
                lbl_descripcion.Text = "Los datos de la seccion se ingresaron correctamente dentro del sistema";
            }
            else if(Atributos_seccion.EstadoFormulario == "Editar")
            {
                lbl_titulo.Text = "¡Se edito la sección exitosamente!";
                lbl_descripcion.Text = "Los datos de la seccion se editaron correctamente dentro del sistema";
            }
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (Atributos_seccion.EstadoFormulario == "Guardar")
            {
                navegar.AbrirFormEnPanel(typeof(Vistas.Seccion.Seccion_Main), "Secciónes");
                this.Close();
            }
            else if (Atributos_seccion.EstadoFormulario == "Editar")
            {
                navegar.AbrirFormEnPanel(typeof(Vistas.Seccion.Modificar_Eliminar_Seccion), "Editar Sección");
                this.Close();
            }
        }

        private void AgregadoEditadoSeccion_Load(object sender, EventArgs e)
        {
            InformacionAlerta();
        }
    }
}
