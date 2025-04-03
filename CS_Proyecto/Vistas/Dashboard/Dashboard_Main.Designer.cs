namespace CS_Proyecto.Vistas.Dashboard
{
    partial class Dashboard_Main
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pict_img_perfil = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_modo = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.lbl_seccion_actual = new System.Windows.Forms.Label();
            this.Panel_Contenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.BarraLateral = new System.Windows.Forms.Panel();
            this.btn_reportes = new Guna.UI2.WinForms.Guna2Button();
            this.btn_instituciones = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Nie_Temporal = new Guna.UI2.WinForms.Guna2Button();
            this.btn_perfil = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cerrarsesion = new Guna.UI2.WinForms.Guna2Button();
            this.btn_comprobante = new Guna.UI2.WinForms.Guna2Button();
            this.btn_letrapago = new Guna.UI2.WinForms.Guna2Button();
            this.btn_usuarios = new Guna.UI2.WinForms.Guna2Button();
            this.btn_dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btn_desplegar = new Guna.UI2.WinForms.Guna2Button();
            this.ActualizarFoto = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_img_perfil)).BeginInit();
            this.BarraLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Panel_Contenedor, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(74, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1141, 718);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.Controls.Add(this.pict_img_perfil);
            this.guna2Panel2.Controls.Add(this.btn_modo);
            this.guna2Panel2.Controls.Add(this.lbl_usuario);
            this.guna2Panel2.Controls.Add(this.lbl_rol);
            this.guna2Panel2.Controls.Add(this.lbl_seccion_actual);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Panel2.Location = new System.Drawing.Point(10, 10);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1121, 47);
            this.guna2Panel2.TabIndex = 1;
            // 
            // pict_img_perfil
            // 
            this.pict_img_perfil.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pict_img_perfil.BorderRadius = 5;
            this.pict_img_perfil.Image = global::CS_Proyecto.Properties.Resources.ImgPerfil;
            this.pict_img_perfil.Location = new System.Drawing.Point(964, 4);
            this.pict_img_perfil.Name = "pict_img_perfil";
            this.pict_img_perfil.ShadowDecoration.Parent = this.pict_img_perfil;
            this.pict_img_perfil.Size = new System.Drawing.Size(38, 38);
            this.pict_img_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pict_img_perfil.TabIndex = 12;
            this.pict_img_perfil.TabStop = false;
            // 
            // btn_modo
            // 
            this.btn_modo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_modo.BorderRadius = 5;
            this.btn_modo.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_modo.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_modo.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_modo.CheckedState.Parent = this.btn_modo;
            this.btn_modo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modo.CustomImages.Parent = this.btn_modo;
            this.btn_modo.FillColor = System.Drawing.Color.White;
            this.btn_modo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_modo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btn_modo.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_modo.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_modo.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_modo.HoverState.Parent = this.btn_modo;
            this.btn_modo.Image = global::CS_Proyecto.Properties.Resources.Modo_e;
            this.btn_modo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_modo.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_modo.ImageSize = new System.Drawing.Size(18, 21);
            this.btn_modo.Location = new System.Drawing.Point(917, 3);
            this.btn_modo.Name = "btn_modo";
            this.btn_modo.PressedColor = System.Drawing.Color.White;
            this.btn_modo.ShadowDecoration.Parent = this.btn_modo;
            this.btn_modo.Size = new System.Drawing.Size(44, 40);
            this.btn_modo.TabIndex = 10;
            this.btn_modo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_modo.TextOffset = new System.Drawing.Point(25, 0);
            this.btn_modo.Visible = false;
            this.btn_modo.Click += new System.EventHandler(this.btn_modo_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_usuario.Location = new System.Drawing.Point(1009, 5);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(63, 19);
            this.lbl_usuario.TabIndex = 8;
            this.lbl_usuario.Text = "Usuario";
            this.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_rol
            // 
            this.lbl_rol.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbl_rol.Location = new System.Drawing.Point(1007, 22);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(64, 19);
            this.lbl_rol.TabIndex = 9;
            this.lbl_rol.Text = "Privilegio";
            this.lbl_rol.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_seccion_actual
            // 
            this.lbl_seccion_actual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_seccion_actual.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seccion_actual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_seccion_actual.Location = new System.Drawing.Point(22, 3);
            this.lbl_seccion_actual.Name = "lbl_seccion_actual";
            this.lbl_seccion_actual.Size = new System.Drawing.Size(370, 40);
            this.lbl_seccion_actual.TabIndex = 7;
            this.lbl_seccion_actual.Text = "Dashboard";
            this.lbl_seccion_actual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel_Contenedor
            // 
            this.Panel_Contenedor.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Contenedor.BorderRadius = 5;
            this.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Contenedor.FillColor = System.Drawing.Color.White;
            this.Panel_Contenedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Panel_Contenedor.Location = new System.Drawing.Point(10, 67);
            this.Panel_Contenedor.Margin = new System.Windows.Forms.Padding(10);
            this.Panel_Contenedor.Name = "Panel_Contenedor";
            this.Panel_Contenedor.ShadowDecoration.Parent = this.Panel_Contenedor;
            this.Panel_Contenedor.Size = new System.Drawing.Size(1121, 641);
            this.Panel_Contenedor.TabIndex = 0;
            // 
            // BarraLateral
            // 
            this.BarraLateral.BackColor = System.Drawing.Color.White;
            this.BarraLateral.Controls.Add(this.btn_reportes);
            this.BarraLateral.Controls.Add(this.btn_instituciones);
            this.BarraLateral.Controls.Add(this.btn_Nie_Temporal);
            this.BarraLateral.Controls.Add(this.btn_perfil);
            this.BarraLateral.Controls.Add(this.btn_cerrarsesion);
            this.BarraLateral.Controls.Add(this.btn_comprobante);
            this.BarraLateral.Controls.Add(this.btn_letrapago);
            this.BarraLateral.Controls.Add(this.btn_usuarios);
            this.BarraLateral.Controls.Add(this.btn_dashboard);
            this.BarraLateral.Controls.Add(this.btn_desplegar);
            this.BarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraLateral.Location = new System.Drawing.Point(0, 0);
            this.BarraLateral.Name = "BarraLateral";
            this.BarraLateral.Size = new System.Drawing.Size(74, 718);
            this.BarraLateral.TabIndex = 2;
            // 
            // btn_reportes
            // 
            this.btn_reportes.BorderRadius = 5;
            this.btn_reportes.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_reportes.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_reportes.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_reportes.CheckedState.Parent = this.btn_reportes;
            this.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reportes.CustomImages.Parent = this.btn_reportes;
            this.btn_reportes.FillColor = System.Drawing.Color.White;
            this.btn_reportes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_reportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btn_reportes.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_reportes.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_reportes.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_reportes.HoverState.Parent = this.btn_reportes;
            this.btn_reportes.Image = global::CS_Proyecto.Properties.Resources.Reportes_e;
            this.btn_reportes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_reportes.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_reportes.Location = new System.Drawing.Point(12, 232);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.PressedColor = System.Drawing.Color.White;
            this.btn_reportes.ShadowDecoration.Parent = this.btn_reportes;
            this.btn_reportes.Size = new System.Drawing.Size(50, 50);
            this.btn_reportes.TabIndex = 3;
            this.btn_reportes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_reportes.TextOffset = new System.Drawing.Point(23, 0);
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click_1);
            // 
            // btn_instituciones
            // 
            this.btn_instituciones.BorderRadius = 5;
            this.btn_instituciones.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_instituciones.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_instituciones.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_instituciones.CheckedState.Parent = this.btn_instituciones;
            this.btn_instituciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_instituciones.CustomImages.Parent = this.btn_instituciones;
            this.btn_instituciones.FillColor = System.Drawing.Color.White;
            this.btn_instituciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_instituciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btn_instituciones.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_instituciones.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_instituciones.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_instituciones.HoverState.Parent = this.btn_instituciones;
            this.btn_instituciones.Image = global::CS_Proyecto.Properties.Resources.Mantenimiento_e;
            this.btn_instituciones.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_instituciones.ImageOffset = new System.Drawing.Point(4, 0);
            this.btn_instituciones.ImageSize = new System.Drawing.Size(21, 21);
            this.btn_instituciones.Location = new System.Drawing.Point(12, 516);
            this.btn_instituciones.Name = "btn_instituciones";
            this.btn_instituciones.PressedColor = System.Drawing.Color.White;
            this.btn_instituciones.ShadowDecoration.Parent = this.btn_instituciones;
            this.btn_instituciones.Size = new System.Drawing.Size(50, 50);
            this.btn_instituciones.TabIndex = 10;
            this.btn_instituciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_instituciones.TextOffset = new System.Drawing.Point(23, 0);
            this.btn_instituciones.Click += new System.EventHandler(this.btn_instituciones_Click);
            // 
            // btn_Nie_Temporal
            // 
            this.btn_Nie_Temporal.BorderRadius = 5;
            this.btn_Nie_Temporal.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_Nie_Temporal.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_Nie_Temporal.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_Nie_Temporal.CheckedState.Parent = this.btn_Nie_Temporal;
            this.btn_Nie_Temporal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nie_Temporal.CustomImages.Parent = this.btn_Nie_Temporal;
            this.btn_Nie_Temporal.FillColor = System.Drawing.Color.White;
            this.btn_Nie_Temporal.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_Nie_Temporal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btn_Nie_Temporal.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_Nie_Temporal.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_Nie_Temporal.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Nie_Temporal.HoverState.Parent = this.btn_Nie_Temporal;
            this.btn_Nie_Temporal.Image = global::CS_Proyecto.Properties.Resources.Nie_temporal_e;
            this.btn_Nie_Temporal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Nie_Temporal.ImageOffset = new System.Drawing.Point(3, 0);
            this.btn_Nie_Temporal.ImageSize = new System.Drawing.Size(22, 22);
            this.btn_Nie_Temporal.Location = new System.Drawing.Point(12, 445);
            this.btn_Nie_Temporal.Name = "btn_Nie_Temporal";
            this.btn_Nie_Temporal.PressedColor = System.Drawing.Color.White;
            this.btn_Nie_Temporal.ShadowDecoration.Parent = this.btn_Nie_Temporal;
            this.btn_Nie_Temporal.Size = new System.Drawing.Size(50, 50);
            this.btn_Nie_Temporal.TabIndex = 9;
            this.btn_Nie_Temporal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Nie_Temporal.TextOffset = new System.Drawing.Point(23, 0);
            this.btn_Nie_Temporal.Click += new System.EventHandler(this.btn_Nie_Temporal_Click);
            // 
            // btn_perfil
            // 
            this.btn_perfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_perfil.BorderRadius = 5;
            this.btn_perfil.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_perfil.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_perfil.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_perfil.CheckedState.Parent = this.btn_perfil;
            this.btn_perfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_perfil.CustomImages.Parent = this.btn_perfil;
            this.btn_perfil.FillColor = System.Drawing.Color.White;
            this.btn_perfil.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_perfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btn_perfil.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_perfil.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_perfil.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_perfil.HoverState.Parent = this.btn_perfil;
            this.btn_perfil.Image = global::CS_Proyecto.Properties.Resources.Mi_Perfil_e;
            this.btn_perfil.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_perfil.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_perfil.ImageSize = new System.Drawing.Size(19, 19);
            this.btn_perfil.Location = new System.Drawing.Point(12, 590);
            this.btn_perfil.Name = "btn_perfil";
            this.btn_perfil.PressedColor = System.Drawing.Color.White;
            this.btn_perfil.ShadowDecoration.Parent = this.btn_perfil;
            this.btn_perfil.Size = new System.Drawing.Size(50, 50);
            this.btn_perfil.TabIndex = 8;
            this.btn_perfil.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_perfil.TextOffset = new System.Drawing.Point(26, 0);
            this.btn_perfil.Click += new System.EventHandler(this.btn_perfil_Click_1);
            // 
            // btn_cerrarsesion
            // 
            this.btn_cerrarsesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cerrarsesion.BorderRadius = 5;
            this.btn_cerrarsesion.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_cerrarsesion.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_cerrarsesion.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_cerrarsesion.CheckedState.Parent = this.btn_cerrarsesion;
            this.btn_cerrarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrarsesion.CustomImages.Parent = this.btn_cerrarsesion;
            this.btn_cerrarsesion.FillColor = System.Drawing.Color.White;
            this.btn_cerrarsesion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_cerrarsesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btn_cerrarsesion.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_cerrarsesion.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_cerrarsesion.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_cerrarsesion.HoverState.Parent = this.btn_cerrarsesion;
            this.btn_cerrarsesion.Image = global::CS_Proyecto.Properties.Resources.Salir_e;
            this.btn_cerrarsesion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_cerrarsesion.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_cerrarsesion.ImageSize = new System.Drawing.Size(20, 19);
            this.btn_cerrarsesion.Location = new System.Drawing.Point(12, 658);
            this.btn_cerrarsesion.Name = "btn_cerrarsesion";
            this.btn_cerrarsesion.PressedColor = System.Drawing.Color.White;
            this.btn_cerrarsesion.ShadowDecoration.Parent = this.btn_cerrarsesion;
            this.btn_cerrarsesion.Size = new System.Drawing.Size(50, 50);
            this.btn_cerrarsesion.TabIndex = 7;
            this.btn_cerrarsesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_cerrarsesion.TextOffset = new System.Drawing.Point(26, 0);
            this.btn_cerrarsesion.Click += new System.EventHandler(this.btn_cerrarsesion_Click);
            // 
            // btn_comprobante
            // 
            this.btn_comprobante.BorderRadius = 5;
            this.btn_comprobante.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_comprobante.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_comprobante.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_comprobante.CheckedState.Parent = this.btn_comprobante;
            this.btn_comprobante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comprobante.CustomImages.Parent = this.btn_comprobante;
            this.btn_comprobante.FillColor = System.Drawing.Color.White;
            this.btn_comprobante.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_comprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btn_comprobante.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_comprobante.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_comprobante.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_comprobante.HoverState.Parent = this.btn_comprobante;
            this.btn_comprobante.Image = global::CS_Proyecto.Properties.Resources.Comprobante_e;
            this.btn_comprobante.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_comprobante.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_comprobante.ImageSize = new System.Drawing.Size(18, 22);
            this.btn_comprobante.Location = new System.Drawing.Point(12, 161);
            this.btn_comprobante.Name = "btn_comprobante";
            this.btn_comprobante.PressedColor = System.Drawing.Color.White;
            this.btn_comprobante.ShadowDecoration.Parent = this.btn_comprobante;
            this.btn_comprobante.Size = new System.Drawing.Size(50, 50);
            this.btn_comprobante.TabIndex = 6;
            this.btn_comprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_comprobante.TextOffset = new System.Drawing.Point(25, 0);
            this.btn_comprobante.Click += new System.EventHandler(this.btn_comprobante_Click);
            // 
            // btn_letrapago
            // 
            this.btn_letrapago.BorderRadius = 5;
            this.btn_letrapago.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_letrapago.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_letrapago.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_letrapago.CheckedState.Parent = this.btn_letrapago;
            this.btn_letrapago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_letrapago.CustomImages.Parent = this.btn_letrapago;
            this.btn_letrapago.FillColor = System.Drawing.Color.White;
            this.btn_letrapago.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_letrapago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btn_letrapago.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_letrapago.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_letrapago.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_letrapago.HoverState.Parent = this.btn_letrapago;
            this.btn_letrapago.Image = global::CS_Proyecto.Properties.Resources.Letra_Pago_e;
            this.btn_letrapago.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_letrapago.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_letrapago.ImageSize = new System.Drawing.Size(18, 21);
            this.btn_letrapago.Location = new System.Drawing.Point(12, 374);
            this.btn_letrapago.Name = "btn_letrapago";
            this.btn_letrapago.PressedColor = System.Drawing.Color.White;
            this.btn_letrapago.ShadowDecoration.Parent = this.btn_letrapago;
            this.btn_letrapago.Size = new System.Drawing.Size(50, 50);
            this.btn_letrapago.TabIndex = 5;
            this.btn_letrapago.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_letrapago.TextOffset = new System.Drawing.Point(25, 0);
            this.btn_letrapago.Click += new System.EventHandler(this.btn_letrapago_Click_1);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.BorderRadius = 5;
            this.btn_usuarios.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_usuarios.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_usuarios.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_usuarios.CheckedState.Parent = this.btn_usuarios;
            this.btn_usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usuarios.CustomImages.Parent = this.btn_usuarios;
            this.btn_usuarios.FillColor = System.Drawing.Color.White;
            this.btn_usuarios.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_usuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btn_usuarios.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_usuarios.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_usuarios.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_usuarios.HoverState.Parent = this.btn_usuarios;
            this.btn_usuarios.Image = global::CS_Proyecto.Properties.Resources.Usuarios_e;
            this.btn_usuarios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_usuarios.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_usuarios.ImageSize = new System.Drawing.Size(18, 18);
            this.btn_usuarios.Location = new System.Drawing.Point(12, 302);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.PressedColor = System.Drawing.Color.White;
            this.btn_usuarios.ShadowDecoration.Parent = this.btn_usuarios;
            this.btn_usuarios.Size = new System.Drawing.Size(50, 50);
            this.btn_usuarios.TabIndex = 4;
            this.btn_usuarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_usuarios.TextOffset = new System.Drawing.Point(25, 0);
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click_1);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BorderRadius = 5;
            this.btn_dashboard.CheckedState.Parent = this.btn_dashboard;
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.CustomImages.Parent = this.btn_dashboard;
            this.btn_dashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_dashboard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_dashboard.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_dashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_dashboard.HoverState.Parent = this.btn_dashboard;
            this.btn_dashboard.Image = global::CS_Proyecto.Properties.Resources.Dashboard;
            this.btn_dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_dashboard.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_dashboard.ImageSize = new System.Drawing.Size(20, 18);
            this.btn_dashboard.Location = new System.Drawing.Point(12, 91);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.PressedColor = System.Drawing.Color.White;
            this.btn_dashboard.ShadowDecoration.Parent = this.btn_dashboard;
            this.btn_dashboard.Size = new System.Drawing.Size(50, 50);
            this.btn_dashboard.TabIndex = 2;
            this.btn_dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_dashboard.TextOffset = new System.Drawing.Point(23, 0);
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click_1);
            // 
            // btn_desplegar
            // 
            this.btn_desplegar.CheckedState.Parent = this.btn_desplegar;
            this.btn_desplegar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_desplegar.CustomImages.Parent = this.btn_desplegar;
            this.btn_desplegar.FillColor = System.Drawing.Color.White;
            this.btn_desplegar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_desplegar.ForeColor = System.Drawing.Color.White;
            this.btn_desplegar.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_desplegar.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_desplegar.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_desplegar.HoverState.Parent = this.btn_desplegar;
            this.btn_desplegar.Image = global::CS_Proyecto.Properties.Resources.Menu;
            this.btn_desplegar.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_desplegar.Location = new System.Drawing.Point(12, 12);
            this.btn_desplegar.Name = "btn_desplegar";
            this.btn_desplegar.PressedColor = System.Drawing.Color.White;
            this.btn_desplegar.ShadowDecoration.Parent = this.btn_desplegar;
            this.btn_desplegar.Size = new System.Drawing.Size(50, 50);
            this.btn_desplegar.TabIndex = 1;
            this.btn_desplegar.Click += new System.EventHandler(this.btn_desplegar_Click_1);
            // 
            // ActualizarFoto
            // 
            this.ActualizarFoto.Enabled = true;
            this.ActualizarFoto.Tick += new System.EventHandler(this.ActualizarFoto_Tick);
            // 
            // Dashboard_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1215, 718);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BarraLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_Main_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_img_perfil)).EndInit();
            this.BarraLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Panel BarraLateral;
        private Guna.UI2.WinForms.Guna2Button btn_desplegar;
        public System.Windows.Forms.Label lbl_seccion_actual;
        public System.Windows.Forms.Label lbl_rol;
        public System.Windows.Forms.Label lbl_usuario;
        public Guna.UI2.WinForms.Guna2Button btn_perfil;
        public Guna.UI2.WinForms.Guna2Button btn_cerrarsesion;
        public Guna.UI2.WinForms.Guna2Button btn_comprobante;
        public Guna.UI2.WinForms.Guna2Button btn_letrapago;
        public Guna.UI2.WinForms.Guna2Button btn_usuarios;
        public Guna.UI2.WinForms.Guna2Button btn_reportes;
        public Guna.UI2.WinForms.Guna2Button btn_dashboard;
        public Guna.UI2.WinForms.Guna2Button btn_Nie_Temporal;
        public Guna.UI2.WinForms.Guna2Button btn_modo;
        public Guna.UI2.WinForms.Guna2Button btn_instituciones;
        public Guna.UI2.WinForms.Guna2Panel Panel_Contenedor;
        private Guna.UI2.WinForms.Guna2PictureBox pict_img_perfil;
        private System.Windows.Forms.Timer ActualizarFoto;
    }
}