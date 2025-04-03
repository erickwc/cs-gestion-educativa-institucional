using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.Vistas.ClasesVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS_Proyecto.Vistas.Login;
using CS_Proyecto.Vistas.Docentes.Modificar;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using MimeKit;


namespace CS_Proyecto.Vistas.RestablecerContraseña
{
    public partial class Part1 : Form
    {
        public Part1()
        {
            InitializeComponent();
        }

        CD_RestablecerContraseña restablecerpass = new CD_RestablecerContraseña();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        private string GenerarToken()
        {
            Random random = new Random();
            Atributos_RecuperarContraseña.Token = random.Next(1000, 9999);
            return Atributos_RecuperarContraseña.Token.ToString();
        }

        private void Btn_enviar_codigo_Click(object sender, EventArgs e)
        {
            if (txt_correo.Text == String.Empty)
            {
                ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                using (IngresarCorreo mensaje = new IngresarCorreo())
                {
                    fondo.Oscurecer(mensaje);
                }
            }
            else
            {
                EliminarToken.Start();

                GenerarToken();

                var ValidarCorreoUsuario = restablecerpass.ConsultarCorreoUsuario(txt_correo.Text);

                if (ValidarCorreoUsuario)
                {
                    CD_RestablecerContraseña restablecerpasstoken = new CD_RestablecerContraseña();
                    restablecerpasstoken.InsertarTokenTemporal(Atributos.Atributos_RecuperarContraseña.Usuario, Convert.ToString(Atributos_RecuperarContraseña.Token));
                    Atributos_RecuperarContraseña.CorreoIngresado = txt_correo.Text;
                    EnviarCorreo(Atributos_RecuperarContraseña.Correo, Convert.ToString(Atributos_RecuperarContraseña.Token));
                }
                else
                {
                    ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                    using (UsuarioNoEncontrado mensaje = new UsuarioNoEncontrado())
                    {
                        fondo.Oscurecer(mensaje);
                    }
                }
            }
           
        }

        private void EnviarCorreo(string destinatario, string token)
        {
            // Configura el cliente SMTP
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("soportesalarrue@gmail.com", "pehh krcn yxmk btps"),
                EnableSsl = true,
            };

            // Crea el mensaje de correo
            
            string cuerpoCorreo = @"
            <html>
            <head>
            <style>
            body {
            font-family: Arial, sans-serif;
            background-color: #f0f0f0;
            margin: 0;
            padding: 20px;
        }

        .container {
            max-width: 600px;
            margin: 0 auto;
            background-color: #ffffff;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }

        h1 {
            color: #333;
            font-size: 24px;
        }

        p {
            color: #333;
            font-size: 16px;
        }


        .detalles{
             font-size: 20px;
        }

        .codigo{
             font-size: 35px;
        }

        strong {
            font-weight: bold;
        }

     
            </style>
        </head>
        <body>
        <div class=""container"">
        <h1>¡Restablece tu contraseña!</h1>
        <p>Estimado usuario <strong>@" + Atributos_RecuperarContraseña.Usuario + @"</strong></p>
        <p>Hemos recibido una solicitud para restablecer la contraseña de tu cuenta. Para continuar con el proceso, necesitas proporcionar el siguiente código de verificación:</p>

        <p class=""codigo""><strong>" + token + @"</strong></p>
              
        <p>Atentamente,</p>
        <p><strong>El equipo de soporte técnico Colegio Salarrué</strong></p>
        </div>
        </body>
        </html>
        ";



            MailMessage mail = new MailMessage("soportesalarrue@gmail.com", destinatario)
            {
                Subject = "Código de restablecimiento de contraseña",
                IsBodyHtml = true,
                Body = cuerpoCorreo,
            };

            try
            {
                // Envía el correo electrónico
                smtpClient.Send(mail);
                navegar.AbrirFormEnPanelRestablecerContra(typeof(Part2), "RestablecerContraseña");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelContainerApp(typeof(Login_main), "");
        }

        private void EliminarToken_Tick(object sender, EventArgs e)
        {
            CD_RestablecerContraseña restablecerpasstoken = new CD_RestablecerContraseña();
            restablecerpasstoken.EliminarTokenTemporal(Atributos_RecuperarContraseña.Usuario);
            EliminarToken.Stop();
        }

        private void Part1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
