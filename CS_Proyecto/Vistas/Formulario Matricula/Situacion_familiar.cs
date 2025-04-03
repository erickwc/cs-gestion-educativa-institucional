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

namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    public partial class Situacion_familiar : Form
    {
        public Situacion_familiar()
        {
            InitializeComponent();
        }

        Vistas.ClasesVista.ValidarCampos validar = new Vistas.ClasesVista.ValidarCampos();

       

        private void cmbx_dependencia_familiar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.DependenciaFamiliar = cmbx_dependencia_familiar.Text;
            validar.EstadoComboBox(cmbx_dependencia_familiar);
        }

        private void cmbx_dependencia_economica_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.DependenciaEconomica = cmbx_dependencia_economica.Text;
            validar.EstadoComboBox(cmbx_dependencia_economica);
        }

        private void txt_lugar_trabajo_situacion_familiar_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.LugarTrabajo = txt_lugar_trabajo_situacion_familiar.Text;
            validar.EstadoTextBox(txt_lugar_trabajo_situacion_familiar);
        }

        private void txt_cargo_trabajo_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.Cargo = txt_cargo_trabajo.Text;
            validar.EstadoTextBox(txt_cargo_trabajo);
        }

        private void Situacion_familiar_Load(object sender, EventArgs e)
        {
            numeroMiembrosFamilia();
            RecordarDatosTextboxComboBox();
            validar.EstadoComboBox(cmbx_dependencia_familiar);
            validar.EstadoComboBox(cmbx_dependencia_economica);
            validar.EstadoComboBox(cmbx_numero_miebros);
        }

        private void RecordarDatosTextboxComboBox()
        {
            txt_cargo_trabajo.Text = Atributos_Alumno.Cargo;
            cmbx_numero_miebros.Text = Atributos_Alumno.NumeroMiembrosFamilia;
            txt_lugar_trabajo_situacion_familiar.Text = Atributos_Alumno.LugarTrabajo;
            cmbx_dependencia_economica.Text = Atributos_Alumno.DependenciaEconomica;
            cmbx_dependencia_familiar.Text = Atributos_Alumno.DependenciaFamiliar;
            cmbx_numero_miebros.Text = Atributos_Alumno.NumeroMiembrosFamilia;

        }

        private void numeroMiembrosFamilia()
        {
            for (int num = 1; num <= 100; num++)
            {
                cmbx_numero_miebros.Items.Add(num);
            }
        }

        private void cmbx_numero_miebros_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.NumeroMiembrosFamilia = cmbx_numero_miebros.Text;
            validar.EstadoComboBox(cmbx_numero_miebros);
        }

        private void txt_lugar_trabajo_situacion_familiar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_cargo_trabajo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbx_dependencia_familiar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
