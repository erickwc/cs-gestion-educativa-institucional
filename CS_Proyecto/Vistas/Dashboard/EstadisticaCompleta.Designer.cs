namespace CS_Proyecto.Vistas.Dashboard
{
    partial class EstadisticaCompleta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dvg_estadistica = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_regresar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_guardar_registro = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbx_tipo_busqueda = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txt_buscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_estadistica)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1170, 607);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.Controls.Add(this.dvg_estadistica);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 212);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(25, 25, 25, 0);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1170, 395);
            this.guna2Panel1.TabIndex = 1;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // dvg_estadistica
            // 
            this.dvg_estadistica.AllowUserToAddRows = false;
            this.dvg_estadistica.AllowUserToDeleteRows = false;
            this.dvg_estadistica.AllowUserToResizeColumns = false;
            this.dvg_estadistica.AllowUserToResizeRows = false;
            this.dvg_estadistica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvg_estadistica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_estadistica.BackgroundColor = System.Drawing.Color.White;
            this.dvg_estadistica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvg_estadistica.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_estadistica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvg_estadistica.ColumnHeadersHeight = 45;
            this.dvg_estadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_estadistica.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvg_estadistica.EnableHeadersVisualStyles = false;
            this.dvg_estadistica.GridColor = System.Drawing.Color.White;
            this.dvg_estadistica.Location = new System.Drawing.Point(25, 92);
            this.dvg_estadistica.Name = "dvg_estadistica";
            this.dvg_estadistica.ReadOnly = true;
            this.dvg_estadistica.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvg_estadistica.RowHeadersVisible = false;
            this.dvg_estadistica.RowHeadersWidth = 50;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.dvg_estadistica.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dvg_estadistica.RowTemplate.Height = 55;
            this.dvg_estadistica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvg_estadistica.Size = new System.Drawing.Size(1119, 316);
            this.dvg_estadistica.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 52);
            this.panel1.TabIndex = 28;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.Controls.Add(this.btn_regresar);
            this.guna2Panel2.Controls.Add(this.btn_guardar_registro);
            this.guna2Panel2.Controls.Add(this.panel2);
            this.guna2Panel2.Controls.Add(this.panel13);
            this.guna2Panel2.Controls.Add(this.lbl_titulo);
            this.guna2Panel2.Controls.Add(this.lbl_descripcion);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1170, 202);
            this.guna2Panel2.TabIndex = 0;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_regresar.BorderRadius = 5;
            this.btn_regresar.CheckedState.Parent = this.btn_regresar;
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.CustomImages.Parent = this.btn_regresar;
            this.btn_regresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_regresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.ForeColor = System.Drawing.Color.White;
            this.btn_regresar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_regresar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_regresar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_regresar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_regresar.HoverState.Parent = this.btn_regresar;
            this.btn_regresar.Location = new System.Drawing.Point(939, 125);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_regresar.ShadowDecoration.Parent = this.btn_regresar;
            this.btn_regresar.Size = new System.Drawing.Size(205, 53);
            this.btn_regresar.TabIndex = 24;
            this.btn_regresar.Text = "Volver al Dashboard";
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_guardar_registro
            // 
            this.btn_guardar_registro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_guardar_registro.BorderRadius = 5;
            this.btn_guardar_registro.CheckedState.Parent = this.btn_guardar_registro;
            this.btn_guardar_registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar_registro.CustomImages.Parent = this.btn_guardar_registro;
            this.btn_guardar_registro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar_registro.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_registro.ForeColor = System.Drawing.Color.White;
            this.btn_guardar_registro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar_registro.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar_registro.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar_registro.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_guardar_registro.HoverState.Parent = this.btn_guardar_registro;
            this.btn_guardar_registro.Location = new System.Drawing.Point(1199, 121);
            this.btn_guardar_registro.Name = "btn_guardar_registro";
            this.btn_guardar_registro.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar_registro.ShadowDecoration.Parent = this.btn_guardar_registro;
            this.btn_guardar_registro.Size = new System.Drawing.Size(205, 53);
            this.btn_guardar_registro.TabIndex = 23;
            this.btn_guardar_registro.Text = "Volver al Dashboard";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cmbx_tipo_busqueda);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(38, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 78);
            this.panel2.TabIndex = 22;
            // 
            // cmbx_tipo_busqueda
            // 
            this.cmbx_tipo_busqueda.BackColor = System.Drawing.Color.Transparent;
            this.cmbx_tipo_busqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.cmbx_tipo_busqueda.BorderRadius = 5;
            this.cmbx_tipo_busqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbx_tipo_busqueda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbx_tipo_busqueda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbx_tipo_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_tipo_busqueda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.cmbx_tipo_busqueda.FocusedColor = System.Drawing.Color.Empty;
            this.cmbx_tipo_busqueda.FocusedState.Parent = this.cmbx_tipo_busqueda;
            this.cmbx_tipo_busqueda.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.cmbx_tipo_busqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.cmbx_tipo_busqueda.FormattingEnabled = true;
            this.cmbx_tipo_busqueda.HoverState.Parent = this.cmbx_tipo_busqueda;
            this.cmbx_tipo_busqueda.ItemHeight = 33;
            this.cmbx_tipo_busqueda.Items.AddRange(new object[] {
            "Docente",
            "Total",
            "Seccion"});
            this.cmbx_tipo_busqueda.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cmbx_tipo_busqueda.ItemsAppearance.Parent = this.cmbx_tipo_busqueda;
            this.cmbx_tipo_busqueda.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.cmbx_tipo_busqueda.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cmbx_tipo_busqueda.Location = new System.Drawing.Point(0, 39);
            this.cmbx_tipo_busqueda.Name = "cmbx_tipo_busqueda";
            this.cmbx_tipo_busqueda.ShadowDecoration.Parent = this.cmbx_tipo_busqueda;
            this.cmbx_tipo_busqueda.Size = new System.Drawing.Size(266, 39);
            this.cmbx_tipo_busqueda.TabIndex = 10;
            this.cmbx_tipo_busqueda.SelectionChangeCommitted += new System.EventHandler(this.cmbx_tipo_busqueda_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(-3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de busqueda";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.txt_buscar);
            this.panel13.Controls.Add(this.label1);
            this.panel13.Location = new System.Drawing.Point(339, 94);
            this.panel13.Margin = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(266, 78);
            this.panel13.TabIndex = 21;
            // 
            // txt_buscar
            // 
            this.txt_buscar.BorderRadius = 5;
            this.txt_buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_buscar.DefaultText = "";
            this.txt_buscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_buscar.DisabledState.FillColor = System.Drawing.Color.White;
            this.txt_buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_buscar.DisabledState.Parent = this.txt_buscar;
            this.txt_buscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_buscar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_buscar.Enabled = false;
            this.txt_buscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_buscar.FocusedState.Parent = this.txt_buscar;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.txt_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_buscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_buscar.HoverState.Parent = this.txt_buscar;
            this.txt_buscar.Location = new System.Drawing.Point(0, 39);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.PasswordChar = '\0';
            this.txt_buscar.PlaceholderText = "";
            this.txt_buscar.SelectedText = "";
            this.txt_buscar.ShadowDecoration.Parent = this.txt_buscar;
            this.txt_buscar.Size = new System.Drawing.Size(266, 39);
            this.txt_buscar.TabIndex = 7;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(-3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dato de busqueda";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_titulo.Location = new System.Drawing.Point(33, 26);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(352, 29);
            this.lbl_titulo.TabIndex = 19;
            this.lbl_titulo.Text = "Selecciona el método de búsqueda";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(34, 58);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbl_descripcion.Size = new System.Drawing.Size(389, 32);
            this.lbl_descripcion.TabIndex = 20;
            this.lbl_descripcion.Text = "Selecciona un Método para una búsqueda eficiente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.label10.Location = new System.Drawing.Point(3, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Secciónes creadas recientemente ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label11.Location = new System.Drawing.Point(3, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 22);
            this.label11.TabIndex = 6;
            this.label11.Text = "Estadistica General";
            // 
            // EstadisticaCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1170, 607);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstadisticaCompleta";
            this.Text = "EstadisticaCompleta";
            this.Load += new System.EventHandler(this.EstadisticaCompleta_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_estadistica)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView dvg_estadistica;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        public Guna.UI2.WinForms.Guna2Button btn_regresar;
        public Guna.UI2.WinForms.Guna2Button btn_guardar_registro;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbx_tipo_busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel13;
        private Guna.UI2.WinForms.Guna2TextBox txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}