using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using Guna.UI2.WinForms.Suite;
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

namespace CS_Proyecto.Vistas.Usuarios
{
    public partial class FotoPerfil : Form
    {
        public FotoPerfil()
        {
            InitializeComponent();
        }

        private void btn_cargar_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pict_foto.Image = new Bitmap(openFileDialog.FileName);
                Atributos_Usuarios.Imagen = ConvertirImagenABytes(pict_foto.Image);
            }
        }

        private void MostrarFotoPerfil()
        {
            if (Atributos_Usuarios.Imagen != null && Atributos_Usuarios.Imagen.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(Atributos_Usuarios.Imagen))
                {
                    Image imagen = Image.FromStream(ms);
                    pict_foto.Image = imagen;
                }
            }
        }

        private byte[] ConvertirImagenABytes(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void FotoPerfil_Load(object sender, EventArgs e)
        {
            MostrarFotoPerfil();
        }

        private void btn_eliminar_foto_Click(object sender, EventArgs e)
        {
            Atributos_Usuarios.Imagen = new byte[0];
            pict_foto.Image = Properties.Resources.SinFotoPerfil;
        }

        private void ActualizarForm_Tick(object sender, EventArgs e)
        {
            MostrarFotoPerfil();
            
        }
    }
}
