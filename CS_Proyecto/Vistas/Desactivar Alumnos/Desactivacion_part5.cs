using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Desactivar_Alumnos
{
    public partial class Desactivacion_part5 : Form
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
        public Desactivacion_part5()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        CD_Alumnos cd_alumnos = new CD_Alumnos();
        string fecha;
        private void Desactivacion_part5_Load(object sender, EventArgs e)
        {
            Timer.Start();
            Timer_loader_carpetas.Start();

        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            barra_progreso.Increment(1);
            if (barra_progreso.Value == 100)
            {
                Timer.Stop();
                cd_alumnos.InactivarAlumnos();
                Vistas.Desactivar_Alumnos.Desactivacion_part6 desactivacion_Part6 = new Vistas.Desactivar_Alumnos.Desactivacion_part6();
                desactivacion_Part6.ShowDialog();
                this.Close();
                cd_alumnos.ObtenerCorreosAdministradores();
                ObtenerFecha();
                EnviarCorreo(Atributos_Alumno.CorreosAdmins);
            }

        }

        private string ObtenerFecha()
        {
            DateTime fechaActual = DateTime.Now;
            fecha = fechaActual.ToString("dddd dd 'de' MMMM 'de' yyyy");
            return fecha;
        }

        private void EnviarCorreo(List<string> destinatarios)
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

        strong {
            font-weight: bold;
        }
            </style>
        </head>
        <body>
        <div class=""container"">
        <h1>La desactivación de todos los alumnos se ha llevado a cabo con éxito</h1>
        <p>Fecha que se realizó la desactivación:<br><strong>" + fecha + @"</strong></p>
        <p>Usuario que realizó la desactivación:<br><strong>@" + Atributos_Login.Usuario + @"</strong></p>
        <p>Atentamente,</p>
        <p><strong>El equipo de soporte técnico Colegio Salarrué</strong></p>
        </div>
        </body>
        </html>
        ";

            foreach (string destinatario in destinatarios)
            {
                MailMessage mail = new MailMessage("soportesalarrue@gmail.com", destinatario)
                {
                    Subject = "Desactivación de alumnos completado con exito",
                    IsBodyHtml = true,
                    Body = cuerpoCorreo,
                };

                try
                {
                    // Envía el correo electrónico
                    smtpClient.Send(mail);
                    // Puedes realizar algún registro o seguimiento aquí si lo deseas
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar el correo: " + ex.Message);
                }
            }
        }


        private void Timer_loader_carpetas_Tick(object sender, EventArgs e)
        {

            if (c1.FillColor == Color.FromArgb(63, 86, 255))
            {
                c1.FillColor = Color.FromArgb(232, 237, 255);
                c2.FillColor = Color.FromArgb(63, 86, 255);

            }
            else if (c2.FillColor == Color.FromArgb(63, 86, 255))
            {
                c2.FillColor = Color.FromArgb(232, 237, 255);
                c3.FillColor = Color.FromArgb(63, 86, 255);
            }
            else if (c3.FillColor == Color.FromArgb(63, 86, 255))
            {
                c3.FillColor = Color.FromArgb(232, 237, 255);
                c4.FillColor = Color.FromArgb(63, 86, 255);
            }
            else if (c4.FillColor == Color.FromArgb(63, 86, 255))
            {
                c4.FillColor = Color.FromArgb(232, 237, 255);
                c1.FillColor = Color.FromArgb(63, 86, 255);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            Timer_loader_carpetas.Stop();
            this.Close();
        }
    }
}
