using CS_Proyecto.CapaNegocio;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Text.RegularExpressions;

namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    public partial class RecursosTecnologicos : Form
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
        public RecursosTecnologicos()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public static List<string> NombresCheckBoxSeleccionados = new List<string>();


        private void ActivarDesactivarChecBox(Guna2CheckBox cb, Guna2Panel c, Guna2Panel borde)
        {
            if (cb.Checked)
            {
                borde.BorderColor = Color.FromArgb(63, 86, 255);
                c.FillColor = Color.FromArgb(63, 86, 255);
                cb.ForeColor = Color.FromArgb(63, 86, 255);

                // Agregar el nombre si no está presente
                if (!NombresCheckBoxSeleccionados.Contains(cb.Text))
                {
                    NombresCheckBoxSeleccionados.Add(cb.Text);
                }

            }
            else
            {
                borde.BorderColor = Color.FromArgb(213, 218, 223);
                c.FillColor = Color.FromArgb(213, 218, 223);
                cb.ForeColor = Color.FromArgb(104, 104, 104);

                // Quitar el nombre si está presente
                if (NombresCheckBoxSeleccionados.Contains(cb.Text))
                {
                    NombresCheckBoxSeleccionados.Remove(cb.Text);
                }
            }
        }


        private void cb_tablet_CheckedChanged(object sender, EventArgs e)
        {
            ActivarDesactivarChecBox(cb_tablet, p_tablet, tablet);

            if (!cb_tablet.Checked)
            {
                // Si el CheckBox está desmarcado, quita la opción de la lista
                NombresCheckBoxSeleccionados.Remove(cb_tablet.Text);
            }

            // Actualiza Atributos_Alumno.RecursosTecnologicos
            Atributos_Alumno.RecursosTecnologicos = string.Join(", ", NombresCheckBoxSeleccionados);
        }

        private void cb_movil_CheckedChanged(object sender, EventArgs e)
        {
            ActivarDesactivarChecBox(cb_movil, p_movil, movil);

            if (!cb_movil.Checked)
            {
                // Si el CheckBox está desmarcado, quita la opción de la lista
                NombresCheckBoxSeleccionados.Remove(cb_movil.Text);
            }

            // Actualiza Atributos_Alumno.RecursosTecnologicos
            Atributos_Alumno.RecursosTecnologicos = string.Join(", ", NombresCheckBoxSeleccionados);
        }

        private void cb_escritorio_CheckedChanged(object sender, EventArgs e)
        {
           
            ActivarDesactivarChecBox(cb_escritorio, p_escritorio, escritorio);

            if (!cb_escritorio.Checked)
            {
                // Si el CheckBox está desmarcado, quita la opción de la lista
                NombresCheckBoxSeleccionados.Remove(cb_escritorio.Text);
            }

            // Actualiza Atributos_Alumno.RecursosTecnologicos
            Atributos_Alumno.RecursosTecnologicos = string.Join(", ", NombresCheckBoxSeleccionados);

        }

        private void cb_portatil_CheckedChanged(object sender, EventArgs e)
        {
           
            ActivarDesactivarChecBox(cb_portatil, p_portatil, portatil);

            if (!cb_portatil.Checked)
            {
                // Si el CheckBox está desmarcado, quita la opción de la lista
                NombresCheckBoxSeleccionados.Remove(cb_portatil.Text);
            }

            // Actualiza Atributos_Alumno.RecursosTecnologicos
            Atributos_Alumno.RecursosTecnologicos = string.Join(", ", NombresCheckBoxSeleccionados);
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.Close();
            string nombresConcatenados = string.Join(", ", NombresCheckBoxSeleccionados);
            Atributos_Alumno.RecursosTecnologicos = nombresConcatenados;
        }



        private void RecursosTecnologicos_Load(object sender, EventArgs e)
        {
            
        }

        private void RecursosTecnologicos_Shown(object sender, EventArgs e)
        {
        }

       

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Atributos_Alumno.RecursosTecnologicos);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Limpiar la lista antes de agregar elementos
            NombresCheckBoxSeleccionados.Clear();

            if (!string.IsNullOrEmpty(Atributos_Alumno.RecursosTecnologicos))
            {
                var recursosSeleccionados = Atributos_Alumno.RecursosTecnologicos.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                NombresCheckBoxSeleccionados.AddRange(recursosSeleccionados);
            }

            if (NombresCheckBoxSeleccionados.Any(item => item.Contains("Tablet")))
            {
                cb_tablet.Checked = true;
                ActivarDesactivarChecBox(cb_tablet, p_tablet, tablet);
            }
            else
            {
                cb_tablet.Checked = false;
                ActivarDesactivarChecBox(cb_tablet, p_tablet, tablet);
            }

            if (NombresCheckBoxSeleccionados.Any(item => item.Contains("Telefono Movil")))
            {
                cb_movil.Checked = true;
                ActivarDesactivarChecBox(cb_movil, p_movil, movil);
            }
            else
            {
                cb_movil.Checked = false;
                ActivarDesactivarChecBox(cb_movil, p_movil, movil);
            }

            if (NombresCheckBoxSeleccionados.Any(item => item.Contains("Computadora de escritorio")))
            {
                cb_escritorio.Checked = true;
                ActivarDesactivarChecBox(cb_escritorio, p_escritorio, escritorio);
            }
            else
            {
                cb_escritorio.Checked = false;
                ActivarDesactivarChecBox(cb_escritorio, p_escritorio, escritorio);
            }

            if (NombresCheckBoxSeleccionados.Any(item => item.Contains("Computadora portatil")))
            {
                cb_portatil.Checked = true;
                ActivarDesactivarChecBox(cb_portatil, p_portatil, portatil);
            }
            else
            {
                cb_portatil.Checked = false;
                ActivarDesactivarChecBox(cb_portatil, p_portatil, portatil);
            }
        }
    }
}
