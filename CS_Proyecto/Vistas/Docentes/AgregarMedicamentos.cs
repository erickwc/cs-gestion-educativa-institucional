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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Docentes
{
    public partial class AgregarMedicamentos : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
 (
     int nLeftRect,     // x-coordinate of upper-left corner
     int nTopRect,      // y-coordinate of upper-left corner
     int nRightRect,    // x-coordinate of lower-right corner
     int nBottomRect,   // y-coordinate of lower-right corner
     int nWidthEllipse, // width of ellipse
     int nHeightEllipse // height of ellipse
 );
        public AgregarMedicamentos()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        CN_Empleado cn_empleado = new CN_Empleado();
        ValidarCampos validar = new ValidarCampos();

        private void txt_medicamento_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.NombreMedicamento = txt_medicamento.Text;
            validar.EstadoTextBox(txt_medicamento);
        }

        private void txt_dosis_medicamento_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.Dosis = txt_dosis_medicamento.Text;
            validar.EstadoTextBox(txt_dosis_medicamento);
        }

        private void txt_frecuencia_medicamento_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.Frecuencia = txt_frecuencia_medicamento.Text;
            validar.EstadoTextBox(txt_frecuencia_medicamento);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                cn_empleado.insertarMedicamentosDocentes(
                    Atributos_Empleado.NombreMedicamento,
                    Atributos_Empleado.Dosis,
                    Atributos_Empleado.Frecuencia,
                    Atributos_Empleado.IdDocente);

                txt_medicamento.Text = String.Empty;
                txt_frecuencia_medicamento.Text = String.Empty;
                txt_dosis_medicamento.Text = String.Empty;

                validar.EstadoTextBoxOpcional(txt_medicamento);
                validar.EstadoTextBoxOpcional(txt_dosis_medicamento);
                validar.EstadoTextBoxOpcional(txt_frecuencia_medicamento);

                PanelAlerta.Visible = true;
                QuitarAlerta.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void ActualizarForm_Tick(object sender, EventArgs e)
        {
            if (
                  !string.IsNullOrWhiteSpace(Atributos_Empleado.NombreMedicamento)
                  && !string.IsNullOrWhiteSpace(Atributos_Empleado.Frecuencia)
                  && !string.IsNullOrWhiteSpace(Atributos_Empleado.Dosis)
                  )
            {
                btn_guardar.Visible = true;
            }
            else
            {
                btn_guardar.Visible = false;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuitarAlerta_Tick(object sender, EventArgs e)
        {
            PanelAlerta.Visible = false;
            if (PanelAlerta.Visible == false)
            {
                QuitarAlerta.Stop();
            }
        }
    }
}
