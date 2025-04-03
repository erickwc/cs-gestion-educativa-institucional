namespace CS_Proyecto.Vistas.Reportes
{
    partial class VistaPreviaReporte
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
            this.img_reporte = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_regresar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.btn_matricula_part1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_matricula_part2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_matricula_part3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_alumnos = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_empleados = new Guna.UI2.WinForms.Guna2Panel();
            this.EmpleadoPart1 = new Guna.UI2.WinForms.Guna2Panel();
            this.EmpleadoPart2 = new Guna.UI2.WinForms.Guna2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.img_reporte)).BeginInit();
            this.btn_alumnos.SuspendLayout();
            this.btn_empleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_reporte
            // 
            this.img_reporte.BorderRadius = 15;
            this.img_reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_reporte.Image = global::CS_Proyecto.Properties.Resources.Usuario_Individual;
            this.img_reporte.Location = new System.Drawing.Point(0, 0);
            this.img_reporte.Name = "img_reporte";
            this.img_reporte.ShadowDecoration.Parent = this.img_reporte;
            this.img_reporte.Size = new System.Drawing.Size(520, 741);
            this.img_reporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_reporte.TabIndex = 0;
            this.img_reporte.TabStop = false;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_regresar.Location = new System.Drawing.Point(24, 662);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_regresar.ShadowDecoration.Parent = this.btn_regresar;
            this.btn_regresar.Size = new System.Drawing.Size(472, 50);
            this.btn_regresar.TabIndex = 54;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.Interval = 200;
            // 
            // btn_matricula_part1
            // 
            this.btn_matricula_part1.BorderRadius = 5;
            this.btn_matricula_part1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_matricula_part1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_matricula_part1.Location = new System.Drawing.Point(20, 11);
            this.btn_matricula_part1.Name = "btn_matricula_part1";
            this.btn_matricula_part1.ShadowDecoration.Parent = this.btn_matricula_part1;
            this.btn_matricula_part1.Size = new System.Drawing.Size(13, 13);
            this.btn_matricula_part1.TabIndex = 56;
            this.btn_matricula_part1.Click += new System.EventHandler(this.btn_matricula_part1_Click);
            // 
            // btn_matricula_part2
            // 
            this.btn_matricula_part2.BorderRadius = 5;
            this.btn_matricula_part2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_matricula_part2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_matricula_part2.Location = new System.Drawing.Point(43, 11);
            this.btn_matricula_part2.Name = "btn_matricula_part2";
            this.btn_matricula_part2.ShadowDecoration.Parent = this.btn_matricula_part2;
            this.btn_matricula_part2.Size = new System.Drawing.Size(13, 13);
            this.btn_matricula_part2.TabIndex = 57;
            this.btn_matricula_part2.Click += new System.EventHandler(this.btn_matricula_part2_Click);
            // 
            // btn_matricula_part3
            // 
            this.btn_matricula_part3.BorderRadius = 5;
            this.btn_matricula_part3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_matricula_part3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_matricula_part3.Location = new System.Drawing.Point(67, 11);
            this.btn_matricula_part3.Name = "btn_matricula_part3";
            this.btn_matricula_part3.ShadowDecoration.Parent = this.btn_matricula_part3;
            this.btn_matricula_part3.Size = new System.Drawing.Size(13, 13);
            this.btn_matricula_part3.TabIndex = 57;
            this.btn_matricula_part3.Click += new System.EventHandler(this.btn_matricula_part3_Click);
            // 
            // btn_alumnos
            // 
            this.btn_alumnos.BorderRadius = 15;
            this.btn_alumnos.Controls.Add(this.btn_matricula_part3);
            this.btn_alumnos.Controls.Add(this.btn_matricula_part1);
            this.btn_alumnos.Controls.Add(this.btn_matricula_part2);
            this.btn_alumnos.Location = new System.Drawing.Point(212, 621);
            this.btn_alumnos.Name = "btn_alumnos";
            this.btn_alumnos.ShadowDecoration.Parent = this.btn_alumnos;
            this.btn_alumnos.Size = new System.Drawing.Size(100, 35);
            this.btn_alumnos.TabIndex = 58;
            this.btn_alumnos.Visible = false;
            // 
            // btn_empleados
            // 
            this.btn_empleados.BorderRadius = 15;
            this.btn_empleados.Controls.Add(this.EmpleadoPart1);
            this.btn_empleados.Controls.Add(this.EmpleadoPart2);
            this.btn_empleados.Location = new System.Drawing.Point(212, 620);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.ShadowDecoration.Parent = this.btn_empleados;
            this.btn_empleados.Size = new System.Drawing.Size(100, 35);
            this.btn_empleados.TabIndex = 59;
            this.btn_empleados.Visible = false;
            // 
            // EmpleadoPart1
            // 
            this.EmpleadoPart1.BorderRadius = 5;
            this.EmpleadoPart1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpleadoPart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.EmpleadoPart1.Location = new System.Drawing.Point(32, 11);
            this.EmpleadoPart1.Name = "EmpleadoPart1";
            this.EmpleadoPart1.ShadowDecoration.Parent = this.EmpleadoPart1;
            this.EmpleadoPart1.Size = new System.Drawing.Size(13, 13);
            this.EmpleadoPart1.TabIndex = 56;
            this.EmpleadoPart1.Click += new System.EventHandler(this.EmpleadoPart1_Click);
            this.EmpleadoPart1.Paint += new System.Windows.Forms.PaintEventHandler(this.EmpleadoPart1_Paint);
            // 
            // EmpleadoPart2
            // 
            this.EmpleadoPart2.BorderRadius = 5;
            this.EmpleadoPart2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpleadoPart2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.EmpleadoPart2.Location = new System.Drawing.Point(55, 11);
            this.EmpleadoPart2.Name = "EmpleadoPart2";
            this.EmpleadoPart2.ShadowDecoration.Parent = this.EmpleadoPart2;
            this.EmpleadoPart2.Size = new System.Drawing.Size(13, 13);
            this.EmpleadoPart2.TabIndex = 57;
            this.EmpleadoPart2.Click += new System.EventHandler(this.EmpleadoPart2_Click);
            this.EmpleadoPart2.Paint += new System.Windows.Forms.PaintEventHandler(this.EmpleadoPart2_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VistaPreviaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 741);
            this.Controls.Add(this.btn_empleados);
            this.Controls.Add(this.btn_alumnos);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.img_reporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaPreviaReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VistaPreviaReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_reporte)).EndInit();
            this.btn_alumnos.ResumeLayout(false);
            this.btn_empleados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox img_reporte;
        public Guna.UI2.WinForms.Guna2Button btn_regresar;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel btn_matricula_part1;
        private Guna.UI2.WinForms.Guna2Panel btn_matricula_part2;
        private Guna.UI2.WinForms.Guna2Panel btn_matricula_part3;
        private Guna.UI2.WinForms.Guna2Panel btn_alumnos;
        private Guna.UI2.WinForms.Guna2Panel btn_empleados;
        private Guna.UI2.WinForms.Guna2Panel EmpleadoPart1;
        private Guna.UI2.WinForms.Guna2Panel EmpleadoPart2;
        private System.Windows.Forms.Timer timer1;
    }
}