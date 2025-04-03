using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
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

namespace CS_Proyecto.Vistas.Reportes
{
    public partial class PaginaReportesSecciones : Form
    {
        public PaginaReportesSecciones()
        {
            InitializeComponent();
        }

        string PaginaHTML_Texto;
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        public void MostrarTipos()
        {
            CD_reportes reportes = new CD_reportes();
            cmbx_categoria.DataSource = reportes.TipoSecciones();
            cmbx_categoria.DisplayMember = "TipoSecciones";
            cmbx_categoria.ValueMember = "IdTipoSeccion";
            cmbx_categoria.SelectedIndex = -1;
        }

        public void MostrarEspecialidades()
        {
            CD_reportes reportes = new CD_reportes();
            cmbx_categoria.DataSource = reportes.TipoEspecialidades();
            cmbx_categoria.DisplayMember = "Nombre";
            cmbx_categoria.ValueMember = "IdEspecialidades";
            cmbx_categoria.SelectedIndex = -1;
        }


        private void informacionReporte(string labelTitulo, string labelDescripcion)
        {
            lbl_titulo_reporte.Text = labelTitulo;
            lbl_descripcion_reporte.Text = labelDescripcion;
        }

        private void IdentificarTipoReporte()
        {
            if (Atributos_Reportes.TipoReporte == "EstadisticaGeneral")
            {
                informacionReporte("Estadistica General", "Listado de todas las secciones registradas.");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.EstadisticaGeneral();
            }
            else if (Atributos_Reportes.TipoReporte == "SujetaATipo")
            {
                cmbx_categoria.Visible = true;
                informacionReporte("Secciones sujetas a un tipo", "Listado de las secciones sujetas a un tipo en especifico");
                MostrarTipos();
            }
            else if (Atributos_Reportes.TipoReporte == "SujetaAEspecialidad")
            {
                cmbx_categoria.Visible = true;
                informacionReporte("Secciones sujetas a una especialidad", "Listado de secciones con la epecialidad en especifico");
                MostrarEspecialidades();
            }
            if (Atributos_Reportes.TipoReporte == "Especialidades")
            {
                informacionReporte("Especialidades secciones", "Listado de todas las especialidades registradas.");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.TipoEspecialidades();
                dgv_reportes.Columns["IdEspecialidades"].Visible = false;
            }
            if (Atributos_Reportes.TipoReporte == "Tipos")
            {
                informacionReporte("Tipos de Secciones", "Listado de todos los tipos de sección registrados.");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.TipoSecciones();
                dgv_reportes.Columns["IdTipoSeccion"].Visible = false;
            }
        }

        private void PaginaReportesSecciones_Load(object sender, EventArgs e)
        {
            IdentificarTipoReporte();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", lbl_titulo_reporte.Text + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf");

            if (Atributos_Reportes.TipoReporte == "EstadisticaGeneral" || Atributos_Reportes.TipoReporte == "SujetaATipo" || Atributos_Reportes.TipoReporte == "SujetaAEspecialidad")
            {

                PaginaHTML_Texto = Properties.Resources.PlantillaEstadisticaGeneral.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text.ToUpper());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                if (Atributos_Reportes.TipoReporte == "SujetaATipo")
                {
                    savefile.FileName = string.Format("{0}.pdf", "Secciones sujetas al tipo " + cmbx_categoria.Text + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", "Secciones sujetas al tipo " + cmbx_categoria.Text);
                }
                else if (Atributos_Reportes.TipoReporte == "SujetaAEspecialidad")
                {
                    savefile.FileName = string.Format("{0}.pdf", "Secciones sujetas a la especialidad " + cmbx_categoria.Text + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", "Secciones sujetas a la especialidad " + cmbx_categoria.Text);
                }
                else if (Atributos_Reportes.TipoReporte == "EstadisticaGeneral")
                {
                    savefile.FileName = string.Format("{0}.pdf", "ESTADISTICA GENERAL" + cmbx_categoria.Text + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", "Estadistica general de las secciones registradas " + cmbx_categoria.Text);
                }


                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Sección"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Guia"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Total"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Masc."].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Fem."].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["3 Dos."].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["2 Dos."].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["1 Dos."].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Repo."].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }

            if (Atributos_Reportes.TipoReporte == "Especialidades")
            {
                PaginaHTML_Texto = Properties.Resources.PlantillaCategoriasExistentes.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text.ToUpper());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CATEGORIA", "Especialidades de secciones");
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Nombre"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }

            if (Atributos_Reportes.TipoReporte == "Tipos")
            {
                PaginaHTML_Texto = Properties.Resources.PlantillaCategoriasExistentes.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text.ToUpper());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CATEGORIA", "Tipos de secciones");
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["TipoSecciones"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }


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

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.Reporte_secciones), "Reportes Secciónes");
        }

        private void cmbx_categoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Atributos_Reportes.TipoReporte == "SujetaATipo")
            {
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.EstadisticaGeneralSujetoATipo(cmbx_categoria.Text);
                dgv_reportes.Columns["IdSecciones"].Visible = false;

            }
            if (Atributos_Reportes.TipoReporte == "SujetaAEspecialidad")
            {
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.EstadisticaGeneralSujetoAEspecialidad(cmbx_categoria.Text);
                dgv_reportes.Columns["IdSecciones"].Visible = false;
            }
        }
    }
}
