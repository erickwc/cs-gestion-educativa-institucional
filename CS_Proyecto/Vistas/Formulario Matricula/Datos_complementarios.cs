using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    public partial class Datos_complementarios : Form
    {
        public Datos_complementarios()
        {
            InitializeComponent();
        }

        Vistas.ClasesVista.ValidarCampos validar = new Vistas.ClasesVista.ValidarCampos();
        ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
        public void MostrarTiposConexion()
        {
            CD_Alumnos cd_alumno_tipo_conexion = new CD_Alumnos();
            cmbx_tipo_conexion.DataSource = cd_alumno_tipo_conexion.MostrarTiposConexion();
            cmbx_tipo_conexion.DisplayMember = "TiposConexion";
            cmbx_tipo_conexion.ValueMember = "IdTipoConexion";
        }

        public void MostrarEstabilidades()
        {
            CD_Alumnos cd_alumno_estabilidades = new CD_Alumnos();
            cmbx_estabilidad.DataSource = cd_alumno_estabilidades.MostrarEstabilidades();
            cmbx_estabilidad.DisplayMember = "TipoEstabilidad";
            cmbx_estabilidad.ValueMember = "IdEstabilidad";
        }

        public void MostrarProveedoresInternet()
        {
            CD_Alumnos cd_alumno_proveedores_internet = new CD_Alumnos();
            cmbx_proveedor_principal.DataSource = cd_alumno_proveedores_internet.MostrarPRoveedoresInternet();
            cmbx_proveedor_principal.DisplayMember = "NombreProveedor";
            cmbx_proveedor_principal.ValueMember = "IdProveedorPrincipal";
        }


        private void Datos_complementarios_Load(object sender, EventArgs e)
        {
            MostrarProveedoresInternet();
            MostrarEstabilidades();
            MostrarTiposConexion();
            RecordarDatosTextboxComboBox();
            validar.EstadoComboBox(cmbx_estabilidad);
            validar.EstadoComboBox(cmbx_internet);
            validar.EstadoComboBox(cmbx_proceso_academico);
            validar.EstadoComboBox(cmbx_proveedor_principal);
            validar.EstadoComboBox(cmbx_tipo_conexion);
            validar.EstadoComboBox(cmbx_vacunacion);
        }

        private void RecordarDatosTextboxComboBox()
        {
            cmbx_vacunacion.Text = Atributos_Alumno.EsquemaVacunacion;
            cmbx_proceso_academico.Text = Atributos_Alumno.ProcesoAcademico;
            cmbx_internet.Text = Atributos_Alumno.PoseeInternet;
            cmbx_tipo_conexion.SelectedValue = Convert.ToInt32(Atributos_Alumno.IdTipoConexion);
            cmbx_proveedor_principal.SelectedValue = Convert.ToInt32(Atributos_Alumno.IdProveedorPrincipal);
            cmbx_estabilidad.SelectedValue = Convert.ToInt32(Atributos_Alumno.IdEstabilidad);

        }

        private void cmbx_tipo_conexion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.IdTipoConexion = Convert.ToInt32(cmbx_tipo_conexion.SelectedValue);
            validar.EstadoComboBox(cmbx_tipo_conexion);
        }

        private void cmbx_estabilidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.IdEstabilidad = Convert.ToInt32(cmbx_estabilidad.SelectedValue);
            validar.EstadoComboBox(cmbx_estabilidad);

        }

        private void cmbx_proveedor_principal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.IdProveedorPrincipal = Convert.ToInt32(cmbx_proveedor_principal.SelectedValue);
            validar.EstadoComboBox(cmbx_proveedor_principal);

        }

        private void cmbx_recursos_tecnologicos_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmbx_vacunacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.EsquemaVacunacion = cmbx_vacunacion.Text;
            validar.EstadoComboBox(cmbx_vacunacion);
        }

        private void cmbx_proceso_academico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.ProcesoAcademico = cmbx_proceso_academico.Text;
            validar.EstadoComboBox(cmbx_proceso_academico);
        }

        private void cmbx_internet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.PoseeInternet = cmbx_internet.Text;
            validar.EstadoComboBox(cmbx_internet);

           
        }

        private void cmbx_recursos_tecnologicos_Click(object sender, EventArgs e)
        {
            using (RecursosTecnologicos recursos = new RecursosTecnologicos())
            {
                fondo.Oscurecer(recursos);
            }

            if (!string.IsNullOrWhiteSpace(Atributos_Alumno.RecursosTecnologicos))
            {
                cmbx_recursos_tecnologicos.FillColor = Color.FromArgb(243, 255, 243);
                cmbx_recursos_tecnologicos.BorderColor = Color.FromArgb(91, 163, 35);
                cmbx_recursos_tecnologicos.ForeColor = Color.FromArgb(36, 114, 23);
                cmbx_recursos_tecnologicos.BorderThickness = 1;
                cmbx_recursos_tecnologicos.HoverState.BorderColor = Color.FromArgb(91, 163, 35);
            }
            else if (string.IsNullOrWhiteSpace(Atributos_Alumno.RecursosTecnologicos))
            {
                cmbx_recursos_tecnologicos.FillColor = Color.FromArgb(245, 247, 252);
                cmbx_recursos_tecnologicos.ForeColor = Color.FromArgb(104, 104, 104);
                cmbx_recursos_tecnologicos.ItemsAppearance.BackColor = Color.White;
                cmbx_recursos_tecnologicos.BorderThickness = 0;
            }
        }
    }
}
