namespace ProyectoBomberos2
{
    partial class FormAdministracion
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
            this.btnAreas = new System.Windows.Forms.Button();
            this.btnDarAlta = new System.Windows.Forms.Button();
            this.btnAsignarArea = new System.Windows.Forms.Button();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            // btnAreas
            // 
            this.btnAreas.BackColor = System.Drawing.Color.Firebrick;
            this.btnAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreas.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreas.ForeColor = System.Drawing.Color.White;
            this.btnAreas.Location = new System.Drawing.Point(202, 111);
            this.btnAreas.Name = "btnAreas";
            this.btnAreas.Size = new System.Drawing.Size(240, 43);
            this.btnAreas.TabIndex = 1;
            this.btnAreas.Text = "Areas";
            this.btnAreas.UseVisualStyleBackColor = false;
            this.btnAreas.Click += new System.EventHandler(this.btnAreas_Click);
            // 
            // btnDarAlta
            // 
            this.btnDarAlta.BackColor = System.Drawing.Color.Firebrick;
            this.btnDarAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarAlta.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarAlta.ForeColor = System.Drawing.Color.White;
            this.btnDarAlta.Location = new System.Drawing.Point(202, 191);
            this.btnDarAlta.Name = "btnDarAlta";
            this.btnDarAlta.Size = new System.Drawing.Size(240, 43);
            this.btnDarAlta.TabIndex = 2;
            this.btnDarAlta.Text = "Dar de Alta";
            this.btnDarAlta.UseVisualStyleBackColor = false;
            this.btnDarAlta.Click += new System.EventHandler(this.btnDarAlta_Click);
            // 
            // btnAsignarArea
            // 
            this.btnAsignarArea.BackColor = System.Drawing.Color.Firebrick;
            this.btnAsignarArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarArea.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarArea.ForeColor = System.Drawing.Color.White;
            this.btnAsignarArea.Location = new System.Drawing.Point(202, 279);
            this.btnAsignarArea.Name = "btnAsignarArea";
            this.btnAsignarArea.Size = new System.Drawing.Size(240, 43);
            this.btnAsignarArea.TabIndex = 3;
            this.btnAsignarArea.Text = "Asignar Area";
            this.btnAsignarArea.UseVisualStyleBackColor = false;
            this.btnAsignarArea.Click += new System.EventHandler(this.btnAsignarArea_Click);
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(268, 53);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(115, 21);
            this.lblSubtitulo.TabIndex = 4;
            this.lblSubtitulo.Text = "Administración";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(33, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.btnAsignarArea);
            this.Controls.Add(this.btnDarAlta);
            this.Controls.Add(this.btnAreas);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormAdministracion";
            this.Text = "FormAdministracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAreas;
        private System.Windows.Forms.Button btnDarAlta;
        private System.Windows.Forms.Button btnAsignarArea;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button button1;
    }
}