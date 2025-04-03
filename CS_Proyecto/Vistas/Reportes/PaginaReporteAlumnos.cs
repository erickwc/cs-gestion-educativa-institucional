using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
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

namespace CS_Proyecto.Vistas.Reportes
{
    public partial class PaginaReporteAlumnos : Form
    {
        public PaginaReporteAlumnos()
        {
            InitializeComponent();
        }

        string PaginaHTML_Texto;
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        private void IdentificarTipoReporte()
        {
            if (Atributos_Reportes.TipoReporte == "AlumnosActivos")
            {
                informacionReporte("Alumnos Activos", "Listado de alumnos activos.");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.AlumnosActivos();
            }
            if (Atributos_Reportes.TipoReporte == "AlumnosInactivos")
            {
                informacionReporte("Alumnos Inactivos", "Listado de alumnos inactivos.");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.AlumnosInactivos();
            }
            if (Atributos_Reportes.TipoReporte == "LetraPago")
            {
                informacionReporte("Alumnos en letra pago", "Listado de alumnos en letra pago.");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.AlumnosConLetraPago();
            }
            if (Atributos_Reportes.TipoReporte == "NieTemporal")
            {
                informacionReporte("Alumnos con NIE temporal", "Listado de alumnos con nie temporal.");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.AlumnosConNieTemporal();
            }
            if (Atributos_Reportes.TipoReporte == "SujetoTipo")
            {
                informacionReporte("Alumnos sujetos a un tipo", "Listado de alumnos sujetos a un tipo");
                cmbx_categoria.Visible = true;
                MostrarTipos();
            }
            if (Atributos_Reportes.TipoReporte == "SujetosSeccion")
            {
                informacionReporte("Alumnos sujetos a una seccion", "Listado de alumnos sujetos a una seccion en especifico");
                cmbx_categoria.Visible = true;
                MostrarSecciones();
            }
            if (Atributos_Reportes.TipoReporte == "EstadisticaGeneral")
            {
                informacionReporte("ESTADISTICA GENERAL", "Estadistica general de los alumnos");
                CD_reportes matricula = new CD_reportes();
                CD_reportes activos = new CD_reportes();
                CD_reportes inactivos = new CD_reportes();

                dgv_activos.DataSource = matricula.AlumnosMatriculadosActivos();
                dgv_inactivos.DataSource = activos.AlumnosMatriculadosInactivos();
                dgv_matricula.DataSource = inactivos.AlumnosMatriculadosGeneral();

                dgv_activos.Visible = true;
                dgv_inactivos.Visible = true;
                dgv_matricula.Visible = true;
            }
        }

        public void MostrarTipos()
        {
            CD_reportes reportes = new CD_reportes();
            cmbx_categoria.DataSource = reportes.TipoSecciones();
            cmbx_categoria.DisplayMember = "TipoSecciones";
            cmbx_categoria.ValueMember = "IdTipoSeccion";
            cmbx_categoria.SelectedIndex = -1;
        }

        public void MostrarSecciones()
        {
            CD_secciones reportes = new CD_secciones();
            cmbx_categoria.DataSource = reportes.mostrarSeccionesActuales();
            cmbx_categoria.DisplayMember = "Codigo";
            cmbx_categoria.ValueMember = "IdSecciones";
            cmbx_categoria.SelectedIndex = -1;
        }


        private void informacionReporte(string labelTitulo, string labelDescripcion)
        {
            lbl_titulo_reporte.Text = labelTitulo;
            lbl_descripcion_reporte.Text = labelDescripcion;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", lbl_titulo_reporte.Text + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf");

            if (Atributos_Reportes.TipoReporte == "AlumnosActivos" || Atributos_Reportes.TipoReporte == "AlumnosInactivos" || Atributos_Reportes.TipoReporte == "SujetosSeccion")
            {

                PaginaHTML_Texto = Properties.Resources.AlumnosActivosInactivos.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["NIE"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Apellidos"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombres"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Seccion"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Resp. Principal"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Tel Resp. Principal"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }
            if (Atributos_Reportes.TipoReporte == "LetraPago")
            {
                PaginaHTML_Texto = Properties.Resources.AlumnosEnLetraPago.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Apellidos"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombres"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Responsable Principal"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Tel. Princ. Responsable"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Cancelado"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Pendiente"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }

            if ( Atributos_Reportes.TipoReporte == "NieTemporal" || Atributos_Reportes.TipoReporte == "SujetoTipo")
            {
                PaginaHTML_Texto = Properties.Resources.PlantillaAlumnosNieTemporal_LetraPago.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
              
                if (Atributos_Reportes.TipoReporte == "NieTemporal")
                {
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@COLUMNA", "NIE TEMP.");
                }
                else if (Atributos_Reportes.TipoReporte == "SujetoTipo")
                {
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@COLUMNA", "Tipo");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", "Alumnos sujetos al tipo " + cmbx_categoria.Text.ToUpper());
                }

                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Apellidos"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombres"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Responsable Principal"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Tel. Princ. Responsable"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }

            if (Atributos_Reportes.TipoReporte == "SujetosSeccion")
            {
                PaginaHTML_Texto = Properties.Resources.AlumnosSujetosSeccion.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text + " " + cmbx_categoria.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Seccion"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["NIE"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Apellidos"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombres"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Resp. Principal"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Tel Resp. Principal"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }

            if (Atributos_Reportes.TipoReporte == "EstadisticaGeneral")
            {
                // Load the HTML template
                PaginaHTML_Texto = Properties.Resources.PlantillaEstadisticaAlumnosActivosInactivos.ToString();
                // Replace placeholders with actual data
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                // Initialize variables for each table's data
                string filas = string.Empty;
                string filas2 = string.Empty;
                string filas3 = string.Empty;

                // Populate data for the first table
                foreach (DataGridViewRow row in dgv_matricula.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Total Matriculados"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Activos"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Inactivos"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                // Replace the placeholder for the first table with its respective data
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS1", filas);

                // Populate data for the second table
                foreach (DataGridViewRow row in dgv_activos.Rows)
                {
                    filas2 += "<tr>";
                    filas2 += "<td>" + row.Cells["Activos"].Value.ToString() + "</td>";
                    filas2 += "<td>" + row.Cells["Masculino"].Value.ToString() + "</td>";
                    filas2 += "<td>" + row.Cells["Femenino"].Value.ToString() + "</td>";
                    filas2 += "</tr>";
                }
                // Replace the placeholder for the second table with its respective data
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS2", filas2);

                // Populate data for the third table
                foreach (DataGridViewRow row in dgv_inactivos.Rows)
                {
                    filas3 += "<tr>";
                    filas3 += "<td>" + row.Cells["Inactivos"].Value.ToString() + "</td>";
                    filas3 += "<td>" + row.Cells["Masculino"].Value.ToString() + "</td>";
                    filas3 += "<td>" + row.Cells["Femenino"].Value.ToString() + "</td>";
                    filas3 += "</tr>";
                }
                // Replace the placeholder for the third table with its respective data
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS3", filas3);
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

        private void PaginaReporteAlumnos_Load(object sender, EventArgs e)
        {
            IdentificarTipoReporte();
        }

        private void cmbx_categoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Atributos_Reportes.TipoReporte == "SujetosSeccion")
            {
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.AlumnosSujetoASeccion(cmbx_categoria.Text);
            }
            else
            {
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.AlumnosSujetoATipo(cmbx_categoria.Text);
            }
            
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.Reporte_alumnos), "Reportes Alumnos");
        }

        private void dgv_reportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
