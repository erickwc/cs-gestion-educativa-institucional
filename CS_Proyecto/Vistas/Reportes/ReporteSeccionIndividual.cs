using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Seccion;
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
    public partial class ReporteSeccionIndividual : Form
    {
        public ReporteSeccionIndividual()
        {
            InitializeComponent();
        }

        string IdSecciones = null;
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        
        string PaginaHTML_Texto;
        private void mostrarSeccionesActuales()
        {
            //Instancia para llenar la tabla
            CN_secciones cN_Secciones = new CN_secciones(); ;
            dgv_secciones.DataSource = cN_Secciones.mostrarSeccionesActuales();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dgv_secciones.Columns["IdSecciones"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_secciones.Columns["Codigo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_secciones.Columns["Especialides"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_secciones.Columns["Docente"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_secciones.Columns["Tipo Seccion"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonPDF(dgv_secciones);
           
            //poner invisible una columna
            dgv_secciones.Columns["IdSecciones"].Visible = false;
            dgv_secciones.Columns["Codigo"].Width = 150;
            dgv_secciones.Columns["Especialides"].Width = 300;
            dgv_secciones.Columns["Docente"].Width = 250;
            dgv_secciones.Columns["Tipo Seccion"].Width = 150;
           // dgv_secciones.Columns["ImagenColumna"].Width = 500;

        }


        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Reporte_secciones), "Reportes Secciónes");
        }

        private void ReporteSeccionIndividual_Load(object sender, EventArgs e)
        {
            mostrarSeccionesActuales();
        }

        private void dgv_secciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_secciones.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgv_secciones.Rows[e.RowIndex];
                    IdSecciones = dr.Cells["IdSecciones"].Value.ToString();
                    Atributos_Reportes.IdSecciones = Convert.ToInt32(IdSecciones);

                    CD_reportes reporte = new CD_reportes();

                    reporte.MostrarDatosSeccionIndividual(Atributos_Reportes.IdSecciones);

                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format("{0}.pdf", "Reporte de la seccion " + Atributos_Reportes.CodigoSeccionInvidivual + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf");

                    PaginaHTML_Texto = Properties.Resources.PlantillaSeccionIndividual.ToString();
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", "FICHA DE LA SECCION");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", "Datos completo de la sección seleccionada.");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@codigo", Atributos_Reportes.CodigoSeccionInvidivual);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@guia", Atributos_Reportes.GuiaInvidivual);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@especialidad", Atributos_Reportes.EspecialidadInvidivual);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@tipo", Atributos_Reportes.TipoSeccionInvidivual);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@total", Convert.ToString(Atributos_Reportes.TotalAlumnos));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@masc", Convert.ToString(Atributos_Reportes.TotalMasc));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@fem", Convert.ToString(Atributos_Reportes.TotalFem));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@3dos", Convert.ToString(Atributos_Reportes.TresDosis));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@2dos", Convert.ToString(Atributos_Reportes.DosDosis));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@1dos", Convert.ToString(Atributos_Reportes.UnDosis));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@repo", Convert.ToString(Atributos_Reportes.Reposicion));

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

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CN_secciones cN_Secciones2 = new CN_secciones();
            dgv_secciones.DataSource = cN_Secciones2.BuscadorSeccion(txt_buscar.Text);
        }

        private void cmbx_tipo_busqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_buscar.Enabled = true;
            txt_buscar.Text = String.Empty;
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbx_tipo_busqueda.Text == "Codigo")
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; // Ignorar otros caracteres
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; // Ignorar otros caracteres
                }
            }
        }
    }
}
