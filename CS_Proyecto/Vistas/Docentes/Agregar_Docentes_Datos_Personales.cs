using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.Vistas.Docentes.Modificar;
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
    public partial class Agregar_Docentes_Datos_Personales : Form
    {
        public Agregar_Docentes_Datos_Personales()
        {
            InitializeComponent();
        }

        Vistas.ClasesVista.ValidarCampos validarCampos = new Vistas.ClasesVista.ValidarCampos();
        string CopiarTextbox;

        private void btn_añadir_nivel_estudio_Click(object sender, EventArgs e)
        {
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (Vistas.Mensajes_Funcionales.Nuevo_nivel_estudio nuevo_Nivel_Estudio = new Mensajes_Funcionales.Nuevo_nivel_estudio())
            {
                fondo.Oscurecer(nuevo_Nivel_Estudio);
            }
        }

        public void MostrarNivelDeEstudio()
        {
            CD_Empleados cd_Empleado_nivel_de_estudio = new CD_Empleados();
            cbx_nivelestudio.DataSource = cd_Empleado_nivel_de_estudio.MostrarNivelDeEstudioParaRegistroDocente();
            cbx_nivelestudio.DisplayMember = "TipoNivel";
            cbx_nivelestudio.ValueMember = "IdNivelEstudioDocente";
            cbx_nivelestudio.StartIndex = -1;
        }

        public void MostrarEstadoCivil()
        {
            cbx_estado_civil.Items.Add("Casado/a");
            cbx_estado_civil.Items.Add("Soltero/a");
            cbx_estado_civil.Items.Add("Vuido/a");
            cbx_estado_civil.Items.Add("Separado/a");
            cbx_estado_civil.StartIndex = -1;
        }

        public void MostrarEstadoJubilado()
        {
            cbx_genero_Docente.Items.Add("Si");
            cbx_genero_Docente.Items.Add("No");
            cbx_genero_Docente.StartIndex = -1;
        }

        private void txt_nombre_completo_DUI_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.NombreCompletoDUI = txt_nombre_completo_DUI.Text;
            validarCampos.EstadoTextBox(txt_nombre_completo_DUI);
            CopiarTextbox = txt_nombre_completo_DUI.Text;
            txt_nombre_completo_NIT.Text = CopiarTextbox;
            txt_docente.Text = CopiarTextbox;
        }

        private void txt_nombre_completo_NIT_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.NombreCompletoNIT = txt_nombre_completo_NIT.Text;
            validarCampos.EstadoTextBox(txt_nombre_completo_NIT);
        }

        private void cbx_estado_civil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Empleado.EstadoCivil = cbx_estado_civil.Text;
            validarCampos.EstadoComboBox(cbx_estado_civil);
        }

        private void txt_conyuge_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.Conyuge = txt_conyuge.Text;
            validarCampos.EstadoTextBoxOpcional(txt_conyuge);
        }

        private void txt_docente_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.NombreCompleto = txt_docente.Text;
            validarCampos.EstadoTextBox(txt_docente);
        }

        private void cbx_genero_Docente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Empleado.Jubilado = cbx_genero_Docente.Text;
            validarCampos.EstadoComboBox(cbx_genero_Docente);
        }

        private void cbx_jubilado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Empleado.IdNivelDeEstudio = Convert.ToInt32(cbx_nivelestudio.SelectedValue);
            validarCampos.EstadoComboBox(cbx_nivelestudio);
        }

        private void RecordarDatosTextboxComboBox()
        {
            cbx_estado_civil.SelectedItem = Atributos_Empleado.EstadoCivil;
            cbx_genero_Docente.SelectedItem = Atributos_Empleado.Jubilado;
            cbx_nivelestudio.SelectedValue = Convert.ToInt32(Atributos_Empleado.IdNivelDeEstudio);
            txt_conyuge.Text = Atributos_Empleado.Conyuge;
            txt_nombre_completo_DUI.Text = Atributos_Empleado.NombreCompletoDUI;
            txt_nombre_completo_NIT.Text = Atributos_Empleado.NombreCompletoNIT;
            txt_docente.Text = Atributos_Empleado.NombreCompleto;
        }

        private void cbx_nivelestudio_DropDown(object sender, EventArgs e)
        {
            if (Atributos_Empleado.IdNivelDeEstudio != 0)
            {
                cbx_nivelestudio.SelectedValue = Convert.ToInt32(Atributos_Empleado.IdNivelDeEstudio);
            }
            else
            {
                cbx_nivelestudio.SelectedIndex = -1;
                MostrarNivelDeEstudio();
            }

        }

        private void Agregar_Docentes_Datos_Personales_Load(object sender, EventArgs e)
        {
            MostrarNivelDeEstudio();
            MostrarEstadoJubilado();
            MostrarEstadoCivil();
            RecordarDatosTextboxComboBox();
            validarCampos.EstadoComboBox(cbx_estado_civil);
            validarCampos.EstadoComboBox(cbx_genero_Docente);
            validarCampos.EstadoComboBox(cbx_nivelestudio);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_nombre_completo_DUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            else if (char.IsLetter(e.KeyChar) && e.KeyChar >= 128)
            {
                e.Handled = true;
            }
        }

        private void txt_nombre_completo_NIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            else if (char.IsLetter(e.KeyChar) && e.KeyChar >= 128)
            {
                e.Handled = true;
            }
        }

        private void txt_conyuge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            else if (char.IsLetter(e.KeyChar) && e.KeyChar >= 128)
            {
                e.Handled = true;
            }
        }

        private void txt_docente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            else if (char.IsLetter(e.KeyChar) && e.KeyChar >= 128)
            {
                e.Handled = true;
            }
        }

        private void cbx_nivelestudio_Click(object sender, EventArgs e)
        {

            if (Atributos_Empleado.IdNivelDeEstudio != 0)
            {
                cbx_nivelestudio.SelectedValue = Convert.ToInt32(Atributos_Empleado.IdNivelDeEstudio);
            }
            else
            {
                cbx_nivelestudio.SelectedIndex = -1;
                MostrarNivelDeEstudio();
            }
        }
    }
}
