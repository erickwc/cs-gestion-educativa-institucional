using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Docentes.Modificar;
using CS_Proyecto.Vistas.Mi_Perfil;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Reportes
{
    public partial class reporte_usuarios : Form
    {
        public reporte_usuarios()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        byte[] imgPerfil;

        private void btn_usuarios_actuvos_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "UsuariosActivos";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporte), "Reporte Usuarios Activos");
        }

        private void btn_volver_reportes_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = null;
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.Controles_Reportes), "Reportes");
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_inactivos_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "UsuariosInactivos";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporte), "Reporte Usuarios Activos");
        }

        private void btn_administradores_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "UsuariosAdministradores";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporte), "Reporte Usuarios Administradores");
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "UsuariosSecundarios";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporte), "Reporte Usuarios Secundarios");
        }

     

        private void btn_usuario_individual_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.UsuarioIndividual), "Reporte Usuarios Secundarios");
        }

        private void btn_v_usuariosActivos_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_activos);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private byte[] ConvertirImagenABytes(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void inactivos_p_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_inactivos);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void administradores_p_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_administradores);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void usuarios_p_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_secundarios);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void individual_p_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_individual);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }
    }
}
