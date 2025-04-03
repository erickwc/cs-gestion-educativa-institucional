using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Dashboard;
using CS_Proyecto.Vistas.Docentes.Modificar;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    public partial class Matricula_main : Form
    {
        public Matricula_main()
        {
            InitializeComponent();


        }

        CN_Alumnos cn_alumnos = new CN_Alumnos();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        LimpiarVariables limpiarvar = new LimpiarVariables();

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.Panel_Contenedor_Secciones_Matricula.Controls.Count > 0)
                this.Panel_Contenedor_Secciones_Matricula.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_Contenedor_Secciones_Matricula.Controls.Add(fh);
            this.Panel_Contenedor_Secciones_Matricula.Tag = fh;
            fh.Show();
        }

        private void SeccionActiva(Guna2Button btn)
        {
            btn.FillColor = Color.FromArgb(232, 237, 255);
            btn.ForeColor = Color.FromArgb(63, 86, 255);
            btn.HoverState.FillColor = Color.FromArgb(232, 237, 255);
            btn.PressedColor = Color.FromArgb(232, 237, 255);
            btn.Font = new Font(btn.Font, FontStyle.Bold);
        }

        private void SeccionInactiva(Guna2Button btn)
        {
            btn.FillColor = Color.White;
            btn.ForeColor = Color.FromArgb(104, 104, 104);
            btn.HoverState.FillColor = Color.White;
            btn.PressedColor = Color.White;
            btn.Font = new Font(btn.Font, FontStyle.Regular);
        }

        private void btn_datos_personales_Click(object sender, EventArgs e)
        {

            SeccionInactiva(btn_residencia_contacto);
            SeccionActiva(btn_datos_personales);
            SeccionInactiva(btn_datos_complemetarios);
            SeccionInactiva(btn_situacion_familiar);
            SeccionInactiva(btn_resp_principal);
            SeccionInactiva(btn_resp_secundario);
            navegar.AbrirFormEnPanelMatricula(typeof(Vistas.Formulario_Matricula.Datos_personales));
        }


        private void btn_residencia_contacto_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelMatricula(typeof(Vistas.Formulario_Matricula.Residencia_contacto));
            SeccionActiva(btn_residencia_contacto);
            SeccionInactiva(btn_datos_personales);
            SeccionInactiva(btn_datos_complemetarios);
            SeccionInactiva(btn_situacion_familiar);
            SeccionInactiva(btn_resp_principal);
            SeccionInactiva(btn_resp_secundario);
        }

        private void Matricula_main_Load(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelMatricula(typeof(Vistas.Formulario_Matricula.Datos_personales));
            SeccionActiva(btn_datos_personales);
        }

        private void btn_situacion_familiar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelMatricula(typeof(Vistas.Formulario_Matricula.Situacion_familiar));
            SeccionInactiva(btn_residencia_contacto);
            SeccionInactiva(btn_datos_personales);
            SeccionInactiva(btn_datos_complemetarios);
            SeccionActiva(btn_situacion_familiar);
            SeccionInactiva(btn_resp_principal);
            SeccionInactiva(btn_resp_secundario);
        }

        private void btn_datos_complemetarios_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelMatricula(typeof(Vistas.Formulario_Matricula.Datos_complementarios));
            SeccionInactiva(btn_residencia_contacto);
            SeccionInactiva(btn_datos_personales);
            SeccionActiva(btn_datos_complemetarios);
            SeccionInactiva(btn_situacion_familiar);
            SeccionInactiva(btn_resp_principal);
            SeccionInactiva(btn_resp_secundario);
        }

        private void btn_resp_principal_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelMatricula(typeof(Vistas.Formulario_Matricula.Responsable_principal));
            SeccionInactiva(btn_residencia_contacto);
            SeccionInactiva(btn_datos_personales);
            SeccionInactiva(btn_datos_complemetarios);
            SeccionInactiva(btn_situacion_familiar);
            SeccionActiva(btn_resp_principal);
            SeccionInactiva(btn_resp_secundario);
        }

        private void btn_resp_secundario_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelMatricula(typeof(Vistas.Formulario_Matricula.Responsable_secundario));
            SeccionInactiva(btn_residencia_contacto);
            SeccionInactiva(btn_datos_personales);
            SeccionInactiva(btn_datos_complemetarios);
            SeccionInactiva(btn_situacion_familiar);
            SeccionInactiva(btn_resp_principal);
            SeccionActiva(btn_resp_secundario);
        }

        private void btn_info_medica_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelMatricula(typeof(Vistas.Formulario_Matricula.Target_seccion_medica));
            SeccionInactiva(btn_residencia_contacto);
            SeccionInactiva(btn_datos_personales);
            SeccionInactiva(btn_datos_complemetarios);
            SeccionInactiva(btn_situacion_familiar);
            SeccionInactiva(btn_resp_principal);
            SeccionInactiva(btn_resp_secundario);
            Nav_sec_matricula.Visible = false;
            seccion_botones.Visible = false;
        }

        private void btn_pago_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelMatricula(typeof(Vistas.Formulario_Matricula.Pago_matricula));
            SeccionInactiva(btn_residencia_contacto);
            SeccionInactiva(btn_datos_personales);
            SeccionInactiva(btn_datos_complemetarios);
            SeccionInactiva(btn_situacion_familiar);
            SeccionInactiva(btn_resp_principal);
            SeccionInactiva(btn_resp_secundario);
        }

        private void btn_identificacion_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelMatricula(typeof(Vistas.Formulario_Matricula.Identificacion));
            SeccionInactiva(btn_residencia_contacto);
            SeccionInactiva(btn_datos_personales);
            SeccionInactiva(btn_datos_complemetarios);
            SeccionInactiva(btn_situacion_familiar);
            SeccionInactiva(btn_resp_principal);
            SeccionInactiva(btn_resp_secundario);
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Atributos_Alumno.NIE == null && Atributos_Alumno.NieTemporal == null)
                {
                    ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                    using (FaltaCompletarNIE nie = new FaltaCompletarNIE())
                    {
                        fondo.Oscurecer(nie);
                    }
                }
                else
                {
                    if (Atributos_Alumno.GuardarConNieTemporal == "NoTieneNieTemporal")
                    {
                        cn_alumnos.insertarAlumno(
                    Atributos_Alumno.Nombres,
                    Atributos_Alumno.Apellidos,
                    Atributos_Alumno.NIE,
                    Atributos_Alumno.Genero,
                    Atributos_Alumno.FechaNacimiento,
                    Atributos_Alumno.LugarNacimiento,
                    Atributos_Alumno.Partida,
                    Atributos_Alumno.EducacionInicial,
                    Atributos_Alumno.SeccionInicial,
                    Atributos_Alumno.AnioInicial,
                    Atributos_Alumno.IdInstitucionProcedencia,
                    Atributos_Alumno.IdNacionalidad,
                    Atributos_Alumno.RepitiendoAnio,
                    Atributos_Alumno.Direccion,
                    Atributos_Alumno.Canton,
                    Atributos_Alumno.Caserio,
                    Atributos_Alumno.IdMunicipio,
                    Atributos_Alumno.IdDepartamento,
                    Atributos_Alumno.IdZonaResidencia,
                    Atributos_Alumno.EmailAumno,
                    Atributos_Alumno.NumeroMiembrosFamilia,
                    Atributos_Alumno.DependenciaFamiliar,
                    Atributos_Alumno.DependenciaEconomica,
                    Atributos_Alumno.LugarTrabajo,
                    Atributos_Alumno.Cargo,
                    Atributos_Alumno.EsquemaVacunacion,
                    Atributos_Alumno.ProcesoAcademico,
                    Atributos_Alumno.PoseeInternet,
                    Atributos_Alumno.IdTipoConexion,
                    Atributos_Alumno.IdEstabilidad,
                    Atributos_Alumno.IdProveedorPrincipal,
                    Atributos_Alumno.RecursosTecnologicos,
                    Atributos_Alumno.ResponsablePrincipal,
                    Atributos_Alumno.ParentescoResponsablePrincipal,
                    Atributos_Alumno.DuiResponsablePrincipal,
                    Atributos_Alumno.GeneroResponsablePrincipal,
                    Atributos_Alumno.EmailResponsablePrincipal,
                    Atributos_Alumno.LugarTrabajoResponsablePrincipal,
                    Atributos_Alumno.PoliticamenteExpuesto,
                    Atributos_Alumno.ResponsableSecundario,
                    Atributos_Alumno.ParentescoResponsableSecundario,
                    Atributos_Alumno.LugarTrabajoResponsableSecundario,
                    Atributos_Alumno.DuiResponsableSecundario,
                    Atributos_Alumno.TelMovilPrincipalAlumno,
                    Atributos_Alumno.TelMovilSecundarioAlumno,
                    Atributos_Alumno.TelMovilPrincipalResponsablePrincipal,
                    Atributos_Alumno.TelMovilSecundarioResponsablePrincipal,
                    Atributos_Alumno.NumeroTrabajoPrincipal,
                    Atributos_Alumno.NumeroTrabajoSecundario,
                    Atributos_Alumno.TelMovilPrincipalResponsableSecundario,
                    Atributos_Alumno.TelMovilSecundarioResponsableSecundario,
                    Atributos_Alumno.TelFijoPrincipal,
                    Atributos_Alumno.TelFijoSecundario);


                    }
                    else if (Atributos_Alumno.GuardarConNieTemporal == "TieneNieTemporal")
                    {

                        cn_alumnos.insertarAlumno(
                        Atributos_Alumno.Nombres,
                        Atributos_Alumno.Apellidos,
                        Atributos_Alumno.NIE,
                        Atributos_Alumno.Genero,
                        Atributos_Alumno.FechaNacimiento,
                        Atributos_Alumno.LugarNacimiento,
                        Atributos_Alumno.Partida,
                        Atributos_Alumno.EducacionInicial,
                        Atributos_Alumno.SeccionInicial,
                        Atributos_Alumno.AnioInicial,
                        Atributos_Alumno.IdInstitucionProcedencia,
                        Atributos_Alumno.IdNacionalidad,
                        Atributos_Alumno.RepitiendoAnio,
                        Atributos_Alumno.Direccion,
                        Atributos_Alumno.Canton,
                        Atributos_Alumno.Caserio,
                        Atributos_Alumno.IdMunicipio,
                        Atributos_Alumno.IdDepartamento,
                        Atributos_Alumno.IdZonaResidencia,
                        Atributos_Alumno.EmailAumno,
                        Atributos_Alumno.NumeroMiembrosFamilia,
                        Atributos_Alumno.DependenciaFamiliar,
                        Atributos_Alumno.DependenciaEconomica,
                        Atributos_Alumno.LugarTrabajo,
                        Atributos_Alumno.Cargo,
                        Atributos_Alumno.EsquemaVacunacion,
                        Atributos_Alumno.ProcesoAcademico,
                        Atributos_Alumno.PoseeInternet,
                        Atributos_Alumno.IdTipoConexion,
                        Atributos_Alumno.IdEstabilidad,
                        Atributos_Alumno.IdProveedorPrincipal,
                        Atributos_Alumno.RecursosTecnologicos,
                        Atributos_Alumno.ResponsablePrincipal,
                        Atributos_Alumno.ParentescoResponsablePrincipal,
                        Atributos_Alumno.DuiResponsablePrincipal,
                        Atributos_Alumno.GeneroResponsablePrincipal,
                        Atributos_Alumno.EmailResponsablePrincipal,
                        Atributos_Alumno.LugarTrabajoResponsablePrincipal,
                        Atributos_Alumno.PoliticamenteExpuesto,
                        Atributos_Alumno.ResponsableSecundario,
                        Atributos_Alumno.ParentescoResponsableSecundario,
                        Atributos_Alumno.LugarTrabajoResponsableSecundario,
                        Atributos_Alumno.DuiResponsableSecundario,
                        Atributos_Alumno.TelMovilPrincipalAlumno,
                        Atributos_Alumno.TelMovilSecundarioAlumno,
                        Atributos_Alumno.TelMovilPrincipalResponsablePrincipal,
                        Atributos_Alumno.TelMovilSecundarioResponsablePrincipal,
                        Atributos_Alumno.NumeroTrabajoPrincipal,
                        Atributos_Alumno.NumeroTrabajoSecundario,
                        Atributos_Alumno.TelMovilPrincipalResponsableSecundario,
                        Atributos_Alumno.TelMovilSecundarioResponsableSecundario,
                        Atributos_Alumno.TelFijoPrincipal,
                        Atributos_Alumno.TelFijoSecundario);
                        cn_alumnos.InsertaNieTemporal(Atributos_Alumno.NieTemporal, Atributos_Alumno.IdAlumno);
                    }

                    limpiarvar.LimpiarVariablesMatriculaAlumno();

                    ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                    using (Vistas.Alertas.Registro_exitoso registro_exitoso = new Vistas.Alertas.Registro_exitoso())
                    {
                        fondo.Oscurecer(registro_exitoso);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo" + ex);
            }
        }

        private void ActualizarFormulario_Tick(object sender, EventArgs e)
        {

            if (Atributos_Alumno.NieTemporal == null)
            {
                Atributos_Alumno.GuardarConNieTemporal = "NoTieneNieTemporal";
            }
            if(
                     !string.IsNullOrWhiteSpace(Atributos_Alumno.Nombres)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.Apellidos)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.Genero)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.FechaNacimiento)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.LugarNacimiento)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.Partida)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.EducacionInicial)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.SeccionInicial)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.AnioInicial)
                  && Atributos_Alumno.IdInstitucionProcedencia != 0
                  && Atributos_Alumno.IdNacionalidad != 0
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.Direccion)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.Canton)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.Caserio)
                  && Atributos_Alumno.IdMunicipio != 0
                  && Atributos_Alumno.IdDepartamento != 0
                  && Atributos_Alumno.IdZonaResidencia != 0
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.EmailAumno)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.NumeroMiembrosFamilia)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.DependenciaFamiliar)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.DependenciaEconomica)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.LugarTrabajo)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.Cargo)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.EsquemaVacunacion)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.ProcesoAcademico)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.PoseeInternet)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.RepitiendoAnio)
                  && Atributos_Alumno.IdTipoConexion != 0
                  && Atributos_Alumno.IdEstabilidad != 0
                  && Atributos_Alumno.IdProveedorPrincipal != 0
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.RecursosTecnologicos)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.ResponsablePrincipal)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.PoliticamenteExpuesto)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.ParentescoResponsablePrincipal)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.DuiResponsablePrincipal)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.GeneroResponsablePrincipal)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.LugarTrabajoResponsablePrincipal)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.ResponsableSecundario)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.ParentescoResponsableSecundario)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.LugarTrabajoResponsableSecundario)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.DuiResponsableSecundario)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.TelMovilPrincipalAlumno)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.TelMovilPrincipalResponsablePrincipal)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.NumeroTrabajoPrincipal)
                  && !string.IsNullOrWhiteSpace(Atributos_Alumno.TelMovilPrincipalResponsableSecundario))
            {
                btn_guardar.Visible = true;
            }
            else
            {
                btn_guardar.Visible = false;
            }

            this.Invalidate();
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (Cancelar_matricula cancelar_Matricula = new Cancelar_matricula())
            {
                fondo.Oscurecer(cancelar_Matricula);
            }
        }

    }
}
