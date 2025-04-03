namespace CS_Proyecto.Vistas.Desactivar_Alumnos
{
    partial class Desactivacion_part5
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barra_progreso = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.c1 = new Guna.UI2.WinForms.Guna2Panel();
            this.c2 = new Guna.UI2.WinForms.Guna2Panel();
            this.c3 = new Guna.UI2.WinForms.Guna2Panel();
            this.c4 = new Guna.UI2.WinForms.Guna2Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Timer_loader_carpetas = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_titulo.Location = new System.Drawing.Point(53, 199);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(563, 25);
            this.lbl_titulo.TabIndex = 42;
            this.lbl_titulo.Text = "Inactivando todos los Alumnos";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(53, 235);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbl_descripcion.Size = new System.Drawing.Size(563, 30);
            this.lbl_descripcion.TabIndex = 43;
            this.lbl_descripcion.Text = "Espere un momento mientras se desactivan todos los alumnos";
            this.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CS_Proyecto.Properties.Resources.Loader1;
            this.pictureBox1.Location = new System.Drawing.Point(195, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // barra_progreso
            // 
            this.barra_progreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barra_progreso.BorderRadius = 5;
            this.barra_progreso.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.barra_progreso.Location = new System.Drawing.Point(53, 328);
            this.barra_progreso.Name = "barra_progreso";
            this.barra_progreso.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
            this.barra_progreso.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.barra_progreso.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.barra_progreso.ShadowDecoration.Parent = this.barra_progreso;
            this.barra_progreso.Size = new System.Drawing.Size(563, 10);
            this.barra_progreso.TabIndex = 46;
            this.barra_progreso.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.label1.Location = new System.Drawing.Point(53, 297);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Size = new System.Drawing.Size(563, 30);
            this.label1.TabIndex = 47;
            this.label1.Text = "Cargando...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::CS_Proyecto.Properties.Resources.Loader2;
            this.pictureBox2.Location = new System.Drawing.Point(415, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // c1
            // 
            this.c1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.c1.BorderRadius = 5;
            this.c1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.c1.Location = new System.Drawing.Point(263, 78);
            this.c1.Name = "c1";
            this.c1.ShadowDecoration.Parent = this.c1;
            this.c1.Size = new System.Drawing.Size(15, 15);
            this.c1.TabIndex = 49;
            // 
            // c2
            // 
            this.c2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.c2.BorderRadius = 5;
            this.c2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.c2.Location = new System.Drawing.Point(304, 56);
            this.c2.Name = "c2";
            this.c2.ShadowDecoration.Parent = this.c2;
            this.c2.Size = new System.Drawing.Size(15, 15);
            this.c2.TabIndex = 50;
            // 
            // c3
            // 
            this.c3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.c3.BorderRadius = 5;
            this.c3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.c3.Location = new System.Drawing.Point(349, 56);
            this.c3.Name = "c3";
            this.c3.ShadowDecoration.Parent = this.c3;
            this.c3.Size = new System.Drawing.Size(15, 15);
            this.c3.TabIndex = 50;
            // 
            // c4
            // 
            this.c4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.c4.BorderRadius = 5;
            this.c4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.c4.Location = new System.Drawing.Point(388, 78);
            this.c4.Name = "c4";
            this.c4.ShadowDecoration.Parent = this.c4;
            this.c4.Size = new System.Drawing.Size(15, 15);
            this.c4.TabIndex = 50;
            // 
            // Timer
            // 
            this.Timer.Interval = 40;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Timer_loader_carpetas
            // 
            this.Timer_loader_carpetas.Enabled = true;
            this.Timer_loader_carpetas.Interval = 200;
            this.Timer_loader_carpetas.Tick += new System.EventHandler(this.Timer_loader_carpetas_Tick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel1.Controls.Add(this.btn_cancelar);
            this.guna2Panel1.Location = new System.Drawing.Point(19, 272);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(630, 100);
            this.guna2Panel1.TabIndex = 51;
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
            this.btn_cancelar.Location = new System.Drawing.Point(176, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar.ShadowDecoration.Parent = this.btn_cancelar;
            this.btn_cancelar.Size = new System.Drawing.Size(278, 66);
            this.btn_cancelar.TabIndex = 40;
            this.btn_cancelar.Text = "Cancelar Desactivación";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Desactivacion_part5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 394);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barra_progreso);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Desactivacion_part5";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Desactivacion_part5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_descripcion;
        private Guna.UI2.WinForms.Guna2ProgressBar barra_progreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Panel c1;
        private Guna.UI2.WinForms.Guna2Panel c2;
        private Guna.UI2.WinForms.Guna2Panel c3;
        private Guna.UI2.WinForms.Guna2Panel c4;
        private System.Windows.Forms.Timer Timer_loader_carpetas;
        private System.Windows.Forms.Timer Timer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_cancelar;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}