namespace ProyectoBomberos2
{
    partial class FormFurrieles
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
            this.lblFurrieles = new System.Windows.Forms.Label();
            this.btnAsistenciaFurrie = new System.Windows.Forms.Button();
            this.btnTareasFurrieles = new System.Windows.Forms.Button();
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
            // lblFurrieles
            // 
            this.lblFurrieles.AutoSize = true;
            this.lblFurrieles.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFurrieles.Location = new System.Drawing.Point(303, 53);
            this.lblFurrieles.Name = "lblFurrieles";
            this.lblFurrieles.Size = new System.Drawing.Size(70, 21);
            this.lblFurrieles.TabIndex = 2;
            this.lblFurrieles.Text = "Furrieles";
            // 
            // btnAsistenciaFurrie
            // 
            this.btnAsistenciaFurrie.BackColor = System.Drawing.Color.Firebrick;
            this.btnAsistenciaFurrie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistenciaFurrie.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistenciaFurrie.ForeColor = System.Drawing.Color.White;
            this.btnAsistenciaFurrie.Location = new System.Drawing.Point(202, 102);
            this.btnAsistenciaFurrie.Name = "btnAsistenciaFurrie";
            this.btnAsistenciaFurrie.Size = new System.Drawing.Size(240, 61);
            this.btnAsistenciaFurrie.TabIndex = 3;
            this.btnAsistenciaFurrie.Text = "Asistencia al Area";
            this.btnAsistenciaFurrie.UseVisualStyleBackColor = false;
            this.btnAsistenciaFurrie.Click += new System.EventHandler(this.btnAsistenciaFurrie_Click);
            // 
            // btnTareasFurrieles
            // 
            this.btnTareasFurrieles.BackColor = System.Drawing.Color.Firebrick;
            this.btnTareasFurrieles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareasFurrieles.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareasFurrieles.ForeColor = System.Drawing.Color.White;
            this.btnTareasFurrieles.Location = new System.Drawing.Point(202, 269);
            this.btnTareasFurrieles.Name = "btnTareasFurrieles";
            this.btnTareasFurrieles.Size = new System.Drawing.Size(240, 61);
            this.btnTareasFurrieles.TabIndex = 4;
            this.btnTareasFurrieles.Text = "Tareas del Area";
            this.btnTareasFurrieles.UseVisualStyleBackColor = false;
            this.btnTareasFurrieles.Click += new System.EventHandler(this.btnTareasFurrieles_Click);
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
            // FormFurrieles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.btnAsistenciaInsti);
            this.Controls.Add(this.btnTareasFurrieles);
            this.Controls.Add(this.btnAsistenciaFurrie);
            this.Controls.Add(this.lblFurrieles);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnInicio);
            this.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormFurrieles";
            this.Text = "FormFurrieles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFurrieles;
        private System.Windows.Forms.Button btnAsistenciaFurrie;
        private System.Windows.Forms.Button btnTareasFurrieles;
        private System.Windows.Forms.Button btnAsistenciaInsti;
    }
}