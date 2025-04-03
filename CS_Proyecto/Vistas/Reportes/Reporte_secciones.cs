using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Dashboard;
using CS_Proyecto.Vistas.Mi_Perfil;
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
    public partial class Reporte_secciones : Form
    {
        public Reporte_secciones()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        byte[] imgPerfil;

        private void btn_volver_reportes_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.Controles_Reportes), "Reportes");
            
        }

        private void btn_estadistica_general_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "EstadisticaGeneral";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReportesSecciones), "Reporte Estadistica General");

        }

        private void btn_secciones_bachillerato_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "SeccionesBachillerato";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReportesSecciones), "Reporte Secciones Bachillerato");

        }

        private void btn_tercer_ciclo_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "TercerCiclo";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReportesSecciones), "Reporte Secciones Tercer Ciclo");

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_estadistica_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "EstadisticaGeneral";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReportesSecciones), "Reportes Secciónes");
        }

        private void btn_seccion_sujeta_tipo_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "SujetaATipo";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReportesSecciones), "Reportes Secciónes");
        }

        private void btn_sujeta_especialidad_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "SujetaAEspecialidad";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReportesSecciones), "Reportes Secciónes");
        }

        private void btn_especialidades_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "Especialidades";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReportesSecciones), "Reportes Secciónes");
        }

        private void btn_tipos_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "Tipos";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReportesSecciones), "Reportes Secciónes");
        }

        private void btn_individual_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.ReporteSeccionIndividual), "Reportes Secciónes");
        }

        private void estadistica_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_estadisticageneral);
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

        private void individual_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_sec_individual);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void sujeta_tipo_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_sujetaTipo);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void sujeta_especialidad_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_sujetaEspecialidad);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void especialidades_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_especialidades);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void tipos_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_tipos);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }
    }
}
