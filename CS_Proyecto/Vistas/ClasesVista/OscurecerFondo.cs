using CS_Proyecto.Vistas.Editar_Matricula;
using CS_Proyecto.Vistas.OscurecerFondo;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.ClasesVista
{
    internal class OscurecerFondo
    {
        public void Oscurecer(Form form)
        {
            Fondo fondoOscuro = new Fondo();

            fondoOscuro.StartPosition = FormStartPosition.Manual;
            fondoOscuro.FormBorderStyle = FormBorderStyle.None;
            fondoOscuro.Opacity = .50d;
            fondoOscuro.BackColor = Color.Black;
            fondoOscuro.WindowState = FormWindowState.Maximized;
            fondoOscuro.TopMost = true;
            fondoOscuro.ShowInTaskbar = false;
            fondoOscuro.Show();

            form.Owner = fondoOscuro;
            form.ShowDialog();

            fondoOscuro.Dispose();
        }
    }
}
