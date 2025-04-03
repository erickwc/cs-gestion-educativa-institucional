using CS_Proyecto.Vistas.ClasesVista;
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
    public partial class MantenimientoDocentes : Form
    {
        public MantenimientoDocentes()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        private void btn_volver_dashboard_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Dashboard_Docente), "Empleados");
        }

        private void btn_niveles_estudio_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Nivel_estudio), "Nieveles de estudio");
        }

        private void btn_especialidad_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(EspecialidadesDocentes), "Especialidades");
        }

        private void btn_materias_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Materias), "Materias");
        }

        private void btn_cargos_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Cargos), "Cargos");
        }
    }
}
