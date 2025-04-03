using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.Alertas;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Dashboard;
using CS_Proyecto.Vistas.Docentes.Modificar;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using CS_Proyecto.Vistas.RestablecerContraseña;
using Guna.UI2.WinForms.Suite;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace CS_Proyecto.Vistas.Login
{
    public partial class Login_main : Form
    {

        private CapaNegocio.CP_Login cp_login = new CapaNegocio.CP_Login();
        CN_Perfil cn_perfil = new CN_Perfil();

        public Login_main()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        private void Formulario_Load(object sender, EventArgs e)
        {
            lblCS.Parent = img_login;
            lblCS.BackColor = Color.Transparent;

            lbldesc.Parent = img_login;
            lbldesc.BackColor = Color.Transparent;

            btn_t1.Parent = img_login;
            btn_t1.BackColor = Color.Transparent;

            btn_t2.Parent = img_login;
            btn_t2.BackColor = Color.Transparent;

            btn_t3.Parent = img_login;
            btn_t3.BackColor = Color.Transparent;

            logo.Parent = img_login;
            logo.BackColor = Color.Transparent;

            lbldesc.Text = "Una nueva alternativa en educación, fomentando el desarrollo de habilidades y competencias clave, tales como la creatividad, el pensamiento crítico y la resolución de problemas.";

            Cambio_de_texto_timer.Start();
        }

        private void btn_t1_Click(object sender, EventArgs e)
        {
            lbldesc.Text = "Una nueva alternativa en educación, fomentando el desarrollo de habilidades " +
               "y competencias clave, tales como la creatividad, el pensamiento crítico y la resolución de " +
               "problemas.";
        }

        private void btn_t2_Click(object sender, EventArgs e)
        {
            lbldesc.Text = "A través de esta nueva alternativa en educación, " +
                "los estudiantes son capaces de ser más autónomos en su aprendizaje " +
                "y adquirir habilidades que les serán útiles en su futuro académico " +
                "y profesional.";
        }

        private void btn_t3_Click(object sender, EventArgs e)
        {
            lbldesc.Text = "En los últimos años, ha surgido una nueva alternativa en educación " +
               "que busca desafiar el modelo tradicional de enseñanza, Enfocandose " +
               "en el aprendizaje personalizado, en el que se adapta a las necesidades individuales " +
               "de cada estudiante.";
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            btn_ocultar.BringToFront();
            txt_contrasena.PasswordChar = '\0';
        }

        private void btn_ocultar_Click(object sender, EventArgs e)
        {
            btn_mostrar.BringToFront();
            txt_contrasena.PasswordChar = '●';
        }

        private void btn_iniciarsesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_usuario.Text == String.Empty || txt_contrasena.Text == String.Empty)
                {
                    ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                    using (Vistas.Alertas.Campos_sin_completar campos_Sin_Completar = new Vistas.Alertas.Campos_sin_completar())
                    {
                        fondo.Oscurecer(campos_Sin_Completar);
                    }
                    
                }
                else
                {
                    var ValidarLoginUsuarioEncriptado = cp_login.consultaUsuarioEncriptado(txt_usuario.Text);

                    if (ValidarLoginUsuarioEncriptado)
                    {
                        string contraseñaEncriptada = Atributos_Login.Contraseña;

                        bool ValidacionEncriptacion = BCrypt.Net.BCrypt.Verify(txt_contrasena.Text, contraseñaEncriptada);

                        if (ValidacionEncriptacion)
                        {
                            
                            if (Atributos_Login.Estado == "Activo")
                            {
                                Atributos_Login.Contraseña = txt_contrasena.Text;
                                navegar.AbrirFormEnPanelContainerApp(typeof(Dashboard_Main), "");
                            }
                            else if (Atributos_Login.Estado == "Inactivo")
                            {
                                UsuarioInactivo inactivo = new UsuarioInactivo();
                                inactivo.ShowDialog();

                                txt_usuario.Text = "";
                                txt_contrasena.Text = "";
                            }
                        }
                        else
                        {
                            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                            using (Vistas.Alertas.Usuario_no_encontrado usuario_No_Encontrado = new Vistas.Alertas.Usuario_no_encontrado())
                            {
                                fondo.Oscurecer(usuario_No_Encontrado);
                            }
                            txt_usuario.Text = "";
                            txt_contrasena.Text = "";
                        }
                    }
                    else
                    {
                        ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                        using (Vistas.Alertas.Usuario_no_encontrado usuario_No_Encontrado = new Vistas.Alertas.Usuario_no_encontrado())
                        {
                            fondo.Oscurecer(usuario_No_Encontrado);
                        }

                        txt_usuario.Text = "";
                        txt_contrasena.Text = "";
                    }
                }
            }
            catch (Exception)
            {
                var ValidarLoginContraseñaNoEncriptada = cp_login.consultaUsuario(txt_usuario.Text, txt_contrasena.Text);

                if (ValidarLoginContraseñaNoEncriptada)
                {
                    string EncriptarContrasena = BCrypt.Net.BCrypt.HashPassword(txt_contrasena.Text);

                    cn_perfil.EncriptarContrasena(
                        EncriptarContrasena,
                        txt_usuario.Text
                    );

                    if (Atributos_Login.Estado == "Activo")
                    {
                        Atributos_Login.Contraseña = txt_contrasena.Text;
                        navegar.AbrirFormEnPanelContainerApp(typeof(Dashboard_Main), "");
                    }
                    else if (Atributos_Login.Estado == "Inactivo")
                    {
                        UsuarioInactivo inactivo = new UsuarioInactivo();
                        inactivo.ShowDialog();

                        txt_usuario.Text = "";
                        txt_contrasena.Text = "";
                    }
                }
                else
                {
                    ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                    using (Vistas.Alertas.Usuario_no_encontrado usuario_No_Encontrado = new Vistas.Alertas.Usuario_no_encontrado())
                    {
                        fondo.Oscurecer(usuario_No_Encontrado);
                    }

                }

            }


        }

        private void Cambio_de_texto_timer_Tick(object sender, EventArgs e)
        {
            if (lbldesc.Text == "Una nueva alternativa en educación, fomentando el desarrollo de habilidades y competencias clave, tales como la creatividad, el pensamiento crítico y la resolución de problemas.")
            {
                lbldesc.Text = "A través de esta nueva alternativa en educación, los estudiantes son capaces de ser más autónomos en su aprendizaje y adquirir habilidades que les serán útiles en su futuro académico y profesional.";
            }
            else if (lbldesc.Text == "A través de esta nueva alternativa en educación, los estudiantes son capaces de ser más autónomos en su aprendizaje y adquirir habilidades que les serán útiles en su futuro académico y profesional.")
            {
                lbldesc.Text = "En los últimos años, ha surgido una nueva alternativa en educación que busca desafiar el modelo tradicional de enseñanza, Enfocandose en el aprendizaje personalizado, en el que se adapta a las necesidades individuales de cada estudiante.";
            }
            else if (lbldesc.Text == "En los últimos años, ha surgido una nueva alternativa en educación que busca desafiar el modelo tradicional de enseñanza, Enfocandose en el aprendizaje personalizado, en el que se adapta a las necesidades individuales de cada estudiante.")
            {
                lbldesc.Text = "Una nueva alternativa en educación, fomentando el desarrollo de habilidades y competencias clave, tales como la creatividad, el pensamiento crítico y la resolución de problemas.";
            }
        }

        private void txt_contrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_iniciarsesion.PerformClick();
            }
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(char.IsLetter(e.KeyChar) && char.IsLower(e.KeyChar) && e.KeyChar != ' '))
            //{
            //    // Bloquear la pulsación
            //    e.Handled = true;
            //}

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_iniciarsesion.PerformClick();
            }
        }

        private void btn_recordar_pass_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelContainerApp(typeof(RestablecerMain), "");
        }
    }



}



