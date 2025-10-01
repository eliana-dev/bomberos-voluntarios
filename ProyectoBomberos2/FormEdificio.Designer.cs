namespace ProyectoBomberos2
{
    partial class FormEdificio
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
            this.BtnInicio = new System.Windows.Forms.Button();
            this.lblEdificio = new System.Windows.Forms.Label();
            this.btnAsistenciaEdificio = new System.Windows.Forms.Button();
            this.btnTareasEdificio = new System.Windows.Forms.Button();
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
            // BtnInicio
            // 
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnInicio.Location = new System.Drawing.Point(33, 12);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(74, 48);
            this.BtnInicio.TabIndex = 1;
            this.BtnInicio.Text = "←";
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // lblEdificio
            // 
            this.lblEdificio.AutoSize = true;
            this.lblEdificio.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdificio.Location = new System.Drawing.Point(306, 53);
            this.lblEdificio.Name = "lblEdificio";
            this.lblEdificio.Size = new System.Drawing.Size(60, 21);
            this.lblEdificio.TabIndex = 2;
            this.lblEdificio.Text = "Edificio";
            // 
            // btnAsistenciaEdificio
            // 
            this.btnAsistenciaEdificio.BackColor = System.Drawing.Color.Firebrick;
            this.btnAsistenciaEdificio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistenciaEdificio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistenciaEdificio.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistenciaEdificio.ForeColor = System.Drawing.Color.White;
            this.btnAsistenciaEdificio.Location = new System.Drawing.Point(202, 102);
            this.btnAsistenciaEdificio.Name = "btnAsistenciaEdificio";
            this.btnAsistenciaEdificio.Size = new System.Drawing.Size(240, 61);
            this.btnAsistenciaEdificio.TabIndex = 3;
            this.btnAsistenciaEdificio.Text = "Asistencia al Area";
            this.btnAsistenciaEdificio.UseVisualStyleBackColor = false;
            this.btnAsistenciaEdificio.Click += new System.EventHandler(this.btnAsistenciaEdificio_Click);
            // 
            // btnTareasEdificio
            // 
            this.btnTareasEdificio.BackColor = System.Drawing.Color.Firebrick;
            this.btnTareasEdificio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTareasEdificio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareasEdificio.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareasEdificio.ForeColor = System.Drawing.Color.White;
            this.btnTareasEdificio.Location = new System.Drawing.Point(202, 269);
            this.btnTareasEdificio.Name = "btnTareasEdificio";
            this.btnTareasEdificio.Size = new System.Drawing.Size(240, 61);
            this.btnTareasEdificio.TabIndex = 4;
            this.btnTareasEdificio.Text = "Tareas del Area";
            this.btnTareasEdificio.UseVisualStyleBackColor = false;
            this.btnTareasEdificio.Click += new System.EventHandler(this.btnTareasEdificio_Click);
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
            this.btnAsistenciaInsti.Text = "Asistencia a la institución";
            this.btnAsistenciaInsti.UseVisualStyleBackColor = false;
            this.btnAsistenciaInsti.Click += new System.EventHandler(this.btnAsistenciaInsti_Click);
            // 
            // FormEdificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.btnAsistenciaInsti);
            this.Controls.Add(this.btnTareasEdificio);
            this.Controls.Add(this.btnAsistenciaEdificio);
            this.Controls.Add(this.lblEdificio);
            this.Controls.Add(this.BtnInicio);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormEdificio";
            this.Text = "FormEdificio";
            this.Load += new System.EventHandler(this.FormEdificio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Label lblEdificio;
        private System.Windows.Forms.Button btnAsistenciaEdificio;
        private System.Windows.Forms.Button btnTareasEdificio;
        private System.Windows.Forms.Button btnAsistenciaInsti;

    }
}