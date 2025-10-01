namespace ProyectoBomberos2
{
    partial class FormAltaID
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAltA = new System.Windows.Forms.Label();
            this.lblImportante = new System.Windows.Forms.Label();
            this.lblDescript = new System.Windows.Forms.Label();
            this.txtIDbombero = new System.Windows.Forms.TextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(230, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bomberos Voluntarios";
            // 
            // lblAltA
            // 
            this.lblAltA.AutoSize = true;
            this.lblAltA.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltA.Location = new System.Drawing.Point(268, 53);
            this.lblAltA.Name = "lblAltA";
            this.lblAltA.Size = new System.Drawing.Size(123, 21);
            this.lblAltA.TabIndex = 1;
            this.lblAltA.Text = "Alta de Usuarios";
            // 
            // lblImportante
            // 
            this.lblImportante.AutoSize = true;
            this.lblImportante.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportante.ForeColor = System.Drawing.Color.Firebrick;
            this.lblImportante.Location = new System.Drawing.Point(72, 34);
            this.lblImportante.Name = "lblImportante";
            this.lblImportante.Size = new System.Drawing.Size(102, 17);
            this.lblImportante.TabIndex = 2;
            this.lblImportante.Text = "*IMPORTANTE:";
            // 
            // lblDescript
            // 
            this.lblDescript.AutoSize = true;
            this.lblDescript.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescript.Location = new System.Drawing.Point(72, 51);
            this.lblDescript.Name = "lblDescript";
            this.lblDescript.Size = new System.Drawing.Size(282, 34);
            this.lblDescript.TabIndex = 3;
            this.lblDescript.Text = "Esta sera su identificación, ingreselo al marcar \r\nentradas y salidas";
            // 
            // txtIDbombero
            // 
            this.txtIDbombero.Enabled = false;
            this.txtIDbombero.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDbombero.ForeColor = System.Drawing.Color.Firebrick;
            this.txtIDbombero.Location = new System.Drawing.Point(139, 98);
            this.txtIDbombero.Multiline = true;
            this.txtIDbombero.Name = "txtIDbombero";
            this.txtIDbombero.Size = new System.Drawing.Size(159, 33);
            this.txtIDbombero.TabIndex = 4;
            this.txtIDbombero.Text = "124";
            this.txtIDbombero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Firebrick;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(235, 314);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(169, 36);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDescript);
            this.groupBox1.Controls.Add(this.lblImportante);
            this.groupBox1.Controls.Add(this.txtIDbombero);
            this.groupBox1.Location = new System.Drawing.Point(105, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 170);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // FormAltaID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.lblAltA);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormAltaID";
            this.Text = "FormAltaID";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAltA;
        private System.Windows.Forms.Label lblImportante;
        private System.Windows.Forms.Label lblDescript;
        private System.Windows.Forms.TextBox txtIDbombero;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}