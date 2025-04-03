using CS_Proyecto.Atributos;
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

namespace CS_Proyecto.Vistas.Docentes
{
    public partial class Agregar_Docente_cargos : Form
    {
        public Agregar_Docente_cargos()
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
            CD_Empleados empleado = new CD_Empleados();
            dvg_cargos.DataSource = empleado.MostrarCargosParaCompletarRegistro();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dvg_cargos.Columns["IdTipoDocente"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_cargos.Columns["Cargos"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Poner Invisible una columna
            dvg_cargos.Columns["IdTipoDocente"].Visible = false;

        }

        private void AñadirBtnAgregarMateriaDocente()
        {
            añadir.BtnAñadirMateriaHaciaDocente(dvg_cargos);
        }

        private void mostrarMateriasAgregadas()
        {
            CD_Empleados empleado = new CD_Empleados();
            dvg_cargos_docente.DataSource = empleado.MostrarCargosAgregadosDocentes(Atributos_Empleado.IdDocente);

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dvg_cargos_docente.Columns["IdDocenteCargos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_cargos_docente.Columns["Cargo"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Poner Invisible una columna
            dvg_cargos_docente.Columns["IdDocenteCargos"].Visible = false;
            dvg_cargos_docente.Columns["IdDocentes"].Visible = false;

        }

        private void AñadirBtnQuitarAgregarMateriaDocente()
        {
            añadir.BtnQuitarMateriaDocente(dvg_cargos_docente);
        }

        private void btn_finalizar_continuar_Click(object sender, EventArgs e)
        {
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (Mensajes_Funcionales.EmpleadoGuardado mensaje = new Mensajes_Funcionales.EmpleadoGuardado())
            {
                fondo.Oscurecer(mensaje);
            }
        }

        private void dvg_cargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_cargos.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                bool materiaDuplicada = false; // Variable para rastrear si la materia ya está agregada

                DataGridViewRow dr = dvg_cargos.Rows[e.RowIndex];
                IdMateria = dr.Cells["IdTipoDocente"].Value.ToString();
                MateriaNueva = dr.Cells["Cargos"].Value.ToString();

                foreach (DataGridViewRow dr1 in dvg_cargos_docente.Rows)
                {
                    MateriaAgregada = dr1.Cells["Cargo"].Value.ToString();

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
                    empleado.AgregarCargosDocentes(Convert.ToInt32(IdMateria), Atributos_Empleado.IdDocente);

                    mostrarMateriasAgregadas();

                    DataGridViewImageCell cell = dvg_cargos.Rows[e.RowIndex].Cells["ImagenColumna"] as DataGridViewImageCell;

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

        private void dvg_cargos_docente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_cargos_docente.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow dr = dvg_cargos_docente.Rows[e.RowIndex];
                IdDocenteMaterias = dr.Cells["IdDocenteCargos"].Value.ToString();
                MateriaNueva = dr.Cells["Cargo"].Value.ToString();

                bool materiaDuplicada = false;
                int rowIndexInDgvMaterias = -1; // Variable para almacenar el índice de la fila en dvg_materias

                foreach (DataGridViewRow dr1 in dvg_cargos.Rows)
                {
                    MateriaAgregada = dr1.Cells["Cargos"].Value.ToString();

                    if (MateriaNueva == MateriaAgregada)
                    {
                        materiaDuplicada = true;
                        rowIndexInDgvMaterias = dr1.Index; // Recordar el índice de la fila en dvg_materias
                        break;
                    }
                }

                if (materiaDuplicada)
                {
                    CD_Empleados empleado = new CD_Empleados();
                    empleado.QuitarCargosDocentes(Convert.ToInt32(IdDocenteMaterias));
                    mostrarMateriasAgregadas();

                    // Cambia la imagen del botón en la fila correspondiente de dvg_materias
                    if (rowIndexInDgvMaterias >= 0)
                    {
                        DataGridViewImageCell cell = dvg_cargos.Rows[rowIndexInDgvMaterias].Cells["ImagenColumna"] as DataGridViewImageCell;

                        if (cell != null)
                        {
                            cell.Value = Properties.Resources.btn_agregar_materia_docente;
                        }
                    }
                }
            }
        }

        private void Agregar_Docente_cargos_Load(object sender, EventArgs e)
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

        private void Agregar_Docente_cargos_Shown(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dvg_cargos.Rows)
            {
                string MateriaNueva = dr.Cells["Cargos"].Value.ToString();

                foreach (DataGridViewRow dr1 in dvg_cargos_docente.Rows)
                {
                    string MateriaAgregada = dr1.Cells["Cargo"].Value.ToString();

                    if (MateriaNueva == MateriaAgregada)
                    {
                        // Cambia la imagen del botón en la fila correspondiente de dgv_materias_agregadas
                        DataGridViewImageCell cell = dvg_cargos.Rows[dr.Index].Cells["ImagenColumna"] as DataGridViewImageCell;

                        if (cell != null)
                        {
                            cell.Value = Properties.Resources.btn_completado;
                        }
                    }
                }
            }

            dvg_cargos.Refresh();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CD_Empleados empleados = new CD_Empleados();
            dvg_cargos.DataSource = empleados.BuscarCargos(txt_buscar.Text);

            foreach (DataGridViewRow dr in dvg_cargos.Rows)
            {
                string MateriaNueva = dr.Cells["Cargo"].Value.ToString();

                foreach (DataGridViewRow dr1 in dvg_cargos_docente.Rows)
                {
                    string MateriaAgregada = dr1.Cells["Cargo"].Value.ToString();

                    if (MateriaNueva == MateriaAgregada)
                    {
                        // Cambia la imagen del botón en la fila correspondiente de dgv_materias_agregadas
                        DataGridViewImageCell cell = dvg_cargos.Rows[dr.Index].Cells["ImagenColumna"] as DataGridViewImageCell;

                        if (cell != null)
                        {
                            cell.Value = Properties.Resources.btn_completado;
                        }
                    }
                }
            }

            dvg_cargos.Refresh();
        }
    }
}
