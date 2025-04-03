using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Docentes.Modificar;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Nacionalidades
{
    public partial class Nacionalidades : Form
    {
        public Nacionalidades()
        {
            InitializeComponent();
        }


        CD_Alumnos alumnos = new CD_Alumnos();
        string IdNac;
        string EstadoForm = "Guardar";
        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        ValidarCampos validar = new ValidarCampos();
        string datobusqueda;



        private void CargarNacionalidades()
        {
            CD_Alumnos alumnos = new CD_Alumnos();
            DGV_nacionalidades.DataSource = alumnos.MostrarNacionalidadesMantenimiento();
            DGV_nacionalidades.Columns["IdNacionalidad"].Visible = false;

            DGV_nacionalidades.Columns["Nacionalidades"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void Mostrarbtn()
        {
            añadirBtn.AñadirBotonEditarEnDataGrid(DGV_nacionalidades);
            DGV_nacionalidades.Columns["ImagenColumna"].DisplayIndex = 2;
            DGV_nacionalidades.Columns["ImagenColumna"].Width = 150;
        }

        private void btn_guardar_registro_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstadoForm == "Guardar")
                {
                    alumnos.InsertarNacionalidad(txt_nacionalidades.Text);
                    CargarNacionalidades();
                }
                else if (EstadoForm == "Editar")
                {
                    alumnos.ModificarNacionalidad(txt_nacionalidades.Text, Convert.ToInt32(IdNac));
                    CargarNacionalidades();
                    EstadoForm = "Guardar";
                    btn_guardar_registro.Text = "Agregar";
                }
                txt_nacionalidades.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Nacionalidades_Load(object sender, EventArgs e)
        {
            CargarNacionalidades();
            Mostrarbtn();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Mantenimiento.Mantenimiento_sistema), "Mantenimiento");
        }

        private void DGV_instituciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_nacionalidades.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    EstadoForm = "Editar";
                    DataGridViewRow dr = DGV_nacionalidades.Rows[e.RowIndex];
                    IdNac = dr.Cells["IdNacionalidad"].Value.ToString();
                    txt_nacionalidades.Text = dr.Cells["Nacionalidades"].Value.ToString();
                    btn_guardar_registro.Text = "Guardar Cambios";
                }
            }
        }

        private void SaberSiYaExisteElRegistro()
        {
            bool registroDuplicadoEncontrado = false;

            string txt_cargoValue = txt_nacionalidades.Text.Trim().ToLower();

            foreach (DataGridViewRow dr in DGV_nacionalidades.Rows)
            {
                string tipoexistente = dr.Cells["Nacionalidades"].Value.ToString().Trim().ToLower();

                if (tipoexistente == txt_cargoValue)
                {
                    registroDuplicadoEncontrado = true;

                    if (EstadoForm == "Guardar")
                    {
                        lbl_alerta.Visible = true;
                        btn_guardar_registro.Visible = false;
                        validar.UsuarioConNombreIgual(txt_nacionalidades);
                        break;
                    }
                    if (EstadoForm == "Editar")
                    {
                        txt_nacionalidades.Text = dr.Cells["Nacionalidades"].Value.ToString();
                    }
                }
            }

            if (!registroDuplicadoEncontrado)
            {
                lbl_alerta.Visible = false;
                btn_guardar_registro.Visible = true;
            }
        }

        private void txt_nacionalidades_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBoxOpcional(txt_nacionalidades);
            SaberSiYaExisteElRegistro();
        }

        private void btn_Tick(object sender, EventArgs e)
        {
            if (lbl_alerta.Visible == true)
            {
                btn_guardar_registro.Visible = false;
            }
            else if (!string.IsNullOrWhiteSpace(txt_nacionalidades.Text))
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
            DGV_nacionalidades.DataSource = alumnos.BuscarNacionalidades(datobusqueda);
        }
    }
}
