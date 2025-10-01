namespace ProyectoBomberos2
{
    partial class FormAsistenciaAutomo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVolverAutomo = new System.Windows.Forms.Button();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.btnFirmar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutomotor = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnVolverAutomo
            // 
            this.btnVolverAutomo.FlatAppearance.BorderSize = 0;
            this.btnVolverAutomo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverAutomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAutomo.ForeColor = System.Drawing.Color.Firebrick;
            this.btnVolverAutomo.Location = new System.Drawing.Point(13, 13);
            this.btnVolverAutomo.Name = "btnVolverAutomo";
            this.btnVolverAutomo.Size = new System.Drawing.Size(74, 48);
            this.btnVolverAutomo.TabIndex = 1;
            this.btnVolverAutomo.Text = "←";
            this.btnVolverAutomo.UseVisualStyleBackColor = true;
            this.btnVolverAutomo.Click += new System.EventHandler(this.btnVolverAutomo_Click);
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(159, 84);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 2;
            // 
            // cmbAño
            // 
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(332, 84);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(81, 21);
            this.cmbAño.TabIndex = 3;
            // 
            // btnFirmar
            // 
            this.btnFirmar.BackColor = System.Drawing.Color.Firebrick;
            this.btnFirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmar.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirmar.ForeColor = System.Drawing.Color.White;
            this.btnFirmar.Location = new System.Drawing.Point(438, 82);
            this.btnFirmar.Name = "btnFirmar";
            this.btnFirmar.Size = new System.Drawing.Size(75, 23);
            this.btnFirmar.TabIndex = 4;
            this.btnFirmar.Text = "Filtrar";
            this.btnFirmar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(230, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(165, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Asistencia al Area";
            // 
            // lblAutomotor
            // 
            this.lblAutomotor.AutoSize = true;
            this.lblAutomotor.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutomotor.Location = new System.Drawing.Point(272, 53);
            this.lblAutomotor.Name = "lblAutomotor";
            this.lblAutomotor.Size = new System.Drawing.Size(101, 21);
            this.lblAutomotor.TabIndex = 6;
            this.lblAutomotor.Text = "Automotores";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(118, 87);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(29, 15);
            this.lblMes.TabIndex = 7;
            this.lblMes.Text = "Mes";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(291, 87);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 15);
            this.lblAño.TabIndex = 8;
            this.lblAño.Text = "Año";
            this.lblAño.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormAsistenciaAutomo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblAutomotor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnFirmar);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.btnVolverAutomo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAsistenciaAutomo";
            this.Text = "FormAsistenciaAutomo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVolverAutomo;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.Button btnFirmar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutomotor;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
    }
}