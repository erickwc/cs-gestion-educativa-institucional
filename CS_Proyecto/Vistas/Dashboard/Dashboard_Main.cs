using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Actividad.CapaDatos;
using CS_Proyecto.CapaNegocio;
using Guna.UI2.WinForms.Suite;
using System.IO;
using CS_Proyecto.Vistas.Login;

namespace CS_Proyecto.Vistas.Dashboard
{
    public partial class Dashboard_Main : Form
    {

        public Dashboard_Main()
        {
            InitializeComponent();
        }

        private Conexion conexion = new Conexion();
        ClasesVista.NavegarEntreFormularios navegar = new ClasesVista.NavegarEntreFormularios();
    

        private void MostrarFotoPerfil()
        {
            if (Atributos_Login.Imagen != null && Atributos_Login.Imagen.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(Atributos_Login.Imagen))
                {
                    Image imagen = Image.FromStream(ms);
                    pict_img_perfil.Image = imagen;
                }
            }
            if(Atributos_Login.Imagen == null)
            {
                pict_img_perfil.Image = Properties.Resources.ImgPerfil;
            }
        }


        private void Dashboard_Main_Load(object sender, EventArgs e)
        {

            if (Atributos_Login.IdRol == 2)
            {
                btn_reportes.Visible = false;
                btn_instituciones.Visible = false;
                btn_usuarios.Visible = false;
                btn_Nie_Temporal.Visible = false;
                btn_letrapago.Visible = false;
                btn_usuarios.Visible = false;

            }

            InformacionDelUsuario();
            MostrarFotoPerfil();
            navegar.AbrirFormEnPanel(typeof(Vistas.Dashboard.Dashboard_controles), "Dashboard");
        }

        private void InformacionDelUsuario()
        {
            lbl_usuario.Text = "@" + Atributos_Login.Usuario;
            lbl_rol.Text = Atributos_Login.Rol;

        }

        private void DesplegarBotonDeBarraLateral(Guna2Button btn, string txt)
        {
            btn.Width = 200;
            btn.Text = txt;
        }

        private void CerrarBotonDeBarraLateral(Guna2Button btn, string txt)
        {
            btn.Width = 50;
            btn.Text = "";
            BarraLateral.Width = 74;
            btn.Text = txt;
        }

        private void ActivarBotonDeBarraLateral(Guna2Button btn, System.Drawing.Image img)
        {
            btn.FillColor = Color.FromArgb(232, 237, 255);
            btn.Font = new Font(btn.Font, FontStyle.Bold);
            btn.ForeColor = Color.FromArgb(63, 86, 255);
            btn.HoverState.FillColor = Color.FromArgb(232, 237, 255);
            btn.PressedColor = Color.FromArgb(232, 237, 255);
            btn.Image = img;
        }

        private void DesactivarBotonDeBarraLateral(Guna2Button btn, System.Drawing.Image img)
        {
            btn.FillColor = Color.White;
            btn.Font = new Font(btn.Font, FontStyle.Regular);
            btn.ForeColor = Color.FromArgb(51, 53, 51);
            btn.HoverState.FillColor = Color.White;
            btn.Image = img;

        }

        

        private void btn_dashboard_Click_1(object sender, EventArgs e)
        {
            ActivarBotonDeBarraLateral(btn_dashboard, Properties.Resources.Dashboard);
            DesactivarBotonDeBarraLateral(btn_letrapago, Properties.Resources.Letra_Pago_e);
            DesactivarBotonDeBarraLateral(btn_usuarios, Properties.Resources.Usuarios_e);
            DesactivarBotonDeBarraLateral(btn_reportes, Properties.Resources.Reportes_e);
            DesactivarBotonDeBarraLateral(btn_comprobante, Properties.Resources.Modo_e);
            DesactivarBotonDeBarraLateral(btn_Nie_Temporal, Properties.Resources.Nie_temporal_e);
            DesactivarBotonDeBarraLateral(btn_perfil, Properties.Resources.Mi_Perfil_e);
            DesactivarBotonDeBarraLateral(btn_comprobante, Properties.Resources.Comprobante_e);
            DesactivarBotonDeBarraLateral(btn_instituciones, Properties.Resources.Mantenimiento_e);

            CerrarBotonDeBarraLateral(btn_dashboard, "");
            navegar.AbrirFormEnPanel(typeof(Vistas.Dashboard.Dashboard_controles), "Dashboard");
        }

