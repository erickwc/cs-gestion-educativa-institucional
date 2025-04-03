using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    public partial class Residencia_contacto : Form
    {
        public Residencia_contacto()
        {
            InitializeComponent();
        }

        Vistas.ClasesVista.ValidarCampos validarCampos = new Vistas.ClasesVista.ValidarCampos();

        public void MostrarDepartamentos()
        {
            CD_Alumnos cd_alumno_departamentos = new CD_Alumnos();
            cmbx_departamento.DataSource = cd_alumno_departamentos.MostrarDepartamentos();
            cmbx_departamento.DisplayMember = "NombreDepartamento";
            cmbx_departamento.ValueMember = "IdDepartamento";
        }

        public void MostrarMunicipios()
        {
            try
            {
                CD_Alumnos cd_alumno_municipios = new CD_Alumnos();
                cmbx_municipio.DataSource = cd_alumno_municipios.MostrarMunicipios(cmbx_departamento.Text);
                cmbx_municipio.DisplayMember = "NombreMunicipio";
                cmbx_municipio.ValueMember = "IdMunicipio";
                cmbx_municipio.SelectedIndex = -1;
                validarCampos.EstadoComboBox(cmbx_municipio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ ex);
            }
            
        }

        public void MostrarZonaResidencia()
        {
            CD_Alumnos cd_alumno_zona_residencia = new CD_Alumnos();
            cmbx_zona_residencia.DataSource = cd_alumno_zona_residencia.MostrarZonasResidencia();
            cmbx_zona_residencia.DisplayMember = "ZonaResidencial";
            cmbx_zona_residencia.ValueMember = "IdZonaResidencia";
        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.Direccion = txt_direccion.Text;
            validarCampos.EstadoTextBox(txt_direccion);
        }

        private void txt_canton_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.Canton = txt_canton.Text;
            validarCampos.EstadoTextBoxOpcional(txt_canton);
        }

        private void txt_caserio_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.Caserio = txt_caserio.Text;
            validarCampos.EstadoTextBoxOpcional(txt_caserio);

        }

        private void Residencia_contacto_Load(object sender, EventArgs e)
        {
            MostrarDepartamentos();
            RecargarDatos();
            MostrarZonaResidencia();
            IniciarComboBoxSinOpcionSeleccionada();
            validarCampos.EstadoComboBox(cmbx_departamento);
            validarCampos.EstadoComboBox(cmbx_municipio);
            validarCampos.EstadoComboBox(cmbx_zona_residencia);
            
        }

        private void cmbx_municipio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.IdMunicipio = Convert.ToInt32(cmbx_municipio.SelectedValue);
            validarCampos.EstadoComboBox(cmbx_municipio);
        }

        private void cmbx_departamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.IdDepartamento = Convert.ToInt32(cmbx_departamento.SelectedValue);
            validarCampos.EstadoComboBox(cmbx_departamento);
            MostrarMunicipios();
        }


        private void txt_tel_fijo_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.TelFijoPrincipal = txt_tel_fijo.Text;
            validarCampos.EstadoTextBoxOpcional(txt_tel_fijo);
        }

        private void txt_tel_fijo_secundario_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.TelFijoSecundario = txt_tel_fijo_secundario.Text;
            validarCampos.EstadoTextBoxOpcional(txt_tel_fijo_secundario);
        }


        private void RecargarDatos()
        {
            cmbx_departamento.SelectedValue = Convert.ToString(Atributos_Alumno.IdDepartamento);
            cmbx_municipio.SelectedValue = Convert.ToString(Atributos_Alumno.IdMunicipio);
            cmbx_zona_residencia.SelectedValue = Convert.ToString(Atributos_Alumno.IdZonaResidencia);
            txt_direccion.Text = Atributos_Alumno.Direccion;
            txt_canton.Text = Atributos_Alumno.Canton;
            txt_caserio.Text = Atributos_Alumno.Caserio;
            txt_tel_fijo.Text = Atributos_Alumno.TelFijoPrincipal;
            txt_tel_fijo_secundario.Text = Atributos_Alumno.TelFijoSecundario;
            txt_movil_alumno.Text = Atributos_Alumno.TelMovilPrincipalAlumno;
            txt_movil_secundario.Text = Atributos_Alumno.TelMovilSecundarioAlumno;
            txt_correo_gmail.Text = Atributos_Alumno.EmailAumno;
            timer1.Start();
        }

        private void IniciarComboBoxSinOpcionSeleccionada()
        {
            if (Atributos_Alumno.IdDepartamento == 0)
            {
                cmbx_departamento.SelectedIndex = -1;
            }
            else
            {
                cmbx_departamento.SelectedValue = Convert.ToString(Atributos_Alumno.IdDepartamento);
            }

            if (Atributos_Alumno.IdZonaResidencia == 0)
            {
                cmbx_zona_residencia.SelectedIndex = -1;
            }
            else
            {
                cmbx_zona_residencia.SelectedValue = Convert.ToString(Atributos_Alumno.IdZonaResidencia);
            }

            if (Atributos_Alumno.IdMunicipio == 0)
            {
                cmbx_municipio.SelectedIndex = -1;
            }
            else
            {
                cmbx_municipio.SelectedValue = Convert.ToString(Atributos_Alumno.IdMunicipio);
            }
        }

        private void txt_movil_alumno_TextChanged_1(object sender, EventArgs e)
        {
            Atributos_Alumno.TelMovilPrincipalAlumno = txt_movil_alumno.Text;
            validarCampos.EstadoTextBox(txt_movil_alumno);
        }

        private void txt_movil_secundario_TextChanged_1(object sender, EventArgs e)
        {
            Atributos_Alumno.TelMovilSecundarioAlumno = txt_movil_secundario.Text;
            validarCampos.EstadoTextBoxOpcional(txt_movil_secundario);
        }

        private void txt_correo_gmail_TextChanged_1(object sender, EventArgs e)
        {
            Atributos_Alumno.EmailAumno = txt_correo_gmail.Text;
            
            string correo = txt_correo_gmail.Text;
            if (ValidarFormatoCorreo(correo))
            {
                lbl_correo_valido.Visible = false;
                validarCampos.EstadoTextBox(txt_correo_gmail);
            }
            else
            {
                lbl_correo_valido.Visible = true;
                validarCampos.UsuarioConNombreIgual(txt_correo_gmail);
            }
        }

        private bool ValidarFormatoCorreo(string correo)
        {
            //Expresiónes regulares para validar el formato del correo electrónico
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(patronCorreo);

            return regex.IsMatch(correo);
        }

        private void cmbx_zona_residencia_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Atributos_Alumno.IdZonaResidencia = Convert.ToInt32(cmbx_zona_residencia.SelectedValue);
            validarCampos.EstadoComboBox(cmbx_zona_residencia);

            if(cmbx_zona_residencia.Text == "Rural")
            {
                txt_canton.Text = String.Empty;
                txt_caserio.Text = String.Empty;
                txt_canton.Enabled = true;
                txt_caserio.Enabled = true;
            }
            else if (cmbx_zona_residencia.Text == "Urbana")
            {
                txt_canton.Text = "N/A";
                txt_caserio.Text = "N/A";
                txt_canton.Enabled = false;
                txt_caserio.Enabled = false;
              
            }
        }

        private void txt_tel_fijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_tel_fijo.TextLength < 9)
            {
                if (txt_tel_fijo.TextLength == 4)
                {
                    txt_tel_fijo.Text += "-";
                    txt_tel_fijo.SelectionStart = txt_tel_fijo.TextLength;
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

        private void txt_tel_fijo_secundario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_tel_fijo_secundario.TextLength < 9)
            {
                if (txt_tel_fijo_secundario.TextLength == 4)
                {
                    txt_tel_fijo_secundario.Text += "-";
                    txt_tel_fijo_secundario.SelectionStart = txt_tel_fijo_secundario.TextLength;
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

        private void txt_movil_alumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_movil_alumno.TextLength < 9)
            {
                if (txt_movil_alumno.TextLength == 4)
                {
                    txt_movil_alumno.Text += "-";
                    txt_movil_alumno.SelectionStart = txt_movil_alumno.TextLength;
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

        private void txt_movil_secundario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_movil_secundario.TextLength < 9)
            {
                if (txt_movil_secundario.TextLength == 4)
                {
                    txt_movil_secundario.Text += "-";
                    txt_movil_secundario.SelectionStart = txt_movil_secundario.TextLength;
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

        private void txt_correo_gmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)
                && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '_' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MostrarMunicipios();
            //validarCampos.EstadoComboBox(cmbx_municipio);

            if (Atributos_Alumno.IdMunicipio != 0)
            {
                
                MostrarMunicipios();
                cmbx_municipio.SelectedValue = Convert.ToString(Atributos_Alumno.IdMunicipio);
                validarCampos.EstadoComboBox(cmbx_municipio);
                timer1.Stop();
            }
        }
    }
}
