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
    public partial class Agregar_Docente_Identificacion : Form
    {
        public Agregar_Docente_Identificacion()
        {
            InitializeComponent();
        }

        Vistas.ClasesVista.ValidarCampos validarCampos = new Vistas.ClasesVista.ValidarCampos();


        private void btn_añadir_cargo_Click(object sender, EventArgs e)
        {
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (Vistas.Mensajes_Funcionales.Nuevo_cargo nuevo_Cargo = new Mensajes_Funcionales.Nuevo_cargo())
            {
                fondo.Oscurecer(nuevo_Cargo);
            }
        }

        private void btn_añadir_especialidad_Click(object sender, EventArgs e)
        {
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (Vistas.Mensajes_Funcionales.Nueva_especialidad nueva_Especialidad = new Mensajes_Funcionales.Nueva_especialidad())
            {
                fondo.Oscurecer(nueva_Especialidad);
            }
        }


        public void MostrarCargos()
        {

            CD_Empleados cd_empleados_cargos = new CD_Empleados();
            cbx_cargo.DataSource = cd_empleados_cargos.MostrarCargosParaRegistroEmpleado();
            cbx_cargo.DisplayMember = "TipoDocente";
            cbx_cargo.ValueMember = "IdTipoDocente";
            cbx_cargo.StartIndex = -1;
        }

        public void MostrarEspecialidad()
        {

            CD_Empleados cd_empleados_especialidad = new CD_Empleados();
            cbx_especialidad_docente.DataSource = cd_empleados_especialidad.MostrarEspecialidadesParaRegistro();
            cbx_especialidad_docente.DisplayMember = "TipoEspecialidad";
            cbx_especialidad_docente.ValueMember = "IdEspecialidadDocentes";
            cbx_especialidad_docente.StartIndex = -1;

        }

        public void MostrarEstadoDelDocente()
        {
            CD_Empleados cd_empleados_estado = new CD_Empleados();
            cbx_estado_docente.DataSource = cd_empleados_estado.MostrarEstadoDocente();
            cbx_estado_docente.DisplayMember = "TipoEstado";
            cbx_estado_docente.ValueMember = "IdTipoEstado";
            cbx_estado_docente.StartIndex = -1;
        }

        private void txt_docente_DUI_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.DUI = txt_docente_DUI.Text;
            validarCampos.EstadoTextBox(txt_docente_DUI);
        }

        private void txt_docente_NIT_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.NIT = txt_docente_NIT.Text;
            validarCampos.EstadoTextBox(txt_docente_NIT);
        }

        private void txt_docente_NIP_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.NIP = txt_docente_NIP.Text;
            validarCampos.EstadoTextBox(txt_docente_NIP);
        }

        private void txt_docente_ISSS_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.NumeroDeISSS = txt_docente_ISSS.Text;
            validarCampos.EstadoTextBox(txt_docente_ISSS);
        }

        private void txt_afiliado_AFP_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.AFP = txt_afiliado_AFP.Text;
            validarCampos.EstadoTextBox(txt_afiliado_AFP);
        }

        private void txt_docente_NUP_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.NUP = txt_docente_NUP.Text;
            validarCampos.EstadoTextBox(txt_docente_NUP);
        }

        private void cbx_especialidad_docente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Empleado.IdEspecialidad = Convert.ToInt32(cbx_especialidad_docente.SelectedValue);
            validarCampos.EstadoComboBox(cbx_especialidad_docente);
        }

        private void cbx_estado_docente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Empleado.IdEstado = Convert.ToInt32(cbx_estado_docente.SelectedValue);
            validarCampos.EstadoComboBox(cbx_estado_docente);
        }

        private void cbx_cargo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Empleado.IdTipoDeCargo = Convert.ToInt32(cbx_cargo.SelectedValue);
            validarCampos.EstadoComboBox(cbx_cargo);
        }

        private void RecordarDatosTextboxComboBox()
        {
            cbx_cargo.SelectedValue = Convert.ToInt32(Atributos_Empleado.IdTipoDeCargo);
            cbx_especialidad_docente.SelectedValue = Convert.ToInt32(Atributos_Empleado.IdEspecialidad);
            cbx_estado_docente.SelectedValue = Convert.ToInt32(Atributos_Empleado.IdEstado);
            txt_afiliado_AFP.Text = Atributos_Empleado.AFP;
            txt_docente_DUI.Text = Atributos_Empleado.DUI;
            txt_docente_ISSS.Text = Atributos_Empleado.NumeroDeISSS;
            txt_docente_NIP.Text = Atributos_Empleado.NIP;
            txt_docente_NUP.Text = Atributos_Empleado.NUP;
            txt_docente_NIT.Text = Atributos_Empleado.NIT;

        }

        private void Agregar_Docente_Identificacion_Load(object sender, EventArgs e)
        {
            MostrarEstadoDelDocente();
            MostrarCargos();
            MostrarEspecialidad();
            RecordarDatosTextboxComboBox();
            validarCampos.EstadoComboBox(cbx_cargo);
            validarCampos.EstadoComboBox(cbx_especialidad_docente);
            validarCampos.EstadoComboBox(cbx_estado_docente);
        }

        private void cbx_cargo_DropDown(object sender, EventArgs e)
        {
            if (Atributos_Empleado.IdTipoDeCargo != 0)
            {
                cbx_cargo.SelectedValue = Convert.ToInt32(Atributos_Empleado.IdTipoDeCargo);
            }
            else
            {
                cbx_cargo.SelectedIndex = -1;
                MostrarCargos();
            }

        }

        private void cbx_especialidad_docente_DropDown(object sender, EventArgs e)
        {
            if (Atributos_Empleado.IdEspecialidad != 0)
            {
                cbx_especialidad_docente.SelectedValue = Convert.ToInt32(Atributos_Empleado.IdEspecialidad);
            }
            else
            {
                cbx_especialidad_docente.SelectedIndex = -1;
                MostrarEspecialidad();
            }

        }

        private void txt_docente_DUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_docente_DUI.TextLength < 10)
            {
                if (txt_docente_DUI.TextLength == 8)
                {
                    txt_docente_DUI.Text += "-";
                    txt_docente_DUI.SelectionStart = txt_docente_DUI.TextLength; // Mover el cursor al final del texto.
                }
            }
            else if (e.KeyChar == '\b')
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_docente_NIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_docente_NIT.TextLength < 10)
            {
                if (txt_docente_NIT.TextLength == 8)
                {
                    txt_docente_NIT.Text += "-";
                    txt_docente_NIT.SelectionStart = txt_docente_NIT.TextLength;
                }
            }
            else if (e.KeyChar == '\b')
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_docente_NIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txt_docente_NIP.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_docente_ISSS_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) && txt_docente_ISSS.TextLength < 10)
            {
                if (txt_docente_ISSS.TextLength == 8)
                {
                    txt_docente_ISSS.Text += "-";
                    txt_docente_ISSS.SelectionStart = txt_docente_NIT.TextLength;
                }
            }
            else if (e.KeyChar == '\b')
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_afiliado_AFP_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_docente_NUP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_docente_NUP.TextLength < 10)
            {
                if (txt_docente_NUP.TextLength == 8)
                {
                    txt_docente_NUP.Text += "-";
                    txt_docente_NUP.SelectionStart = txt_docente_NIT.TextLength;
                }
            }
            else if (e.KeyChar == '\b')
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cbx_cargo_Click(object sender, EventArgs e)
        {
            if (Atributos_Empleado.IdTipoDeCargo != 0)
            {
                cbx_cargo.SelectedValue = Convert.ToInt32(Atributos_Empleado.IdTipoDeCargo);
            }
            else
            {
                cbx_cargo.SelectedIndex = -1;
                MostrarCargos();
            }

        }

        private void cbx_especialidad_docente_Click(object sender, EventArgs e)
        {
            if (Atributos_Empleado.IdEspecialidad != 0)
            {
                cbx_especialidad_docente.SelectedValue = Convert.ToInt32(Atributos_Empleado.IdEspecialidad);
            }
            else
            {
                cbx_especialidad_docente.SelectedIndex = -1;
                MostrarEspecialidad();
            }
        }
    }
}
