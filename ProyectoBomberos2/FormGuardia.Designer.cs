namespace ProyectoBomberos2
{
    partial class FormGuardia
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
            this.lblGuardia = new System.Windows.Forms.Label();
            this.btnAsistenciaGuardia = new System.Windows.Forms.Button();
            this.btnTareaGuardia = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAsistenciaInsti = new System.Windows.Forms.Button();
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
            // lblGuardia
            // 
            this.lblGuardia.AutoSize = true;
            this.lblGuardia.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardia.Location = new System.Drawing.Point(299, 53);
            this.lblGuardia.Name = "lblGuardia";
            this.lblGuardia.Size = new System.Drawing.Size(65, 21);
            this.lblGuardia.TabIndex = 1;
            this.lblGuardia.Text = "Guardia";
            // 
            // btnAsistenciaGuardia
            // 
            this.btnAsistenciaGuardia.BackColor = System.Drawing.Color.Firebrick;
            this.btnAsistenciaGuardia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistenciaGuardia.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistenciaGuardia.ForeColor = System.Drawing.Color.White;
            this.btnAsistenciaGuardia.Location = new System.Drawing.Point(202, 102);
            this.btnAsistenciaGuardia.Name = "btnAsistenciaGuardia";
            this.btnAsistenciaGuardia.Size = new System.Drawing.Size(240, 61);
            this.btnAsistenciaGuardia.TabIndex = 2;
            this.btnAsistenciaGuardia.Text = "Asistencia al Area";
            this.btnAsistenciaGuardia.UseVisualStyleBackColor = false;
            this.btnAsistenciaGuardia.Click += new System.EventHandler(this.btnAsistenciaGuardia_Click);
            // 
            // btnTareaGuardia
            // 
            this.btnTareaGuardia.BackColor = System.Drawing.Color.Firebrick;
            this.btnTareaGuardia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareaGuardia.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareaGuardia.ForeColor = System.Drawing.Color.White;
            this.btnTareaGuardia.Location = new System.Drawing.Point(202, 269);
            this.btnTareaGuardia.Name = "btnTareaGuardia";
            this.btnTareaGuardia.Size = new System.Drawing.Size(240, 61);
            this.btnTareaGuardia.TabIndex = 0;
            this.btnTareaGuardia.Text = "Tareas del Area";
            this.btnTareaGuardia.UseVisualStyleBackColor = false;
            this.btnTareaGuardia.Click += new System.EventHandler(this.btnTareaGuardia_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Firebrick;
            this.btnVolver.Location = new System.Drawing.Point(33, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(74, 48);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "←";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAsistenciaInsti
            // 
            this.btnAsistenciaInsti.BackColor = System.Drawing.Color.Firebrick;
            this.btnAsistenciaInsti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistenciaInsti.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistenciaInsti.ForeColor = System.Drawing.Color.White;
            this.btnAsistenciaInsti.Location = new System.Drawing.Point(202, 187);
            this.btnAsistenciaInsti.Name = "btnAsistenciaInsti";
            this.btnAsistenciaInsti.Size = new System.Drawing.Size(240, 61);
            this.btnAsistenciaInsti.TabIndex = 4;
            this.btnAsistenciaInsti.Text = "Asistencia a la Institución";
            this.btnAsistenciaInsti.UseVisualStyleBackColor = false;
            this.btnAsistenciaInsti.Click += new System.EventHandler(this.btnAsistenciaInsti_Click);
            // 
            // FormGuardia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.btnAsistenciaInsti);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnTareaGuardia);
            this.Controls.Add(this.btnAsistenciaGuardia);
            this.Controls.Add(this.lblGuardia);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormGuardia";
            this.Text = "FormGuardia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGuardia;
        private System.Windows.Forms.Button btnAsistenciaGuardia;
        private System.Windows.Forms.Button btnTareaGuardia;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAsistenciaInsti;
    }
}