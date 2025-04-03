using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using Guna.UI2.WinForms;
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
    public partial class AgregarDetalles : Form
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

        public AgregarDetalles()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);

        }

        CN_Empleado cn_empleado = new CN_Empleado();
        ValidarCampos validar = new ValidarCampos();

        private void txt_alergias_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.AlegiasPadecidas = txt_alergias.Text;
            validar.EstadoTextBox(txt_alergias);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                cn_empleado.insertarDetallesMedicosDocente(
                Atributos_Empleado.AlegiasPadecidas,
                Atributos_Empleado.IdDocente);

                txt_alergias.Text = String.Empty;
                validar.EstadoTextBoxOpcional(txt_alergias);
                PanelAlerta.Visible = true;
                MostrarAlerta.Start();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void ValidarBotones()
        {
            if (
                  !string.IsNullOrWhiteSpace(Atributos_Empleado.AlegiasPadecidas)
                  )
            {
                btn_guardar.Visible = true;
            }
            else
            {
                btn_guardar.Visible = false;
            }
        }

        private void AgregarDetalles_Load(object sender, EventArgs e)
        {
            txt_alergias.Text = Atributos_Empleado.AlegiasPadecidas;
        }

        private void ActualizarForm_Tick(object sender, EventArgs e)
        {
            ValidarBotones();
            this.Invalidate();
        }

        private void MostrarAlerta_Tick(object sender, EventArgs e)
        {
            PanelAlerta.Visible = false;
            this.Close();
            if (PanelAlerta.Visible == false)
            {
                MostrarAlerta.Stop();
            }
        }
    }
}
