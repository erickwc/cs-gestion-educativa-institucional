using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.Mi_Perfil;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Reportes
{
    public partial class VistaPreviaReporte : Form
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
        public VistaPreviaReporte()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

      
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Atributos_Reportes.TipoReporte = null;
        }

        private void MostrarFotoPerfil()
        {
            if (Atributos_Reportes.ImagenReporte != null && Atributos_Reportes.ImagenReporte.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(Atributos_Reportes.ImagenReporte))
                {
                    Image imagen = Image.FromStream(ms);
                    img_reporte.Image = imagen;
                }
            }
        }

        private void VistaPreviaReporte_Load(object sender, EventArgs e)
        {
            MostrarFotoPerfil();
           
            
        }
      

        private void btn_matricula_part1_Click(object sender, EventArgs e)
        {
            img_reporte.Image = Properties.Resources.Par1;
        }

        private void btn_matricula_part2_Click(object sender, EventArgs e)
        {
            img_reporte.Image = Properties.Resources.Part2;
        }

        private void btn_matricula_part3_Click(object sender, EventArgs e)
        {
            img_reporte.Image = Properties.Resources.Parte3;
        }

        private void EmpleadoPart1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void EmpleadoPart2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void EmpleadoPart1_Click(object sender, EventArgs e)
        {
            img_reporte.Image = Properties.Resources.EmpleadoPArt1;
        }

        private void EmpleadoPart2_Click(object sender, EventArgs e)
        {
            img_reporte.Image = Properties.Resources.EmpleadoPart2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Atributos_Reportes.TipoReporte == "MatriculaAlumno")
            {
                btn_alumnos.Visible = true;
                btn_empleados.Visible = false;

            }
            else if (Atributos_Reportes.TipoReporte == "FichaEmpleado")
            {
                btn_empleados.Visible = true;
                btn_alumnos.Visible = false;
            }
            else if (Atributos_Reportes.TipoReporte != "FichaEmpleado" || Atributos_Reportes.TipoReporte != "MatriculaAlumno")
            {
                btn_empleados.Visible = false;
                btn_alumnos.Visible = false;
            }
        }
    }
}
