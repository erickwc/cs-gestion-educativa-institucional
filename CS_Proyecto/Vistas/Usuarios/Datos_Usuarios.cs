using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
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
using static Guna.UI2.HtmlRenderer.Adapters.RGraphicsPath;

namespace CS_Proyecto.Vistas.Usuarios
{
    public partial class Datos_Usuarios : Form
    {
        public Datos_Usuarios()
        {
            InitializeComponent();
        }

        ValidarCampos validar = new ValidarCampos();
        CN_Usuarios cn_usuario = new CN_Usuarios();

        private void compararContraseñas()
        {
            if (txt_repetir_contrasena.Text != txt_contrasena.Text)
            {
                lbl_no_coincide.Visible = true;
                validar.UsuarioConNombreIgual(txt_repetir_contrasena);
                Atributos_Usuarios.ContraseñaNoCoincide = "las contraseñas no coinciden";
            }
            else if (txt_repetir_contrasena.Text == txt_contrasena.Text)
            {
                lbl_no_coincide.Visible = false;
                validar.EstadoTextBox(txt_repetir_contrasena);
                Atributos_Usuarios.ContraseñaNoCoincide = "las contraseñas si coinciden";
            }
        }

        private void ValidarContraseñaLengh()
        {

            if (txt_contrasena.Text.Length <= 8)
            {
                validar.UsuarioConNombreIgual(txt_contrasena);
                lbl_mayor_8digitos.Visible = true;
                Atributos_Usuarios.ValidarLongitudContraseña = "Es Menor";
            }
            else if (txt_contrasena.Text.Length > 8)
            {
                validar.EstadoTextBox(txt_contrasena);
                lbl_mayor_8digitos.Visible = false;
                Atributos_Usuarios.ValidarLongitudContraseña = "Es Mayor";
            }
        }
        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            Atributos_Usuarios.NombreUsuario = txt_usuario.Text;
            string nombreUsuario = txt_usuario.Text;
            bool nombreUsuarioExistente = cn_usuario.ConsultarNombreExistente(nombreUsuario);

            if (Atributos_Usuarios.EstadoFormulario == "GuardarUsuario")
            {
                if (nombreUsuarioExistente)
                {
                    lbl_alerta.Visible = true;
                    validar.UsuarioConNombreIgual(txt_usuario);
                    Atributos_Usuarios.ValidarNombreUsuario = "UsuarioExiste";
                }
                else
                {
                    lbl_alerta.Visible = false;
                    validar.EstadoTextBox(txt_usuario);
                    Atributos_Usuarios.ValidarNombreUsuario = "UsuarioNoExiste";
                }
            }
            if (Atributos_Usuarios.EstadoFormulario == "EditarUsuario")
            {
                if (nombreUsuarioExistente)
                {
                    if (txt_usuario.Text != Atributos_Usuarios.NombreUsuario)
                    {
                        lbl_alerta.Visible = true;
                        validar.UsuarioConNombreIgual(txt_usuario);
                        Atributos_Usuarios.ValidarNombreUsuario = "UsuarioExiste";
                    }
                    else
                    {
                        lbl_alerta.Visible = false;
                        validar.EstadoTextBox(txt_usuario);
                        Atributos_Usuarios.ValidarNombreUsuario = "UsuarioNoExiste";
                    }

                }
                else
                {
                    lbl_alerta.Visible = false;
                    validar.EstadoTextBox(txt_usuario);
                    Atributos_Usuarios.ValidarNombreUsuario = "UsuarioNoExiste";
                }
            }

        }


        private void txt_correo_TextChanged(object sender, EventArgs e)
        {
            Atributos_Usuarios.Correo = txt_correo.Text;

            string correo = txt_correo.Text;
            if (ValidarFormatoCorreo(correo))
            {
                lbl_correo_valido.Visible = false;
                validar.EstadoTextBoxOpcional(txt_correo);
            }
            else
            {
                lbl_correo_valido.Visible = true;
                validar.UsuarioConNombreIgual(txt_correo);
            }
        }


        private bool ValidarFormatoCorreo(string correo)
        {
            //Expresiónes regulares para validar el formato del correo electrónico
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(patronCorreo);

            return regex.IsMatch(correo);
        }

        private void txt_contrasena_TextChanged(object sender, EventArgs e)
        {
            Atributos_Usuarios.Contrasena = txt_contrasena.Text;
            ValidarContraseñaLengh();
            compararContraseñas();
        }



        private void txt_repetir_contrasena_TextChanged(object sender, EventArgs e)
        {
            Atributos_Usuarios.ValidarContrasena = txt_repetir_contrasena.Text;
            compararContraseñas();
        }

        private void RecordarCampos()
        {
            txt_contrasena.Text = Atributos_Usuarios.Contrasena;
            txt_correo.Text = Atributos_Usuarios.Correo;
            txt_usuario.Text = Atributos_Usuarios.NombreUsuario;
            txt_repetir_contrasena.Text = Atributos_Usuarios.ValidarContrasena;
        }

        private void Datos_Usuarios_Load(object sender, EventArgs e)
        {
            RecordarCampos();

            if (Atributos_Usuarios.EstadoFormulario == "EditarUsuario")
            {
                panel_contraseña.Visible = false;
                Panel_contraseña_confirmar.Visible = false;
                lbl_alerta.Visible = false;
            }
            else
            {
                panel_contraseña.Visible = true;
                Panel_contraseña_confirmar.Visible = true;
                lbl_alerta.Visible = false;
            }
        }


        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)
            && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '_')
            {
                e.Handled = true;
            }
        }

        private void txt_contrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;  
            }
        }

        private void txt_repetir_contrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true; 
            }
        }

        private void txt_correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)
                && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '_' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
