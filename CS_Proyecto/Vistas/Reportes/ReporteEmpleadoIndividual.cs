using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using iTextSharp.text.pdf;
using iTextSharp.text;
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
using CS_Proyecto.CapaDatos;

namespace CS_Proyecto.Vistas.Reportes
{
    public partial class ReporteEmpleadoIndividual : Form
    {
        public ReporteEmpleadoIndividual()
        {
            InitializeComponent();
        }

        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        private string IdDocente = string.Empty;
        


        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        string PaginaHTML_Texto;

        private void PoblarComboBox()
        {
            cbx_datos_busqueda.Items.Add("Nombre Completo");
            cbx_datos_busqueda.Items.Add("DUI");
            cbx_datos_busqueda.SelectedIndex = -1;

            txt_busqueda.Enabled = false;
        }

        public void MostrarDatos()
        {
            CN_Empleado cn_empleado = new CN_Empleado();
            dvg_editar_docentes.DataSource = cn_empleado.EstadisticaEditarDocente();

            añadirBtn.AñadirBotonPDF(dvg_editar_docentes);

            foreach (DataGridViewColumn column in dvg_editar_docentes.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.MinimumWidth = 3;
            }

            dvg_editar_docentes.Columns["IdDocentes"].Visible = false;
            dvg_editar_docentes.Columns["Cargo"].Width = 150;
            dvg_editar_docentes.Columns["Nombre Completo"].Width = 220;
            dvg_editar_docentes.Columns["Nivel de Estudio"].Width = 200;
            //dvg_editar_docentes.Columns["Especialidad"].Width = 160;
            dvg_editar_docentes.Columns["DUI"].Width = 100;
            dvg_editar_docentes.Columns["Tel. Emergencia"].Width = 110;
            dvg_editar_docentes.Columns["Telefono"].Width = 110;
            dvg_editar_docentes.Columns["ImagenColumna"].Width = 190;

            dvg_editar_docentes.Columns["ImagenColumna"].DisplayIndex = 7;
        }

        private void dvg_editar_docentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_editar_docentes.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dvg_editar_docentes.Rows[e.RowIndex];
                    IdDocente = dr.Cells["IdDocentes"].Value.ToString();
                    Atributos_Reportes.IdDocente = Convert.ToInt32(IdDocente);

                    CD_reportes reporte = new CD_reportes();
                    CD_Empleados medicamentos = new CD_Empleados();
                    CD_Empleados afecciones = new CD_Empleados();
                    CD_Empleados materias = new CD_Empleados();
                    CD_Empleados cargos = new CD_Empleados();
                    CD_Empleados especialidades = new CD_Empleados();

