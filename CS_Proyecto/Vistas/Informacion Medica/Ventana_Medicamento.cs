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

namespace CS_Proyecto.Vistas.Informacion_Medica
{
    public partial class Ventana_Medicamento : Form
    {
        public Ventana_Medicamento()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Atributos_Alumno.Dosis = null;
            Atributos_Alumno.Frecuencia = null;
            Atributos_Alumno.NombreMedicamento = null;
        }

        private void Ventana_Medicamento_Load(object sender, EventArgs e)
        {
            lbl_dosis.Text = Atributos_Alumno.Dosis;
            lbl_frecuencia.Text = Atributos_Alumno.Frecuencia;
            lbl_medicamento.Text = Atributos_Alumno.NombreMedicamento;
        }
    }
}
