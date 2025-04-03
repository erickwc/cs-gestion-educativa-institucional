namespace CS_Proyecto.Vistas.Modo_Nocturno
{
    partial class Modo_nocturno
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.pnl_modo_claro = new Guna.UI2.WinForms.Guna2Panel();
            this.img_modo_claro = new System.Windows.Forms.PictureBox();
            this.pnl_modo_oscuro = new Guna.UI2.WinForms.Guna2Panel();
            this.img_modo_oscuro = new System.Windows.Forms.PictureBox();
            this.btn_seguir_modo_actual = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_claro = new System.Windows.Forms.Label();
            this.lbl_oscuro = new System.Windows.Forms.Label();
            this.pnl_modo_claro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_modo_claro)).BeginInit();
            this.pnl_modo_oscuro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_modo_oscuro)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_titulo.Location = new System.Drawing.Point(31, 31);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(352, 29);
            this.lbl_titulo.TabIndex = 8;
            this.lbl_titulo.Text = "Temas de Color";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(32, 62);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbl_descripcion.Size = new System.Drawing.Size(351, 32);
            this.lbl_descripcion.TabIndex = 9;
            this.lbl_descripcion.Text = "Escoge un tema de color de tu preferencia";
            this.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnl_modo_claro
            // 
            this.pnl_modo_claro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_modo_claro.BackColor = System.Drawing.Color.Transparent;
            this.pnl_modo_claro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.pnl_modo_claro.BorderRadius = 10;
            this.pnl_modo_claro.BorderThickness = 1;
            this.pnl_modo_claro.Controls.Add(this.img_modo_claro);
            this.pnl_modo_claro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_modo_claro.Location = new System.Drawing.Point(36, 110);
            this.pnl_modo_claro.Name = "pnl_modo_claro";
            this.pnl_modo_claro.ShadowDecoration.Parent = this.pnl_modo_claro;
            this.pnl_modo_claro.Size = new System.Drawing.Size(250, 225);
            this.pnl_modo_claro.TabIndex = 10;
            this.pnl_modo_claro.Click += new System.EventHandler(this.pnl_modo_claro_Click);
            // 
            // img_modo_claro
            // 
            this.img_modo_claro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_modo_claro.Image = global::CS_Proyecto.Properties.Resources.img_tema_blanco;
            this.img_modo_claro.Location = new System.Drawing.Point(15, 30);
            this.img_modo_claro.Name = "img_modo_claro";
            this.img_modo_claro.Size = new System.Drawing.Size(249, 172);
            this.img_modo_claro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img_modo_claro.TabIndex = 0;
            this.img_modo_claro.TabStop = false;
            this.img_modo_claro.Click += new System.EventHandler(this.pnl_modo_claro_Click);
            // 
            // pnl_modo_oscuro
            // 
            this.pnl_modo_oscuro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_modo_oscuro.BackColor = System.Drawing.Color.Transparent;
            this.pnl_modo_oscuro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.pnl_modo_oscuro.BorderRadius = 10;
            this.pnl_modo_oscuro.BorderThickness = 1;
            this.pnl_modo_oscuro.Controls.Add(this.img_modo_oscuro);
            this.pnl_modo_oscuro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_modo_oscuro.Location = new System.Drawing.Point(310, 110);
            this.pnl_modo_oscuro.Name = "pnl_modo_oscuro";
            this.pnl_modo_oscuro.ShadowDecoration.Parent = this.pnl_modo_oscuro;
            this.pnl_modo_oscuro.Size = new System.Drawing.Size(250, 225);
            this.pnl_modo_oscuro.TabIndex = 11;
            this.pnl_modo_oscuro.Click += new System.EventHandler(this.img_modo_oscuro_Click);
            // 
            // img_modo_oscuro
            // 
            this.img_modo_oscuro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_modo_oscuro.Image = global::CS_Proyecto.Properties.Resources.img_tema_oscuro;
            this.img_modo_oscuro.Location = new System.Drawing.Point(5, 30);
            this.img_modo_oscuro.Name = "img_modo_oscuro";
            this.img_modo_oscuro.Size = new System.Drawing.Size(269, 192);
            this.img_modo_oscuro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img_modo_oscuro.TabIndex = 1;
            this.img_modo_oscuro.TabStop = false;
            this.img_modo_oscuro.Click += new System.EventHandler(this.img_modo_oscuro_Click);
            // 
            // btn_seguir_modo_actual
            // 
            this.btn_seguir_modo_actual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_seguir_modo_actual.BorderRadius = 5;
            this.btn_seguir_modo_actual.CheckedState.Parent = this.btn_seguir_modo_actual;
            this.btn_seguir_modo_actual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_seguir_modo_actual.CustomImages.Parent = this.btn_seguir_modo_actual;
            this.btn_seguir_modo_actual.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_seguir_modo_actual.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seguir_modo_actual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_seguir_modo_actual.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_seguir_modo_actual.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_seguir_modo_actual.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_seguir_modo_actual.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_seguir_modo_actual.HoverState.Parent = this.btn_seguir_modo_actual;
            this.btn_seguir_modo_actual.Location = new System.Drawing.Point(36, 422);
            this.btn_seguir_modo_actual.Name = "btn_seguir_modo_actual";
            this.btn_seguir_modo_actual.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_seguir_modo_actual.ShadowDecoration.Parent = this.btn_seguir_modo_actual;
            this.btn_seguir_modo_actual.Size = new System.Drawing.Size(524, 57);
            this.btn_seguir_modo_actual.TabIndex = 42;
            this.btn_seguir_modo_actual.Text = "Continuar en el modo seleccionado";
            this.btn_seguir_modo_actual.Click += new System.EventHandler(this.btn_seguir_modo_actual_Click);
            // 
            // lbl_claro
            // 
            this.lbl_claro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_claro.AutoSize = true;
            this.lbl_claro.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_claro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_claro.Location = new System.Drawing.Point(32, 357);
            this.lbl_claro.Name = "lbl_claro";
            this.lbl_claro.Size = new System.Drawing.Size(102, 22);
            this.lbl_claro.TabIndex = 43;
            this.lbl_claro.Text = "Tema Claro";
            this.lbl_claro.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_oscuro
            // 
            this.lbl_oscuro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_oscuro.AutoSize = true;
            this.lbl_oscuro.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oscuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_oscuro.Location = new System.Drawing.Point(306, 357);
            this.lbl_oscuro.Name = "lbl_oscuro";
            this.lbl_oscuro.Size = new System.Drawing.Size(116, 22);
            this.lbl_oscuro.TabIndex = 44;
            this.lbl_oscuro.Text = "Tema Oscuro";
            this.lbl_oscuro.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Modo_nocturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 516);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_oscuro);
            this.Controls.Add(this.lbl_claro);
            this.Controls.Add(this.btn_seguir_modo_actual);
            this.Controls.Add(this.pnl_modo_oscuro);
            this.Controls.Add(this.pnl_modo_claro);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_descripcion);
            this.Name = "Modo_nocturno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Modo_nocturno_Load);
            this.pnl_modo_claro.ResumeLayout(false);
            this.pnl_modo_claro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_modo_claro)).EndInit();
            this.pnl_modo_oscuro.ResumeLayout(false);
            this.pnl_modo_oscuro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_modo_oscuro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_descripcion;
        private Guna.UI2.WinForms.Guna2Panel pnl_modo_claro;
        private Guna.UI2.WinForms.Guna2Panel pnl_modo_oscuro;
        private System.Windows.Forms.PictureBox img_modo_claro;
        private System.Windows.Forms.PictureBox img_modo_oscuro;
        private Guna.UI2.WinForms.Guna2Button btn_seguir_modo_actual;
        private System.Windows.Forms.Label lbl_claro;
        private System.Windows.Forms.Label lbl_oscuro;
    }
}