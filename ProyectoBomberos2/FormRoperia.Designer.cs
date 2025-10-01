namespace ProyectoBomberos2
{
    partial class FormRoperia
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
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblRoperia = new System.Windows.Forms.Label();
            this.btnAsistenciaRoperia = new System.Windows.Forms.Button();
            this.btnTareasRoperia = new System.Windows.Forms.Button();
            this.btnAsistenciaInsti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.Firebrick;
            this.btnInicio.Location = new System.Drawing.Point(33, 12);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(74, 48);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "←";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(230, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Bomberos Voluntarios";
            // 
            // lblRoperia
            // 
            this.lblRoperia.AutoSize = true;
            this.lblRoperia.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoperia.Location = new System.Drawing.Point(299, 53);
            this.lblRoperia.Name = "lblRoperia";
            this.lblRoperia.Size = new System.Drawing.Size(64, 21);
            this.lblRoperia.TabIndex = 2;
            this.lblRoperia.Text = "Roperia";
            // 
            // btnAsistenciaRoperia
            // 
            this.btnAsistenciaRoperia.BackColor = System.Drawing.Color.Firebrick;
            this.btnAsistenciaRoperia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistenciaRoperia.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistenciaRoperia.ForeColor = System.Drawing.Color.White;
            this.btnAsistenciaRoperia.Location = new System.Drawing.Point(202, 102);
            this.btnAsistenciaRoperia.Name = "btnAsistenciaRoperia";
            this.btnAsistenciaRoperia.Size = new System.Drawing.Size(240, 61);
            this.btnAsistenciaRoperia.TabIndex = 3;
            this.btnAsistenciaRoperia.Text = "Asistencia al Area";
            this.btnAsistenciaRoperia.UseVisualStyleBackColor = false;
            this.btnAsistenciaRoperia.Click += new System.EventHandler(this.btnAsistenciaRoperia_Click);
            // 
            // btnTareasRoperia
            // 
            this.btnTareasRoperia.BackColor = System.Drawing.Color.Firebrick;
            this.btnTareasRoperia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareasRoperia.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareasRoperia.ForeColor = System.Drawing.Color.White;
            this.btnTareasRoperia.Location = new System.Drawing.Point(202, 269);
            this.btnTareasRoperia.Name = "btnTareasRoperia";
            this.btnTareasRoperia.Size = new System.Drawing.Size(240, 61);
            this.btnTareasRoperia.TabIndex = 4;
            this.btnTareasRoperia.Text = "Tareas del Area";
            this.btnTareasRoperia.UseVisualStyleBackColor = false;
            this.btnTareasRoperia.Click += new System.EventHandler(this.btnTareasRoperia_Click);
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
            this.btnAsistenciaInsti.TabIndex = 5;
            this.btnAsistenciaInsti.Text = "Asistencia a la Institución";
            this.btnAsistenciaInsti.UseVisualStyleBackColor = false;
            this.btnAsistenciaInsti.Click += new System.EventHandler(this.btnAsistenciaInsti_Click);
            // 
            // FormRoperia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.btnAsistenciaInsti);
            this.Controls.Add(this.btnTareasRoperia);
            this.Controls.Add(this.btnAsistenciaRoperia);
            this.Controls.Add(this.lblRoperia);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnInicio);
            this.Name = "FormRoperia";
            this.Text = "FormRoperia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRoperia;
        private System.Windows.Forms.Button btnAsistenciaRoperia;
        private System.Windows.Forms.Button btnTareasRoperia;
        private System.Windows.Forms.Button btnAsistenciaInsti;
    }
}