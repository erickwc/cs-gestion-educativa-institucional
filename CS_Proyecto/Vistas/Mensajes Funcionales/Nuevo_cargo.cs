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

namespace CS_Proyecto.Vistas.Mensajes_Funcionales
{
    public partial class Nuevo_cargo : Form
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
        public Nuevo_cargo()
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
            if (txt_cargo.Text == "")
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

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                btn_registrar.Enabled = false;
                cn_empleado.insertarTipoDocente(txt_cargo.Text);
                txt_cargo.Text = String.Empty;
                panel_ingresar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarBtn()
        {
            if (txt_cargo.Text == "")
            {
                btn_registrar.Visible = false;
            }
            else
            {
                btn_registrar.Visible = true;
            }
        }


        private void txt_cargo_TextChanged(object sender, EventArgs e)
        {
            ActualizarBtn();

            CD_Empleados alumnos = new CD_Empleados();

            bool busqueda = alumnos.BuscarCargosVentana(txt_cargo.Text);

            if (busqueda)
            {
                if (txt_cargo.Text == String.Empty)
                {
                    validar.EstadoTextBox(txt_cargo);
                    lbl_error.Visible = false;
                }
                else
                {
                    btn_registrar.Visible = false;
                    lbl_error.Visible = true;
                    validar.EstadoTextBoxIncorrecto(txt_cargo);
                }
            }
            else
            {
                lbl_error.Visible = false;
                validar.EstadoTextBoxOpcional(txt_cargo);
            }
        }
    }
}
