using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Desactivar_Alumnos;
using CS_Proyecto.Vistas.Docentes.Modificar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Mantenimiento
{
    public partial class Mantenimiento_sistema : Form
    {
        public Mantenimiento_sistema()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        ValidarCampos validar = new ValidarCampos();
        CD_Alumnos alumnos = new CD_Alumnos();
        private void btn_manual_Click(object sender, EventArgs e)
        {
            string url = "https://colegio-salarrue-manual-de-usuar.gitbook.io/colegiosalarruemanual/";

            AbrirURLenChrome(url);
        }

        private void AbrirURLenChrome(string url)
        {
            try
            {
                // Ruta del ejecutable de Google Chrome en el sistema
                string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

                // Comprueba si el archivo de Google Chrome existe en la ruta especificada
                if (System.IO.File.Exists(chromePath))
                {
                    // Abre la URL en Google Chrome usando Process.Start
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = chromePath,
                        Arguments = url
                    });
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar Google Chrome en la ruta especificada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la URL en Google Chrome: " + ex.Message);
            }
        }

        private void btn_desactivar_Click(object sender, EventArgs e)
        {
            alumnos.ObtenerCorreosAdministradores();
           
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (Desactivacion_part1 desactivar = new Desactivacion_part1())
            {
                fondo.Oscurecer(desactivar);
            }
            
        }

        private void btn_instituciones_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Instituciones.Instituciones_Main), "Instituciónes");
        }

        private void btn_volver_dashboard_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Dashboard.Dashboard_controles), "Dashboard");
        }

        private void btn_nacionalidades_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Nacionalidades.Nacionalidades), "Nacionalidades");
        }

        private void btn_tiposMatricula_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.PagosTiposMatricula.PagosTiposMatricula), "Tipos de Matricula");
        }

        private void btn_formasPago_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Formas_de_pago.FormasPago), "Formas de pago");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Desarrolladores.DesarrolladoresInfo), "Desarrolladores");
        }
    }
}
