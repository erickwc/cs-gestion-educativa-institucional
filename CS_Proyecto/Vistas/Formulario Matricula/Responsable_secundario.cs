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

namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    public partial class Responsable_secundario : Form
    {
        public Responsable_secundario()
        {
            InitializeComponent();
        }

        Vistas.ClasesVista.ValidarCampos validar = new Vistas.ClasesVista.ValidarCampos();
        private void txt_nombre_resp_secundario_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.ResponsableSecundario = txt_nombre_resp_secundario.Text;
            validar.EstadoTextBox(txt_nombre_resp_secundario);
        }

        private void cmbx_parentesco_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.ParentescoResponsableSecundario = cmbx_parentesco.Text;
            validar.EstadoComboBox(cmbx_parentesco);

        }

        private void txt_lugar_trabajo_resp_principal_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.LugarTrabajoResponsableSecundario = txt_lugar_trabajo_resp_principal.Text;
            validar.EstadoTextBox(txt_lugar_trabajo_resp_principal);
        }

        private void txt_dui_resp_secundario_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.DuiResponsableSecundario = txt_dui_resp_secundario.Text;
            validar.EstadoTextBox(txt_dui_resp_secundario);

        }

        private void txt_tel_movil_principal_resp_secundario_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.TelMovilPrincipalResponsableSecundario = txt_tel_movil_principal_resp_secundario.Text;
            validar.EstadoTextBox(txt_tel_movil_principal_resp_secundario);

        }

        private void txt_tel_movil_secundario_resp_secundario_TextChanged(object sender, EventArgs e)
        {
            
            Atributos_Alumno.TelMovilSecundarioResponsableSecundario = txt_tel_movil_secundario_resp_secundario.Text;
            validar.EstadoTextBoxOpcional(txt_tel_movil_secundario_resp_secundario);


        }

        private void Responsable_secundario_Load(object sender, EventArgs e)
        {
            RecordarDatosTextboxComboBox();
            validar.EstadoComboBox(cmbx_parentesco);

        }

        private void RecordarDatosTextboxComboBox()
        {
            txt_nombre_resp_secundario.Text = Atributos_Alumno.ResponsableSecundario;
            txt_dui_resp_secundario.Text = Atributos_Alumno.DuiResponsableSecundario;
            cmbx_parentesco.Text = Atributos_Alumno.ParentescoResponsableSecundario;
            txt_lugar_trabajo_resp_principal.Text = Atributos_Alumno.LugarTrabajoResponsableSecundario;
            txt_tel_movil_principal_resp_secundario.Text = Atributos_Alumno.TelMovilPrincipalResponsableSecundario;
            txt_tel_movil_secundario_resp_secundario.Text = Atributos_Alumno.TelMovilSecundarioResponsableSecundario;
        }

        private void txt_nombre_resp_secundario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            else if (char.IsLetter(e.KeyChar) && e.KeyChar >= 128)
            {
                e.Handled = true;
            }
        }

        private void txt_lugar_trabajo_resp_principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            else if (char.IsLetter(e.KeyChar) && e.KeyChar >= 128)
            {
                e.Handled = true;
            }
        }

        private void txt_tel_movil_principal_resp_secundario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_tel_movil_principal_resp_secundario.TextLength < 9)
            {
                // Agregar el guión después del séptimo dígito.
                if (txt_tel_movil_principal_resp_secundario.TextLength == 4)
                {
                    txt_tel_movil_principal_resp_secundario.Text += "-";
                    txt_tel_movil_principal_resp_secundario.SelectionStart = txt_tel_movil_principal_resp_secundario.TextLength; // Mover el cursor al final del texto.
                }
            }
            // Permitir el uso de la tecla Backspace para borrar caracteres.
            else if (e.KeyChar == '\b')
            {
                // No hacer nada, permitir el borrado.
            }
            else
            {
                // Prevenir la entrada de caracteres no numéricos y asegurarse de que no se ingresen más de 9 caracteres.
                e.Handled = true;
            }
        }

        private void txt_tel_movil_secundario_resp_secundario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_tel_movil_secundario_resp_secundario.TextLength < 9)
            {
                // Agregar el guión después del séptimo dígito.
                if (txt_tel_movil_secundario_resp_secundario.TextLength == 4)
                {
                    txt_tel_movil_secundario_resp_secundario.Text += "-";
                    txt_tel_movil_secundario_resp_secundario.SelectionStart = txt_tel_movil_secundario_resp_secundario.TextLength; // Mover el cursor al final del texto.
                }
            }
            // Permitir el uso de la tecla Backspace para borrar caracteres.
            else if (e.KeyChar == '\b')
            {
                // No hacer nada, permitir el borrado.
            }
            else
            {
                // Prevenir la entrada de caracteres no numéricos y asegurarse de que no se ingresen más de 9 caracteres.
                e.Handled = true;
            }
        }

        private void txt_dui_resp_secundario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_dui_resp_secundario.TextLength < 10)
            {
                // Agregar el guión después del séptimo dígito.
                if (txt_dui_resp_secundario.TextLength == 8)
                {
                    txt_dui_resp_secundario.Text += "-";
                    txt_dui_resp_secundario.SelectionStart = txt_dui_resp_secundario.TextLength; // Mover el cursor al final del texto.
                }
            }
            // Permitir el uso de la tecla Backspace para borrar caracteres.
            else if (e.KeyChar == '\b')
            {
                // No hacer nada, permitir el borrado.
            }
            else
            {
                // Prevenir la entrada de caracteres no numéricos y asegurarse de que no se ingresen más de 9 caracteres.
                e.Handled = true;
            }
        }
    }
}
