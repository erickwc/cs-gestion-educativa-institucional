using CS_Proyecto.Atributos;
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
    public partial class AgregarAfecciones : Form
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

        public AgregarAfecciones()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        CN_Empleado cn_empleado = new CN_Empleado();
        ValidarCampos validar = new ValidarCampos();

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                cn_empleado.insertarAfeccionesDocentes(
                Atributos_Empleado.NombreAfeccion,
                Atributos_Empleado.TipoAfeccion,
                Atributos_Empleado.ProcedimientoMedico,
                Atributos_Empleado.IdDocente);

                txt_afeccion.Text = String.Empty;
                txt_tipoafeccion.Text = String.Empty;
                txt_procedimiento.Text = String.Empty;

                PanelAlerta.Visible = true;
                QuitarAlerta.Start();
                  
                validar.EstadoTextBoxOpcional(txt_afeccion);
                validar.EstadoTextBoxOpcional(txt_tipoafeccion);
                validar.EstadoTextBoxOpcional(txt_procedimiento);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void txt_afeccion_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.NombreAfeccion = txt_afeccion.Text;
            validar.EstadoTextBox(txt_afeccion);
        }

        private void txt_tipoafeccion_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.TipoAfeccion = txt_tipoafeccion.Text;
            validar.EstadoTextBox(txt_tipoafeccion);
        }

        private void txt_procedimiento_TextChanged(object sender, EventArgs e)
        {
            Atributos_Empleado.ProcedimientoMedico = txt_procedimiento.Text;
            validar.EstadoTextBox(txt_procedimiento);
        }

        private void ActualizarFormulario_Tick(object sender, EventArgs e)
        {
            if (
                  !string.IsNullOrWhiteSpace(txt_procedimiento.Text)
                  && !string.IsNullOrWhiteSpace(txt_tipoafeccion.Text)
                  && !string.IsNullOrWhiteSpace(txt_afeccion.Text)
                  )
            {
                btn_guardar.Visible = true;
            }
            else
            {
                btn_guardar.Visible = false;
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
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
