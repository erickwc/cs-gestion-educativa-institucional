using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Docentes.Modificar;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using Guna.UI2.WinForms;
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
using CS_Proyecto.CapaDatos;

namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    public partial class Comprobante_main : Form
    {
        public Comprobante_main()
        {
            InitializeComponent();
        }

        CN_Alumnos cn_alumnos = new CN_Alumnos();
        LimpiarVariables limpiarvar = new LimpiarVariables();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        CD_Alumnos cd_alumnos = new CD_Alumnos();
        string fecha;
        private void SeccionActiva(Guna2Button btn)
        {
            btn.FillColor = Color.FromArgb(232, 237, 255);
            btn.ForeColor = Color.FromArgb(63, 86, 255);
            btn.HoverState.FillColor = Color.FromArgb(232, 237, 255);
            btn.PressedColor = Color.FromArgb(232, 237, 255);
            btn.Font = new Font(btn.Font, FontStyle.Bold);
        }

        private void SeccionInactiva(Guna2Button btn)
        {
            btn.FillColor = Color.White;
            btn.ForeColor = Color.FromArgb(104, 104, 104);
            btn.HoverState.FillColor = Color.White;
            btn.PressedColor = Color.White;
            btn.Font = new Font(btn.Font, FontStyle.Regular);
        }


        private void btn_pago_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormPanelInscripcion(typeof( Vistas.Formulario_Matricula.Pago_matricula));
            SeccionActiva(btn_pago);
            SeccionInactiva(btn_identificacion);
        }

        private void btn_identificacion_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormPanelInscripcion(typeof( Vistas.Formulario_Matricula.Identificacion));
            SeccionInactiva(btn_pago);
            SeccionActiva(btn_identificacion);
        }

        private void Comprobante_main_Load(object sender, EventArgs e)
        {
            navegar.AbrirFormPanelInscripcion(typeof( Vistas.Formulario_Matricula.Pago_matricula));
            SeccionActiva(btn_pago);
            SeccionInactiva(btn_identificacion);
        }


        private void btn_guardar_registro_Click(object sender, EventArgs e)
        {
            try
            {
                cn_alumnos.InsertaComprobanteAlumno(
                Atributos_Alumno.CantidadCancelada,
                Atributos_Alumno.CantidadPendiente,
                Atributos_Alumno.IdTipoPago,
                Atributos_Alumno.IdTipoPagoMatricula,
                Atributos_Alumno.IdSecciones,
                Atributos_Alumno.IdEspecialidades,
                Atributos_Alumno.IdTipoEstado,
                Atributos_Alumno.NumeroDeTalonario,
                Atributos_Alumno.IdAlumno);

                ObtenerFecha();

                cd_alumnos.ObtenerCorreoAlumnoResponsable(Atributos_Alumno.IdAlumno);
                EnviarCorreo(Atributos_Alumno.CorreosInscripcionAlumnoResponsable);

                ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                using (ComprobanteGuardado mensaje = new ComprobanteGuardado())
                {
                    fondo.Oscurecer(mensaje);
                }

                limpiarvar.LimpiarVariablesComprobantePagoAlumno();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo" + ex);
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

        .margen{
             padding-bottom: 30px;
        }

        .detalles{
             font-size: 20px;
        }

        strong {
            font-weight: bold;
        }

     
            </style>
        </head>
        <body>
        <div class=""container"">
        <h1>¡Inscripción Realizada!</h1>
        <p class=""margen"">Nos complace informarte que tu inscripción ha sido procesada con éxito en <strong>Colegio Salarrue</strong>. ¡Bienvenido a nuestra comunidad educativa!</p>
       
        <p class=""detalles""><strong>Detalles de la inscripción realizada</strong></p>
        <p>Nombre del alumno inscrito:<br><strong>" + Atributos_Alumno.AlumnoInscrito + @"</strong></p>
        <p>Responsable Principal del alumno:<br><strong>" + Atributos_Alumno.ResponsableInscrito + @"</strong></p>
        <p>Especialidad del alumno:<br><strong>" + Atributos_Alumno.EspecialidadAlumno + @"</strong></p>
        <p>Fecha de Inscripción:<br><strong>" + fecha + @"</strong></p>
        <p class=""margen"">Total cancelado de inscripción:<br><strong>" + Atributos_Alumno.CantidadCancelada + @" dolares</strong></p>
     
        <p class=""margen""><strong>Por favor, asegúrate de conservar esta información para futuras referencias. </strong></p>        
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
                    Subject = "Comprobante de inscripción realizada",
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            CancelarComprobante cancelarComprobante = new CancelarComprobante();
            cancelarComprobante.ShowDialog();
        }

        private void ActualizarFormulario_Tick(object sender, EventArgs e)
        {
            if (
                  Atributos_Alumno.IdTipoPago != 0
                  && Atributos_Alumno.IdSecciones != 0
                  && Atributos_Alumno.IdEspecialidades != 0
                  && Atributos_Alumno.IdTipoEstado != 0
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.NumeroDeTalonario))
            {
                btn_guardar_registro.Visible = true;
            }
            else
            {
                btn_guardar_registro.Visible = false;
            }

            this.Invalidate();
        }


    }
}