        private void btn_reportes_Click_1(object sender, EventArgs e)
        {
            ActivarBotonDeBarraLateral(btn_reportes, Properties.Resources.Reporte);
            DesactivarBotonDeBarraLateral(btn_dashboard, Properties.Resources.Dashboard_e);
            DesactivarBotonDeBarraLateral(btn_usuarios, Properties.Resources.Usuarios_e);
            DesactivarBotonDeBarraLateral(btn_letrapago, Properties.Resources.Letra_Pago_e);
            DesactivarBotonDeBarraLateral(btn_comprobante, Properties.Resources.Modo_e);
            DesactivarBotonDeBarraLateral(btn_Nie_Temporal, Properties.Resources.Nie_temporal_e);
            DesactivarBotonDeBarraLateral(btn_comprobante, Properties.Resources.Comprobante_e);
            DesactivarBotonDeBarraLateral(btn_perfil, Properties.Resources.Mi_Perfil_e);
            DesactivarBotonDeBarraLateral(btn_instituciones, Properties.Resources.Mantenimiento_e);

            CerrarBotonDeBarraLateral(btn_reportes, "");
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.Controles_Reportes), "Reportes");
            lbl_seccion_actual.Text = "Reportes";
        }

        private void btn_usuarios_Click_1(object sender, EventArgs e)
        {
            ActivarBotonDeBarraLateral(btn_usuarios, Properties.Resources.Usuarios);
            DesactivarBotonDeBarraLateral(btn_dashboard, Properties.Resources.Dashboard_e);
            DesactivarBotonDeBarraLateral(btn_reportes, Properties.Resources.Reportes_e);
            DesactivarBotonDeBarraLateral(btn_letrapago, Properties.Resources.Letra_Pago_e);
            DesactivarBotonDeBarraLateral(btn_comprobante, Properties.Resources.Modo_e);
            DesactivarBotonDeBarraLateral(btn_Nie_Temporal, Properties.Resources.Nie_temporal_e);
            DesactivarBotonDeBarraLateral(btn_comprobante, Properties.Resources.Comprobante_e);
            DesactivarBotonDeBarraLateral(btn_perfil, Properties.Resources.Mi_Perfil_e);
            DesactivarBotonDeBarraLateral(btn_instituciones, Properties.Resources.Mantenimiento_e);

            navegar.AbrirFormEnPanel(typeof(Vistas.Usuarios.Controles_Usuarios), "Usuarios");
            CerrarBotonDeBarraLateral(btn_usuarios, "");
        }

        private void btn_letrapago_Click_1(object sender, EventArgs e)
        {
            ActivarBotonDeBarraLateral(btn_letrapago, Properties.Resources.Letra_Pago);
            DesactivarBotonDeBarraLateral(btn_dashboard, Properties.Resources.Dashboard_e);
            DesactivarBotonDeBarraLateral(btn_usuarios, Properties.Resources.Usuarios_e);
            DesactivarBotonDeBarraLateral(btn_reportes, Properties.Resources.Reportes_e);
            DesactivarBotonDeBarraLateral(btn_comprobante, Properties.Resources.Modo_e);
            DesactivarBotonDeBarraLateral(btn_perfil, Properties.Resources.Mi_Perfil_e);
            DesactivarBotonDeBarraLateral(btn_Nie_Temporal, Properties.Resources.Nie_temporal_e);
            DesactivarBotonDeBarraLateral(btn_comprobante, Properties.Resources.Comprobante_e);
            DesactivarBotonDeBarraLateral(btn_instituciones, Properties.Resources.Mantenimiento_e);

            CerrarBotonDeBarraLateral(btn_letrapago, "");
            navegar.AbrirFormEnPanel(typeof(Vistas.Letra_de_Pago.Letra_de_pago_main), "Letra Pago");

        }

       

        private void btn_perfil_Click_1(object sender, EventArgs e)
        {
            ActivarBotonDeBarraLateral(btn_perfil, Properties.Resources.Mi_Perfil);
            DesactivarBotonDeBarraLateral(btn_dashboard, Properties.Resources.Dashboard_e);
            DesactivarBotonDeBarraLateral(btn_usuarios, Properties.Resources.Usuarios_e);
            DesactivarBotonDeBarraLateral(btn_reportes, Properties.Resources.Reportes_e);
            DesactivarBotonDeBarraLateral(btn_letrapago, Properties.Resources.Letra_Pago_e);
            DesactivarBotonDeBarraLateral(btn_comprobante, Properties.Resources.Modo_e);
            DesactivarBotonDeBarraLateral(btn_Nie_Temporal, Properties.Resources.Nie_temporal_e);
            DesactivarBotonDeBarraLateral(btn_comprobante, Properties.Resources.Comprobante_e);
            DesactivarBotonDeBarraLateral(btn_instituciones, Properties.Resources.Mantenimiento_e);

            CerrarBotonDeBarraLateral(btn_perfil, "");
            navegar.AbrirFormEnPanel(typeof(Vistas.Mi_Perfil.Mi_perfil_main), "Mi Perfil");
        }

        private void btn_cerrarsesion_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelContainerApp(typeof(Login_main), "");
        }

        private void btn_desplegar_Click_1(object sender, EventArgs e)
        {
            if (BarraLateral.Width == 225)
            {
                CerrarBotonDeBarraLateral(btn_dashboard, "");
                CerrarBotonDeBarraLateral(btn_reportes, "");
                CerrarBotonDeBarraLateral(btn_usuarios, "");
                CerrarBotonDeBarraLateral(btn_letrapago, "");
                CerrarBotonDeBarraLateral(btn_comprobante, "");
                CerrarBotonDeBarraLateral(btn_perfil, "");
                CerrarBotonDeBarraLateral(btn_cerrarsesion, "");
                CerrarBotonDeBarraLateral(btn_Nie_Temporal, "");
                CerrarBotonDeBarraLateral(btn_instituciones, "");
            }
            else
            {
                BarraLateral.Width = 225;
                
                DesplegarBotonDeBarraLateral(btn_dashboard, "Dashboard");
                DesplegarBotonDeBarraLateral(btn_reportes, "Reportes");
                DesplegarBotonDeBarraLateral(btn_usuarios, "Usuarios");
                DesplegarBotonDeBarraLateral(btn_letrapago, "Letra de Pago");
                DesplegarBotonDeBarraLateral(btn_comprobante, "Inscripción");
                DesplegarBotonDeBarraLateral(btn_perfil, "Mi perfil");
                DesplegarBotonDeBarraLateral(btn_cerrarsesion, "Cerrar Sesion");
                DesplegarBotonDeBarraLateral(btn_Nie_Temporal, "Nie Temporal");
                DesplegarBotonDeBarraLateral(btn_instituciones, "Mantenimiento");
            }
        }

        private void btn_Nie_Temporal_Click(object sender, EventArgs e)
        {
            ActivarBotonDeBarraLateral(btn_Nie_Temporal, Properties.Resources.Nie_temporal);
            DesactivarBotonDeBarraLateral(btn_perfil, Properties.Resources.Mi_Perfil_e);
            DesactivarBotonDeBarraLateral(btn_dashboard, Properties.Resources.Dashboard_e);
            DesactivarBotonDeBarraLateral(btn_usuarios, Properties.Resources.Usuarios_e);
            DesactivarBotonDeBarraLateral(btn_reportes, Properties.Resources.Reportes_e);
            DesactivarBotonDeBarraLateral(btn_letrapago, Properties.Resources.Letra_Pago_e);
            DesactivarBotonDeBarraLateral(btn_comprobante, Properties.Resources.Modo_e);
            DesactivarBotonDeBarraLateral(btn_comprobante, Properties.Resources.Comprobante_e);
            DesactivarBotonDeBarraLateral(btn_instituciones, Properties.Resources.Mantenimiento_e);

            CerrarBotonDeBarraLateral(btn_Nie_Temporal, "");
            navegar.AbrirFormEnPanel(typeof(Vistas.Nie_Temporal.Nie_temporal_main), "Temporales");
        }

        private void btn_comprobante_Click(object sender, EventArgs e)
        {
            ActivarBotonDeBarraLateral(btn_comprobante, Properties.Resources.Comprobante);
            DesactivarBotonDeBarraLateral(btn_dashboard, Properties.Resources.Dashboard_e);
            DesactivarBotonDeBarraLateral(btn_usuarios, Properties.Resources.Usuarios_e);
            DesactivarBotonDeBarraLateral(btn_reportes, Properties.Resources.Reportes_e);
            DesactivarBotonDeBarraLateral(btn_letrapago, Properties.Resources.Letra_Pago_e);
            DesactivarBotonDeBarraLateral(btn_perfil, Properties.Resources.Mi_Perfil_e);
            DesactivarBotonDeBarraLateral(btn_Nie_Temporal, Properties.Resources.Nie_temporal_e);
            DesactivarBotonDeBarraLateral(btn_instituciones, Properties.Resources.Mantenimiento_e);

            CerrarBotonDeBarraLateral(btn_comprobante, "");
            navegar.AbrirFormEnPanel(typeof(Vistas.Formulario_Matricula.Consulta), "Inscripción");

        }



        private void btn_modo_Click(object sender, EventArgs e)
        {
            Vistas.Modo_Nocturno.Modo_nocturno modo_Nocturno = new Vistas.Modo_Nocturno.Modo_nocturno();
            modo_Nocturno.ShowDialog();
        }

        private void btn_instituciones_Click(object sender, EventArgs e)
        {
            ActivarBotonDeBarraLateral(btn_instituciones, Properties.Resources.Mantenimiento);
            DesactivarBotonDeBarraLateral(btn_comprobante, Properties.Resources.Comprobante_e);
            DesactivarBotonDeBarraLateral(btn_dashboard, Properties.Resources.Dashboard_e);
            DesactivarBotonDeBarraLateral(btn_usuarios, Properties.Resources.Usuarios_e);
            DesactivarBotonDeBarraLateral(btn_reportes, Properties.Resources.Reportes_e);
            DesactivarBotonDeBarraLateral(btn_letrapago, Properties.Resources.Letra_Pago_e);
            DesactivarBotonDeBarraLateral(btn_perfil, Properties.Resources.Mi_Perfil_e);
            DesactivarBotonDeBarraLateral(btn_Nie_Temporal, Properties.Resources.Nie_temporal_e);
            
            CerrarBotonDeBarraLateral(btn_instituciones, "");
            navegar.AbrirFormEnPanel(typeof(Vistas.Mantenimiento.Mantenimiento_sistema), "Mantenimiento");

        }


        private void Dashboard_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ActualizarFoto_Tick(object sender, EventArgs e)
        {
            MostrarFotoPerfil();
            InformacionDelUsuario();
        }
    }
}
