using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
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

namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    public partial class Identificacion : Form
    {
        public Identificacion()
        {
            InitializeComponent();
        }

        ValidarCampos validar = new ValidarCampos();
        private void btn_añadir_nie_temporal_Click(object sender, EventArgs e)
        {
            
        }

        private void MostrarEspecialidades()
        {
            CD_Alumnos especialidades = new CD_Alumnos();
            cmbx_especialidad.DataSource = especialidades.MostrarEspecialidadesAlumnoRegistradas();
            cmbx_especialidad.DisplayMember = "Nombre";
            cmbx_especialidad.ValueMember = "IdEspecialidades";
        }

        private void MostrarSecciones()
        {
            CD_Alumnos secciones = new CD_Alumnos();
            cmbx_seccion_asignada.DataSource = secciones.MostrarSeccionesRegistradas();
            cmbx_seccion_asignada.DisplayMember = "SeccionAbreviacion";
            cmbx_seccion_asignada.ValueMember = "IdSecciones";
        }

        private void MostrarEstados()
        {
            CD_Alumnos estados = new CD_Alumnos();
            cmbx_estado.DataSource = estados.MostrasTiposEstado();
            cmbx_estado.DisplayMember = "TipoEstado";
            cmbx_estado.ValueMember = "IdTipoEstado";
        }

      

        private void txt_talonario_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.NumeroDeTalonario = txt_talonario.Text;
            validar.EstadoTextBox(txt_talonario);
        }

        private void cmbx_especialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.EspecialidadAlumno = cmbx_especialidad.Text;
            Atributos_Alumno.IdEspecialidades = Convert.ToInt32(cmbx_especialidad.SelectedValue);
            validar.EstadoComboBox(cmbx_especialidad);
        }

        private void cmbx_seccion_asignada_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.IdSecciones = Convert.ToInt32(cmbx_seccion_asignada.SelectedValue);
            validar.EstadoComboBox(cmbx_seccion_asignada);
        }

        private void cmbx_estado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.IdTipoEstado = Convert.ToInt32(cmbx_estado.SelectedValue);
            validar.EstadoComboBox(cmbx_estado);
        }

        private void Identificacion_Load(object sender, EventArgs e)
        {
            MostrarEspecialidades();
            MostrarEstados();
            MostrarSecciones();
            RecordarDatosTextboxComboBox();
            validar.EstadoComboBox(cmbx_estado);
            validar.EstadoComboBox(cmbx_seccion_asignada);
            validar.EstadoComboBox(cmbx_especialidad);
        }

        private void RecordarDatosTextboxComboBox()
        {
            txt_talonario.Text = Atributos_Alumno.NumeroDeTalonario;
            cmbx_especialidad.SelectedValue = Convert.ToString(Atributos_Alumno.IdEspecialidades);
            cmbx_estado.SelectedValue = Convert.ToString(Atributos_Alumno.IdTipoEstado);
            cmbx_seccion_asignada.SelectedValue = Convert.ToString(Atributos_Alumno.IdSecciones);
        }


        private void txt_nie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
           
        }

        private void txt_talonario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_talonario.TextLength < 6)
            {
               
            }
            else if (e.KeyChar == '\b')
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
