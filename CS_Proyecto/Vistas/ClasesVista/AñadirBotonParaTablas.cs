using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.ClasesVista
{
    internal class AñadirBotonParaTablas
    {
        public void AñadirBotonComprobanteEnDataGrid(DataGridView dgv)
        {

            //Crear Columna de Boton
            DataGridViewImageColumn imageColumnEditar = new DataGridViewImageColumn();
            imageColumnEditar.Name = "ImagenColumna";
            imageColumnEditar.HeaderText = " ";
            imageColumnEditar.Image = Properties.Resources.btn_comprobante;
            //imageColumnEditar.ImageLayout = DataGridViewImageCellLayout.Stretch; 

            //Agregar la columna de imagen del botón al DataGridView
            dgv.Columns.Add(imageColumnEditar);

            //Establecer el orden de visualización del boton editar
            dgv.Columns["ImagenColumna"].DisplayIndex = 5;

            //Establecer el centrado de la imagen del boton
            DataGridViewColumn columnaImagen = dgv.Columns["ImagenColumna"];

            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;

            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Definir Tamaño de la columna
            dgv.Columns["ImagenColumna"].Width = 28;
            
        }


        public void AñadirBotonEditarEnDataGrid(DataGridView dgv)
        {

            //Crear Columna de Boton
            DataGridViewImageColumn imageColumnEditar = new DataGridViewImageColumn();
            imageColumnEditar.Name = "ImagenColumna";
            imageColumnEditar.HeaderText = " ";
            imageColumnEditar.Image = Properties.Resources.btn_Editar;
            //imageColumnEditar.ImageLayout = DataGridViewImageCellLayout.Stretch; 

            //Agregar la columna de imagen del botón al DataGridView
            dgv.Columns.Add(imageColumnEditar);

            //Establecer el centrado de la imagen del boton
            DataGridViewColumn columnaImagen = dgv.Columns["ImagenColumna"];

            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;
            
            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Definir Tamaño de la columna
            dgv.Columns["ImagenColumna"].Width = 35;
        }

        public void AñadirBotonEliminarEnDataGrid(DataGridView dgv)
        {

            //Crear Columna de Boton
            DataGridViewImageColumn imageColumnEditar = new DataGridViewImageColumn();
            imageColumnEditar.Name = "ImagenColumnaEliminar";
            imageColumnEditar.HeaderText = " ";
            imageColumnEditar.Image = Properties.Resources.btn_eliminar;
            //imageColumnEditar.ImageLayout = DataGridViewImageCellLayout.Stretch; 

            //Agregar la columna de imagen del botón al DataGridView
            dgv.Columns.Add(imageColumnEditar);

            //Establecer el centrado de la imagen del boton
            DataGridViewColumn columnaImagen = dgv.Columns["ImagenColumnaEliminar"];

            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;

            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        public void AñadirBotonObservarEnDataGrid(DataGridView dgv)
        {
            //Crear Columna de Boton
            DataGridViewImageColumn imageColumnEditar = new DataGridViewImageColumn();
            imageColumnEditar.Name = "ImagenColumna";
            imageColumnEditar.HeaderText = " ";
            imageColumnEditar.Image = Properties.Resources.btn_informacion;
            //imageColumnEditar.ImageLayout = DataGridViewImageCellLayout.Stretch; 

            //Agregar la columna de imagen del botón al DataGridView
            dgv.Columns.Add(imageColumnEditar);

            //Establecer el centrado de la imagen del boton
            DataGridViewColumn columnaImagen = dgv.Columns["ImagenColumna"];

            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;

            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Definir Tamaño de la columna
            dgv.Columns["ImagenColumna"].Width = 28;
        }


        public void BtnAñadirMateriaHaciaDocente(DataGridView dgv)
        {
            //Crear Columna de Boton
            DataGridViewImageColumn imageColumnEditar = new DataGridViewImageColumn();
            imageColumnEditar.Name = "ImagenColumna";
            imageColumnEditar.HeaderText = " ";
            imageColumnEditar.Image = Properties.Resources.btn_agregar_materia_docente;
          //  imageColumnEditar.ImageLayout = DataGridViewImageCellLayout.Normal;

            //Agregar la columna de imagen del botón al DataGridView
            dgv.Columns.Add(imageColumnEditar);

            //Establecer el centrado de la imagen del boton
            DataGridViewColumn columnaImagen = dgv.Columns["ImagenColumna"];

            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;

            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Definir Tamaño de la columna
            dgv.Columns["ImagenColumna"].Width =200;

            dgv.Columns["ImagenColumna"].DisplayIndex = 2;
        }

        public void BtnQuitarMateriaDocente(DataGridView dgv)
        {
            //Crear Columna de Boton
            DataGridViewImageColumn imageColumnEditar = new DataGridViewImageColumn();
            imageColumnEditar.Name = "ImagenColumna";
            imageColumnEditar.HeaderText = " ";
            imageColumnEditar.Image = Properties.Resources.btn_quitar;
           // imageColumnEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            //Agregar la columna de imagen del botón al DataGridView
            dgv.Columns.Add(imageColumnEditar);

            //Establecer el centrado de la imagen del boton
            DataGridViewColumn columnaImagen = dgv.Columns["ImagenColumna"];

            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;

            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Definir Tamaño de la columna
            dgv.Columns["ImagenColumna"].Width = 145;

            dgv.Columns["ImagenColumna"].DisplayIndex =2;
        }

        public void AñadirBotonPDF(DataGridView dgv)
        {

            //Crear Columna de Boton
            DataGridViewImageColumn imageColumnEditar = new DataGridViewImageColumn();
            imageColumnEditar.Name = "ImagenColumna";
            imageColumnEditar.HeaderText = " ";
            imageColumnEditar.Image = Properties.Resources.btn_generar_pdf_morado;
            //imageColumnEditar.ImageLayout = DataGridViewImageCellLayout.Stretch; 

            //Agregar la columna de imagen del botón al DataGridView
            dgv.Columns.Add(imageColumnEditar);

            //Establecer el centrado de la imagen del boton
            DataGridViewColumn columnaImagen = dgv.Columns["ImagenColumna"];

            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;

            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Definir Tamaño de la columna
            dgv.Columns["ImagenColumna"].Width = 20;
        }
    }
}
