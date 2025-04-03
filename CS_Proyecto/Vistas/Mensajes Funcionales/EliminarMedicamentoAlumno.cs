using CS_Proyecto.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Mensajes_Funcionales
{
    public partial class EliminarMedicamentoAlumno : Form
    {
        public EliminarMedicamentoAlumno()
        {
            InitializeComponent();
        }

        CN_Alumnos cn_alumnos = new CN_Alumnos();

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            cn_alumnos.EliminarAfecciones(Atributos_Alumno.IdAfeccion);
            Atributos_Alumno.IdAfeccion = 0;
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
