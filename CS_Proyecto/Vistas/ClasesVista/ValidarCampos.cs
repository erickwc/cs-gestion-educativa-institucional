using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
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
    internal class ValidarCampos
    {
        public void EstadoTextBox(Guna2TextBox textbox)
        {
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                textbox.FillColor = Color.FromArgb(255, 243, 243);
                textbox.BorderColor = Color.FromArgb(230, 57, 70);
                textbox.FocusedState.BorderColor = Color.FromArgb(230, 57, 70);
                textbox.HoverState.BorderColor = Color.FromArgb(230, 57, 70);
                textbox.IconRight = Properties.Resources.Incompleto;
                textbox.IconRightSize = new Size(15, 15);
                textbox.IconRightOffset = new Point(10, 0);
            }
            else if (!string.IsNullOrWhiteSpace(textbox.Text))
            {
                textbox.FillColor = Color.FromArgb(243, 255, 243);
                textbox.BorderColor = Color.FromArgb(91, 163, 35);
                textbox.FocusedState.BorderColor = Color.FromArgb(91, 163, 35);
                textbox.HoverState.BorderColor = Color.FromArgb(91, 163, 35);
                textbox.ForeColor = Color.FromArgb(36, 114, 23);
                textbox.IconRight = Properties.Resources.Completo;
                textbox.IconRightSize = new Size(15, 15);
                textbox.IconRightOffset = new Point(10, 0);
            }

        }

        public void EstadoTextBoxIncorrecto(Guna2TextBox textbox)
        {
            textbox.FillColor = Color.FromArgb(255, 243, 243);
            textbox.BorderColor = Color.FromArgb(230, 57, 70);
            textbox.ForeColor = Color.FromArgb(230, 57, 70);
            textbox.FocusedState.BorderColor = Color.FromArgb(230, 57, 70);
            textbox.HoverState.BorderColor = Color.FromArgb(230, 57, 70);
            textbox.IconRight = Properties.Resources.Incompleto;
            textbox.IconRightSize = new Size(15, 15);
            textbox.IconRightOffset = new Point(10, 0);
        }

        public void EstadoTextBoxOpcional(Guna2TextBox textbox)
        {
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                textbox.FillColor = Color.White;
                textbox.BorderColor = Color.FromArgb(213, 218, 223);
                textbox.FocusedState.BorderColor = Color.FromArgb(213, 218, 223);
                textbox.HoverState.BorderColor = Color.FromArgb(213, 218, 223);
                textbox.IconRight = null;
            }
            else if (!string.IsNullOrWhiteSpace(textbox.Text))
            {
                textbox.FillColor = Color.FromArgb(243, 255, 243);
                textbox.BorderColor = Color.FromArgb(91, 163, 35);
                textbox.FocusedState.BorderColor = Color.FromArgb(91, 163, 35);
                textbox.HoverState.BorderColor = Color.FromArgb(91, 163, 35);
                textbox.ForeColor = Color.FromArgb(36, 114, 23);
                textbox.IconRight = Properties.Resources.Completo;
                textbox.IconRightSize = new Size(15, 15);
                textbox.IconRightOffset = new Point(10, 0);
            }
        }

        public void EstadoTextBoxPago(Guna2TextBox textbox)
        {
            if (textbox.Text.Length <= 0)
            {
                textbox.FillColor = Color.FromArgb(243, 255, 243);
                textbox.BorderColor = Color.FromArgb(91, 163, 35);
                textbox.BorderColor = Color.FromArgb(91, 163, 35);
                textbox.ForeColor = Color.FromArgb(36, 114, 23);
                textbox.IconRight = null;
            }
            else if (textbox.Text == "0")
            {
                textbox.FillColor = Color.FromArgb(243, 255, 243);
                textbox.BorderColor = Color.FromArgb(91, 163, 35);
                textbox.FocusedState.BorderColor = Color.FromArgb(91, 163, 35);
                textbox.HoverState.BorderColor = Color.FromArgb(91, 163, 35);
                textbox.ForeColor = Color.FromArgb(36, 114, 23);
                textbox.IconRight = Properties.Resources.Completo;
                textbox.IconRightSize = new Size(15, 15);
                textbox.IconRightOffset = new Point(10, 0);
            }
        }

        public void EstadoTextBoxDesactivado(Guna2TextBox textbox)
        {
            if (textbox.Text.Length <= 0)
            {
                textbox.FillColor = Color.White;
                textbox.BorderColor = Color.FromArgb(213, 218, 223);
                textbox.FocusedState.BorderColor = Color.FromArgb(213, 218, 223);
                textbox.HoverState.BorderColor = Color.FromArgb(213, 218, 223);
                textbox.IconRight = null;
            }
            else if (textbox.Text.Length > 0)
            {
                textbox.DisabledState.FillColor = Color.FromArgb(243, 255, 243);
                textbox.DisabledState.BorderColor = Color.FromArgb(91, 163, 35);
                textbox.FocusedState.BorderColor = Color.FromArgb(91, 163, 35);
                textbox.DisabledState.ForeColor = Color.FromArgb(36, 114, 23);
                textbox.IconRight = Properties.Resources.Completo;
                textbox.IconRightSize = new Size(15, 15);
                textbox.IconRightOffset = new Point(10, 0);
            }
        }

        public void EstadoComboBox(Guna2ComboBox cmbx)
        {
            if (cmbx.Text.Length > 0)
            {
                cmbx.FillColor = Color.FromArgb(243, 255, 243);
                cmbx.BorderColor = Color.FromArgb(91, 163, 35);
                cmbx.ForeColor = Color.FromArgb(36, 114, 23);
                cmbx.BorderThickness = 1;
                cmbx.HoverState.BorderColor = Color.FromArgb(91, 163, 35);
            }
            else if (cmbx.SelectedIndex == -1)
            {
                cmbx.FillColor = Color.FromArgb(245, 247, 252);
                cmbx.ForeColor = Color.FromArgb(104, 104, 104);
                cmbx.ItemsAppearance.BackColor = Color.White;
                cmbx.BorderThickness = 0;

            }
        }

        public void EstadoDateTime(Guna2DateTimePicker dtm)
        {
            if (Atributos_Alumno.FechaNacimiento != null)
            {
                dtm.FillColor = Color.FromArgb(243, 255, 243);
                dtm.BorderColor = Color.FromArgb(91, 163, 35);
                dtm.CheckedState.BorderColor = Color.FromArgb(91, 163, 35);
                dtm.HoverState.BorderColor = Color.FromArgb(91, 163, 35);
                dtm.ForeColor = Color.FromArgb(36, 114, 23);
                dtm.HoverState.FillColor = Color.FromArgb(243, 255, 243);

            }
        }

        public void UsuarioConNombreIgual(Guna2TextBox textbox)
        {
            if (textbox.Text.Length > 0)
            {
                textbox.FillColor = Color.FromArgb(255, 243, 243);
                textbox.BorderColor = Color.FromArgb(230, 57, 70);
                textbox.ForeColor = Color.FromArgb(230, 57, 70);
                textbox.FocusedState.BorderColor = Color.FromArgb(230, 57, 70);
                textbox.HoverState.BorderColor = Color.FromArgb(230, 57, 70);
                textbox.IconRight = Properties.Resources.Incompleto;
                textbox.IconRightSize = new Size(15, 15);
                textbox.IconRightOffset = new Point(10, 0);

            }

        }


    }
}
