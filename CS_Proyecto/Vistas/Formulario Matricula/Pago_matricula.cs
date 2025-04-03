using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using Guna.UI2.WinForms;
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
    public partial class Pago_matricula : Form
    {
        public Pago_matricula()
        {
            InitializeComponent();
        }

        private void MostrarTiposPago()
        {
            CD_Alumnos tiposPago = new CD_Alumnos();
            cmbx_forma_pago.DataSource = tiposPago.MostrarTiposDePago();
            cmbx_forma_pago.DisplayMember = "NombreTipoPago";
            cmbx_forma_pago.ValueMember = "IdTipoPago";
        }

        private void MostrarTiposPagoMatricula()
        {
            CD_Alumnos tiposPago = new CD_Alumnos();
            cbx_tipo_matricula.DataSource = tiposPago.MostrarTiposDePagatricula();
            cbx_tipo_matricula.DisplayMember = "TipoPagoMatricula";
            cbx_tipo_matricula.ValueMember = "IdTipoPagoMatricula";
        }

        double PrecioMatricula;
        ValidarCampos validar = new ValidarCampos();


        private void calcularPago()
        {
            PrecioMatricula = Atributos_Alumno.PrecioMatriculaSegunTipo;
            double TotalRestante;

            double CantidadCancelada = Convert.ToDouble(txt_cantidad_cancelada.Text);

            TotalRestante = PrecioMatricula - CantidadCancelada;

            Atributos_Alumno.CantidadCancelada = CantidadCancelada;
            Atributos_Alumno.CantidadPendiente = TotalRestante;
            txt_cantidad_restante.Text = Atributos_Alumno.CantidadPendiente.ToString("0.00");

        }


        private void txt_cantidad_cancelada_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_cantidad_cancelada.Text))
            {
               
            }
            else
            {
                calcularPago();
            }
        }



        private void txt_cantidad_restante_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbx_forma_pago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.IdTipoPago = Convert.ToInt32(cmbx_forma_pago.SelectedValue);
            validar.EstadoComboBox(cmbx_forma_pago);
        }



        private void Pago_matricula_Load(object sender, EventArgs e)
        {
            MostrarTiposPagoMatricula();
            MostrarTiposPago();
            RecordarDatosTextboxComboBox();
            validar.EstadoComboBox(cmbx_forma_pago);
            validar.EstadoComboBox(cbx_tipo_matricula);
            validar.EstadoTextBox(txt_cantidad_cancelada);
            txt_cantidad_restante.DisabledState.FillColor = Color.FromArgb(243, 255, 243);
            txt_cantidad_restante.DisabledState.BorderColor = Color.FromArgb(91, 163, 35);
            txt_cantidad_restante.DisabledState.ForeColor = Color.FromArgb(36, 114, 23);
            cbx_tipo_matricula.SelectedValue = Convert.ToString(Atributos_Alumno.IdTipoPagoMatricula);
            cmbx_forma_pago.SelectedValue = Convert.ToString(Atributos_Alumno.IdTipoPago);

            if (Atributos_Alumno.EstadoFormulario == "EditarAlumno")
            {
                txt_cantidad_cancelada.Enabled = true;
            }

            txt_cantidad_cancelada.Text = Atributos_Alumno.CantidadCancelada.ToString("0.00");

        }

        private void RecordarDatosTextboxComboBox()
        {
            //txt_cantidad_cancelada.Text = Atributos_Alumno.CantidadCancelada.ToString("0.00");
            txt_cantidad_restante.Text = Atributos_Alumno.CantidadPendiente.ToString("0.00");
           
        }

        private void txt_cantidad_cancelada_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o la tecla de retroceso (backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es un número ni una tecla de retroceso, verificar si es un punto
                if (e.KeyChar == '.')
                {
                    // Verificar si ya hay un punto en el texto
                    if (((Guna2TextBox)sender).Text.Contains("."))
                    {
                        // Si ya hay un punto, ignorar la tecla presionada
                        e.Handled = true;
                    }
                    else if (((Guna2TextBox)sender).Text.Length == 0)
                    {
                        // Si el texto está vacío, ignorar la tecla presionada
                        e.Handled = true;
                    }
                    else if (!((Guna2TextBox)sender).Text.Contains("."))
                    {
                        // Si no hay un punto y el texto no está vacío, permitir la tecla presionada
                        e.Handled = false;
                    }
                }
                else
                {
                    // Si la tecla no es un número ni un punto, ignorarla
                    e.Handled = true;
                }
            }
            else if (txt_cantidad_cancelada.Text.Length >= 4 && !txt_cantidad_cancelada.Text.Contains("."))
            {
                // Si ya hay 4 dígitos y no hay un punto, permitir eliminar números (tecla de retroceso)
                if (e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
        }

        private void cbx_tipo_matricula_SelectionChangeCommitted(object sender, EventArgs e)
        {       
            calcularPago();
            validar.EstadoTextBox(txt_cantidad_cancelada);
            validar.EstadoTextBox(txt_cantidad_restante);
            validar.EstadoComboBox(cbx_tipo_matricula);
            txt_cantidad_restante.DisabledState.FillColor = Color.FromArgb(243, 255, 243);
            txt_cantidad_restante.DisabledState.BorderColor = Color.FromArgb(91, 163, 35);
            txt_cantidad_restante.DisabledState.ForeColor = Color.FromArgb(36, 114, 23);

            Atributos_Alumno.IdTipoPagoMatricula = Convert.ToInt32(cbx_tipo_matricula.SelectedValue);
            validar.EstadoComboBox(cbx_tipo_matricula);

            txt_cantidad_cancelada.Text = "0.00";
            txt_cantidad_cancelada.Enabled = true;
            validar.EstadoTextBox(txt_cantidad_cancelada);
        }

        private void txt_cantidad_cancelada_Click(object sender, EventArgs e)
        {
            txt_cantidad_cancelada.Text = String.Empty;
        }

        private void txt_cantidad_cancelada_MouseClick(object sender, MouseEventArgs e)
        {
            //txt_cantidad_cancelada.Text = String.Empty;
        }

        private void actualizarTipoPago_Tick(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_cantidad_cancelada.Text))
            {
                // Puedes dejarlo como está o asignar otro valor si es necesario
                // txt_cantidad_cancelada.Text = String.Empty;
            }
            else
            {
                CD_Alumnos tipoMatricula = new CD_Alumnos();
                tipoMatricula.SaberPrecioMatricula(cbx_tipo_matricula.Text);
                calcularPago();


                RecordarDatosTextboxComboBox();
                validar.EstadoComboBox(cmbx_forma_pago);
                validar.EstadoComboBox(cbx_tipo_matricula);
                validar.EstadoTextBox(txt_cantidad_cancelada);
                txt_cantidad_restante.DisabledState.FillColor = Color.FromArgb(243, 255, 243);
                txt_cantidad_restante.DisabledState.BorderColor = Color.FromArgb(91, 163, 35);
                txt_cantidad_restante.DisabledState.ForeColor = Color.FromArgb(36, 114, 23);

                if (cbx_tipo_matricula.SelectedIndex != 0)
                {
                    txt_cantidad_cancelada.Enabled = true;
                }
            }
            
        }
    }
}
