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

namespace CS_Proyecto.Vistas.Instituciones
{
    public partial class Instituciones_Main : Form
    {
        public Instituciones_Main()
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

        private void CargarInstituciones()
        {
            CD_Alumnos alumnos = new CD_Alumnos();
            DGV_instituciones.DataSource = alumnos.MostrarInstitucionesMantenimiento();
            DGV_instituciones.Columns["IdInst"].Visible = false;
            DGV_instituciones.Columns["Instituciones"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void Mostrarbtn()
        {
            añadirBtn.AñadirBotonEditarEnDataGrid(DGV_instituciones);
            DGV_instituciones.Columns["ImagenColumna"].DisplayIndex = 2;
            DGV_instituciones.Columns["ImagenColumna"].Width = 150;
        }

        private void btn_guardar_registro_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstadoForm == "Guardar")
                {
                    alumnos.InsertarInstituciones(txt_institucion.Text);
                    CargarInstituciones();
                }
                else if (EstadoForm == "Editar")
                {
                    alumnos.ModificarInstituciones(txt_institucion.Text, Convert.ToInt32(IdInst));
                    CargarInstituciones();
                    EstadoForm = "Guardar";
                    btn_guardar_registro.Text = "Agregar";
                }

                txt_institucion.Text = String.Empty;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaberSiYaExisteElRegistro()
        {
            bool registroDuplicadoEncontrado = false;

            string txt_cargoValue = txt_institucion.Text.Trim().ToLower();

            foreach (DataGridViewRow dr in DGV_instituciones.Rows)
            {
                string tipoexistente = dr.Cells["Instituciones"].Value.ToString().Trim().ToLower();

                if (tipoexistente == txt_cargoValue)
                {
                    registroDuplicadoEncontrado = true;

                    if (EstadoForm == "Guardar")
                    {
                        lbl_alerta.Visible = true;
                        btn_guardar_registro.Visible = false;
                        validar.UsuarioConNombreIgual(txt_institucion);
                        break;
                    }
                    if (EstadoForm == "Editar")
                    {
                        txt_institucion.Text = dr.Cells["Instituciones"].Value.ToString();
                    }
                }
            }

            if (!registroDuplicadoEncontrado)
            {
                lbl_alerta.Visible = false;
                btn_guardar_registro.Visible = true;
            }
        }

        private void Instituciones_Main_Load(object sender, EventArgs e)
        {
            CargarInstituciones();
            Mostrarbtn();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Mantenimiento.Mantenimiento_sistema), "Mantenimiento");
        }

        private void DGV_instituciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_instituciones.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                    EstadoForm = "Editar";
                    DataGridViewRow dr = DGV_instituciones.Rows[e.RowIndex];
                    IdInst = dr.Cells["IdInst"].Value.ToString();
                    txt_institucion.Text = dr.Cells["Instituciones"].Value.ToString();
                    btn_guardar_registro.Text = "Guardar Cambios";
            }
        }

       
        private void txt_institucion_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBoxOpcional(txt_institucion);
            SaberSiYaExisteElRegistro();
        }

        private void Actualizar_Tick(object sender, EventArgs e)
        {
            if (lbl_alerta.Visible == true)
            {
                btn_guardar_registro.Visible = false;
            }
            else if (!string.IsNullOrWhiteSpace(txt_institucion.Text))
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
            datobusqueda = txt_buscar.Text;
            CD_Alumnos alumnos = new CD_Alumnos();
            DGV_instituciones.DataSource = alumnos.BuscarInstituciones(datobusqueda);
        }
    }
}
