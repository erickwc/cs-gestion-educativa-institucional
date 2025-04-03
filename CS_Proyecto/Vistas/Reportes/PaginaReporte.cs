using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
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
    public partial class PaginaReporte : Form
    {
        public PaginaReporte()
        {
            InitializeComponent();
        }

        string PaginaHTML_Texto;
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        private void informacionReporte(string labelTitulo, string labelDescripcion)
        {
            lbl_titulo_reporte.Text = labelTitulo;
            lbl_descripcion_reporte.Text = labelDescripcion;
        }


        private void IdentificarTipoReporte()
        {
            if (Atributos_Reportes.TipoReporte == "UsuariosActivos")
            {
                informacionReporte("Usuarios Activos", "Listado de todos los usuarios activos del sistema");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.UsuariosActivos();
            }
            else if (Atributos_Reportes.TipoReporte == "UsuariosInactivos")
            {
                informacionReporte("Usuarios Inactivos", "Listado de todos los usuarios inactivos del sistema");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.UsuariosInactivos();
            }
            else if (Atributos_Reportes.TipoReporte == "UsuariosAdministradores")
            {
                informacionReporte("Usuarios Administradores", "Listado de todos los usuarios administradores del sistema");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.UsuariosRolAdministradores();
            }
            else if (Atributos_Reportes.TipoReporte == "UsuariosSecundarios")
            {
                informacionReporte("Usuarios Secundarios", "Listado de todos los usuarios del sistema");
                CD_reportes reportes = new CD_reportes();
                dgv_reportes.DataSource = reportes.UsuariosRolUsuarios();
            }
        }

        private void PaginaReporte_Load(object sender, EventArgs e)
        {
            IdentificarTipoReporte();
            lbl_fecha_reporte.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", lbl_titulo_reporte.Text + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf");

            if (Atributos_Reportes.TipoReporte == "UsuariosActivos")
            {

                PaginaHTML_Texto = Properties.Resources.PlantillaParaReporteUsuariosActivosInactivos.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));


                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["ID"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Usuario"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombres"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Apellidos"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Genero"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }

            if (Atributos_Reportes.TipoReporte == "UsuariosInactivos")
            {
                PaginaHTML_Texto = Properties.Resources.PlantillaParaReporteUsuariosActivosInactivos.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["ID"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Usuario"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombres"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Apellidos"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Genero"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }

            if (Atributos_Reportes.TipoReporte == "UsuariosAdministradores")
            {
                PaginaHTML_Texto = Properties.Resources.PlantillaParaUsuariosyAdministradores.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["ID"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Usuario"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombres"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Apellidos"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Genero"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Privilegio"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            }

            if (Atributos_Reportes.TipoReporte == "UsuariosSecundarios")
            {
                PaginaHTML_Texto = Properties.Resources.PlantillaParaUsuariosyAdministradores.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", lbl_titulo_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", lbl_descripcion_reporte.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                string filas = string.Empty;
                foreach (DataGridViewRow row in dgv_reportes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["ID"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Usuario"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombres"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Apellidos"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Genero"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Privilegio"].Value.ToString() + "</td>";
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

        private void dgv_reportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Reportes.reporte_usuarios), "Reportes Usuarios");
        }
    }
}
