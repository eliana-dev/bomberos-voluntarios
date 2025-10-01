namespace ProyectoBomberos2
{
    partial class FormCapacitacion
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
            this.lblCapacitacion = new System.Windows.Forms.Label();
            this.btnAsistenciaCapac = new System.Windows.Forms.Button();
            this.btnTareasCapac = new System.Windows.Forms.Button();
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
            // lblCapacitacion
            // 
            this.lblCapacitacion.AutoSize = true;
            this.lblCapacitacion.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacitacion.Location = new System.Drawing.Point(283, 53);
            this.lblCapacitacion.Name = "lblCapacitacion";
            this.lblCapacitacion.Size = new System.Drawing.Size(98, 21);
            this.lblCapacitacion.TabIndex = 2;
            this.lblCapacitacion.Text = "Capacitación";
            // 
            // btnAsistenciaCapac
            // 
            this.btnAsistenciaCapac.BackColor = System.Drawing.Color.Firebrick;
            this.btnAsistenciaCapac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistenciaCapac.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistenciaCapac.ForeColor = System.Drawing.Color.White;
            this.btnAsistenciaCapac.Location = new System.Drawing.Point(202, 102);
            this.btnAsistenciaCapac.Name = "btnAsistenciaCapac";
            this.btnAsistenciaCapac.Size = new System.Drawing.Size(240, 61);
            this.btnAsistenciaCapac.TabIndex = 3;
            this.btnAsistenciaCapac.Text = "Asistencia al Area";
            this.btnAsistenciaCapac.UseVisualStyleBackColor = false;
            this.btnAsistenciaCapac.Click += new System.EventHandler(this.btnAsistenciaCapac_Click);
            // 
            // btnTareasCapac
            // 
            this.btnTareasCapac.BackColor = System.Drawing.Color.Firebrick;
            this.btnTareasCapac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareasCapac.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareasCapac.ForeColor = System.Drawing.Color.White;
            this.btnTareasCapac.Location = new System.Drawing.Point(202, 269);
            this.btnTareasCapac.Name = "btnTareasCapac";
            this.btnTareasCapac.Size = new System.Drawing.Size(240, 61);
            this.btnTareasCapac.TabIndex = 4;
            this.btnTareasCapac.Text = "Tareas del Area";
            this.btnTareasCapac.UseVisualStyleBackColor = false;
            this.btnTareasCapac.Click += new System.EventHandler(this.btnTareasCapac_Click);
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
            // FormCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.btnAsistenciaInsti);
            this.Controls.Add(this.btnTareasCapac);
            this.Controls.Add(this.btnAsistenciaCapac);
            this.Controls.Add(this.lblCapacitacion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnInicio);
            this.Name = "FormCapacitacion";
            this.Text = "FormCapacitacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCapacitacion;
        private System.Windows.Forms.Button btnAsistenciaCapac;
        private System.Windows.Forms.Button btnTareasCapac;
        private System.Windows.Forms.Button btnAsistenciaInsti;
    }
}