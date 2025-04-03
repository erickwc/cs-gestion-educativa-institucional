using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CS_Proyecto.Vistas.Reportes
{
    public partial class ReporteIndividualAlumno : Form
    {
        public ReporteIndividualAlumno()
        {
            InitializeComponent();
        }

        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        private string IdAlumno = null;
       

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        private string datoBusqueda = string.Empty;
        string PaginaHTML_Texto;
        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            datoBusqueda = txt_buscar.Text;
            CN_Alumnos cN_Alumnos = new CN_Alumnos();
            dvg_editar_alumnos.DataSource = cN_Alumnos.consultaUltimoAlumnoRegistradoMatriculaParteDos(datoBusqueda);
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.Reporte_alumnos), "Reportes Alumnos");
        }

        private void cmbx_tipo_busqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_buscar.Enabled = true;
            txt_buscar.Text = String.Empty;
        }

        private void MostrarUltimoAlumnoRegistradoParteMatriculaDos()
        {
            //Instancia para llenar la tabla
            CN_Alumnos cn_alumnos = new CN_Alumnos();
            dvg_editar_alumnos.DataSource = cn_alumnos.MostrarUltimoAlumnoParteMatriculaDos();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dvg_editar_alumnos.Columns["NIE"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_editar_alumnos.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_editar_alumnos.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_editar_alumnos.Columns["Seccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_editar_alumnos.Columns["Especialidad"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_editar_alumnos.Columns["Resp. Principal"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_editar_alumnos.Columns["Tel Resp. Principal"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Añadir Boton
            añadirBtn.AñadirBotonPDF(dvg_editar_alumnos);

            //Establecer el orden de visualización del boton editar
            dvg_editar_alumnos.Columns["ImagenColumna"].DisplayIndex = 8;
            dvg_editar_alumnos.Columns["ImagenColumna"].Width = 200;


            //Establecer Tamaño de celdas
            dvg_editar_alumnos.Columns["NIE"].Width = 60;
            dvg_editar_alumnos.Columns["Seccion"].Width = 60;
            dvg_editar_alumnos.Columns["Apellidos"].Width = 120;
            dvg_editar_alumnos.Columns["Nombres"].Width = 120;
            dvg_editar_alumnos.Columns["Resp. Principal"].Width = 180;
            dvg_editar_alumnos.Columns["Tel Resp. Principal"].Width = 95;
            dvg_editar_alumnos.Columns["Especialidad"].Width = 220;

            //Poner Invisible una columna
            dvg_editar_alumnos.Columns["IdAlumno"].Visible = false;
        }

        private void ReporteIndividualAlumno_Load(object sender, EventArgs e)
        {
            MostrarUltimoAlumnoRegistradoParteMatriculaDos();
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbx_tipo_busqueda.Text == "Nombres Alumno" || cmbx_tipo_busqueda.Text == "Apellidos Alumno")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }
                else if (char.IsLetter(e.KeyChar) && e.KeyChar >= 128)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (char.IsDigit(e.KeyChar) && txt_buscar.TextLength < 7)
                {

                }

                else if (e.KeyChar == '\b')
                {
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void dvg_editar_alumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_editar_alumnos.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dvg_editar_alumnos.Rows[e.RowIndex];
                    IdAlumno = dr.Cells["IdAlumno"].Value.ToString();
                    Atributos_Reportes.IdAlumno = Convert.ToInt32(IdAlumno);

                    CD_reportes reportes = new CD_reportes();
                    CD_Alumnos reporteMedicamentos = new CD_Alumnos();
                    CD_Alumnos reporteAfecciones = new CD_Alumnos();

                    reportes.ConsultarRegistroCompletoDelAlumnoReporte(Atributos_Reportes.IdAlumno);
                    dgv_afecciones.DataSource = reporteAfecciones.ConsultarAfeccionesAlumnoPorId(Atributos_Reportes.IdAlumno);
                    dvg_medicamentos.DataSource = reporteMedicamentos.ConsultarMedicamentosAlumnoPorId(Atributos_Reportes.IdAlumno);

                    

                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format("{0}.pdf", "MATRICULA DE " + Atributos_Reportes.Nombres + " " + Atributos_Reportes.Apellidos + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf");

                    PaginaHTML_Texto = Properties.Resources.PlantillaMatriculaAlumno.ToString();
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", "FICHA DE MATRICULA");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", "Datos completo del alumno");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                    //DATOS PERSONALES

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Nombres", Atributos_Reportes.Nombres);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@apellidos", Atributos_Reportes.Apellidos);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@fechaNac", Atributos_Reportes.FechaNacimiento);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@LugarNac", Atributos_Reportes.LugarNacimiento);

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Genero", Atributos_Reportes.Genero);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@instProc", Atributos_Reportes.InstitucionProcedencia);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@PartidaNac", Atributos_Reportes.Partida);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Nacionalidad", Atributos_Reportes.Nacionalidad);

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@EducInicial", Atributos_Reportes.EducacionInicial);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SecInicial", Atributos_Reportes.SeccionInicial);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@AñoIngreso", Atributos_Reportes.AnioInicial);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Repitiendo", Atributos_Reportes.RepitiendoAnio);

                    //RESPONSABLE PRINCIPAL
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@RespPrin", Atributos_Reportes.ResponsablePrincipal);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Politica", Atributos_Reportes.PoliticamenteExpuesto);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@parentesco", Atributos_Reportes.ParentescoResponsablePrincipal);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@dui", Atributos_Reportes.DuiResponsablePrincipal);

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@genero", Atributos_Reportes.GeneroResponsablePrincipal);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@correo", Atributos_Reportes.EmailResponsablePrincipal);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@telPrin", Atributos_Reportes.TelMovilPrincipalResponsablePrincipal);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@telSec", Atributos_Reportes.TelMovilPrincipalResponsableSecundario);

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@LugarTrab", Atributos_Reportes.LugarTrabajoResponsablePrincipal);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TelTrabPrin", Atributos_Reportes.NumeroTrabajoPrincipal);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TelTrabSec", Atributos_Reportes.NumeroTrabajoSecundario);


                    //RESPONSABLE SECUNDARIO
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@RespSec", Atributos_Reportes.ResponsableSecundario);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Parentesco", Atributos_Reportes.ParentescoResponsableSecundario);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@LugarTrab", Atributos_Reportes.LugarTrabajoResponsableSecundario);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Dui", Atributos_Reportes.DuiResponsableSecundario);

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TelPrinRespSec", Atributos_Reportes.TelMovilPrincipalResponsableSecundario);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TelSecRespSec", Atributos_Reportes.TelMovilSecundarioResponsableSecundario);


                    //RESIDENCIA CONTACTO
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@direccion", Atributos_Reportes.Direccion);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@canton", Atributos_Reportes.Canton);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@caserio", Atributos_Reportes.Caserio);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@departamento", Atributos_Reportes.Departamento);

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@municipio", Atributos_Reportes.Municipio);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@residencia", Atributos_Reportes.ZonaResidencia);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@telFijo", Atributos_Reportes.TelFijoPrincipal);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@telFIjoSec", Atributos_Reportes.TelFijoSecundario);

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@telAlumno", Atributos_Reportes.TelMovilPrincipalAlumno);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@tlSec", Atributos_Reportes.TelMovilSecundarioAlumno);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CorreoAlumno", Atributos_Reportes.EmailAumno);


                    //SITUACION FAMILIAR
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@numero", Atributos_Reportes.NumeroMiembrosFamilia);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@dependenciaFam", Atributos_Reportes.DependenciaFamiliar);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@dependenciaEco", Atributos_Reportes.DependenciaEconomica);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@lugartrabajo", Atributos_Reportes.LugarTrabajo);

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CargoTrabajo", Atributos_Reportes.Cargo);


                    //DATOS COMPLEMENTARIOS
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@vacunacion", Atributos_Reportes.EsquemaVacunacion);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@proceso", Atributos_Reportes.ProcesoAcademico);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@internet", Atributos_Reportes.PoseeInternet);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@tipoconexion", Atributos_Reportes.TipoConexion);

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@estabilidad", Atributos_Reportes.Estabilidad);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@provInter", Atributos_Reportes.ProveedorPrincipal);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Recursos", Atributos_Reportes.RecursosTecnologicos);


                    //PAGO
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@tipoPago", Atributos_Reportes.TipoPagoMatricula);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@cantCancelada", Convert.ToString(Atributos_Reportes.CantidadCancelada));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@cantRestante", Convert.ToString(Atributos_Reportes.CantidadPendiente));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@formaPago", Atributos_Reportes.TipoPago);


                    //INSCRIPCION
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@seccion", Atributos_Reportes.Secciones);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@especialidad", Atributos_Reportes.Especialidades);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@estado", Atributos_Reportes.TipoEstado);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@numtalonario", Atributos_Reportes.NumeroDeTalonario);

                    //NIE
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NIE", Atributos_Reportes.NIE + Atributos_Reportes.NieTemporal);

                    //DETALLES MEDICOS
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@alergias", Atributos_Reportes.Alergias);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@fisica", Atributos_Reportes.ActividadFisica);

                    //AFECCIONES
                    string filasAfecciones = string.Empty;
                    foreach (DataGridViewRow row in dgv_afecciones.Rows)
                    {
                        filasAfecciones += "<tr>";
                        filasAfecciones += "<td>" + row.Cells["Afección"].Value.ToString() + "</td>";
                        filasAfecciones += "<td>" + row.Cells["Tipo"].Value.ToString() + "</td>";
                        filasAfecciones += "<td>" + row.Cells["Procedimiento"].Value.ToString() + "</td>";
                        filasAfecciones += "</tr>";
                    }
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILASAFECCIONES", filasAfecciones);

                    //MEDICAMENTOS
                    string filasMedicamentos = string.Empty;
                    foreach (DataGridViewRow row in dvg_medicamentos.Rows)
                    {
                        filasMedicamentos += "<tr>";
                        filasMedicamentos += "<td>" + row.Cells["Medicamento"].Value.ToString() + "</td>";
                        filasMedicamentos += "<td>" + row.Cells["Dosis"].Value.ToString() + "</td>";
                        filasMedicamentos += "<td>" + row.Cells["Frecuencia"].Value.ToString() + "</td>";
                        filasMedicamentos += "</tr>";
                    }
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILASMEDICAMENTOS", filasMedicamentos);

                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                        {
                            //Creamos un nuevo documento y lo definimos como PDF
                            Document pdfDoc = new Document(PageSize.A4, 30, 30, 30, 30);

                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(new Phrase(""));

                            using (StringReader sr = new StringReader(PaginaHTML_Texto))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                            }

                            pdfDoc.Close();
                            stream.Close();
                        }

                    }


                }
            }
        }
    }
}
