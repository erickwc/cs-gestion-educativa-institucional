using CS_Proyecto.Atributos;
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
    public partial class Nivel_estudio : Form
    {
        public Nivel_estudio()
        {
            InitializeComponent();
        }

        CN_Empleado cn_empleado = new CN_Empleado();
        string IdNivelDeEstudio;
        string datoBusqueda;
        string EstadoForm = "Guardar";
        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        ValidarCampos validar = new ValidarCampos();

        private void CargarNivelesDeEstudio()
        {
            CD_Empleados cD_Empleados = new CD_Empleados();
            dtg_niveles_estudio.DataSource = cD_Empleados.MostrarNivelDeEstudioDocente();
            dtg_niveles_estudio.Columns["Niveles"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dtg_niveles_estudio.Columns["IdNivelEstudioDocente"].Visible = false;
        }

        private void AgregarBotonesADataGrid()
        {
            añadirBtn.AñadirBotonEditarEnDataGrid(dtg_niveles_estudio);
            dtg_niveles_estudio.Columns["ImagenColumna"].DisplayIndex = 2;
            dtg_niveles_estudio.Columns["ImagenColumna"].Width = 100;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Docentes.MantenimientoDocentes), "Mantenimiento Empleados");
        }

        private void Nivel_estudio_Load(object sender, EventArgs e)
        {
            CargarNivelesDeEstudio();
            AgregarBotonesADataGrid();
        }

        private void dtg_niveles_estudio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtg_niveles_estudio.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                EstadoForm = "Editar";
                DataGridViewRow dr = dtg_niveles_estudio.Rows[e.RowIndex];
                IdNivelDeEstudio = dr.Cells["IdNivelEstudioDocente"].Value.ToString();
                txt_nivel.Text = dr.Cells["Niveles"].Value.ToString();
                btn_guardar_registro.Text = "Guardar Cambios";
            }
               
        }


        private void btn_guardar_registro_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstadoForm == "Guardar")
                {
                    cn_empleado.insertarNivelDeEstudio(txt_nivel.Text);
                    CargarNivelesDeEstudio();
                    txt_nivel.Text = String.Empty;
                }
                else if (EstadoForm == "Editar")
                {
                    cn_empleado.modificarNivelDeEstudioDocente(txt_nivel.Text, Convert.ToInt32(IdNivelDeEstudio));
                    CargarNivelesDeEstudio();
                    EstadoForm = "Guardar";
                    btn_guardar_registro.Text = "Agregar";
                    txt_nivel.Text = String.Empty;
                }

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
            string txt_cargoValue = txt_nivel.Text.Trim().ToLower();

            foreach (DataGridViewRow dr in dtg_niveles_estudio.Rows)
            {
                string tipoexistente = dr.Cells["Niveles"].Value.ToString().Trim().ToLower();

                if (tipoexistente == txt_cargoValue)
                {
                    registroDuplicadoEncontrado = true;

                    if (EstadoForm == "Guardar")
                    {
                        lbl_alerta.Visible = true;
                        btn_guardar_registro.Visible = false;
                        validar.UsuarioConNombreIgual(txt_nivel);
                        break;
                    }
                    if (EstadoForm == "Editar")
                    {
                        txt_nivel.Text = dr.Cells["Niveles"].Value.ToString();
                    }
                }
            }

            if (!registroDuplicadoEncontrado)
            {
                lbl_alerta.Visible = false;
                btn_guardar_registro.Visible = true;
            }
        }

        private void txt_nivel_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBoxOpcional(txt_nivel);
            SaberSiYaExisteElRegistro();
        }

        private void MostrarBtn_Tick(object sender, EventArgs e)
        {
            if (lbl_alerta.Visible == true)
            {
                btn_guardar_registro.Visible = false;
            }
            else if (!string.IsNullOrWhiteSpace(txt_nivel.Text))
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
            dtg_niveles_estudio.DataSource = empleados.BuscarNivelDeEstudio(datoBusqueda);
        }
    }
}
