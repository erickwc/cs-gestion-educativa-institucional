using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Docentes.Modificar;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    public partial class Target_seccion_medica : Form
    {
        public Target_seccion_medica()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        private void btn_medicamentos_Click(object sender, EventArgs e)
        {
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (Vistas.Formulario_Matricula.Agregar_medicamentos agregar_Medicamentos = new Vistas.Formulario_Matricula.Agregar_medicamentos())
            {
                fondo.Oscurecer(agregar_Medicamentos);
            }
        }

        private void btn_añadir_informacion_Click(object sender, EventArgs e)
        {
            
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (Vistas.Formulario_Matricula.Agregar_Afecciones_alumno agregar_afeccion_medica = new Vistas.Formulario_Matricula.Agregar_Afecciones_alumno())
            {
                fondo.Oscurecer(agregar_afeccion_medica);
            }
        }

        private void btn_detalles_Click(object sender, EventArgs e)
        {
           
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (Vistas.Formulario_Matricula.Agregar_Informacion_medica agregar_info_medica = new Vistas.Formulario_Matricula.Agregar_Informacion_medica())
            {
                fondo.Oscurecer(agregar_info_medica);
            }
            btn_detalles.Enabled = false;
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (RegistroCompletoAlumno completo = new RegistroCompletoAlumno())
            {
                fondo.Oscurecer(completo);
            }
        }
    }
}
