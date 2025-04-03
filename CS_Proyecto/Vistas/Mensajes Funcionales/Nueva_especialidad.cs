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

namespace CS_Proyecto.Vistas.Mensajes_Funcionales
{
    public partial class Nueva_especialidad : Form
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
        public Nueva_especialidad()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        Vistas.ClasesVista.ValidarCampos validarCampos = new Vistas.ClasesVista.ValidarCampos();
        CN_Empleado cn_empleado = new CN_Empleado();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        ValidarCampos validar = new ValidarCampos();

        private void actualizarBtn()
        {
            if (txt_especialidad.Text == "")
            {
                btn_registrar.Visible = false;
            }
            else
            {
                btn_registrar.Visible = true;
            }
        }


        private void btn_cancelar__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                btn_registrar.Enabled = false;
                cn_empleado.insertarEspecialidadDocentes(txt_especialidad.Text);
                txt_especialidad.Text = String.Empty;
                panel_ingresar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_especialidad_TextChanged(object sender, EventArgs e)
        {
            actualizarBtn();

            CD_Empleados alumnos = new CD_Empleados();

            bool busqueda = alumnos.BuscarEspecialidadesDocenteVentana(txt_especialidad.Text);

            if (busqueda)
            {
                if (txt_especialidad.Text == String.Empty)
                {
                    validar.EstadoTextBox(txt_especialidad);
                    lbl_error.Visible = false;
                }
                else
                {
                    btn_registrar.Visible = false;
                    lbl_error.Visible = true;
                    validar.EstadoTextBoxIncorrecto(txt_especialidad);
                }
            }
            else
            {
                lbl_error.Visible = false;
                validar.EstadoTextBoxOpcional(txt_especialidad);
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
