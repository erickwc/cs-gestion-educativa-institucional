using CS_Proyecto.Vistas.Docentes.Modificar;
using CS_Proyecto.Vistas.Mi_Perfil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Editar_Matricula
{
    public partial class Editar_Medicamentos : Form
    {
        public Editar_Medicamentos()
        {
            InitializeComponent();
        }

        ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();

        private void btn_medicamentos_Click(object sender, EventArgs e)
        {

            using (Medicamentos editarMedicamento = new Medicamentos())
            {
                fondo.Oscurecer(editarMedicamento);
            }
        }

        private void btn_añadir_informacion_Click(object sender, EventArgs e)
        {
            using (Afecciones editarAfeccion = new Afecciones())
            {
                fondo.Oscurecer(editarAfeccion);
            }
        }

        private void btn_detalles_Click(object sender, EventArgs e)
        {
            using (Detalles_Medicos editarDetalles = new Detalles_Medicos())
            {
                fondo.Oscurecer(editarDetalles);
            }
        }
    }
}
