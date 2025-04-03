using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Docentes.Modificar;
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

namespace CS_Proyecto.Vistas.Docentes
{
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
        }

        CN_Empleado cn_empleado = new CN_Empleado();
        string IdMateria;
        string datoBusqueda;
        string EstadoForm = "Guardar";
        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        ValidarCampos validar = new ValidarCampos();

        private void CargarMaterias()
        {
            CD_Empleados cd_empleado = new CD_Empleados();
            DGV_especialidades.DataSource = cd_empleado.MostrarMateriasMantenimiento();
            DGV_especialidades.Columns["IdMaterias"].Visible = false;
            DGV_especialidades.Columns["Materias"].SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        private void Mostrarbtn()
        {
            añadirBtn.AñadirBotonEditarEnDataGrid(DGV_especialidades);
            DGV_especialidades.Columns["ImagenColumna"].DisplayIndex = 2;
            DGV_especialidades.Columns["ImagenColumna"].Width = 110;
        }


        private void btn_guardar_registro_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstadoForm == "Guardar")
                {
                    cn_empleado.insertarMateria(txt_materia.Text);
                    CargarMaterias();
                }
                else if (EstadoForm == "Editar")
                {
                    cn_empleado.modificarMateria(txt_materia.Text, Convert.ToInt32(IdMateria));
                    CargarMaterias();
                    EstadoForm = "Guardar";
                    btn_guardar_registro.Text = "Agregar";
                }

                txt_materia.Text = String.Empty;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            CargarMaterias();
            Mostrarbtn();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Docentes.MantenimientoDocentes), "Mantenimiento Empleados");
        }

        private void DGV_especialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_especialidades.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    EstadoForm = "Editar";
                    DataGridViewRow dr = DGV_especialidades.Rows[e.RowIndex];
                    IdMateria = dr.Cells["IdMaterias"].Value.ToString();
                    txt_materia.Text = dr.Cells["Materias"].Value.ToString();
                    btn_guardar_registro.Text = "Guardar Cambios";
                }
            }
        }

        private void txt_materia_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBoxOpcional(txt_materia);
            SaberSiYaExisteElRegistro();
        }

        private void SaberSiYaExisteElRegistro()
        {
            bool registroDuplicadoEncontrado = false; // Indicador de registro duplicado

            // Eliminamos espacios en blanco al final del texto del TextBox
            string txt_cargoValue = txt_materia.Text.Trim().ToLower();

            foreach (DataGridViewRow dr in DGV_especialidades.Rows)
            {
                string tipoexistente = dr.Cells["Materias"].Value.ToString().Trim().ToLower();

                if (tipoexistente == txt_cargoValue)
                {
                    registroDuplicadoEncontrado = true;

                    if (EstadoForm == "Guardar")
                    {
                        lbl_alerta.Visible = true;
                        btn_guardar_registro.Visible = false;
                        validar.UsuarioConNombreIgual(txt_materia);
                        break;
                    }
                    if (EstadoForm == "Editar")
                    {
                        txt_materia.Text = dr.Cells["Materias"].Value.ToString();
                    }
                }
            }

            if (!registroDuplicadoEncontrado)
            {
                lbl_alerta.Visible = false;
                btn_guardar_registro.Visible = true;
            }
        }


        private void actualizar_Tick(object sender, EventArgs e)
        {
            if (lbl_alerta.Visible == true)
            {
                btn_guardar_registro.Visible = false;
            }
            else if (!string.IsNullOrWhiteSpace(txt_materia.Text))
            {
                btn_guardar_registro.Visible = true;
            }
            else
            {
                btn_guardar_registro.Visible = false;
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            datoBusqueda = txt_buscar.Text;
            CD_Empleados empleados = new CD_Empleados();
            DGV_especialidades.DataSource = empleados.BuscarMaterias(datoBusqueda);
        }
    }
}
