using CS_Proyecto.CapaDatos;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.PagosTiposMatricula
{
    public partial class PagosTiposMatricula : Form
    {
        public PagosTiposMatricula()
        {
            InitializeComponent();
        }

        CD_Alumnos alumnos = new CD_Alumnos();
        string Id;
        string datobusqueda;
        string EstadoForm = "Guardar";
        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        ValidarCampos validar = new ValidarCampos();

        private void CargarTiposPagosMatricula()
        {
            CD_Alumnos alumnos = new CD_Alumnos();
            DGV_matriculas.DataSource = alumnos.MostrarTipoPagoMatriculas(); 
            DGV_matriculas.Columns["IdTipoPagoMatricula"].Visible = false;
            DGV_matriculas.Columns["Tipo de matrícula"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DGV_matriculas.Columns["Precio"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void Mostrarbtn()
        {
            añadirBtn.AñadirBotonEditarEnDataGrid(DGV_matriculas);
            DGV_matriculas.Columns["ImagenColumna"].DisplayIndex = 3;
            DGV_matriculas.Columns["ImagenColumna"].Width = 110;
        }

        private void btn_guardar_registro_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstadoForm == "Guardar")
                {
                    alumnos.InsertarTipoPagoMatriculas(txt_matricula.Text, Convert.ToDouble(txt_precio.Text));
                    CargarTiposPagosMatricula();
                }
                else if (EstadoForm == "Editar")
                {
                    alumnos.ModificarTipoPagoMatriculas(txt_matricula.Text, Convert.ToDouble(txt_precio.Text), Convert.ToInt32(Id));
                    CargarTiposPagosMatricula();
                    EstadoForm = "Guardar";
                    btn_guardar_registro.Text = "Agregar";
                }

                txt_matricula.Text = String.Empty;
                txt_precio.Text = String.Empty;

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
            string txt_cargoValue = txt_matricula.Text.Trim().ToLower();

            foreach (DataGridViewRow dr in DGV_matriculas.Rows)
            {
                string tipoexistente = dr.Cells["Tipo de matrícula"].Value.ToString().Trim().ToLower();

                if (tipoexistente == txt_cargoValue)
                {
                    registroDuplicadoEncontrado = true;

                    if (EstadoForm == "Guardar")
                    {
                        lbl_alerta.Visible = true;
                        btn_guardar_registro.Visible = false;
                        validar.UsuarioConNombreIgual(txt_matricula);
                        break;
                    }
                    if (EstadoForm == "Editar")
                    {
                        txt_matricula.Text = dr.Cells["Tipo de matrícula"].Value.ToString();
                    }
                }
            }

            if (!registroDuplicadoEncontrado)
            {
                lbl_alerta.Visible = false;
                btn_guardar_registro.Visible = true;
            }
        }

        private void PagosTiposMatricula_Load(object sender, EventArgs e)
        {
            CargarTiposPagosMatricula();
            Mostrarbtn();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Mantenimiento.Mantenimiento_sistema), "Mantenimiento");
        }

        private void DGV_matriculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_matriculas.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                EstadoForm = "Editar";
                DataGridViewRow dr = DGV_matriculas.Rows[e.RowIndex];
                Id = dr.Cells["IdTipoPagoMatricula"].Value.ToString();
                txt_matricula.Text = dr.Cells["Tipo de matrícula"].Value.ToString();

                // Eliminar el signo "$" y convertir a decimal
                string precioConSigno = dr.Cells["Precio"].Value.ToString();
                string precioSinSigno = precioConSigno.Replace("$", "");
                txt_precio.Text = precioSinSigno;
                btn_guardar_registro.Text = "Guardar Cambios";
            }
        }

        private void txt_matricula_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBoxOpcional(txt_matricula);
            SaberSiYaExisteElRegistro();
        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBoxOpcional(txt_precio);
            if (txt_precio.Text.Length > 5)
            {
                txt_precio.Text = String.Empty;
            }
        }

        private void Actualizar_Tick(object sender, EventArgs e)
        {
            if (lbl_alerta.Visible == true)
            {
                btn_guardar_registro.Visible = false;
            }
            else if (!string.IsNullOrWhiteSpace(txt_matricula.Text) || !string.IsNullOrWhiteSpace(txt_precio.Text))
            {
                btn_guardar_registro.Visible = true;
            }
            else
            {
                btn_guardar_registro.Visible = false;
            }
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o la tecla de retroceso (backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es un número ni una tecla de retroceso, verificar si es un punto
                if (e.KeyChar == '.')
                {
                    // Verificar si ya hay un punto en el texto
                    if (((Guna2TextBox)sender).Text.Contains("."))
                    {
                        // Si ya hay un punto, ignorar la tecla presionada
                        e.Handled = true;
                    }
                    else if (((Guna2TextBox)sender).Text.Length == 0)
                    {
                        // Si el texto está vacío, ignorar la tecla presionada
                        e.Handled = true;
                    }
                    else if (!((Guna2TextBox)sender).Text.Contains("."))
                    {
                        // Si no hay un punto y el texto no está vacío, permitir la tecla presionada
                        e.Handled = false;
                    }
                }
                else
                {
                    // Si la tecla no es un número ni un punto, ignorarla
                    e.Handled = true;
                }
            }
            else if (txt_precio.Text.Length >= 4 && !txt_precio.Text.Contains("."))
            {
                // Si ya hay 4 dígitos y no hay un punto, permitir eliminar números (tecla de retroceso)
                if (e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
        }
    }
}
