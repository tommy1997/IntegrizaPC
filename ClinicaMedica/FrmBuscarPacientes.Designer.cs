namespace ClinicaMedica
{
    partial class FrmBuscarPacientes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.BtnSalirBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApellidoBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombreBuscar = new System.Windows.Forms.TextBox();
            this.DgvPacientesBuscar = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCancelarBajas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellidoBajas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombreBajas = new System.Windows.Forms.TextBox();
            this.DgvPacientesBajas = new System.Windows.Forms.DataGridView();
            this.BtnExpediente = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientesBuscar)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientesBajas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnExpediente);
            this.tabPage1.Controls.Add(this.BtnBaja);
            this.tabPage1.Controls.Add(this.BtnSalirBuscar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.DgvPacientesBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pacientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnBaja
            // 
            this.BtnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBaja.Location = new System.Drawing.Point(531, 337);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(107, 56);
            this.BtnBaja.TabIndex = 6;
            this.BtnBaja.Text = "Dar De Baja";
            this.BtnBaja.UseVisualStyleBackColor = true;
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // BtnSalirBuscar
            // 
            this.BtnSalirBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirBuscar.Location = new System.Drawing.Point(531, 408);
            this.BtnSalirBuscar.Name = "BtnSalirBuscar";
            this.BtnSalirBuscar.Size = new System.Drawing.Size(107, 56);
            this.BtnSalirBuscar.TabIndex = 5;
            this.BtnSalirBuscar.Text = "Cancelar";
            this.BtnSalirBuscar.UseVisualStyleBackColor = true;
            this.BtnSalirBuscar.Click += new System.EventHandler(this.BtnSalirBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtApellidoBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtNombreBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // TxtApellidoBuscar
            // 
            this.TxtApellidoBuscar.Location = new System.Drawing.Point(324, 31);
            this.TxtApellidoBuscar.Name = "TxtApellidoBuscar";
            this.TxtApellidoBuscar.Size = new System.Drawing.Size(161, 24);
            this.TxtApellidoBuscar.TabIndex = 2;
            this.TxtApellidoBuscar.TextChanged += new System.EventHandler(this.TxtApellidoBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // TxtNombreBuscar
            // 
            this.TxtNombreBuscar.Location = new System.Drawing.Point(76, 34);
            this.TxtNombreBuscar.Name = "TxtNombreBuscar";
            this.TxtNombreBuscar.Size = new System.Drawing.Size(161, 24);
            this.TxtNombreBuscar.TabIndex = 0;
            this.TxtNombreBuscar.TextChanged += new System.EventHandler(this.TxtNombreBuscar_TextChanged);
            // 
            // DgvPacientesBuscar
            // 
            this.DgvPacientesBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPacientesBuscar.Location = new System.Drawing.Point(9, 106);
            this.DgvPacientesBuscar.Name = "DgvPacientesBuscar";
            this.DgvPacientesBuscar.Size = new System.Drawing.Size(501, 358);
            this.DgvPacientesBuscar.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.BtnCancelarBajas);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.DgvPacientesBajas);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bajas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(531, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dar De Baja";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnCancelarBajas
            // 
            this.BtnCancelarBajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarBajas.Location = new System.Drawing.Point(531, 408);
            this.BtnCancelarBajas.Name = "BtnCancelarBajas";
            this.BtnCancelarBajas.Size = new System.Drawing.Size(107, 56);
            this.BtnCancelarBajas.TabIndex = 9;
            this.BtnCancelarBajas.Text = "Cancelar";
            this.BtnCancelarBajas.UseVisualStyleBackColor = true;
            this.BtnCancelarBajas.Click += new System.EventHandler(this.BtnCancelarBajas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtApellidoBajas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtNombreBajas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 77);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // TxtApellidoBajas
            // 
            this.TxtApellidoBajas.Location = new System.Drawing.Point(324, 31);
            this.TxtApellidoBajas.Name = "TxtApellidoBajas";
            this.TxtApellidoBajas.Size = new System.Drawing.Size(161, 24);
            this.TxtApellidoBajas.TabIndex = 2;
            this.TxtApellidoBajas.TextChanged += new System.EventHandler(this.TxtApellidoBajas_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // TxtNombreBajas
            // 
            this.TxtNombreBajas.Location = new System.Drawing.Point(76, 34);
            this.TxtNombreBajas.Name = "TxtNombreBajas";
            this.TxtNombreBajas.Size = new System.Drawing.Size(161, 24);
            this.TxtNombreBajas.TabIndex = 0;
            this.TxtNombreBajas.TextChanged += new System.EventHandler(this.TxtNombreBajas_TextChanged);
            // 
            // DgvPacientesBajas
            // 
            this.DgvPacientesBajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPacientesBajas.Location = new System.Drawing.Point(9, 106);
            this.DgvPacientesBajas.Name = "DgvPacientesBajas";
            this.DgvPacientesBajas.Size = new System.Drawing.Size(501, 358);
            this.DgvPacientesBajas.TabIndex = 7;
            // 
            // BtnExpediente
            // 
            this.BtnExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExpediente.Location = new System.Drawing.Point(531, 265);
            this.BtnExpediente.Name = "BtnExpediente";
            this.BtnExpediente.Size = new System.Drawing.Size(107, 56);
            this.BtnExpediente.TabIndex = 7;
            this.BtnExpediente.Text = "Ver Expediente";
            this.BtnExpediente.UseVisualStyleBackColor = true;
            // 
            // FrmBuscarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 515);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmBuscarPacientes";
            this.Text = "FrmBuscarPacientes";
            this.Load += new System.EventHandler(this.FrmBuscarPacientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientesBuscar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientesBajas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.Button BtnSalirBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtApellidoBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombreBuscar;
        private System.Windows.Forms.DataGridView DgvPacientesBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCancelarBajas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellidoBajas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombreBajas;
        private System.Windows.Forms.DataGridView DgvPacientesBajas;
        private System.Windows.Forms.Button BtnExpediente;


    }
}