                    reporte.MostrarDatosEmpleadoIndividual(Atributos_Reportes.IdDocente);
                    dgv_afecciones.DataSource = afecciones.mostrarAfeccionesDocente(Atributos_Reportes.IdDocente);
                    dvg_medicamentos.DataSource = medicamentos.BuscarMedicamentosDocentes(Atributos_Reportes.IdDocente);
                    dgv_materias.DataSource = materias.MostrarMateriasAgregadasDocentes(Atributos_Reportes.IdDocente);
                    dgv_cargo_empleado.DataSource = cargos.MostrarCargosAgregadosDocentes(Atributos_Reportes.IdDocente);
                    dvg_especialidades.DataSource = especialidades.MostrarEspecialidadesAgregadosDocentes(Atributos_Reportes.IdDocente);


                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format("{0}.pdf", "Reporte del empleado " + Atributos_Reportes.NombreCompletoDUI + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf");

                    PaginaHTML_Texto = Properties.Resources.PlantillaEmpleadoIndividual.ToString();
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", "FICHA DEL EMPLEADO");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", "Datos completo del empleado seleccionado");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@ID", Convert.ToString(Atributos_Reportes.IdDocente));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@nombre", Atributos_Reportes.NombreCompletoDUI);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@nombre", Atributos_Reportes.NombreCompletoDUI);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@conyuge", Atributos_Reportes.Conyuge);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@jubilado", Atributos_Reportes.Jubilado);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@nivel", Atributos_Reportes.NivelDeEstudio);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@dui", Atributos_Reportes.DUI);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@nit", Atributos_Reportes.NIT);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@nip", Atributos_Reportes.NIP);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@isss", Atributos_Reportes.NumeroDeISSS);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@afp", Atributos_Reportes.AFP);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@nup", Atributos_Reportes.NUP);
                    //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@cargo", Atributos_Reportes.Cargo);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@especialidad", Atributos_Reportes.Especialidad);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@direccion", Atributos_Reportes.DireccionEmpleado);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@telcasa", Atributos_Reportes.TelefonoCasa);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@teloficina", Atributos_Reportes.TelefonoDeOficina);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@telmovilprincipal", Atributos_Reportes.TelefonoMovilPrincipal);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@telmovils", Atributos_Reportes.TelefonoMovilSecundario);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@telemers", Atributos_Reportes.TelefonoEmergencia);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@telemersec", Atributos_Reportes.TelefonoDeEmergenciaSecundario);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@estado", Atributos_Reportes.Estado);


                    //DETALLES MEDICOS
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@alergias", Atributos_Reportes.Alergias);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@fisica", Atributos_Reportes.ActividadFisica);

                    //AFECCIONES
                    string filasAfecciones = string.Empty;
                    foreach (DataGridViewRow row in dgv_afecciones.Rows)
                    {
                        filasAfecciones += "<tr>";
                        filasAfecciones += "<td>" + row.Cells["Afeccion"].Value.ToString() + "</td>";
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

                    string FilaMateria = string.Empty;
                    foreach (DataGridViewRow row in dgv_materias.Rows)
                    {
                        FilaMateria += "<tr>";
                        FilaMateria += "<td>" + row.Cells["Materias"].Value.ToString() + "</td>";
                        FilaMateria += "</tr>";
                    }
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MATERIAS", FilaMateria);


                    string FilaCargos = string.Empty;
                    foreach (DataGridViewRow row in dgv_cargo_empleado.Rows)
                    {
                        FilaCargos += "<tr>";
                        FilaCargos += "<td>" + row.Cells["Cargo"].Value.ToString() + "</td>";
                        FilaCargos += "</tr>";
                    }
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CARGOS", FilaCargos);


                    string FilaEspecialidades = string.Empty;
                    foreach (DataGridViewRow row in dvg_especialidades.Rows)
                    {
                        FilaEspecialidades += "<tr>";
                        FilaEspecialidades += "<td>" + row.Cells["Especialidades"].Value.ToString() + "</td>";
                        FilaEspecialidades += "</tr>";
                    }
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@ESPECIALIDADES", FilaEspecialidades);



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

        private void ReporteEmpleadoIndividual_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            PoblarComboBox();
            
        }

        private void cbx_datos_busqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_busqueda.Enabled = true;
            txt_busqueda.Text = String.Empty;
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            CN_Empleado cn_empleado = new CN_Empleado();

            if (cbx_datos_busqueda.Text == "Nombre Completo")
            {
                dvg_editar_docentes.DataSource = cn_empleado.buscarEmpleadoPorNombre(txt_busqueda.Text);
            }
            else
            {
                dvg_editar_docentes.DataSource = cn_empleado.buscarEmpleadoPorDUI(txt_busqueda.Text);
            }
        }

        private void txt_busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbx_datos_busqueda.Text == "DUI")
            {
                if (char.IsDigit(e.KeyChar) && txt_busqueda.TextLength < 9)
                {
                    if (txt_busqueda.TextLength == 7)
                    {
                        txt_busqueda.Text += "-";
                        txt_busqueda.SelectionStart = txt_busqueda.TextLength;
                    }
                }
                else if (e.KeyChar == '\b')
                {
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (cbx_datos_busqueda.Text == "Nombre Completo")
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
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.Reporte_docentes), "Reportes Empleados");
        }
    }
}
