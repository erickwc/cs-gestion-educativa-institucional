using CS_Proyecto.Atributos;
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
using System.Runtime.InteropServices;
using CS_Proyecto.Vistas.ClasesVista;

namespace CS_Proyecto.Vistas.Docentes.Modificar
{
    public partial class Modificar_Detalles : Form
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
        public Modificar_Detalles()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        private const int DEFAULT_VALUE = 1;
        CN_Empleado cN_Empleado = new CN_Empleado();
        string accionBtn="Guardar";

        private void mostrarAlergias()
        {
            cN_Empleado.MostrarAlergiasDocente(Atributos_Empleado.IdDocente);
            lbl_alergias_docentes.Text = Atributos_Empleado.MostrarAlergias;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (accionBtn == "Guardar")
                {
                    CN_Empleado cN_Empleado = new CN_Empleado();
                    cN_Empleado.insertarDetallesMedicosDocente(txt_alergias.Text, Atributos_Empleado.IdDocente);
                    txt_alergias.Text = String.Empty;
                    mostrarAlergias();
                    panel_tabla.Visible = true;
                    btn_detalles.Visible = true;

                }
                else if (accionBtn=="Editar")
                {
                    CN_Empleado cN_Empleado = new CN_Empleado();
                    cN_Empleado.modificarDetallesMedicosDocente(txt_alergias.Text, Atributos_Empleado.IdDocente);
                    txt_alergias.Text = String.Empty;
                    mostrarAlergias();
                    panel_tabla.Visible = true;
                    btn_detalles.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Modificar_Detalles_Load(object sender, EventArgs e)
        {
            mostrarAlergias();
            
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
           
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


        private void AccionBtn_Tick(object sender, EventArgs e)
        {
           
        }

        private void btn_detalles_Click(object sender, EventArgs e)
        {
            panel_tabla.Visible = false;
            btn_detalles.Visible = false;

            if (lbl_alergias_docentes.Text == "No Agregado" || lbl_alergias_docentes.Text == String.Empty)
            {
                btn_detalles.Text = "Agregar Detalles";
                accionBtn = "Guardar";
                lbl_alergias_docentes.Text = "No Agregado";
            }
            else if (lbl_alergias_docentes.Text != "No Agregado")
            {
                btn_detalles.Text = "Modificar Detalles";
                accionBtn = "Editar";
                txt_alergias.Text = lbl_alergias_docentes.Text;
            }

        }

        private void btn_regresar_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_alergias_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos validar = new ValidarCampos();
            validar.EstadoTextBox(txt_alergias);
        }
    }
}
