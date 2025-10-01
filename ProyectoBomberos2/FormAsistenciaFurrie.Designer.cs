namespace ProyectoBomberos2
{
    partial class FormAsistenciaFurrie
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
            this.dgvAsistenciaFurrie = new System.Windows.Forms.DataGridView();
            this.btnVolverFurrie = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFurrieles = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaFurrie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsistenciaFurrie
            // 
            this.dgvAsistenciaFurrie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistenciaFurrie.Location = new System.Drawing.Point(28, 111);
            this.dgvAsistenciaFurrie.Name = "dgvAsistenciaFurrie";
            this.dgvAsistenciaFurrie.Size = new System.Drawing.Size(598, 340);
            this.dgvAsistenciaFurrie.TabIndex = 0;
            // 
            // btnVolverFurrie
            // 
            this.btnVolverFurrie.FlatAppearance.BorderSize = 0;
            this.btnVolverFurrie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverFurrie.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverFurrie.ForeColor = System.Drawing.Color.Firebrick;
            this.btnVolverFurrie.Location = new System.Drawing.Point(13, 13);
            this.btnVolverFurrie.Name = "btnVolverFurrie";
            this.btnVolverFurrie.Size = new System.Drawing.Size(74, 48);
            this.btnVolverFurrie.TabIndex = 1;
            this.btnVolverFurrie.Text = "←";
            this.btnVolverFurrie.UseVisualStyleBackColor = true;
            this.btnVolverFurrie.Click += new System.EventHandler(this.btnVolverFurrie_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(230, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(165, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Asistencia al Area";
            // 
            // lblFurrieles
            // 
            this.lblFurrieles.AutoSize = true;
            this.lblFurrieles.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFurrieles.Location = new System.Drawing.Point(281, 53);
            this.lblFurrieles.Name = "lblFurrieles";
            this.lblFurrieles.Size = new System.Drawing.Size(70, 21);
            this.lblFurrieles.TabIndex = 3;
            this.lblFurrieles.Text = "Furrieles";
            // 
            // cmbMes
            // 
            this.cmbMes.ForeColor = System.Drawing.Color.Firebrick;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(159, 84);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(332, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(81, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(438, 82);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(124, 87);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(29, 15);
            this.lblMes.TabIndex = 7;
            this.lblMes.Text = "Mes";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(297, 87);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 15);
            this.lblAño.TabIndex = 8;
            this.lblAño.Text = "Año";
            // 
            // FormAsistenciaFurrie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblFurrieles);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVolverFurrie);
            this.Controls.Add(this.dgvAsistenciaFurrie);
            this.Name = "FormAsistenciaFurrie";
            this.Text = "FormAsistenciaFurrie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaFurrie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsistenciaFurrie;
        private System.Windows.Forms.Button btnVolverFurrie;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFurrieles;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
    }
}