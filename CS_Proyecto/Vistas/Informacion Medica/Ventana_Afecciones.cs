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
using System.Windows.Forms.DataVisualization.Charting;

namespace CS_Proyecto.Vistas.Informacion_Medica
{
    public partial class Ventana_Afecciones : Form
    {
        public Ventana_Afecciones()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Atributos_Alumno.NombreAfeccion = null;
            Atributos_Alumno.TipoAfeccion = null;
            Atributos_Alumno.ProcedimientoMedico = null;
        }

        private void Ventana_Afecciones_Load(object sender, EventArgs e)
        {
            lbl_afeccion.Text = Atributos_Alumno.NombreAfeccion;
            lbl_tipo.Text = Atributos_Alumno.TipoAfeccion;
            txt_proc_medico_alumno.Text = Atributos_Alumno.ProcedimientoMedico;
            
        }

        private void txt_proc_medico_alumno_MouseClick(object sender, MouseEventArgs e)
        {
            lbl_afeccion.Focus();
            this.Focus();
            Cursor = Cursors.Arrow;
            
        }

    
    }
}
