using CS_Proyecto.CapaDatos;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Formas_de_pago
{
    public partial class FormasPago : Form
    {
        public FormasPago()
        {
            InitializeComponent();
        }

        CD_Alumnos alumnos = new CD_Alumnos();
        string IdInst;
        string datobusqueda;
        string EstadoForm = "Guardar";
        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        ValidarCampos validar = new ValidarCampos();

        private void CargarFormasPago()
        {
            CD_Alumnos alumnos = new CD_Alumnos();
            DGV_formasPago.DataSource = alumnos.MostrarFormasDePago();
            DGV_formasPago.Columns["IdTipoPago"].Visible = false;
            DGV_formasPago.Columns["Formas de pago"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void Mostrarbtn()
        {
            añadirBtn.AñadirBotonEditarEnDataGrid(DGV_formasPago);
            DGV_formasPago.Columns["ImagenColumna"].DisplayIndex = 2;
            DGV_formasPago.Columns["ImagenColumna"].Width = 150;
        }

        private void btn_guardar_registro_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstadoForm == "Guardar")
                {
                    alumnos.InsertarFormasDePago(txt_formas_pago.Text);
                    CargarFormasPago();
                }
                else if (EstadoForm == "Editar")
                {
                    alumnos.ModificarFormasDePago(txt_formas_pago.Text, Convert.ToInt32(IdInst));
                    CargarFormasPago();
                    EstadoForm = "Guardar";
                    btn_guardar_registro.Text = "Agregar";
                }

                txt_formas_pago.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaberSiYaExisteElRegistro()
        {
            bool registroDuplicadoEncontrado = false; // Indicador de registro duplicado

            // Eliminamos espacios en blanco al final del texto del TextBox
            string txt_cargoValue = txt_formas_pago.Text.Trim().ToLower();

            foreach (DataGridViewRow dr in DGV_formasPago.Rows)
            {
                string tipoexistente = dr.Cells["Formas de pago"].Value.ToString().Trim().ToLower();

                if (tipoexistente == txt_cargoValue)
                {
                    registroDuplicadoEncontrado = true;

                    if (EstadoForm == "Guardar")
                    {
                        lbl_alerta.Visible = true;
                        btn_guardar_registro.Visible = false;
                        validar.UsuarioConNombreIgual(txt_formas_pago);
                        break;
                    }
                    if (EstadoForm == "Editar")
                    {
                        txt_formas_pago.Text = dr.Cells["Formas de pago"].Value.ToString();
                    }
                }
            }

            if (!registroDuplicadoEncontrado)
            {
                lbl_alerta.Visible = false;
                btn_guardar_registro.Visible = true;
            }
        }

        private void FormasPago_Load(object sender, EventArgs e)
        {
            CargarFormasPago();
            Mostrarbtn();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Mantenimiento.Mantenimiento_sistema), "Mantenimiento");

        }

        private void DGV_formasPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_formasPago.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                EstadoForm = "Editar";
                DataGridViewRow dr = DGV_formasPago.Rows[e.RowIndex];
                IdInst = dr.Cells["IdTipoPago"].Value.ToString();
                txt_formas_pago.Text = dr.Cells["Formas de pago"].Value.ToString();
                btn_guardar_registro.Text = "Guardar Cambios";
            }
        }

        private void txt_formas_pago_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBoxOpcional(txt_formas_pago);
            SaberSiYaExisteElRegistro();
        }

        private void Actualizar_Tick(object sender, EventArgs e)
        {
            if (lbl_alerta.Visible == true)
            {
                btn_guardar_registro.Visible = false;
            }
            else if (!string.IsNullOrWhiteSpace(txt_formas_pago.Text))
            {
                btn_guardar_registro.Visible = true;
            }
            else
            {
                btn_guardar_registro.Visible = false;
            }
        }
    }
}
