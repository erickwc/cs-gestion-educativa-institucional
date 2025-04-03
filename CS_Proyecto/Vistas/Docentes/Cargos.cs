using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Docentes.Modificar;
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

namespace CS_Proyecto.Vistas.Docentes
{
    public partial class Cargos : Form
    {
        public Cargos()
        {
            InitializeComponent();
        }


        CN_Empleado cn_empleado = new CN_Empleado();
        string IdCargo;
        string Cargo;
        string datoBusqueda;
        string EstadoForm = "Guardar";
        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        ValidarCampos validar = new ValidarCampos();

        private void CargarCargos()
        {
            CD_Empleados cd_empleado = new CD_Empleados();
            DGV_cargos.DataSource = cd_empleado.MostrarCargosRegistrados();

            DGV_cargos.Columns["IdTipoDocente"].Visible = false;

        }

        private void Mostrarbtn()
        {
            añadirBtn.AñadirBotonEditarEnDataGrid(DGV_cargos);
            DGV_cargos.Columns["ImagenColumna"].DisplayIndex = 2;
            DGV_cargos.Columns["ImagenColumna"].Width = 120;
        }

        private void btn_guardar_registro_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstadoForm == "Guardar")
                {
                    cn_empleado.insertarTipoDocente(txt_cargo.Text);
                    CargarCargos();
                    EstadoForm = "Guardar";
                }
                else if (EstadoForm == "Editar")
                {
                    cn_empleado.modificarTipoDocente(txt_cargo.Text, Convert.ToInt32(IdCargo));
                    CargarCargos();
                    EstadoForm = "Guardar";
                    btn_guardar_registro.Text = "Agregar";
                }

                txt_cargo.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cargos_Load(object sender, EventArgs e)
        {
            CargarCargos();
            Mostrarbtn();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Docentes.MantenimientoDocentes), "Mantenimiento Empleados");
        }

        private void DGV_cargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_cargos.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    EstadoForm = "Editar";
                    DataGridViewRow dr = DGV_cargos.Rows[e.RowIndex];
                    IdCargo = dr.Cells["IdTipoDocente"].Value.ToString();
                    Cargo = dr.Cells["Cargos"].Value.ToString();
                    txt_cargo.Text = Cargo;
                    btn_guardar_registro.Text = "Guardar Cambios";
                }
            }
        }

        private void SaberSiYaExisteElRegistro()
        {
            bool registroDuplicadoEncontrado = false; // Indicador de registro duplicado

            // Eliminamos espacios en blanco al final del texto del TextBox
            string txt_cargoValue = txt_cargo.Text.Trim().ToLower();

            foreach (DataGridViewRow dr in DGV_cargos.Rows)
            {
                string tipoexistente = dr.Cells["Cargos"].Value.ToString().Trim().ToLower();

                if (tipoexistente == txt_cargoValue)
                {
                    registroDuplicadoEncontrado = true;

                    if (EstadoForm == "Guardar")
                    {
                        lbl_alerta.Visible = true;
                        btn_guardar_registro.Visible = false;
                        validar.UsuarioConNombreIgual(txt_cargo);
                        break;
                    }
                    if (EstadoForm == "Editar")
                    {
                        txt_cargo.Text = dr.Cells["Cargos"].Value.ToString();
                    }
                }
            }

            if (!registroDuplicadoEncontrado)
            {
                lbl_alerta.Visible = false;
                btn_guardar_registro.Visible = true;
            }
        }



        private void txt_cargo_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBoxOpcional(txt_cargo);
            SaberSiYaExisteElRegistro();
        }

        private void Actualizar_Tick(object sender, EventArgs e)
        {
            if (lbl_alerta.Visible == true)
            {
                btn_guardar_registro.Visible = false;
            }
            else if (!string.IsNullOrWhiteSpace(txt_cargo.Text))
            {
                btn_guardar_registro.Visible = true;
            }
            else
            {
                btn_guardar_registro.Visible = false;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            datoBusqueda = guna2TextBox1.Text;
            CD_Empleados empleados = new CD_Empleados();
            DGV_cargos.DataSource = empleados.BuscarCargos(datoBusqueda);
        }
    }
}
