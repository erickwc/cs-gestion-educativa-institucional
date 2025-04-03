using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
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

namespace CS_Proyecto.Vistas.Secciones
{
    public partial class TipoSeccion : Form
    {
        public TipoSeccion()
        {
            InitializeComponent();
        }

        CD_secciones secciones = new CD_secciones();
        string Id;
        string EstadoForm = "Guardar";
        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        ValidarCampos validar = new ValidarCampos();
        string datobusqueda;


        private void CargarTipos()
        {
            CD_secciones secciones = new CD_secciones();
            DGV_tiposSecciones.DataSource = secciones.MostrarTipoSeccionFormularioSeccion();
            DGV_tiposSecciones.Columns["IdTipoSeccion"].Visible = false;

            DGV_tiposSecciones.Columns["Tipo de Secciones"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void Mostrarbtn()
        {
            añadirBtn.AñadirBotonEditarEnDataGrid(DGV_tiposSecciones);
            DGV_tiposSecciones.Columns["ImagenColumna"].DisplayIndex = 2;
            DGV_tiposSecciones.Columns["ImagenColumna"].Width = 110;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Seccion.Seccion_Main), "Secciónes");
        }

        private void btn_guardar_registro_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstadoForm == "Guardar")
                {
                    secciones.InsertarTipoSeccion(txt_tipo.Text);
                    CargarTipos();
                }
                else if (EstadoForm == "Editar")
                {
                    secciones.ModificarTipoSeccion(Convert.ToInt32(Id), txt_tipo.Text);
                    CargarTipos();
                    EstadoForm = "Guardar";
                    btn_guardar_registro.Text = "Agregar";
                }
                txt_tipo.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TipoSeccion_Load(object sender, EventArgs e)
        {
            CargarTipos();
            Mostrarbtn();
        }

        private void DGV_tiposSecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_tiposSecciones.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    EstadoForm = "Editar";
                    DataGridViewRow dr = DGV_tiposSecciones.Rows[e.RowIndex];
                    Id = dr.Cells["IdTipoSeccion"].Value.ToString();
                    txt_tipo.Text = dr.Cells["Tipo de Secciones"].Value.ToString();
                    btn_guardar_registro.Text = "Guardar Cambios";
                }
            }
        }

        private void SaberSiYaExisteElRegistro()
        {
            bool registroDuplicadoEncontrado = false;

            string txt_cargoValue = txt_tipo.Text.Trim().ToLower();

            foreach (DataGridViewRow dr in DGV_tiposSecciones.Rows)
            {
                string tipoexistente = dr.Cells["Tipo de Secciones"].Value.ToString().Trim().ToLower();

                if (tipoexistente == txt_cargoValue)
                {
                    registroDuplicadoEncontrado = true;

                    if (EstadoForm == "Guardar")
                    {
                        lbl_alerta.Visible = true;
                        btn_guardar_registro.Visible = false;
                        validar.UsuarioConNombreIgual(txt_tipo);
                        break;
                    }
                    if (EstadoForm == "Editar")
                    {
                        txt_tipo.Text = dr.Cells["Tipo de Secciones"].Value.ToString();
                    }
                }
            }

            if (!registroDuplicadoEncontrado)
            {
                lbl_alerta.Visible = false;
                btn_guardar_registro.Visible = true;
            }
        }

        private void txt_tipo_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBoxOpcional(txt_tipo);
            SaberSiYaExisteElRegistro();
        }

        private void btn_Tick(object sender, EventArgs e)
        {
            if (lbl_alerta.Visible == true)
            {
                btn_guardar_registro.Visible = false;
            }
            else if (!string.IsNullOrWhiteSpace(txt_tipo.Text))
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
            CD_secciones secciones = new CD_secciones();
            DGV_tiposSecciones.DataSource = secciones.BuscadorTipoSeccion(datobusqueda);
        }
    }
}
