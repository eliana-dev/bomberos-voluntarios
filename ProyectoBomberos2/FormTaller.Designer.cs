namespace ProyectoBomberos2
{
    partial class FormTaller
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
            this.lblTaller = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAsistenciaTaller = new System.Windows.Forms.Button();
            this.btnTareasTaller = new System.Windows.Forms.Button();
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
            // lblTaller
            // 
            this.lblTaller.AutoSize = true;
            this.lblTaller.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaller.Location = new System.Drawing.Point(306, 53);
            this.lblTaller.Name = "lblTaller";
            this.lblTaller.Size = new System.Drawing.Size(48, 21);
            this.lblTaller.TabIndex = 4;
            this.lblTaller.Text = "Taller";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(230, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Bomberos Voluntarios";
            // 
            // btnAsistenciaTaller
            // 
            this.btnAsistenciaTaller.BackColor = System.Drawing.Color.Firebrick;
            this.btnAsistenciaTaller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistenciaTaller.FlatAppearance.BorderSize = 0;
            this.btnAsistenciaTaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistenciaTaller.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistenciaTaller.ForeColor = System.Drawing.Color.White;
            this.btnAsistenciaTaller.Location = new System.Drawing.Point(202, 102);
            this.btnAsistenciaTaller.Name = "btnAsistenciaTaller";
            this.btnAsistenciaTaller.Size = new System.Drawing.Size(240, 61);
            this.btnAsistenciaTaller.TabIndex = 5;
            this.btnAsistenciaTaller.Text = "Asistencia al Area";
            this.btnAsistenciaTaller.UseVisualStyleBackColor = false;
            this.btnAsistenciaTaller.Click += new System.EventHandler(this.btnAsistenciaTaller_Click);
            // 
            // btnTareasTaller
            // 
            this.btnTareasTaller.BackColor = System.Drawing.Color.Firebrick;
            this.btnTareasTaller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTareasTaller.FlatAppearance.BorderSize = 0;
            this.btnTareasTaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareasTaller.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareasTaller.ForeColor = System.Drawing.Color.White;
            this.btnTareasTaller.Location = new System.Drawing.Point(202, 270);
            this.btnTareasTaller.Name = "btnTareasTaller";
            this.btnTareasTaller.Size = new System.Drawing.Size(240, 61);
            this.btnTareasTaller.TabIndex = 6;
            this.btnTareasTaller.Text = "Tareas del Area";
            this.btnTareasTaller.UseVisualStyleBackColor = false;
            this.btnTareasTaller.Click += new System.EventHandler(this.btnTareasTaller_Click);
            // 
            // btnAsistenciaInsti
            // 
            this.btnAsistenciaInsti.BackColor = System.Drawing.Color.Firebrick;
            this.btnAsistenciaInsti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistenciaInsti.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistenciaInsti.ForeColor = System.Drawing.Color.White;
            this.btnAsistenciaInsti.Location = new System.Drawing.Point(202, 187);
            this.btnAsistenciaInsti.Name = "btnAsistenciaInsti";
            this.btnAsistenciaInsti.Size = new System.Drawing.Size(240, 61);
            this.btnAsistenciaInsti.TabIndex = 7;
            this.btnAsistenciaInsti.Text = "Asistencia a la Institución";
            this.btnAsistenciaInsti.UseVisualStyleBackColor = false;
            this.btnAsistenciaInsti.Click += new System.EventHandler(this.btnAsistenciaInsti_Click);
            // 
            // FormTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.btnAsistenciaInsti);
            this.Controls.Add(this.btnTareasTaller);
            this.Controls.Add(this.btnAsistenciaTaller);
            this.Controls.Add(this.lblTaller);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnInicio);
            this.Name = "FormTaller";
            this.Text = "FormTaller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblTaller;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAsistenciaTaller;
        private System.Windows.Forms.Button btnTareasTaller;
        private System.Windows.Forms.Button btnAsistenciaInsti;
    }
}