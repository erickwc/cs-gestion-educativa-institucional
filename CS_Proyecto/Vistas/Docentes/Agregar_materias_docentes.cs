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
using static System.Net.Mime.MediaTypeNames;

namespace CS_Proyecto.Vistas.Docentes
{
    public partial class Agregar_materias_docentes : Form
    {
        public Agregar_materias_docentes()
        {
            InitializeComponent();
        }

      
        AñadirBotonParaTablas añadir = new AñadirBotonParaTablas();
        private string IdMateria = null;
        private string MateriaNueva = null;
        private string MateriaAgregada = null;
        private string IdDocenteMaterias = null;


        private void mostrarMateriasRegistro()
        {
            CN_Empleado empleado = new CN_Empleado();
            dvg_materias.DataSource = empleado.MostrarMateriasParaCompletarRegistro();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dvg_materias.Columns["IdMaterias"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_materias.Columns["Materias"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Poner Invisible una columna
            dvg_materias.Columns["IdMaterias"].Visible = false;

        }

        private void AñadirBtnAgregarMateriaDocente()
        {
            añadir.BtnAñadirMateriaHaciaDocente(dvg_materias);
        }

        private void mostrarMateriasAgregadas()
        {
            CD_Empleados empleado = new CD_Empleados();
            dgv_materias_agregadas.DataSource = empleado.MostrarMateriasAgregadasDocentes(Atributos_Empleado.IdDocente);

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dgv_materias_agregadas.Columns["IdDocenteMaterias"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_materias_agregadas.Columns["Materias"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Poner Invisible una columna
            dgv_materias_agregadas.Columns["IdDocenteMaterias"].Visible = false;
            dgv_materias_agregadas.Columns["IdDocentes"].Visible = false;

        }

        private void AñadirBtnQuitarAgregarMateriaDocente()
        {
            añadir.BtnQuitarMateriaDocente(dgv_materias_agregadas);
        }

        private void dvg_materias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_materias.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                bool materiaDuplicada = false; // Variable para rastrear si la materia ya está agregada

                DataGridViewRow dr = dvg_materias.Rows[e.RowIndex];
                IdMateria = dr.Cells["IdMaterias"].Value.ToString();
                MateriaNueva = dr.Cells["Materias"].Value.ToString();

                foreach (DataGridViewRow dr1 in dgv_materias_agregadas.Rows)
                {
                    MateriaAgregada = dr1.Cells["Materias"].Value.ToString();

                    if (MateriaNueva == MateriaAgregada)
                    {
                        materiaDuplicada = true;
                        break;
                    }
                }

                if (materiaDuplicada)
                {
                    ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                    using (MateriaAgregada materiaAgregada = new MateriaAgregada())
                    {
                        fondo.Oscurecer(materiaAgregada);
                    }
                }
                else
                {
                    CD_Empleados empleado = new CD_Empleados();
                    empleado.AgregarMateriasDocentes(Convert.ToInt32(IdMateria), Atributos_Empleado.IdDocente);
                    
                    mostrarMateriasAgregadas();

                    DataGridViewImageCell cell = dvg_materias.Rows[e.RowIndex].Cells["ImagenColumna"] as DataGridViewImageCell;

                    if (cell != null)
                    {
                        if (cell.Value == null || cell.Value == Properties.Resources.btn_agregar_materia_docente)
                        {
                            cell.Value = Properties.Resources.btn_completado;
                        }
                        else
                        {
                            cell.Value = Properties.Resources.btn_completado;
                        }
                    }
                }
            }
        }

        private void dgv_materias_agregadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_materias_agregadas.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow dr = dgv_materias_agregadas.Rows[e.RowIndex];
                IdDocenteMaterias = dr.Cells["IdDocenteMaterias"].Value.ToString();
                MateriaNueva = dr.Cells["Materias"].Value.ToString();

                bool materiaDuplicada = false;
                int rowIndexInDgvMaterias = -1; // Variable para almacenar el índice de la fila en dvg_materias

                foreach (DataGridViewRow dr1 in dvg_materias.Rows)
                {
                    MateriaAgregada = dr1.Cells["Materias"].Value.ToString();

                    if (MateriaNueva == MateriaAgregada)
                    {
                        materiaDuplicada = true;
                        rowIndexInDgvMaterias = dr1.Index; // Recordar el índice de la fila en dvg_materias
                        break;
                    }
                }

                if (materiaDuplicada)
                {
                    CN_Empleado empleado = new CN_Empleado();
                    empleado.EliminarMateriasDocentes(Convert.ToInt32(IdDocenteMaterias));
                    mostrarMateriasAgregadas();

                    // Cambia la imagen del botón en la fila correspondiente de dvg_materias
                    if (rowIndexInDgvMaterias >= 0)
                    {
                        DataGridViewImageCell cell = dvg_materias.Rows[rowIndexInDgvMaterias].Cells["ImagenColumna"] as DataGridViewImageCell;

                        if (cell != null)
                        {
                            cell.Value = Properties.Resources.btn_agregar_materia_docente;
                        }
                    }
                }
            }
        }

        private void Agregar_materias_docentes_Load(object sender, EventArgs e)
        {
            mostrarMateriasRegistro();
            AñadirBtnAgregarMateriaDocente();
            mostrarMateriasAgregadas();
            AñadirBtnQuitarAgregarMateriaDocente();

            if (Atributos_Empleado.EstadoFormulario == "EditarDocente")
            {
                this.BackColor = Color.White;
            }
        }

        private void Agregar_materias_docentes_Shown(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dvg_materias.Rows)
            {
                string MateriaNueva = dr.Cells["Materias"].Value.ToString();

                foreach (DataGridViewRow dr1 in dgv_materias_agregadas.Rows)
                {
                    string MateriaAgregada = dr1.Cells["Materias"].Value.ToString();

                    if (MateriaNueva == MateriaAgregada)
                    {
                        // Cambia la imagen del botón en la fila correspondiente de dgv_materias_agregadas
                        DataGridViewImageCell cell = dvg_materias.Rows[dr.Index].Cells["ImagenColumna"] as DataGridViewImageCell;

                        if (cell != null)
                        {
                            cell.Value = Properties.Resources.btn_completado;
                        }
                    }
                }
            }

            dvg_materias.Refresh();
        }

        private void btn_finalizar_continuar_Click(object sender, EventArgs e)
        {


        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CD_Empleados empleados = new CD_Empleados();
            dvg_materias.DataSource = empleados.BuscarMaterias(txt_buscar.Text);

            foreach (DataGridViewRow dr in dvg_materias.Rows)
            {
                string MateriaNueva = dr.Cells["Materias"].Value.ToString();

                foreach (DataGridViewRow dr1 in dgv_materias_agregadas.Rows)
                {
                    string MateriaAgregada = dr1.Cells["Materias"].Value.ToString();

                    if (MateriaNueva == MateriaAgregada)
                    {
                        // Cambia la imagen del botón en la fila correspondiente de dgv_materias_agregadas
                        DataGridViewImageCell cell = dvg_materias.Rows[dr.Index].Cells["ImagenColumna"] as DataGridViewImageCell;

                        if (cell != null)
                        {
                            cell.Value = Properties.Resources.btn_completado;
                        }
                    }
                }
            }

            dvg_materias.Refresh();
        }
    }
}
