using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.OscurecerFondo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Docentes.Modificar
{
    public partial class Modificar_Informacion_Medica_Main : Form
    {
        public Modificar_Informacion_Medica_Main()
        {
            InitializeComponent();

        }

        ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();

        private void btn_medicamentos_Click(object sender, EventArgs e)
        {
            using (Modificar_Medicamentos editar_medicamentos = new Modificar_Medicamentos())
            {
                fondo.Oscurecer(editar_medicamentos);
            }
        }

        private void btn_añadir_informacion_Click(object sender, EventArgs e)
        {
            using (Modificar_Afecciones afecciones = new Modificar_Afecciones())
            {
                fondo.Oscurecer(afecciones);
            }
        }

        private void btn_detalles_Click(object sender, EventArgs e)
        {
            using (Modificar_Detalles detalles_medicos = new Modificar_Detalles())
            {
                fondo.Oscurecer(detalles_medicos);
            }
        }
    }
}
