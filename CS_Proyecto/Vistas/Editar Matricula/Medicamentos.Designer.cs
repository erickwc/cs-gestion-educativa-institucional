namespace CS_Proyecto.Vistas.Editar_Matricula
{
    partial class Medicamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_regresar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dosis_medicamento = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_frecuencia_medicamento = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_medicamento = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_tabla = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ActualizarForm = new System.Windows.Forms.Timer(this.components);
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btn_regresar_cerrar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_nueva_medicamento = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.separador = new Guna.UI2.WinForms.Guna2VSeparator();
            this.separador2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.dvg_med_alum = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_med_alum)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_regresar.BackColor = System.Drawing.Color.White;
            this.btn_regresar.BorderRadius = 5;
            this.btn_regresar.CheckedState.Parent = this.btn_regresar;
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.CustomImages.Parent = this.btn_regresar;
            this.btn_regresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_regresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_regresar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_regresar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_regresar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_regresar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_regresar.HoverState.Parent = this.btn_regresar;
            this.btn_regresar.Location = new System.Drawing.Point(786, 501);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_regresar.ShadowDecoration.Parent = this.btn_regresar;
            this.btn_regresar.Size = new System.Drawing.Size(208, 52);
            this.btn_regresar.TabIndex = 42;
            this.btn_regresar.Text = "Cancelar";
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_guardar.Location = new System.Drawing.Point(562, 501);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar.ShadowDecoration.Parent = this.btn_guardar;
            this.btn_guardar.Size = new System.Drawing.Size(208, 52);
            this.btn_guardar.TabIndex = 37;
            this.btn_guardar.Text = "Agregar medicamento";
            this.btn_guardar.Visible = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_dosis_medicamento);
            this.panel3.Location = new System.Drawing.Point(640, 199);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 78);
            this.panel3.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(-3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dosis";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_dosis_medicamento
            // 
            this.txt_dosis_medicamento.BorderRadius = 5;
            this.txt_dosis_medicamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dosis_medicamento.DefaultText = "";
            this.txt_dosis_medicamento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_dosis_medicamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_dosis_medicamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dosis_medicamento.DisabledState.Parent = this.txt_dosis_medicamento;
            this.txt_dosis_medicamento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dosis_medicamento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_dosis_medicamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_dosis_medicamento.FocusedState.Parent = this.txt_dosis_medicamento;
            this.txt_dosis_medicamento.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dosis_medicamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_dosis_medicamento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_dosis_medicamento.HoverState.Parent = this.txt_dosis_medicamento;
            this.txt_dosis_medicamento.Location = new System.Drawing.Point(0, 39);
            this.txt_dosis_medicamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_dosis_medicamento.Name = "txt_dosis_medicamento";
            this.txt_dosis_medicamento.PasswordChar = '\0';
            this.txt_dosis_medicamento.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.txt_dosis_medicamento.PlaceholderText = "";
            this.txt_dosis_medicamento.SelectedText = "";
            this.txt_dosis_medicamento.ShadowDecoration.Parent = this.txt_dosis_medicamento;
            this.txt_dosis_medicamento.Size = new System.Drawing.Size(354, 39);
            this.txt_dosis_medicamento.TabIndex = 0;
            this.txt_dosis_medicamento.TextChanged += new System.EventHandler(this.txt_dosis_medicamento_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_frecuencia_medicamento);
            this.panel1.Location = new System.Drawing.Point(258, 315);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 148);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Frecuencia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_frecuencia_medicamento
            // 
            this.txt_frecuencia_medicamento.BorderRadius = 5;
            this.txt_frecuencia_medicamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_frecuencia_medicamento.DefaultText = "";
            this.txt_frecuencia_medicamento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_frecuencia_medicamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_frecuencia_medicamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_frecuencia_medicamento.DisabledState.Parent = this.txt_frecuencia_medicamento;
            this.txt_frecuencia_medicamento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_frecuencia_medicamento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_frecuencia_medicamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_frecuencia_medicamento.FocusedState.Parent = this.txt_frecuencia_medicamento;
            this.txt_frecuencia_medicamento.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_frecuencia_medicamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_frecuencia_medicamento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_frecuencia_medicamento.HoverState.Parent = this.txt_frecuencia_medicamento;
            this.txt_frecuencia_medicamento.Location = new System.Drawing.Point(0, 30);
            this.txt_frecuencia_medicamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_frecuencia_medicamento.Multiline = true;
            this.txt_frecuencia_medicamento.Name = "txt_frecuencia_medicamento";
            this.txt_frecuencia_medicamento.PasswordChar = '\0';
            this.txt_frecuencia_medicamento.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.txt_frecuencia_medicamento.PlaceholderText = "";
            this.txt_frecuencia_medicamento.SelectedText = "";
            this.txt_frecuencia_medicamento.ShadowDecoration.Parent = this.txt_frecuencia_medicamento;
            this.txt_frecuencia_medicamento.Size = new System.Drawing.Size(736, 118);
            this.txt_frecuencia_medicamento.TabIndex = 0;
            this.txt_frecuencia_medicamento.TextChanged += new System.EventHandler(this.txt_frecuencia_medicamento_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_medicamento);
            this.panel2.Location = new System.Drawing.Point(259, 199);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 78);
            this.panel2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(-3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Medicamento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_medicamento
            // 
            this.txt_medicamento.BorderRadius = 5;
            this.txt_medicamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_medicamento.DefaultText = "";
            this.txt_medicamento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_medicamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_medicamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_medicamento.DisabledState.Parent = this.txt_medicamento;
            this.txt_medicamento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_medicamento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_medicamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_medicamento.FocusedState.Parent = this.txt_medicamento;
            this.txt_medicamento.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medicamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_medicamento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_medicamento.HoverState.Parent = this.txt_medicamento;
            this.txt_medicamento.Location = new System.Drawing.Point(0, 39);
            this.txt_medicamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_medicamento.Name = "txt_medicamento";
            this.txt_medicamento.PasswordChar = '\0';
            this.txt_medicamento.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.txt_medicamento.PlaceholderText = "";
            this.txt_medicamento.SelectedText = "";
            this.txt_medicamento.ShadowDecoration.Parent = this.txt_medicamento;
            this.txt_medicamento.Size = new System.Drawing.Size(354, 39);
            this.txt_medicamento.TabIndex = 0;
            this.txt_medicamento.TextChanged += new System.EventHandler(this.txt_medicamento_TextChanged);
            // 
            // panel_tabla
            // 
            this.panel_tabla.BorderRadius = 5;
            this.panel_tabla.Controls.Add(this.dvg_med_alum);
            this.panel_tabla.Controls.Add(this.label8);
            this.panel_tabla.Controls.Add(this.label7);
            this.panel_tabla.Controls.Add(this.label6);
            this.panel_tabla.FillColor = System.Drawing.Color.White;
            this.panel_tabla.Location = new System.Drawing.Point(-1, 123);
            this.panel_tabla.Margin = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.panel_tabla.Name = "panel_tabla";
            this.panel_tabla.ShadowDecoration.Parent = this.panel_tabla;
            this.panel_tabla.Size = new System.Drawing.Size(1261, 515);
            this.panel_tabla.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(638, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 60;
            this.label8.Text = "Frecuencia";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(340, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 59;
            this.label7.Text = "Dosis";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(38, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 58;
            this.label6.Text = "Medicamento";
            // 
            // ActualizarForm
            // 
            this.ActualizarForm.Enabled = true;
            this.ActualizarForm.Interval = 10;
            this.ActualizarForm.Tick += new System.EventHandler(this.ActualizarForm_Tick);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Location = new System.Drawing.Point(-1, 117);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1276, 10);
            this.guna2Separator1.TabIndex = 54;
            // 
            // btn_regresar_cerrar
            // 
            this.btn_regresar_cerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_regresar_cerrar.BackColor = System.Drawing.Color.White;
            this.btn_regresar_cerrar.BorderRadius = 5;
            this.btn_regresar_cerrar.CheckedState.Parent = this.btn_regresar_cerrar;
            this.btn_regresar_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar_cerrar.CustomImages.Parent = this.btn_regresar_cerrar;
            this.btn_regresar_cerrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_regresar_cerrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_regresar_cerrar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_regresar_cerrar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_regresar_cerrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_regresar_cerrar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_regresar_cerrar.HoverState.Parent = this.btn_regresar_cerrar;
            this.btn_regresar_cerrar.Location = new System.Drawing.Point(1022, 34);
            this.btn_regresar_cerrar.Name = "btn_regresar_cerrar";
            this.btn_regresar_cerrar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_regresar_cerrar.ShadowDecoration.Parent = this.btn_regresar_cerrar;
            this.btn_regresar_cerrar.Size = new System.Drawing.Size(198, 52);
            this.btn_regresar_cerrar.TabIndex = 58;
            this.btn_regresar_cerrar.Text = "Regresar";
            this.btn_regresar_cerrar.Click += new System.EventHandler(this.btn_regresar_cerrar_Click);
            // 
            // btn_nueva_medicamento
            // 
            this.btn_nueva_medicamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_nueva_medicamento.BorderRadius = 5;
            this.btn_nueva_medicamento.CheckedState.Parent = this.btn_nueva_medicamento;
            this.btn_nueva_medicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nueva_medicamento.CustomImages.Parent = this.btn_nueva_medicamento;
            this.btn_nueva_medicamento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_nueva_medicamento.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nueva_medicamento.ForeColor = System.Drawing.Color.White;
            this.btn_nueva_medicamento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_nueva_medicamento.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_nueva_medicamento.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_nueva_medicamento.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_nueva_medicamento.HoverState.Parent = this.btn_nueva_medicamento;
            this.btn_nueva_medicamento.Location = new System.Drawing.Point(803, 34);
            this.btn_nueva_medicamento.Name = "btn_nueva_medicamento";
            this.btn_nueva_medicamento.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_nueva_medicamento.ShadowDecoration.Parent = this.btn_nueva_medicamento;
            this.btn_nueva_medicamento.Size = new System.Drawing.Size(199, 52);
            this.btn_nueva_medicamento.TabIndex = 57;
            this.btn_nueva_medicamento.Text = "Nuevo Medicamento";
            this.btn_nueva_medicamento.Click += new System.EventHandler(this.btn_nueva_medicamento_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.label4.Location = new System.Drawing.Point(37, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Administra los medicamentos del empleado";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(37, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 55;
            this.label5.Text = "Medicamentos";
            // 
            // separador
            // 
            this.separador.Location = new System.Drawing.Point(601, 123);
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(12, 581);
            this.separador.TabIndex = 62;
            this.separador.Visible = false;
            this.separador.Click += new System.EventHandler(this.separador_Click);
            // 
            // separador2
            // 
            this.separador2.Location = new System.Drawing.Point(307, 123);
            this.separador2.Name = "separador2";
            this.separador2.Size = new System.Drawing.Size(12, 581);
            this.separador2.TabIndex = 61;
            this.separador2.Visible = false;
            this.separador2.Click += new System.EventHandler(this.separador2_Click);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_NEGATIVE;
            this.guna2AnimateWindow1.Interval = 150;
            // 
            // dvg_med_alum
            // 
            this.dvg_med_alum.AllowUserToAddRows = false;
            this.dvg_med_alum.AllowUserToDeleteRows = false;
            this.dvg_med_alum.AllowUserToResizeColumns = false;
            this.dvg_med_alum.AllowUserToResizeRows = false;
            this.dvg_med_alum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvg_med_alum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_med_alum.BackgroundColor = System.Drawing.Color.White;
            this.dvg_med_alum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvg_med_alum.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_med_alum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_med_alum.ColumnHeadersHeight = 45;
            this.dvg_med_alum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvg_med_alum.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_med_alum.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_med_alum.EnableHeadersVisualStyles = false;
            this.dvg_med_alum.GridColor = System.Drawing.Color.White;
            this.dvg_med_alum.Location = new System.Drawing.Point(38, 76);
            this.dvg_med_alum.Name = "dvg_med_alum";
            this.dvg_med_alum.ReadOnly = true;
            this.dvg_med_alum.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvg_med_alum.RowHeadersVisible = false;
            this.dvg_med_alum.RowHeadersWidth = 50;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.dvg_med_alum.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_med_alum.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 45, 55);
            this.dvg_med_alum.RowTemplate.Height = 55;
            this.dvg_med_alum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvg_med_alum.Size = new System.Drawing.Size(1447, 518);
            this.dvg_med_alum.TabIndex = 61;
            this.dvg_med_alum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_med_alum_CellContentClick);
            // 
            // Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 636);
            this.ControlBox = false;
            this.Controls.Add(this.separador);
            this.Controls.Add(this.separador2);
            this.Controls.Add(this.panel_tabla);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btn_regresar_cerrar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_nueva_medicamento);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Medicamentos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Medicamentos_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_tabla.ResumeLayout(false);
            this.panel_tabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_med_alum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_dosis_medicamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_frecuencia_medicamento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_medicamento;
        public Guna.UI2.WinForms.Guna2Button btn_guardar;
        private System.Windows.Forms.Timer ActualizarForm;
        private Guna.UI2.WinForms.Guna2Panel panel_tabla;
        private Guna.UI2.WinForms.Guna2Button btn_regresar;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btn_regresar_cerrar;
        public Guna.UI2.WinForms.Guna2Button btn_nueva_medicamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2VSeparator separador;
        private Guna.UI2.WinForms.Guna2VSeparator separador2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.DataGridView dvg_med_alum;
    }
}