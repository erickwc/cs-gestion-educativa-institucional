using CS_Proyecto.Atributos;
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
    public partial class Agregar_Docente_Residencia_Contacto : Form
    {
        public Agregar_Docente_Residencia_Contacto()
        {
            InitializeComponent();
        }

        Vistas.ClasesVista.ValidarCampos validarCampos = new Vistas.ClasesVista.ValidarCampos();

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_direccion_docente_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.Direccion = txt_direccion_docente.Text;
            validarCampos.EstadoTextBox(txt_direccion_docente);
        }

        private void txt_telefono_de_casa_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.TelefonoCasa = txt_telefono_de_casa.Text;
            validarCampos.EstadoTextBox(txt_telefono_de_casa);
        }

        private void txt_telefono_oficina_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.TelefonoDeOficina = txt_telefono_oficina.Text;
            validarCampos.EstadoTextBox(txt_telefono_oficina);
        }

        private void txt_telefono_secundario_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.TelefonoMovilSecundario = txt_telefono_secundario.Text;
            validarCampos.EstadoTextBoxOpcional(txt_telefono_secundario);
        }

        private void txt_telefono_emergencia_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.TelefonoEmergencia = txt_telefono_emergencia.Text;
            validarCampos.EstadoTextBox(txt_telefono_emergencia);
        }

        private void txt_telefono_emergencia_sencundario_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.TelefonoDeEmergenciaSecundario = txt_telefono_emergencia_sencundario.Text;
            validarCampos.EstadoTextBoxOpcional(txt_telefono_emergencia_sencundario);
        }

        private void txt_telefono_movil_principal_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.TelefonoMovilPrincipal = txt_telefono_movil_principal.Text;
            validarCampos.EstadoTextBox(txt_telefono_movil_principal);
        }

        private void RecordarDatosTextboxComboBox()
        {
            txt_direccion_docente.Text = Atributos_Empleado.Direccion;
            txt_telefono_de_casa.Text = Atributos_Empleado.TelefonoCasa;
            txt_telefono_emergencia.Text = Atributos_Empleado.TelefonoEmergencia;
            txt_telefono_movil_principal.Text = Atributos_Empleado.TelefonoMovilPrincipal;
            txt_telefono_oficina.Text = Atributos_Empleado.TelefonoDeOficina;
            txt_telefono_secundario.Text = Atributos_Empleado.TelefonoMovilSecundario;
            txt_telefono_emergencia_sencundario.Text = Atributos_Empleado.TelefonoDeEmergenciaSecundario;
        }

        private void Agregar_Docente_Residencia_Contacto_Load(object sender, EventArgs e)
        {
            RecordarDatosTextboxComboBox();
        }

        private void txt_telefono_de_casa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_telefono_de_casa.TextLength < 9)
            {
                if (txt_telefono_de_casa.TextLength == 4)
                {
                    txt_telefono_de_casa.Text += "-";
                    txt_telefono_de_casa.SelectionStart = txt_telefono_de_casa.TextLength;
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

        private void txt_telefono_oficina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_telefono_oficina.TextLength < 9)
            {
                if (txt_telefono_oficina.TextLength == 4)
                {
                    txt_telefono_oficina.Text += "-";
                    txt_telefono_oficina.SelectionStart = txt_telefono_oficina.TextLength;
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

        private void txt_telefono_movil_principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_telefono_movil_principal.TextLength < 9)
            {
                if (txt_telefono_movil_principal.TextLength == 4)
                {
                    txt_telefono_movil_principal.Text += "-";
                    txt_telefono_movil_principal.SelectionStart = txt_telefono_movil_principal.TextLength;
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

        private void txt_telefono_secundario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_telefono_secundario.TextLength < 9)
            {
                if (txt_telefono_secundario.TextLength == 4)
                {
                    txt_telefono_secundario.Text += "-";
                    txt_telefono_secundario.SelectionStart = txt_telefono_secundario.TextLength;
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

        private void txt_telefono_emergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_telefono_emergencia.TextLength < 9)
            {
                if (txt_telefono_emergencia.TextLength == 4)
                {
                    txt_telefono_emergencia.Text += "-";
                    txt_telefono_emergencia.SelectionStart = txt_telefono_emergencia.TextLength;
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

        private void txt_telefono_emergencia_sencundario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_telefono_emergencia_sencundario.TextLength < 9)
            {
                if (txt_telefono_emergencia_sencundario.TextLength == 4)
                {
                    txt_telefono_emergencia_sencundario.Text += "-";
                    txt_telefono_emergencia_sencundario.SelectionStart = txt_telefono_emergencia_sencundario.TextLength;
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
    }
}
