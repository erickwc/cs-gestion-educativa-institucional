using CS_Proyecto.Atributos;
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
    public partial class Reporte_alumnos : Form
    {
        public Reporte_alumnos()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        byte[] imgPerfil;
        private void btn_volver_reportes_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = null;
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.Controles_Reportes), "Reportes");
        }

        private void btn_activos_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "AlumnosActivos";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteAlumnos), "Reportes de alumnos");
        }

        private void btn_inactivos_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "AlumnosInactivos";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteAlumnos), "Reportes de alumnos");
        }

        private void btn_nie_temporal_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "NieTemporal";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteAlumnos), "Reportes de alumnos");
        }

        private void btn_letraPago_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "LetraPago";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteAlumnos), "Reportes de alumnos");
        }

        private void btn_sujeto_tipo_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "SujetoTipo";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteAlumnos), "Reportes de alumnos");
        }

        private void btn_estadistica_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "EstadisticaGeneral";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteAlumnos), "Reportes de alumnos");
        }

        private void btn_individual_Click(object sender, EventArgs e)
        {
            
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.ReporteIndividualAlumno), "Reportes de alumnos");
        }

        private void activos_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_AlActivos);
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

        private void inactivos_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.R_AlInactivos);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }

        }

        private void nieTemporal_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_nieTemporal);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void LetraPago_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_letraPago);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void sujetosTipo_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_AlumSujetoTipo);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void Estadistica_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.EstadisticaGeneralAlumnos);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void Individual_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "MatriculaAlumno";
            imgPerfil = ConvertirImagenABytes(Properties.Resources.Par1);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void btn_sujetos_seccion_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "SujetosSeccion";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteAlumnos), "Reportes de alumnos");
        }

        private void sujetosSeccion_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "SujetosSeccion";
            imgPerfil = ConvertirImagenABytes(Properties.Resources.Alumnos_sujetos_a_una_seccion_10_10_2023_pdf_page_0001__1_);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }
    }
}
