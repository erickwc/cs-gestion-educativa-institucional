using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Dashboard;
using Guna.UI2.WinForms;
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

namespace CS_Proyecto.Vistas.Mi_Perfil
{
    public partial class Mi_perfil_main : Form
    {
        public Mi_perfil_main()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        private void btn_EditalPerfil_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Mi_Perfil.Editar), "Mi perfil");

        }

        private void MostrarFotoPerfil()
        {
            if (Atributos_Login.Imagen != null && Atributos_Login.Imagen.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(Atributos_Login.Imagen))
                {
                    Image imagen = Image.FromStream(ms);
                    pict_foto.Image = imagen;
                }
            }
            else if (Atributos_Login.Imagen == null)
            {
                pict_foto.Image = Properties.Resources.ImgPerfil;
            }
        }

        private void Mi_perfil_main_Load(object sender, EventArgs e)
        {
            lbl_NombreUsuario.Text = Atributos_Login.Nombres + " " + Atributos_Login.Apellidos;
            lbl_Usuario.Text = "@" + Atributos_Login.Usuario;
            MostrarFotoPerfil(); 
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Dashboard.Dashboard_controles), "Dashboard");
        }
      
    }
}
