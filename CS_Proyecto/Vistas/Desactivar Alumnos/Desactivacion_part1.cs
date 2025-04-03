using Guna.UI2.WinForms;
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
    public partial class Desactivacion_part1 : Form
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

        public Desactivacion_part1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_descripcion_Click(object sender, EventArgs e)
        {

        }

        private void btn_comenzar_desactivacion_Click(object sender, EventArgs e)
        {
            Vistas.Desactivar_Alumnos.Desactivacion_part2 desactivacion_Part2 = new Vistas.Desactivar_Alumnos.Desactivacion_part2();
            desactivacion_Part2.ShowDialog();
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Desactivacion_part1_Load(object sender, EventArgs e)
        {

        }
    }
}
