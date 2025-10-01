namespace ProyectoBomberos2
{
    partial class FormAutomotores
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
            this.lblAutomotores = new System.Windows.Forms.Label();
            this.btnAsistenciaAutom = new System.Windows.Forms.Button();
            this.btnTareasAutom = new System.Windows.Forms.Button();
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
            // lblAutomotores
            // 
            this.lblAutomotores.AutoSize = true;
            this.lblAutomotores.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutomotores.Location = new System.Drawing.Point(283, 53);
            this.lblAutomotores.Name = "lblAutomotores";
            this.lblAutomotores.Size = new System.Drawing.Size(101, 21);
            this.lblAutomotores.TabIndex = 2;
            this.lblAutomotores.Text = "Automotores";
            // 
            // btnAsistenciaAutom
            // 
            this.btnAsistenciaAutom.BackColor = System.Drawing.Color.Firebrick;
            this.btnAsistenciaAutom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistenciaAutom.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistenciaAutom.ForeColor = System.Drawing.Color.White;
            this.btnAsistenciaAutom.Location = new System.Drawing.Point(202, 102);
            this.btnAsistenciaAutom.Name = "btnAsistenciaAutom";
            this.btnAsistenciaAutom.Size = new System.Drawing.Size(240, 61);
            this.btnAsistenciaAutom.TabIndex = 3;
            this.btnAsistenciaAutom.Text = "Asistencia al Area";
            this.btnAsistenciaAutom.UseVisualStyleBackColor = false;
            this.btnAsistenciaAutom.Click += new System.EventHandler(this.btnAsistenciaAutom_Click);
            // 
            // btnTareasAutom
            // 
            this.btnTareasAutom.BackColor = System.Drawing.Color.Firebrick;
            this.btnTareasAutom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareasAutom.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareasAutom.ForeColor = System.Drawing.Color.White;
            this.btnTareasAutom.Location = new System.Drawing.Point(202, 269);
            this.btnTareasAutom.Name = "btnTareasAutom";
            this.btnTareasAutom.Size = new System.Drawing.Size(240, 61);
            this.btnTareasAutom.TabIndex = 4;
            this.btnTareasAutom.Text = "Tareas del Area";
            this.btnTareasAutom.UseVisualStyleBackColor = false;
            this.btnTareasAutom.Click += new System.EventHandler(this.btnTareasAutom_Click);
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
            // FormAutomotores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.btnAsistenciaInsti);
            this.Controls.Add(this.btnTareasAutom);
            this.Controls.Add(this.btnAsistenciaAutom);
            this.Controls.Add(this.lblAutomotores);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnInicio);
            this.Name = "FormAutomotores";
            this.Text = "FormAutomotores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutomotores;
        private System.Windows.Forms.Button btnAsistenciaAutom;
        private System.Windows.Forms.Button btnTareasAutom;
        private System.Windows.Forms.Button btnAsistenciaInsti;
    }
}