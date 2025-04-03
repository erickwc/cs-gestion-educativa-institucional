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
    public partial class EspecialidadesDocentes : Form
    {
        public EspecialidadesDocentes()
        {
            InitializeComponent();
        }

        CN_Empleado cn_empleado = new CN_Empleado();
        string IdEspecialidad;
        string datoBusqueda;
        string EstadoForm = "Guardar";
        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        ValidarCampos validar = new ValidarCampos();

        private void CargarEspecialidades()
        {
            CD_Empleados cd_empleado = new CD_Empleados();
            DGV_especialidades.DataSource = cd_empleado.MostrarEspecialidades();
            DGV_especialidades.Columns["IdEspecialidadDocentes"].Visible = false;
            DGV_especialidades.Columns["Especialidad"].SortMode = DataGridViewColumnSortMode.NotSortable;

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
                    cn_empleado.insertarEspecialidadDocentes(txt_especialidad.Text);
                    CargarEspecialidades();
                }
                else if (EstadoForm == "Editar")
                {
                    cn_empleado.modificarEspecialidadDocente(txt_especialidad.Text, Convert.ToInt32(IdEspecialidad));
                    CargarEspecialidades();
                    EstadoForm = "Guardar";
                    btn_guardar_registro.Text = "Agregar";
                }

                txt_especialidad.Text = String.Empty;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EspecialidadesDocentes_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
            Mostrarbtn();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Docentes.MantenimientoDocentes), "Mantenimiento Empleados");
        }

        private void DGV_cargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_especialidades.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    EstadoForm = "Editar";
                    DataGridViewRow dr = DGV_especialidades.Rows[e.RowIndex];
                    IdEspecialidad = dr.Cells["IdEspecialidadDocentes"].Value.ToString();
                    txt_especialidad.Text = dr.Cells["Especialidad"].Value.ToString();
                    btn_guardar_registro.Text = "Guardar Cambios";
                }
            }
        }

        private void SaberSiYaExisteElRegistro()
        {

            foreach (DataGridViewRow dr in DGV_especialidades.Rows)
            {
                string NacionalidadExistente = dr.Cells["Especialidad"].Value.ToString().ToLower();

                if (NacionalidadExistente == txt_especialidad.Text.ToLower())
                {
                    if (EstadoForm == "Guardar")
                    {
                        lbl_alerta.Visible = true;
                        btn_guardar_registro.Visible = false;
                        validar.UsuarioConNombreIgual(txt_especialidad);
                    }
                    else if (EstadoForm == "Editar")
                    {
                        txt_especialidad.Text = dr.Cells["Especialidad"].Value.ToString();
                    }
                }
                
                else
                {
                    lbl_alerta.Visible = false;
                    btn_guardar_registro.Visible = true;
                }

            }
        }

        private void txt_especialidad_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBoxOpcional(txt_especialidad);
            SaberSiYaExisteElRegistro();
        }

        private void txt_especialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            datoBusqueda = txt_buscar.Text;
            CD_Empleados empleados = new CD_Empleados();
            DGV_especialidades.DataSource = empleados.BuscarEspecialidades(datoBusqueda);
        }

        private void btn_Tick_1(object sender, EventArgs e)
        {
            if (lbl_alerta.Visible == true)
            {
                btn_guardar_registro.Visible = false;
            }
            else if (!string.IsNullOrWhiteSpace(txt_especialidad.Text))
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
