using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Mi_Perfil
{

    public partial class ImgPerfil : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
 (
     int nLeftRect,     // x-coordinate of upper-left corner
     int nTopRect,      // y-coordinate of upper-left corner
     int nRightRect,    // x-coordinate of lower-right corner
     int nBottomRect,   // y-coordinate of lower-right corner
     int nWidthEllipse, // width of ellipse
     int nHeightEllipse // height of ellipse
 );

        public ImgPerfil()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            guna2AnimateWindow1.SetAnimateWindow(this);

        }

        byte[] imgPerfil;
        CN_Perfil cN_Perfil = new CN_Perfil();

        private void ImgPerfil_Load(object sender, EventArgs e)
        {
            imgPerfil = Atributos_Login.Imagen;
            MostrarFotoPerfil();
        }

        private byte[] ConvertirImagenABytes(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void MostrarFotoPerfil()
        {
            if (Atributos_Login.Imagen != null && Atributos_Login.Imagen.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(Atributos_Login.Imagen))
                {
                    Image imagen = Image.FromStream(ms);
                    PictFoto.Image = imagen;
                    
                }
            }
        }

        private void PictFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictFoto.Image = new Bitmap(openFileDialog.FileName);
                imgPerfil = ConvertirImagenABytes(PictFoto.Image);
            }
        }

        private void btn_cambiar_Click(object sender, EventArgs e)
        {

            try
            {
                string ContraseñEncriptada = BCrypt.Net.BCrypt.HashPassword((Atributos_Login.Contraseña));

                cN_Perfil.EditarPerfil(
                Atributos_Login.IdUsuario,
                Atributos_Login.Nombres,
                Atributos_Login.Apellidos,
                Atributos_Login.Genero,
                Atributos_Login.Dui,
                Atributos_Login.Usuario,
                ContraseñEncriptada,
                imgPerfil,
                Atributos_Login.Correo,
                Atributos_Login.IdRol,
                Atributos_Login.IdEstado
                );

                this.Close();

                Atributos_Login.Imagen = imgPerfil;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
           
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            Atributos_Login.Imagen = null;
            PictFoto.Image = Properties.Resources.ImgPerfil;
            imgPerfil = Atributos_Login.Imagen;
        }
    }
}
