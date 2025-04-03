namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    partial class Matricula_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Panel_Contenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Contenedor_Secciones_Matricula = new System.Windows.Forms.TableLayoutPanel();
            this.seccion_botones = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.Nav_sec_matricula = new System.Windows.Forms.TableLayoutPanel();
            this.btn_resp_secundario = new Guna.UI2.WinForms.Guna2Button();
            this.btn_resp_principal = new Guna.UI2.WinForms.Guna2Button();
            this.btn_datos_complemetarios = new Guna.UI2.WinForms.Guna2Button();
            this.btn_situacion_familiar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_residencia_contacto = new Guna.UI2.WinForms.Guna2Button();
            this.btn_datos_personales = new Guna.UI2.WinForms.Guna2Button();
            this.ActualizarFormulario = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel_Contenedor.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.seccion_botones.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Nav_sec_matricula.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Contenedor
            // 
            this.Panel_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.Panel_Contenedor.BorderRadius = 5;
            this.Panel_Contenedor.Controls.Add(this.tableLayoutPanel2);
            this.Panel_Contenedor.Controls.Add(this.seccion_botones);
            this.Panel_Contenedor.Controls.Add(this.Nav_sec_matricula);
            this.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Contenedor.FillColor = System.Drawing.Color.White;
            this.Panel_Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Panel_Contenedor.Name = "Panel_Contenedor";
            this.Panel_Contenedor.Padding = new System.Windows.Forms.Padding(5);
            this.Panel_Contenedor.ShadowDecoration.Parent = this.Panel_Contenedor;
            this.Panel_Contenedor.Size = new System.Drawing.Size(1170, 607);
            this.Panel_Contenedor.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Panel_Contenedor_Secciones_Matricula, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 61);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 404F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1160, 404);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Panel_Contenedor_Secciones_Matricula
            // 
            this.Panel_Contenedor_Secciones_Matricula.ColumnCount = 1;
            this.Panel_Contenedor_Secciones_Matricula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Contenedor_Secciones_Matricula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_Contenedor_Secciones_Matricula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Contenedor_Secciones_Matricula.Location = new System.Drawing.Point(3, 3);
            this.Panel_Contenedor_Secciones_Matricula.Name = "Panel_Contenedor_Secciones_Matricula";
            this.Panel_Contenedor_Secciones_Matricula.RowCount = 1;
            this.Panel_Contenedor_Secciones_Matricula.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Contenedor_Secciones_Matricula.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 398F));
            this.Panel_Contenedor_Secciones_Matricula.Size = new System.Drawing.Size(1154, 398);
            this.Panel_Contenedor_Secciones_Matricula.TabIndex = 0;
            // 
            // seccion_botones
            // 
            this.seccion_botones.BackColor = System.Drawing.Color.White;
            this.seccion_botones.ColumnCount = 1;
            this.seccion_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.seccion_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.seccion_botones.Controls.Add(this.panel2, 0, 0);
            this.seccion_botones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.seccion_botones.Location = new System.Drawing.Point(5, 465);
            this.seccion_botones.Name = "seccion_botones";
            this.seccion_botones.RowCount = 1;
            this.seccion_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.seccion_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.seccion_botones.Size = new System.Drawing.Size(1160, 137);
            this.seccion_botones.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.btn_guardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 131);
            this.panel2.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.BorderRadius = 5;
            this.btn_cancelar.CheckedState.Parent = this.btn_cancelar;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.CustomImages.Parent = this.btn_cancelar;
            this.btn_cancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cancelar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cancelar.HoverState.Parent = this.btn_cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(840, 33);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar.ShadowDecoration.Parent = this.btn_cancelar;
            this.btn_cancelar.Size = new System.Drawing.Size(276, 57);
            this.btn_cancelar.TabIndex = 79;
            this.btn_cancelar.Text = "Cancelar Matricula";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BorderRadius = 5;
            this.btn_guardar.CheckedState.Parent = this.btn_guardar;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.CustomImages.Parent = this.btn_guardar;
            this.btn_guardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.HoverState.Parent = this.btn_guardar;
            this.btn_guardar.Location = new System.Drawing.Point(545, 33);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar.ShadowDecoration.Parent = this.btn_guardar;
            this.btn_guardar.Size = new System.Drawing.Size(269, 57);
            this.btn_guardar.TabIndex = 78;
            this.btn_guardar.Text = "Registrar Matricula";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Nav_sec_matricula
            // 
            this.Nav_sec_matricula.BackColor = System.Drawing.Color.White;
            this.Nav_sec_matricula.ColumnCount = 6;
            this.Nav_sec_matricula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.Nav_sec_matricula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Nav_sec_matricula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Nav_sec_matricula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Nav_sec_matricula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Nav_sec_matricula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.Nav_sec_matricula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Nav_sec_matricula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Nav_sec_matricula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Nav_sec_matricula.Controls.Add(this.btn_resp_secundario, 5, 0);
            this.Nav_sec_matricula.Controls.Add(this.btn_resp_principal, 4, 0);
            this.Nav_sec_matricula.Controls.Add(this.btn_datos_complemetarios, 3, 0);
            this.Nav_sec_matricula.Controls.Add(this.btn_situacion_familiar, 2, 0);
            this.Nav_sec_matricula.Controls.Add(this.btn_residencia_contacto, 1, 0);
            this.Nav_sec_matricula.Controls.Add(this.btn_datos_personales, 0, 0);
            this.Nav_sec_matricula.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nav_sec_matricula.Location = new System.Drawing.Point(5, 5);
            this.Nav_sec_matricula.Name = "Nav_sec_matricula";
            this.Nav_sec_matricula.RowCount = 1;
            this.Nav_sec_matricula.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Nav_sec_matricula.Size = new System.Drawing.Size(1160, 56);
            this.Nav_sec_matricula.TabIndex = 0;
            // 
            // btn_resp_secundario
            // 
            this.btn_resp_secundario.BackColor = System.Drawing.Color.Transparent;
            this.btn_resp_secundario.BorderRadius = 5;
            this.btn_resp_secundario.CheckedState.Parent = this.btn_resp_secundario;
            this.btn_resp_secundario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_resp_secundario.CustomImages.Parent = this.btn_resp_secundario;
            this.btn_resp_secundario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_resp_secundario.FillColor = System.Drawing.Color.White;
            this.btn_resp_secundario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resp_secundario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_resp_secundario.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_resp_secundario.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_resp_secundario.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_resp_secundario.HoverState.Parent = this.btn_resp_secundario;
            this.btn_resp_secundario.Location = new System.Drawing.Point(970, 5);
            this.btn_resp_secundario.Margin = new System.Windows.Forms.Padding(5);
            this.btn_resp_secundario.Name = "btn_resp_secundario";
            this.btn_resp_secundario.PressedColor = System.Drawing.Color.White;
            this.btn_resp_secundario.ShadowDecoration.Parent = this.btn_resp_secundario;
            this.btn_resp_secundario.Size = new System.Drawing.Size(185, 46);
            this.btn_resp_secundario.TabIndex = 5;
            this.btn_resp_secundario.Text = "Resp. Secundario";
            this.btn_resp_secundario.Click += new System.EventHandler(this.btn_resp_secundario_Click);
            // 
            // btn_resp_principal
            // 
            this.btn_resp_principal.BackColor = System.Drawing.Color.Transparent;
            this.btn_resp_principal.BorderRadius = 5;
            this.btn_resp_principal.CheckedState.Parent = this.btn_resp_principal;
            this.btn_resp_principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_resp_principal.CustomImages.Parent = this.btn_resp_principal;
            this.btn_resp_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_resp_principal.FillColor = System.Drawing.Color.White;
            this.btn_resp_principal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resp_principal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_resp_principal.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_resp_principal.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_resp_principal.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_resp_principal.HoverState.Parent = this.btn_resp_principal;
            this.btn_resp_principal.Location = new System.Drawing.Point(777, 5);
            this.btn_resp_principal.Margin = new System.Windows.Forms.Padding(5);
            this.btn_resp_principal.Name = "btn_resp_principal";
            this.btn_resp_principal.PressedColor = System.Drawing.Color.White;
            this.btn_resp_principal.ShadowDecoration.Parent = this.btn_resp_principal;
            this.btn_resp_principal.Size = new System.Drawing.Size(183, 46);
            this.btn_resp_principal.TabIndex = 4;
            this.btn_resp_principal.Text = "Resp. Principal";
            this.btn_resp_principal.Click += new System.EventHandler(this.btn_resp_principal_Click);
            // 
            // btn_datos_complemetarios
            // 
            this.btn_datos_complemetarios.BackColor = System.Drawing.Color.Transparent;
            this.btn_datos_complemetarios.BorderRadius = 5;
            this.btn_datos_complemetarios.CheckedState.Parent = this.btn_datos_complemetarios;
            this.btn_datos_complemetarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_datos_complemetarios.CustomImages.Parent = this.btn_datos_complemetarios;
            this.btn_datos_complemetarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_datos_complemetarios.FillColor = System.Drawing.Color.White;
            this.btn_datos_complemetarios.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datos_complemetarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_datos_complemetarios.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_datos_complemetarios.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_datos_complemetarios.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_datos_complemetarios.HoverState.Parent = this.btn_datos_complemetarios;
            this.btn_datos_complemetarios.Location = new System.Drawing.Point(584, 5);
            this.btn_datos_complemetarios.Margin = new System.Windows.Forms.Padding(5);
            this.btn_datos_complemetarios.Name = "btn_datos_complemetarios";
            this.btn_datos_complemetarios.PressedColor = System.Drawing.Color.White;
            this.btn_datos_complemetarios.ShadowDecoration.Parent = this.btn_datos_complemetarios;
            this.btn_datos_complemetarios.Size = new System.Drawing.Size(183, 46);
            this.btn_datos_complemetarios.TabIndex = 3;
            this.btn_datos_complemetarios.Text = "Dat. Complementarios";
            this.btn_datos_complemetarios.Click += new System.EventHandler(this.btn_datos_complemetarios_Click);
            // 
            // btn_situacion_familiar
            // 
            this.btn_situacion_familiar.BackColor = System.Drawing.Color.Transparent;
            this.btn_situacion_familiar.BorderRadius = 5;
            this.btn_situacion_familiar.CheckedState.Parent = this.btn_situacion_familiar;
            this.btn_situacion_familiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_situacion_familiar.CustomImages.Parent = this.btn_situacion_familiar;
            this.btn_situacion_familiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_situacion_familiar.FillColor = System.Drawing.Color.White;
            this.btn_situacion_familiar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_situacion_familiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_situacion_familiar.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_situacion_familiar.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_situacion_familiar.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_situacion_familiar.HoverState.Parent = this.btn_situacion_familiar;
            this.btn_situacion_familiar.Location = new System.Drawing.Point(391, 5);
            this.btn_situacion_familiar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_situacion_familiar.Name = "btn_situacion_familiar";
            this.btn_situacion_familiar.PressedColor = System.Drawing.Color.White;
            this.btn_situacion_familiar.ShadowDecoration.Parent = this.btn_situacion_familiar;
            this.btn_situacion_familiar.Size = new System.Drawing.Size(183, 46);
            this.btn_situacion_familiar.TabIndex = 2;
            this.btn_situacion_familiar.Text = "Situación Familiar";
            this.btn_situacion_familiar.Click += new System.EventHandler(this.btn_situacion_familiar_Click);
            // 
            // btn_residencia_contacto
            // 
            this.btn_residencia_contacto.BackColor = System.Drawing.Color.Transparent;
            this.btn_residencia_contacto.BorderRadius = 5;
            this.btn_residencia_contacto.CheckedState.Parent = this.btn_residencia_contacto;
            this.btn_residencia_contacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_residencia_contacto.CustomImages.Parent = this.btn_residencia_contacto;
            this.btn_residencia_contacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_residencia_contacto.FillColor = System.Drawing.Color.White;
            this.btn_residencia_contacto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_residencia_contacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_residencia_contacto.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_residencia_contacto.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_residencia_contacto.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_residencia_contacto.HoverState.Parent = this.btn_residencia_contacto;
            this.btn_residencia_contacto.Location = new System.Drawing.Point(198, 5);
            this.btn_residencia_contacto.Margin = new System.Windows.Forms.Padding(5);
            this.btn_residencia_contacto.Name = "btn_residencia_contacto";
            this.btn_residencia_contacto.PressedColor = System.Drawing.Color.White;
            this.btn_residencia_contacto.ShadowDecoration.Parent = this.btn_residencia_contacto;
            this.btn_residencia_contacto.Size = new System.Drawing.Size(183, 46);
            this.btn_residencia_contacto.TabIndex = 1;
            this.btn_residencia_contacto.Text = "Residencia y Contacto";
            this.btn_residencia_contacto.Click += new System.EventHandler(this.btn_residencia_contacto_Click);
            // 
            // btn_datos_personales
            // 
            this.btn_datos_personales.BackColor = System.Drawing.Color.Transparent;
            this.btn_datos_personales.BorderRadius = 5;
            this.btn_datos_personales.CheckedState.Parent = this.btn_datos_personales;
            this.btn_datos_personales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_datos_personales.CustomImages.Parent = this.btn_datos_personales;
            this.btn_datos_personales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_datos_personales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.btn_datos_personales.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datos_personales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_datos_personales.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_datos_personales.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_datos_personales.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_datos_personales.HoverState.Parent = this.btn_datos_personales;
            this.btn_datos_personales.Location = new System.Drawing.Point(5, 5);
            this.btn_datos_personales.Margin = new System.Windows.Forms.Padding(5);
            this.btn_datos_personales.Name = "btn_datos_personales";
            this.btn_datos_personales.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_datos_personales.ShadowDecoration.Parent = this.btn_datos_personales;
            this.btn_datos_personales.Size = new System.Drawing.Size(183, 46);
            this.btn_datos_personales.TabIndex = 0;
            this.btn_datos_personales.Text = "Datos Personales";
            this.btn_datos_personales.Click += new System.EventHandler(this.btn_datos_personales_Click);
            // 
            // ActualizarFormulario
            // 
            this.ActualizarFormulario.Enabled = true;
            this.ActualizarFormulario.Tick += new System.EventHandler(this.ActualizarFormulario_Tick);
            // 
            // Matricula_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 607);
            this.Controls.Add(this.Panel_Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Matricula_main";
            this.Text = "Matricula";
            this.Load += new System.EventHandler(this.Matricula_main_Load);
            this.Panel_Contenedor.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.seccion_botones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Nav_sec_matricula.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel Nav_sec_matricula;
        private Guna.UI2.WinForms.Guna2Button btn_resp_secundario;
        private Guna.UI2.WinForms.Guna2Button btn_resp_principal;
        private Guna.UI2.WinForms.Guna2Button btn_datos_complemetarios;
        private Guna.UI2.WinForms.Guna2Button btn_situacion_familiar;
        private Guna.UI2.WinForms.Guna2Button btn_residencia_contacto;
        private Guna.UI2.WinForms.Guna2Button btn_datos_personales;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel seccion_botones;
        private System.Windows.Forms.Panel panel2;
        public Guna.UI2.WinForms.Guna2Button btn_guardar;
        public Guna.UI2.WinForms.Guna2Panel Panel_Contenedor;
        private System.Windows.Forms.Timer ActualizarFormulario;
        private Guna.UI2.WinForms.Guna2Button btn_cancelar;
        public System.Windows.Forms.TableLayoutPanel Panel_Contenedor_Secciones_Matricula;
        private System.Windows.Forms.Timer timer1;
    }
}