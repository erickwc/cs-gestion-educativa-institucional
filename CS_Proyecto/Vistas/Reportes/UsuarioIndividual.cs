using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Usuarios;
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
    public partial class UsuarioIndividual : Form
    {
        public UsuarioIndividual()
        {
            InitializeComponent();
        }


        string idusuario = null;
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
      
        AñadirBotonParaTablas añadir = new AñadirBotonParaTablas();
        string PaginaHTML_Texto;
        private void MostrarUltimoUsuarioRegistrado()
        {
            //Instancia para llenar la tabla
            CN_Usuarios cn_usuarios = new CN_Usuarios(); ;
            tbl_usuarios_registrados.DataSource = cn_usuarios.EditarUsuarioRegistrado();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            tbl_usuarios_registrados.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Genero"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Dui"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Usuario"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Contraseña"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Correo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Estado"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Privilegio"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["ID"].SortMode = DataGridViewColumnSortMode.NotSortable;

            tbl_usuarios_registrados.Columns["ID"].Width = 25;
            tbl_usuarios_registrados.Columns["Estado"].Width = 25;
            tbl_usuarios_registrados.Columns["Privilegio"].Width = 50;
            tbl_usuarios_registrados.Columns["Genero"].Width = 60;
            tbl_usuarios_registrados.Columns["Dui"].Visible = false;
            tbl_usuarios_registrados.Columns["Correo"].Width = 80;
            tbl_usuarios_registrados.Columns["Contraseña"].Width = 65;
            tbl_usuarios_registrados.Columns["Nombres"].Width = 110;
            tbl_usuarios_registrados.Columns["Apellidos"].Width = 110;
            tbl_usuarios_registrados.Columns["Usuario"].Width = 110;

        }
        private void mostrarboton()
        {

            añadir.AñadirBotonPDF(tbl_usuarios_registrados);

            //Establecer el orden de visualización del boton editar
            tbl_usuarios_registrados.Columns["ImagenColumna"].DisplayIndex = 10;
            tbl_usuarios_registrados.Columns["ImagenColumna"].Width = 200;
        }


        private void btn_volver_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(reporte_usuarios), "Reportes Usuarios");
        }

        private void tbl_usuarios_registrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbl_usuarios_registrados.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = tbl_usuarios_registrados.Rows[e.RowIndex];
                    idusuario = dr.Cells["ID"].Value.ToString();
                    Atributos_Reportes.IdUsuario = Convert.ToInt32(idusuario);

                    CD_reportes reporte = new CD_reportes();

                    reporte.MostrarDatoUsuarioReporte(Atributos_Reportes.IdUsuario);

                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format("{0}.pdf", "Reporte del usuario " + Atributos_Reportes.Usuario + " "+ DateTime.Now.ToString("dd-MM-yyyy") + ".pdf");

                    PaginaHTML_Texto = Properties.Resources.PlantillaParaUsuarioIndividual.ToString();
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", "FICHA DEL USUARIO");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCRIPCION", "Datos completos del usuario");
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@nombres", Atributos_Reportes.NombresUsuario);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@apellidos", Atributos_Reportes.ApellidosUsuario);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@dui", Atributos_Reportes.DuiUsuario);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@genero", Atributos_Reportes.GeneroUsuario);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@usuario", Atributos_Reportes.Usuario);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@correo", Atributos_Reportes.CorreoUsuario);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@privilegio", Atributos_Reportes.PrivilegioUsuario);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@estado", Atributos_Reportes.EstadoUsuario);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@ID", Convert.ToString(Atributos_Reportes.IdUsuario));

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

        private void UsuarioIndividual_Load(object sender, EventArgs e)
        {
            MostrarUltimoUsuarioRegistrado();
            mostrarboton();
        }

        private void tbl_usuarios_registrados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tbl_usuarios_registrados.Columns[e.ColumnIndex].Name == "Contraseña")
            {
                if (e.Value != null)
                {
                    string contraseña = e.Value.ToString();
                    e.Value = new string('●', contraseña.Length);
                }
            }
        }

        private void cmbx_buscador_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_buscador.Enabled = true;
            txt_buscador.Text = String.Empty;
        }

        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {
            CN_Usuarios cn_buscador = new CN_Usuarios();
            tbl_usuarios_registrados.DataSource = cn_buscador.BuscarUsuario(txt_buscador.Text);
        }

        private void txt_buscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbx_buscador.Text == "Nombre de Usuario" || cmbx_buscador.Text == "Nombres" || cmbx_buscador.Text == "Apellidos")
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
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
        }
    }
}
