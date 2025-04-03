using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    public partial class Responsable_principal : Form
    {
        public Responsable_principal()
        {
            InitializeComponent();
        }

        Vistas.ClasesVista.ValidarCampos validar = new Vistas.ClasesVista.ValidarCampos();

        private void txt_nombre_completo_resp_principal_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.ResponsablePrincipal = txt_nombre_completo_resp_principal.Text;
            validar.EstadoTextBox(txt_nombre_completo_resp_principal);
        }

        private void cmbx_parentesco_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.ParentescoResponsablePrincipal = cmbx_parentesco.Text;
            validar.EstadoComboBox(cmbx_parentesco);
        }

        private void txt_dui_resp_principal_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.DuiResponsablePrincipal = txt_dui_resp_principal.Text;
            validar.EstadoTextBox(txt_dui_resp_principal);
        }

        private void cmbx_genero_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.GeneroResponsablePrincipal = cmbx_genero.Text;
            validar.EstadoComboBox(cmbx_genero);
        }

        private void txt_correo_gmail_resp_principal_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.EmailResponsablePrincipal = txt_correo_gmail_resp_principal.Text;
            
            string correo = txt_correo_gmail_resp_principal.Text;
            if(txt_correo_gmail_resp_principal.Text == String.Empty)
            {
                validar.EstadoTextBoxOpcional(txt_correo_gmail_resp_principal);
                lbl_correo_valido.Visible = false;
            }
            else
            {
                if (ValidarFormatoCorreo(correo))
                {
                    lbl_correo_valido.Visible = false;
                    validar.EstadoTextBoxOpcional(txt_correo_gmail_resp_principal);
                }
                else
                {
                    lbl_correo_valido.Visible = true;
                    validar.UsuarioConNombreIgual(txt_correo_gmail_resp_principal);
                }
            }
            
        }

        private bool ValidarFormatoCorreo(string correo)
        {
            //Expresiónes regulares para validar el formato del correo electrónico
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(patronCorreo);

            return regex.IsMatch(correo);
        }

        private void txt_movil_principal_resp_principal_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.TelMovilPrincipalResponsablePrincipal = txt_movil_principal_resp_principal.Text;
            validar.EstadoTextBox(txt_movil_principal_resp_principal);

        }

        private void txt_tel_movil_secundario_resp_principal_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.TelMovilSecundarioResponsablePrincipal = txt_tel_movil_secundario_resp_principal.Text;
            validar.EstadoTextBoxOpcional(txt_tel_movil_secundario_resp_principal);

        }

        private void txt_lugar_trabajo_resp_principal_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.LugarTrabajoResponsablePrincipal = txt_lugar_trabajo_resp_principal.Text;
            validar.EstadoTextBox(txt_lugar_trabajo_resp_principal);

        }

        private void txt_tel_principal_trabajo_resp_principal_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.NumeroTrabajoPrincipal = txt_tel_principal_trabajo_resp_principal.Text;
            validar.EstadoTextBox(txt_tel_principal_trabajo_resp_principal);

        }

        private void txt_tel_secundario_trabajo_resp_principal_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.NumeroTrabajoSecundario = txt_tel_secundario_trabajo_resp_principal.Text;
            validar.EstadoTextBoxOpcional(txt_tel_secundario_trabajo_resp_principal);
        }

        private void cmbx_politicamente_exp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.PoliticamenteExpuesto = cmbx_politicamente_exp.Text;
            validar.EstadoComboBox(cmbx_politicamente_exp);
        }
        private void Responsable_principal_Load(object sender, EventArgs e)
        {
            RecordarDatosTextboxComboBox();
            validar.EstadoComboBox(cmbx_genero);
            validar.EstadoComboBox(cmbx_parentesco);
            validar.EstadoComboBox(cmbx_politicamente_exp);
        }

        private void RecordarDatosTextboxComboBox()
        {
            txt_correo_gmail_resp_principal.Text = Atributos_Alumno.EmailResponsablePrincipal;
            txt_nombre_completo_resp_principal.Text = Atributos_Alumno.ResponsablePrincipal;
            cmbx_parentesco.Text = Atributos_Alumno.ParentescoResponsablePrincipal;
            cmbx_politicamente_exp.Text = Atributos_Alumno.PoliticamenteExpuesto;
            cmbx_genero.Text = Atributos_Alumno.GeneroResponsablePrincipal;
            txt_movil_principal_resp_principal.Text = Atributos_Alumno.TelMovilPrincipalResponsablePrincipal;
            txt_tel_movil_secundario_resp_principal.Text = Atributos_Alumno.TelMovilSecundarioResponsablePrincipal;
            txt_lugar_trabajo_resp_principal.Text = Atributos_Alumno.LugarTrabajoResponsablePrincipal;
            txt_tel_principal_trabajo_resp_principal.Text = Atributos_Alumno.NumeroTrabajoPrincipal;
            txt_tel_secundario_trabajo_resp_principal.Text = Atributos_Alumno.NumeroTrabajoSecundario;
            txt_dui_resp_principal.Text = Atributos_Alumno.DuiResponsablePrincipal;
        }

        private void txt_nombre_completo_resp_principal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_movil_principal_resp_principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_movil_principal_resp_principal.TextLength < 9)
            {
                if (txt_movil_principal_resp_principal.TextLength == 4)
                {
                    txt_movil_principal_resp_principal.Text += "-";
                    txt_movil_principal_resp_principal.SelectionStart = txt_movil_principal_resp_principal.TextLength;
                }
            }

            else if (e.KeyChar == '\b')
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_tel_movil_secundario_resp_principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_tel_movil_secundario_resp_principal.TextLength < 9)
            {
                if (txt_tel_movil_secundario_resp_principal.TextLength == 4)
                {
                    txt_tel_movil_secundario_resp_principal.Text += "-";
                    txt_tel_movil_secundario_resp_principal.SelectionStart = txt_tel_movil_secundario_resp_principal.TextLength;
                }
            }

            else if (e.KeyChar == '\b')
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_tel_principal_trabajo_resp_principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_tel_principal_trabajo_resp_principal.TextLength < 9)
            {
                if (txt_tel_principal_trabajo_resp_principal.TextLength == 4)
                {
                    txt_tel_principal_trabajo_resp_principal.Text += "-";
                    txt_tel_principal_trabajo_resp_principal.SelectionStart = txt_tel_principal_trabajo_resp_principal.TextLength;
                }
            }

            else if (e.KeyChar == '\b')
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_tel_secundario_trabajo_resp_principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_tel_secundario_trabajo_resp_principal.TextLength < 9)
            {
                if (txt_tel_secundario_trabajo_resp_principal.TextLength == 4)
                {
                    txt_tel_secundario_trabajo_resp_principal.Text += "-";
                    txt_tel_secundario_trabajo_resp_principal.SelectionStart = txt_tel_secundario_trabajo_resp_principal.TextLength;
                }
            }

            else if (e.KeyChar == '\b')
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_dui_resp_principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_dui_resp_principal.TextLength < 10)
            {
                // Agregar el guión después del séptimo dígito.
                if (txt_dui_resp_principal.TextLength == 8)
                {
                    txt_dui_resp_principal.Text += "-";
                    txt_dui_resp_principal.SelectionStart = txt_dui_resp_principal.TextLength; // Mover el cursor al final del texto.
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

        private void txt_correo_gmail_resp_principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)
                && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '_' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        
    }
}
