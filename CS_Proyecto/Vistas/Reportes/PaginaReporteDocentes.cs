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
    public partial class PaginaReporteDocentes : Form
    {
        public PaginaReporteDocentes()
        {
            InitializeComponent();
        }


        string PaginaHTML_Texto;
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        public void MostrarCargos()
        {
            CD_reportes reportes = new CD_reportes();
            cmbx_categoria.DataSource = reportes.MostrarCargos();
            cmbx_categoria.DisplayMember = "Cargos";
            cmbx_categoria.ValueMember = "IdTipoDocente";
        }

        public void MostrarNiveles()
        {
            CD_reportes reportes = new CD_reportes();
            cmbx_categoria.DataSource = reportes.MostrarNivelesEstudio();
            cmbx_categoria.DisplayMember = "Niveles de estudio";
            cmbx_categoria.ValueMember = "IdNivelEstudioDocente";
           
        }

        public void MostrarEspecialidades()
        {
            CD_reportes reportes = new CD_reportes();
            cmbx_categoria.DataSource = reportes.MostrarEspecialidades();
            cmbx_categoria.DisplayMember = "Especialidad";
            cmbx_categoria.ValueMember = "IdEspecialidadDocentes";
        }

        private void informacionReporte(string labelTitulo, string labelDescripcion)
        {
            lbl_titulo_reporte.Text = labelTitulo;
            lbl_descripcion_reporte.Text = labelDescripcion;
        }

        private void IdentificarTipoReporte()
        {
            if (Atributos_Reportes.TipoReporte == "EmpleadosRegistradosActivosInactivos")
            {
                informacionReporte("Empleados Registrados", "Listado de empleados activos / inactivos");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.EmpleadosRegistradosActivosInactivos();
                cmbx_categoria.Visible = false;
            }
            if (Atributos_Reportes.TipoReporte == "EmpleadosActivos")
            {
                informacionReporte("Empleados Activos", "Listado de empleados activos");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.EmpleadosActivos();
                cmbx_categoria.Visible = false;
            }
            if (Atributos_Reportes.TipoReporte == "EmpleadosInactivos")
            {
                informacionReporte("Empleados Inactivos", "Listado de empleados inactivos");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.EmpleadosInactivos();
                cmbx_categoria.Visible = false;
            }
            if (Atributos_Reportes.TipoReporte == "EmpleadoSujetoCargo")
            {
                informacionReporte("Empleados sujetos a un cargo", "Listado de empleados sujetos al cargo en especifico");
                MostrarCargos();
                cmbx_categoria.SelectedIndex = -1;
                btn_guardar.Visible = false;
                cmbx_categoria.Visible = true;
            }
            if (Atributos_Reportes.TipoReporte == "EmpleadoSujetoEspecialidad")
            {
                informacionReporte("Empleados sujetos a una especialidad", "Listado de empleados con la especialidad de en especifico");
                MostrarEspecialidades();
                cmbx_categoria.SelectedIndex = -1;
                btn_guardar.Visible = false;
                cmbx_categoria.Visible = true;
            }
            if (Atributos_Reportes.TipoReporte == "EmpleadoSujetoNivel")
            {
                informacionReporte("Empleados sujetos a un nivel de estudio", "Listado de empleados con el nivel de estudio en especifico");
                MostrarNiveles();
                cmbx_categoria.SelectedIndex = -1;
                btn_guardar.Visible = false;
                cmbx_categoria.Visible = true;
            }
            if (Atributos_Reportes.TipoReporte == "Cargos")
            {
                informacionReporte("Cargos registrados actuales", "Listado de los cargos registrados");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.MostrarCargos();
                dgv_reportes.Columns["IdTipoDocente"].Visible = false;
            }
            if (Atributos_Reportes.TipoReporte == "Especialidades")
            {
                informacionReporte("Especialidades registradas actuales", "Listado de las especialidades registradas");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.MostrarEspecialidades();
                dgv_reportes.Columns["IdEspecialidadDocentes"].Visible = false;
            }
            if (Atributos_Reportes.TipoReporte == "Niveles")
            {
                informacionReporte("Niveles de estudio registrados actuales", "Listado de los niveles de estudio registrados");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.MostrarNivelesEstudio();
                dgv_reportes.Columns["IdNivelEstudioDocente"].Visible = false;
            }
        }



        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", lbl_titulo_reporte.Text + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf");

            if (Atributos_Reportes.TipoReporte == "EmpleadosRegistradosActivosInactivos")
            {

                PaginaHTML_Texto = Properties.Resources.PlantillaParaEmpleadosActivosInactivos.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["DUI"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombre Completo"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nivel De Estudio"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Especialidad"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Cargo"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Telefono"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }

            if (Atributos_Reportes.TipoReporte == "EmpleadosActivos")
            {
                PaginaHTML_Texto = Properties.Resources.PlantillaParaEmpleadosActivosInactivos.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["DUI"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombre Completo"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nivel De Estudio"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Especialidad"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Cargo"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Telefono"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }

            if (Atributos_Reportes.TipoReporte == "EmpleadosInactivos")
            {
                PaginaHTML_Texto = Properties.Resources.PlantillaParaEmpleadosActivosInactivos.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["DUI"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombre Completo"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nivel De Estudio"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Especialidad"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Cargo"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Telefono"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }

            if (Atributos_Reportes.TipoReporte == "EmpleadoSujetoCargo")
            {
                savefile.FileName = string.Format("{0}.pdf", "EMPLEADOS CON CARGO " + cmbx_categoria.Text.ToUpper() + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf");

                PaginaHTML_Texto = Properties.Resources.PlantillaEmpleadoSujetoACategorias.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", "EMPLEADOS CON CARGO " + cmbx_categoria.Text.ToUpper());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CATEGORIA", "Cargo");
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["DUI"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombre Completo"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Cargo"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Telefono"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }
            if (Atributos_Reportes.TipoReporte == "EmpleadoSujetoEspecialidad")
            {
                savefile.FileName = string.Format("{0}.pdf", "EMPLEADOS CON LA ESPECIALIDAD " + cmbx_categoria.Text.ToUpper() + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf");

                PaginaHTML_Texto = Properties.Resources.PlantillaEmpleadoSujetoACategorias.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", "EMPLEADOS CON LA ESPECIALIDAD " + cmbx_categoria.Text.ToUpper());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CATEGORIA", "Especialidad");
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["DUI"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombre Completo"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Especialidad"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Telefono"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }
            if (Atributos_Reportes.TipoReporte == "EmpleadoSujetoNivel")
            {
                savefile.FileName = string.Format("{0}.pdf", "EMPLEADOS CON NIVEL DE ESTUDIO " + cmbx_categoria.Text.ToUpper() + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf");

                PaginaHTML_Texto = Properties.Resources.PlantillaEmpleadoSujetoACategorias.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", "EMPLEADOS CON NIVEL DE ESTUDIO " + cmbx_categoria.Text.ToUpper());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CATEGORIA", "Nivel de estudio");
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["DUI"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombre Completo"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nivel De estudio"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Telefono"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }
            if (Atributos_Reportes.TipoReporte == "Cargos")
            {
                PaginaHTML_Texto = Properties.Resources.PlantillaCategoriasExistentes.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CATEGORIA", "Cargos");
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Cargos"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }
            if (Atributos_Reportes.TipoReporte == "Especialidades")
            {
                PaginaHTML_Texto = Properties.Resources.PlantillaCategoriasExistentes.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CATEGORIA", "Especialidades");
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Especialidad"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }
            if (Atributos_Reportes.TipoReporte == "Niveles")
            {
                PaginaHTML_Texto = Properties.Resources.PlantillaCategoriasExistentes.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CATEGORIA", "Niveles de estudio");
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Niveles de estudio"].Value.ToString() + "</td>";
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

        private void PaginaReporteDocentes_Load(object sender, EventArgs e)
        {
            IdentificarTipoReporte();
        }

        private void cmbx_categoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string categoria = cmbx_categoria.Text;
            btn_guardar.Visible = true;
            if (Atributos_Reportes.TipoReporte == "EmpleadoSujetoCargo")
            {
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.MostrarEmpleadosSujetoACargo(categoria);

            }
            if (Atributos_Reportes.TipoReporte == "EmpleadoSujetoEspecialidad")
            {
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.MostrarEmpleadosSujetoAEspecialidad(categoria);

            }
            if (Atributos_Reportes.TipoReporte == "EmpleadoSujetoNivel")
            {
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.MostrarEmpleadosSujetoNivelesEstudio(categoria);

            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.Reporte_docentes), "Reportes Docentes");
        }
    }
}
