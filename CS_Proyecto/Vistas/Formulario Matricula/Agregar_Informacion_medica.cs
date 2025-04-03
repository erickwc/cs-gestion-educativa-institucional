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

namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    public partial class Agregar_Informacion_medica : Form
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
        public Agregar_Informacion_medica()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);

        }

        CN_Alumnos cn_alumnos = new CN_Alumnos();
        ValidarCampos validar = new ValidarCampos();

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                cn_alumnos.InsertarDetallesMedicos(
                Atributos_Alumno.PermiteActividadFisica,
                Atributos_Alumno.AlegiasPadecidas,
                Atributos_Alumno.IdAlumno);

                txt_alergias.Text = String.Empty;
                validar.EstadoTextBoxOpcional(txt_alergias);
                PanelAlerta.Visible = true;
                MostrarAlerta.Start();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void txt_alergias_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.AlegiasPadecidas = txt_alergias.Text;
            validar.EstadoTextBoxOpcional(txt_alergias);
        }

        private void cmbx_actividadfisica_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.PermiteActividadFisica = cmbx_actividadfisica.Text;
            validar.EstadoComboBox(cmbx_actividadfisica);
        }

        private void ValidarBotones()
        {
            if (
                  !string.IsNullOrWhiteSpace(Atributos_Alumno.PermiteActividadFisica)
                  )
            {
                btn_guardar.Visible = true;
            }
            else
            {
                btn_guardar.Visible = false;
            }
        }

        private void Agregar_Informacion_medica_Load(object sender, EventArgs e)
        {
            cmbx_actividadfisica.Text = Atributos_Alumno.PermiteActividadFisica;
            txt_alergias.Text = Atributos_Alumno.AlegiasPadecidas;
            validar.EstadoComboBox(cmbx_actividadfisica);
        }

        private void ActualizarFormulario_Tick(object sender, EventArgs e)
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
