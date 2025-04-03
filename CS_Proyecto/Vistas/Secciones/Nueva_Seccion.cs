using CS_Proyecto.Atributos;
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

namespace CS_Proyecto.Vistas.Seccion
{
    public partial class Nueva_Seccion : Form
    {
        public Nueva_Seccion()
        {
            InitializeComponent();
        }

        Vistas.ClasesVista.ValidarCampos validar = new Vistas.ClasesVista.ValidarCampos();

        public void MostrarEspecialidades()
        {
            CD_secciones cd_seccion_especialidades = new CD_secciones();
            cbmx_especialidades.DataSource = cd_seccion_especialidades.mostrarEspecialidadesRegistro();
            cbmx_especialidades.DisplayMember = "Especialidades";
            cbmx_especialidades.ValueMember = "IdEspecialidades";

        }

        public void MostrarTipoSeccion()
        {
            CD_secciones cd_seccion_tipo_seccion = new CD_secciones();
            cmbxTipoSeccion.DataSource = cd_seccion_tipo_seccion.MostrarTipoSeccion();
            cmbxTipoSeccion.DisplayMember = "TipoSecciones";
            cmbxTipoSeccion.ValueMember = "IdTipoSeccion";

        }

        public void MostrarDocenteSeccion()
        {
            CD_secciones cd_seccion_docente_seccion = new CD_secciones();
            cmbx_DocenteGuia.DataSource = cd_seccion_docente_seccion.MostrarDocenteSeccion();
            cmbx_DocenteGuia.DisplayMember = "NombreCompletoDUI";
            cmbx_DocenteGuia.ValueMember = "IdDatosPersonalesDocente";

        }

        private void RecargarTextBox()
        {
            cbmx_especialidades.SelectedValue = Convert.ToString(Atributos_seccion.IdEspecialidades);
            cmbxTipoSeccion.SelectedValue = Convert.ToString(Atributos_seccion.IdTipoSeccion);
            cmbx_DocenteGuia.SelectedValue = Convert.ToString(Atributos_seccion.IdDocentes);
            txt_seccion.Text = Atributos_seccion.SeccionAbreviacion;
        }


        private void txt_seccion_TextChanged(object sender, EventArgs e)
        {
            Atributos_seccion.SeccionAbreviacion = txt_seccion.Text;
            validar.EstadoTextBox(txt_seccion);
        }

        private void Nueva_Seccion_Load(object sender, EventArgs e)
        {
            MostrarEspecialidades();
            MostrarTipoSeccion();
            MostrarDocenteSeccion();
            RecargarTextBox();
            validar.EstadoComboBox(cbmx_especialidades);
            validar.EstadoComboBox(cmbxTipoSeccion);
            validar.EstadoComboBox(cmbx_DocenteGuia);
        }

        private void cbmx_especialidades_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_seccion.IdEspecialidades = Convert.ToInt32(cbmx_especialidades.SelectedValue);
            validar.EstadoComboBox(cbmx_especialidades);
        }

        private void cmbx_DocenteGuia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_seccion.IdDocentes = Convert.ToInt32(cmbx_DocenteGuia.SelectedValue);
            validar.EstadoComboBox(cmbx_DocenteGuia);
        }

        private void cmbxTipoSeccion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_seccion.IdTipoSeccion = Convert.ToInt32(cmbxTipoSeccion.SelectedValue);
            validar.EstadoComboBox(cmbxTipoSeccion);
        }

        private void txt_seccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar otros caracteres
            }
            else if (char.IsLetter(e.KeyChar) && e.KeyChar >= 128)
            {
                e.Handled = true; // Ignorar letras con acentos
            }
        }
    }
}
