using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Editar_Matricula;
using CS_Proyecto.Vistas.Formulario_Matricula;
using CS_Proyecto.Vistas.Mi_Perfil;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS_Proyecto.Vistas.Dashboard
{
    public partial class Dashboard_controles : Form
    {
        public Dashboard_controles()
        {
            InitializeComponent();
        }

        ClasesVista.NavegarEntreFormularios navegar = new ClasesVista.NavegarEntreFormularios();
        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        private string IdDocente = string.Empty;
        CN_Empleado cn_empleado = new CN_Empleado();
        private void Dashboard_controles_Load(object sender, EventArgs e)
        {
            SaludoUsuario();
            EstadisticaGeneral();
            UltimoEmpleadoRegistrado();
            CantidadDeAlumnosActivosRegistrados();
            CargarGrafica();
            CantidadDeAlumnosMasculinosActivosRegistrados();
            CantidadDeAlumnasFemeninasActivosRegistrados();

            if (Atributos_Login.IdRol==2)
            {
                DatosInactivos.Visible = false;
                infoMedica.Visible = false;
                Secciones.Visible = false;
                Empleados.Visible = false;
                tbl_ultimos_docentes.Enabled = false;
            }
        }

        private void SaludoUsuario()
        {
            string[] nombres = Atributos_Login.Nombres.Split(' ');
            string[] apellidos = Atributos_Login.Apellidos.Split(' ');

            string saludoGenero = (Atributos_Login.Genero == "Femenino") ? "Bienvenida " : "Bienvenido ";

            if (nombres.Length > 0)
            {
                string primerNombre = nombres[0];
                string primerApellido = apellidos[0];

                lbl_saludo.Text = saludoGenero + primerNombre + " " + primerApellido;
            }

            lbl_rol.Text = Atributos_Login.Rol;
        }


        private void tabla_docentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbl_ultimos_docentes.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = tbl_ultimos_docentes.Rows[e.RowIndex];
                    IdDocente = dr.Cells["IdDocentes"].Value.ToString();
                    Atributos_Empleado.IdDocente = Convert.ToInt32(IdDocente);
                    cn_empleado.MostrarRegistroCompletoDocente(Atributos_Empleado.IdDocente);
                    navegar.AbrirFormEnPanel(typeof(Vistas.Docentes.Modificar.ModificarDocenteMain), "Editar Empleados");
                    Atributos_Empleado.EstadoFormulario = "EditarDocente";
                }
            }
        }

        private void EstadisticaGeneral()
        {
            //Instancia para llenar la tabla
            CN_Dashboard cn_Dashboard = new CN_Dashboard(); ;
            tbl_estadistica_general.DataSource = cn_Dashboard.EstadisticaGeneral();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            tbl_estadistica_general.Columns["Sección"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_estadistica_general.Columns["Guia"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_estadistica_general.Columns["Total"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_estadistica_general.Columns["Masc."].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_estadistica_general.Columns["Fem."].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_estadistica_general.Columns["3 Dos."].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_estadistica_general.Columns["2 Dos."].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_estadistica_general.Columns["1 Dos."].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_estadistica_general.Columns["Repo."].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Establecer Tamaño de celdas
            tbl_estadistica_general.Columns["Guia"].Width = 180;
            tbl_estadistica_general.Columns["IdSecciones"].Visible = false;

        }

        private void UltimoEmpleadoRegistrado()
        {
            //Instancia para llenar la tabla
            CN_Dashboard cn_Dashboard = new CN_Dashboard();
            tbl_ultimos_docentes.DataSource = cn_Dashboard.UltimoEmpleadoRegistrado();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            tbl_ultimos_docentes.Columns["Docente"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_ultimos_docentes.Columns["Cargo"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Añadir Boton a la tabla
            añadirBtn.AñadirBotonEditarEnDataGrid(tbl_ultimos_docentes);

            //Establecer el orden de visualización del boton editar
            tbl_ultimos_docentes.Columns["ImagenColumna"].DisplayIndex = 3;

            //Establecer Tamaño de celdas
            tbl_ultimos_docentes.Columns["Cargo"].Width = 50;

            //Poner Invisible una columna
            tbl_ultimos_docentes.Columns["IdDocentes"].Visible = false;
        }

        private void CargarGrafica()
        {
            CD_Dashboard cd_Dashboard = new CD_Dashboard();
            cd_Dashboard.EstadisticaGeneros(GenerosGrafica);
        }
        private void CantidadDeAlumnosActivosRegistrados()
        {
            CD_Dashboard cd_Dashboard = new CD_Dashboard();
            cd_Dashboard.TotalDeAlumnosActivos();
            lblCantidadAlumnos.Text = Convert.ToString(Atributos_Dashboard.CantidadTotalDeAlumnosActivos);
        }

        private void CantidadDeAlumnosMasculinosActivosRegistrados()
        {
            CD_Dashboard cd_Dashboard = new CD_Dashboard();
            cd_Dashboard.TotalDeAlumnosMasculinos();
            lbl_cantidad_alumnos.Text = "Masculino - " + Convert.ToString(Atributos_Dashboard.CantidadTotalDeAlumnosMasculinos);
        }

        private void CantidadDeAlumnasFemeninasActivosRegistrados()
        {
            CD_Dashboard cd_Dashboard = new CD_Dashboard();
            cd_Dashboard.TotalDeAlumnasFemeninas();
            lbl_alumnas_cantidad.Text = "Femenino - " + Convert.ToString(Atributos_Dashboard.CantidadTotalDeAlumnosFemeninos);
        }

        private void btn_nueva_matricula_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Formulario_Matricula.Matricula_main), "Nueva Matricula");
            Atributos_Alumno.EstadoFormulario = "GuardarAlumno";
        }

        private void btn_editar_matricula_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Editar_Matricula.Editar_matricula), "Editar Matricula");
            Atributos_Alumno.EstadoFormulario = "EditarAlumno";
        }


        private void btn_secciones_actuales_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Seccion.Seccion_Main), "Secciones Actuales");
        }

        private void btn_docentes_registrados_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Docentes.Dashboard_Docente), "Empleados");
        }

        private void btn_datos_inactivos_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Datos_Inactivos.Controles_datos_inactivos), "Datos Inactivos");
        }

        private void btn_informacion_medica_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Informacion_Medica.Controles_info_medica_main), "Información Medica");
        }

        private void tbl_estadistica_general_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.tbl_estadistica_general.Columns[e.ColumnIndex].Name == "Total")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {

                        if (Convert.ToInt32(e.Value) > 45)
                        {
                            e.CellStyle.ForeColor = Color.FromArgb(230, 57, 70);
                            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                        }
                    }
                }
            }
        }

        private void RefrescarDatos_Tick(object sender, EventArgs e)
        {
            CN_Dashboard cn_Dashboard = new CN_Dashboard();
            CN_Dashboard cn_Estadistica = new CN_Dashboard();
            tbl_ultimos_docentes.DataSource = cn_Dashboard.UltimoEmpleadoRegistrado();
            tbl_estadistica_general.DataSource = cn_Estadistica.EstadisticaGeneral();
            CantidadDeAlumnosActivosRegistrados();
            CantidadDeAlumnasFemeninasActivosRegistrados();
            CantidadDeAlumnosMasculinosActivosRegistrados();
            CargarGrafica();
            SaludoUsuario();
            this.Invalidate();
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void tableLayoutPanel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btn_estadistica_completa_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Dashboard.EstadisticaCompleta), "Estadistica Completa");

        }
    }
}
