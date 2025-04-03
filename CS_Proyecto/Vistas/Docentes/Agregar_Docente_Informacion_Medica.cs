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

namespace CS_Proyecto.Vistas.Docentes
{
    public partial class Agregar_Docente_Informacion_Medica : Form
    {
        public Agregar_Docente_Informacion_Medica()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        private void btn_medicamentos_Click(object sender, EventArgs e)
        {

            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (Vistas.Docentes.AgregarMedicamentos agregar_medicamentos = new Vistas.Docentes.AgregarMedicamentos())
            {
                fondo.Oscurecer(agregar_medicamentos);
            }
        }

        private void btn_añadir_informacion_Click(object sender, EventArgs e)
        {
            
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (Vistas.Docentes.AgregarAfecciones agregar_afecciones = new Vistas.Docentes.AgregarAfecciones())
            {
                fondo.Oscurecer(agregar_afecciones);
            }
        }

        private void btn_detalles_Click(object sender, EventArgs e)
        {
           
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (Vistas.Docentes.AgregarDetalles agregar_detalles_medicos = new Vistas.Docentes.AgregarDetalles())
            {
                fondo.Oscurecer(agregar_detalles_medicos);
            }
            btn_detalles.Enabled = false;
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (RegistroCompletoDocente completo = new RegistroCompletoDocente())
            {
                fondo.Oscurecer(completo);
            }
        }
    }
}
