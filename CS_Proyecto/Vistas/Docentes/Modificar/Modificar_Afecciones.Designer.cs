namespace CS_Proyecto.Vistas.Docentes.Modificar
{
    partial class Modificar_Afecciones
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
            this.ActualizarForm = new System.Windows.Forms.Timer(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tipo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_procedimiento = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_afeccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_regresar_cerrar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_nueva_afeccion = new Guna.UI2.WinForms.Guna2Button();
            this.separador2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.separador = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dvg_afecciones_docentes = new System.Windows.Forms.DataGridView();
            this.panel_tabla = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_afecciones_docentes)).BeginInit();
            this.panel_tabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActualizarForm
            // 
            this.ActualizarForm.Enabled = true;
            this.ActualizarForm.Interval = 1;
            this.ActualizarForm.Tick += new System.EventHandler(this.ActualizarForm_Tick);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_NEGATIVE;
            this.guna2AnimateWindow1.Interval = 150;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Location = new System.Drawing.Point(-3, 117);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1276, 10);
            this.guna2Separator1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.label1.Location = new System.Drawing.Point(41, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Administra las afecciónes del empleado";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(41, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Afecciones";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txt_tipo);
            this.panel4.Location = new System.Drawing.Point(644, 207);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 78);
            this.panel4.TabIndex = 35;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(-4, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de Afeccion";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_tipo
            // 
            this.txt_tipo.BorderRadius = 5;
            this.txt_tipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tipo.DefaultText = "";
            this.txt_tipo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tipo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tipo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tipo.DisabledState.Parent = this.txt_tipo;
            this.txt_tipo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tipo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_tipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_tipo.FocusedState.Parent = this.txt_tipo;
            this.txt_tipo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_tipo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_tipo.HoverState.Parent = this.txt_tipo;
            this.txt_tipo.Location = new System.Drawing.Point(0, 39);
            this.txt_tipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.PasswordChar = '\0';
            this.txt_tipo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.txt_tipo.PlaceholderText = "";
            this.txt_tipo.SelectedText = "";
            this.txt_tipo.ShadowDecoration.Parent = this.txt_tipo;
            this.txt_tipo.Size = new System.Drawing.Size(354, 39);
            this.txt_tipo.TabIndex = 2;
            this.txt_tipo.TextChanged += new System.EventHandler(this.txt_tipo_TextChanged_1);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_cancelar.Location = new System.Drawing.Point(800, 510);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar.ShadowDecoration.Parent = this.btn_cancelar;
            this.btn_cancelar.Size = new System.Drawing.Size(198, 52);
            this.btn_cancelar.TabIndex = 43;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.btn_guardar.Location = new System.Drawing.Point(581, 510);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar.ShadowDecoration.Parent = this.btn_guardar;
            this.btn_guardar.Size = new System.Drawing.Size(199, 52);
            this.btn_guardar.TabIndex = 37;
            this.btn_guardar.Text = "Agregar Afección";
            this.btn_guardar.Visible = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click_1);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_procedimiento);
            this.panel3.Location = new System.Drawing.Point(262, 314);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(736, 148);
            this.panel3.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(-5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Procedimiento medico";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_procedimiento
            // 
            this.txt_procedimiento.BorderRadius = 5;
            this.txt_procedimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_procedimiento.DefaultText = "";
            this.txt_procedimiento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_procedimiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_procedimiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_procedimiento.DisabledState.Parent = this.txt_procedimiento;
            this.txt_procedimiento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_procedimiento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_procedimiento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_procedimiento.FocusedState.Parent = this.txt_procedimiento;
            this.txt_procedimiento.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_procedimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_procedimiento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_procedimiento.HoverState.Parent = this.txt_procedimiento;
            this.txt_procedimiento.Location = new System.Drawing.Point(0, 39);
            this.txt_procedimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_procedimiento.Multiline = true;
            this.txt_procedimiento.Name = "txt_procedimiento";
            this.txt_procedimiento.PasswordChar = '\0';
            this.txt_procedimiento.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.txt_procedimiento.PlaceholderText = "";
            this.txt_procedimiento.SelectedText = "";
            this.txt_procedimiento.ShadowDecoration.Parent = this.txt_procedimiento;
            this.txt_procedimiento.Size = new System.Drawing.Size(736, 109);
            this.txt_procedimiento.TabIndex = 3;
            this.txt_procedimiento.TextChanged += new System.EventHandler(this.txt_procedimiento_TextChanged_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_afeccion);
            this.panel2.Location = new System.Drawing.Point(261, 207);
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
            this.label2.Text = "Afección";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_afeccion
            // 
            this.txt_afeccion.BorderRadius = 5;
            this.txt_afeccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_afeccion.DefaultText = "";
            this.txt_afeccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_afeccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_afeccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_afeccion.DisabledState.Parent = this.txt_afeccion;
            this.txt_afeccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_afeccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_afeccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_afeccion.FocusedState.Parent = this.txt_afeccion;
            this.txt_afeccion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_afeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_afeccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_afeccion.HoverState.Parent = this.txt_afeccion;
            this.txt_afeccion.Location = new System.Drawing.Point(0, 39);
            this.txt_afeccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_afeccion.Name = "txt_afeccion";
            this.txt_afeccion.PasswordChar = '\0';
            this.txt_afeccion.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.txt_afeccion.PlaceholderText = "";
            this.txt_afeccion.SelectedText = "";
            this.txt_afeccion.ShadowDecoration.Parent = this.txt_afeccion;
            this.txt_afeccion.Size = new System.Drawing.Size(354, 39);
            this.txt_afeccion.TabIndex = 1;
            this.txt_afeccion.TextChanged += new System.EventHandler(this.txt_afeccion_TextChanged_1);
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
            this.btn_regresar_cerrar.Location = new System.Drawing.Point(1033, 34);
            this.btn_regresar_cerrar.Name = "btn_regresar_cerrar";
            this.btn_regresar_cerrar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_regresar_cerrar.ShadowDecoration.Parent = this.btn_regresar_cerrar;
            this.btn_regresar_cerrar.Size = new System.Drawing.Size(198, 52);
            this.btn_regresar_cerrar.TabIndex = 48;
            this.btn_regresar_cerrar.Text = "Regresar";
            this.btn_regresar_cerrar.Click += new System.EventHandler(this.btn_regresar_cerrar_Click);
            // 
            // btn_nueva_afeccion
            // 
            this.btn_nueva_afeccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_nueva_afeccion.BorderRadius = 5;
            this.btn_nueva_afeccion.CheckedState.Parent = this.btn_nueva_afeccion;
            this.btn_nueva_afeccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nueva_afeccion.CustomImages.Parent = this.btn_nueva_afeccion;
            this.btn_nueva_afeccion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_nueva_afeccion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nueva_afeccion.ForeColor = System.Drawing.Color.White;
            this.btn_nueva_afeccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_nueva_afeccion.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_nueva_afeccion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_nueva_afeccion.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_nueva_afeccion.HoverState.Parent = this.btn_nueva_afeccion;
            this.btn_nueva_afeccion.Location = new System.Drawing.Point(814, 34);
            this.btn_nueva_afeccion.Name = "btn_nueva_afeccion";
            this.btn_nueva_afeccion.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_nueva_afeccion.ShadowDecoration.Parent = this.btn_nueva_afeccion;
            this.btn_nueva_afeccion.Size = new System.Drawing.Size(199, 52);
            this.btn_nueva_afeccion.TabIndex = 47;
            this.btn_nueva_afeccion.Text = "Nueva Afección";
            this.btn_nueva_afeccion.Click += new System.EventHandler(this.btn_nueva_afeccion_Click);
            // 
            // separador2
            // 
            this.separador2.Location = new System.Drawing.Point(263, 123);
            this.separador2.Name = "separador2";
            this.separador2.Size = new System.Drawing.Size(10, 581);
            this.separador2.TabIndex = 51;
            // 
            // separador
            // 
            this.separador.Location = new System.Drawing.Point(560, 123);
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(10, 581);
            this.separador.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(42, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "Afección";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(298, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 48;
            this.label7.Text = "Tipo";
            // 
            // dvg_afecciones_docentes
            // 
            this.dvg_afecciones_docentes.AllowUserToAddRows = false;
            this.dvg_afecciones_docentes.AllowUserToDeleteRows = false;
            this.dvg_afecciones_docentes.AllowUserToResizeColumns = false;
            this.dvg_afecciones_docentes.AllowUserToResizeRows = false;
            this.dvg_afecciones_docentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvg_afecciones_docentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_afecciones_docentes.BackgroundColor = System.Drawing.Color.White;
            this.dvg_afecciones_docentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvg_afecciones_docentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_afecciones_docentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_afecciones_docentes.ColumnHeadersHeight = 45;
            this.dvg_afecciones_docentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvg_afecciones_docentes.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_afecciones_docentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_afecciones_docentes.EnableHeadersVisualStyles = false;
            this.dvg_afecciones_docentes.GridColor = System.Drawing.Color.White;
            this.dvg_afecciones_docentes.Location = new System.Drawing.Point(42, 85);
            this.dvg_afecciones_docentes.Name = "dvg_afecciones_docentes";
            this.dvg_afecciones_docentes.ReadOnly = true;
            this.dvg_afecciones_docentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvg_afecciones_docentes.RowHeadersVisible = false;
            this.dvg_afecciones_docentes.RowHeadersWidth = 50;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.dvg_afecciones_docentes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_afecciones_docentes.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 45, 55);
            this.dvg_afecciones_docentes.RowTemplate.Height = 100;
            this.dvg_afecciones_docentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvg_afecciones_docentes.Size = new System.Drawing.Size(1245, 512);
            this.dvg_afecciones_docentes.TabIndex = 50;
            this.dvg_afecciones_docentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_afecciones_docentes_CellContentClick);
            // 
            // panel_tabla
            // 
            this.panel_tabla.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_tabla.BorderRadius = 5;
            this.panel_tabla.Controls.Add(this.dvg_afecciones_docentes);
            this.panel_tabla.Controls.Add(this.label8);
            this.panel_tabla.Controls.Add(this.label7);
            this.panel_tabla.Controls.Add(this.label6);
            this.panel_tabla.FillColor = System.Drawing.Color.White;
            this.panel_tabla.Location = new System.Drawing.Point(-3, 123);
            this.panel_tabla.Margin = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.panel_tabla.Name = "panel_tabla";
            this.panel_tabla.ShadowDecoration.Parent = this.panel_tabla;
            this.panel_tabla.Size = new System.Drawing.Size(1267, 581);
            this.panel_tabla.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(588, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 19);
            this.label8.TabIndex = 49;
            this.label8.Text = "Procedimiento";
            // 
            // Modificar_Afecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 704);
            this.ControlBox = false;
            this.Controls.Add(this.separador);
            this.Controls.Add(this.separador2);
            this.Controls.Add(this.btn_regresar_cerrar);
            this.Controls.Add(this.btn_nueva_afeccion);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.panel_tabla);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modificar_Afecciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modificar_Afecciones_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_afecciones_docentes)).EndInit();
            this.panel_tabla.ResumeLayout(false);
            this.panel_tabla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer ActualizarForm;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_tipo;
        private Guna.UI2.WinForms.Guna2Button btn_cancelar;
        public Guna.UI2.WinForms.Guna2Button btn_guardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_procedimiento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_afeccion;
        private Guna.UI2.WinForms.Guna2Button btn_regresar_cerrar;
        public Guna.UI2.WinForms.Guna2Button btn_nueva_afeccion;
        private Guna.UI2.WinForms.Guna2VSeparator separador2;
        private Guna.UI2.WinForms.Guna2VSeparator separador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dvg_afecciones_docentes;
        private Guna.UI2.WinForms.Guna2Panel panel_tabla;
        private System.Windows.Forms.Label label8;
    }
}