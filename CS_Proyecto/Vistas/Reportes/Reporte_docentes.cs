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
    public partial class Reporte_docentes : Form
    {
        public Reporte_docentes()
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

        private void btn_empleados_registrados_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "EmpleadosRegistradosActivosInactivos";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteDocentes), "Reportes de empleados");
        }

        private void btn_activos_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "EmpleadosActivos";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteDocentes), "Reporte de empleados");
        }

        private void btn_inactivos_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "EmpleadosInactivos";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteDocentes), "Reporte de empleados");
        }

        private void btn_sujeto_cargo_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "EmpleadoSujetoCargo";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteDocentes), "Reporte de empleados");
        }

        private void btn_sujeto_especialidad_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "EmpleadoSujetoEspecialidad";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteDocentes), "Reporte de empleados");
        }

        private void btn_sujeto_estudio_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "EmpleadoSujetoNivel";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteDocentes), "Reporte de empleados");
        }

        private void btn_cargos_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "Cargos";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteDocentes), "Reporte de empleados");
        }

        private void btn_especialidades_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "Especialidades";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteDocentes), "Reporte de empleados");
        }

        private void btn_niveles_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "Niveles";
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.PaginaReporteDocentes), "Reporte de empleados");
        }

        private void btn_individual_Click(object sender, EventArgs e)
        {
      
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.ReporteEmpleadoIndividual), "Reporte de empleados");
        }

        private byte[] ConvertirImagenABytes(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void registrados_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_EmpleadosRegistrados);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void activos_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_EMpleadosActivos);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void Inactivos_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_EmpleadosInactivos);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void Sujetocargos_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_SujetoCargo);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void sujetoNivel_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_SujetoNivelEstudio);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_SujetoEspecialidad);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void cargos_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_Cargos);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void especialidades_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_especialidadesRegistradas);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void niveles_Click(object sender, EventArgs e)
        {
            imgPerfil = ConvertirImagenABytes(Properties.Resources.V_NivelesEstudio);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void individual_Click(object sender, EventArgs e)
        {
            Atributos_Reportes.TipoReporte = "FichaEmpleado";
            imgPerfil = ConvertirImagenABytes(Properties.Resources.EmpleadoPArt1);
            Atributos_Reportes.ImagenReporte = imgPerfil;

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (VistaPreviaReporte mensaje = new VistaPreviaReporte())
            {
                fondo.Oscurecer(mensaje);
            }
        }
    }
    
}
