using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Dashboard;
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

namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    public partial class Agregar_medicamentos : Form
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
        public Agregar_medicamentos()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }


        CN_Alumnos cn_alumnos = new CN_Alumnos();
        ValidarCampos validar = new ValidarCampos();
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_iniciarsesion_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                cn_alumnos.InsertarMedicamento(
                    Atributos_Alumno.NombreMedicamento,
                    Atributos_Alumno.Dosis,
                    Atributos_Alumno.Frecuencia,
                    Atributos_Alumno.IdAlumno);
                

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

        private void txt_medicamento_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.NombreMedicamento = txt_medicamento.Text;
            validar.EstadoTextBox(txt_medicamento);
        }

        private void Agregar_medicamentos_Load(object sender, EventArgs e)
        {
            txt_frecuencia_medicamento.Text = Atributos_Alumno.Dosis;
            txt_dosis_medicamento.Text = Atributos_Alumno.Frecuencia;
            txt_medicamento.Text = Atributos_Alumno.NombreMedicamento;
        }

        private void ActualizarFormulario_Tick(object sender, EventArgs e)
        {
            if (
                  !string.IsNullOrWhiteSpace(Atributos_Alumno.NombreMedicamento)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.Frecuencia)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.Dosis)
                  )
            {
                btn_guardar.Visible = true;
            }
            else
            {
                btn_guardar.Visible = false;
            }
        }

        private void txt_dosis_medicamento_TextChanged_1(object sender, EventArgs e)
        {
            Atributos_Alumno.Dosis = txt_dosis_medicamento.Text;
            validar.EstadoTextBox(txt_dosis_medicamento);
        }

        private void txt_frecuencia_medicamento_TextChanged_1(object sender, EventArgs e)
        {
            Atributos_Alumno.Frecuencia = txt_frecuencia_medicamento.Text;
            validar.EstadoTextBox(txt_frecuencia_medicamento);
        }

        private void QuitarAlerta_Tick(object sender, EventArgs e)
        {
            PanelAlerta.Visible = false;
            if (PanelAlerta.Visible == false)
            {
                QuitarAlerta.Stop();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
