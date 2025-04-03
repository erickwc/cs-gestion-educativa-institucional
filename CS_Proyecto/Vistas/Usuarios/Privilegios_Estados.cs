using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Usuarios
{
    public partial class Privilegios_Estados : Form
    {
        public Privilegios_Estados()
        {
            InitializeComponent();
        }

        ValidarCampos validar = new ValidarCampos();
        CN_Usuarios cN_Usuarios = new CN_Usuarios();

        private void MostrarPrivilegios()
        {
            CD_Usuariuos cD_Usuariuos = new CD_Usuariuos();
            cmbx_privilegio.DataSource = cD_Usuariuos.MostrarPrivilegios();
            cmbx_privilegio.DisplayMember = "TipoRol";
            cmbx_privilegio.ValueMember = "IdRol";

        }
        private void MostrarEstado()
        {
            CD_Usuariuos cD_Usuariuos = new CD_Usuariuos();
            cmbx_estado.DataSource = cD_Usuariuos.MostrarEstado();
            cmbx_estado.DisplayMember = "TipoEstado";
            cmbx_estado.ValueMember = "IdTipoEstado";

        }
        private void cmbx_estado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Usuarios.IdEstado = Convert.ToInt32(cmbx_estado.SelectedValue);
            validar.EstadoComboBox(cmbx_estado);
        }

        private void cmbx_privilegio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Usuarios.IdRol = Convert.ToInt32(cmbx_privilegio.SelectedValue);
            validar.EstadoComboBox(cmbx_privilegio);
        }

        private void Privilegios_Estados_Load(object sender, EventArgs e)
        {
            MostrarPrivilegios();
            MostrarEstado();
            RecordarComboBox();
        }

        private void RecordarComboBox()
        {
            cmbx_privilegio.SelectedValue = Convert.ToString(Atributos_Usuarios.IdRol);
            validar.EstadoComboBox(cmbx_privilegio);
            cmbx_estado.SelectedValue = Convert.ToString(Atributos_Usuarios.IdEstado);
            validar.EstadoComboBox(cmbx_estado);
        }
    }
}
