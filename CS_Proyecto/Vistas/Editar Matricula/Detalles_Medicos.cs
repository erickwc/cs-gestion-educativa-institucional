using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CS_Proyecto.Vistas.Editar_Matricula
{
    public partial class Detalles_Medicos : Form
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
        public Detalles_Medicos()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        ValidarCampos validar = new ValidarCampos();
        CN_Alumnos cn_alumnos = new CN_Alumnos();
        LimpiarVariables limpiar = new LimpiarVariables();
        string AccionBtn = "Guardar";

        private void Detalles_Medicos_Load(object sender, EventArgs e)
        {
            ActualizarLbl();
            txt_alergias.Text = Atributos_Alumno.MostrarAlergias;

            if (Atributos_Alumno.MostrarAlergias == "Si Permite" || Atributos_Alumno.MostrarAlergias == "No Permite")
            {
                cmbx_permite_act_fisica.Text = Atributos_Alumno.MostrarPermiteActividadFisica;
            }
            else if (Atributos_Alumno.MostrarAlergias != "Si" && Atributos_Alumno.MostrarAlergias != "No")
            {
            }

            if (AccionBtn == "Editar")
            {
                cmbx_permite_act_fisica.Visible = true;
            }

        }

        private void ActualizarLbl()
        {
            cn_alumnos.ConsultarDetallesMedicosAlumnoPorId(Atributos_Alumno.IdAlumno);
            lbl_act_fisica.Text = Atributos_Alumno.MostrarPermiteActividadFisica;
            lbl_alergias.Text = Atributos_Alumno.MostrarAlergias;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            panel_tabla.Visible = true;
            btn_detalles.Visible = true;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (AccionBtn == "Guardar")
                {
                    cn_alumnos.InsertarDetallesMedicos(
                        Atributos_Alumno.PermiteActividadFisica,
                        Atributos_Alumno.AlegiasPadecidas,
                        Atributos_Alumno.IdAlumno
                    );
                    ActualizarLbl();
                }
                else if (AccionBtn == "Editar")
                {
                    cn_alumnos.ModificarDetallesMedicos(
                       Atributos_Alumno.PermiteActividadFisica,
                       Atributos_Alumno.AlegiasPadecidas,
                       Atributos_Alumno.IdAlumno
                    );
                    ActualizarLbl();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            panel_tabla.Visible = true;
            btn_detalles.Visible = true;
        }

        private void txt_alergias_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.AlegiasPadecidas = txt_alergias.Text;
            validar.EstadoTextBoxOpcional(txt_alergias);
        }

        private void cmbx_permite_act_fisica_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.PermiteActividadFisica = cmbx_permite_act_fisica.Text;
            validar.EstadoComboBox(cmbx_permite_act_fisica);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbx_permite_act_fisica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_alergias_Click(object sender, EventArgs e)
        {

        }

        

        private void btn_detalles_Click(object sender, EventArgs e)
        {
            panel_tabla.Visible = false;
            btn_detalles.Visible = false;

            AccionBtn = "Editar";
            txt_alergias.Text = lbl_alergias.Text;
            cmbx_permite_act_fisica.Text = lbl_act_fisica.Text;
        }

        private void btn_regresar_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarForm_Tick(object sender, EventArgs e)
        {
            if (
               !string.IsNullOrWhiteSpace(txt_alergias.Text)
               )
            {
                btn_guardar.Visible = true;
            }
            else
            {
                btn_guardar.Visible = false;
            }
            this.Invalidate();
        }

        private void Actulizarbtn_Tick(object sender, EventArgs e)
        {
            if (lbl_act_fisica.Text == "No Establecido" || lbl_alergias.Text == "No Posee")
            {
                btn_detalles.Text = "Agregar Detalles";
                AccionBtn = "Guardar";
                lbl_alergias.Text = "No Agregado";
            }
            else if (lbl_alergias.Text != "No Agregado")
            {
                btn_detalles.Text = "Modificar Detalles";
                AccionBtn = "Editar";
            }
        }

        private void panel_tabla_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
