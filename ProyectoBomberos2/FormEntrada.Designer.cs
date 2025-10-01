namespace ProyectoBomberos2
{
    partial class FormEntrada
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
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnFirmarEntrada = new System.Windows.Forms.Button();
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.Location = new System.Drawing.Point(304, 53);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(63, 21);
            this.lblSubTitulo.TabIndex = 8;
            this.lblSubTitulo.Text = "Entrada";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(230, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 25);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Bomberos Voluntarios";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHora.Location = new System.Drawing.Point(311, 368);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(50, 21);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "00:00";
            // 
            // btnFirmarEntrada
            // 
            this.btnFirmarEntrada.BackColor = System.Drawing.Color.Firebrick;
            this.btnFirmarEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirmarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmarEntrada.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirmarEntrada.ForeColor = System.Drawing.Color.White;
            this.btnFirmarEntrada.Location = new System.Drawing.Point(272, 392);
            this.btnFirmarEntrada.Name = "btnFirmarEntrada";
            this.btnFirmarEntrada.Size = new System.Drawing.Size(125, 30);
            this.btnFirmarEntrada.TabIndex = 12;
            this.btnFirmarEntrada.Text = "Firmar";
            this.btnFirmarEntrada.UseVisualStyleBackColor = false;
            this.btnFirmarEntrada.Click += new System.EventHandler(this.btnFirmarEntrada_Click);
            // 
            // Reloj
            // 
            this.Reloj.Interval = 999;
            this.Reloj.Tick += new System.EventHandler(this.Reloj_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(287, 347);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(110, 21);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "dd/mm/aaaa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Firme para registrar la fecha y hora de entrada";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ProyectoBomberos2.Properties.Resources.BomberosLogo;
            this.pbLogo.Location = new System.Drawing.Point(204, 77);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(256, 245);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // FormEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnFirmarEntrada);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormEntrada";
            this.Text = "FormEntrada";
            this.Load += new System.EventHandler(this.FormEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnFirmarEntrada;
        private System.Windows.Forms.Timer Reloj;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
    }
}