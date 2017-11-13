namespace ClinicaMedica
{
    partial class FrmConfigurar
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCerrarUsuarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNombreMedico = new System.Windows.Forms.TextBox();
            this.PicFotoUser = new System.Windows.Forms.PictureBox();
            this.TxtNickname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtContraseniaNueva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRepetirContrasenia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnGuardarCambiosImagen = new System.Windows.Forms.Button();
            this.PicImagenFondo = new System.Windows.Forms.PictureBox();
            this.BtnCambioImagen = new System.Windows.Forms.Button();
            this.BtnSinImagen = new System.Windows.Forms.Button();
            this.BtnCerrarImagen = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFotoUser)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.BtnCerrarUsuarios);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(603, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.BtnCerrarImagen);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(603, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Imagen";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Controls.Add(this.TxtRepetirContrasenia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtContraseniaNueva);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtNickname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PicFotoUser);
            this.panel1.Controls.Add(this.BtnNombreMedico);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 296);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnCerrarUsuarios
            // 
            this.BtnCerrarUsuarios.Location = new System.Drawing.Point(503, 316);
            this.BtnCerrarUsuarios.Name = "BtnCerrarUsuarios";
            this.BtnCerrarUsuarios.Size = new System.Drawing.Size(82, 46);
            this.BtnCerrarUsuarios.TabIndex = 0;
            this.BtnCerrarUsuarios.Text = "Cerrar";
            this.BtnCerrarUsuarios.UseVisualStyleBackColor = true;
            this.BtnCerrarUsuarios.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Del Medico";
            // 
            // BtnNombreMedico
            // 
            this.BtnNombreMedico.Location = new System.Drawing.Point(126, 50);
            this.BtnNombreMedico.Name = "BtnNombreMedico";
            this.BtnNombreMedico.Size = new System.Drawing.Size(359, 26);
            this.BtnNombreMedico.TabIndex = 1;
            // 
            // PicFotoUser
            // 
            this.PicFotoUser.Location = new System.Drawing.Point(40, 26);
            this.PicFotoUser.Name = "PicFotoUser";
            this.PicFotoUser.Size = new System.Drawing.Size(76, 74);
            this.PicFotoUser.TabIndex = 2;
            this.PicFotoUser.TabStop = false;
            // 
            // TxtNickname
            // 
            this.TxtNickname.Location = new System.Drawing.Point(126, 114);
            this.TxtNickname.Name = "TxtNickname";
            this.TxtNickname.Size = new System.Drawing.Size(359, 26);
            this.TxtNickname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nickname";
            // 
            // TxtContraseniaNueva
            // 
            this.TxtContraseniaNueva.Location = new System.Drawing.Point(126, 181);
            this.TxtContraseniaNueva.Name = "TxtContraseniaNueva";
            this.TxtContraseniaNueva.Size = new System.Drawing.Size(166, 26);
            this.TxtContraseniaNueva.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña Nueva";
            // 
            // TxtRepetirContrasenia
            // 
            this.TxtRepetirContrasenia.Location = new System.Drawing.Point(319, 181);
            this.TxtRepetirContrasenia.Name = "TxtRepetirContrasenia";
            this.TxtRepetirContrasenia.Size = new System.Drawing.Size(166, 26);
            this.TxtRepetirContrasenia.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repetir Contraseña";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(366, 233);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(82, 46);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BtnSinImagen);
            this.panel2.Controls.Add(this.BtnCambioImagen);
            this.panel2.Controls.Add(this.BtnGuardarCambiosImagen);
            this.panel2.Controls.Add(this.PicImagenFondo);
            this.panel2.Location = new System.Drawing.Point(18, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 296);
            this.panel2.TabIndex = 1;
            // 
            // BtnGuardarCambiosImagen
            // 
            this.BtnGuardarCambiosImagen.Location = new System.Drawing.Point(414, 235);
            this.BtnGuardarCambiosImagen.Name = "BtnGuardarCambiosImagen";
            this.BtnGuardarCambiosImagen.Size = new System.Drawing.Size(82, 46);
            this.BtnGuardarCambiosImagen.TabIndex = 1;
            this.BtnGuardarCambiosImagen.Text = "Guardar";
            this.BtnGuardarCambiosImagen.UseVisualStyleBackColor = true;
            // 
            // PicImagenFondo
            // 
            this.PicImagenFondo.Location = new System.Drawing.Point(150, 19);
            this.PicImagenFondo.Name = "PicImagenFondo";
            this.PicImagenFondo.Size = new System.Drawing.Size(265, 197);
            this.PicImagenFondo.TabIndex = 2;
            this.PicImagenFondo.TabStop = false;
            // 
            // BtnCambioImagen
            // 
            this.BtnCambioImagen.Location = new System.Drawing.Point(68, 235);
            this.BtnCambioImagen.Name = "BtnCambioImagen";
            this.BtnCambioImagen.Size = new System.Drawing.Size(82, 46);
            this.BtnCambioImagen.TabIndex = 3;
            this.BtnCambioImagen.Text = "Cambiar Imagen";
            this.BtnCambioImagen.UseVisualStyleBackColor = true;
            // 
            // BtnSinImagen
            // 
            this.BtnSinImagen.Location = new System.Drawing.Point(232, 235);
            this.BtnSinImagen.Name = "BtnSinImagen";
            this.BtnSinImagen.Size = new System.Drawing.Size(82, 46);
            this.BtnSinImagen.TabIndex = 4;
            this.BtnSinImagen.Text = "Sin Imagen";
            this.BtnSinImagen.UseVisualStyleBackColor = true;
            // 
            // BtnCerrarImagen
            // 
            this.BtnCerrarImagen.Location = new System.Drawing.Point(503, 316);
            this.BtnCerrarImagen.Name = "BtnCerrarImagen";
            this.BtnCerrarImagen.Size = new System.Drawing.Size(82, 46);
            this.BtnCerrarImagen.TabIndex = 2;
            this.BtnCerrarImagen.Text = "Cerrar";
            this.BtnCerrarImagen.UseVisualStyleBackColor = true;
            // 
            // FrmConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 421);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmConfigurar";
            this.Text = "Configurar";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFotoUser)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnCerrarUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtRepetirContrasenia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtContraseniaNueva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNickname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PicFotoUser;
        private System.Windows.Forms.TextBox BtnNombreMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnGuardarCambiosImagen;
        private System.Windows.Forms.PictureBox PicImagenFondo;
        private System.Windows.Forms.Button BtnSinImagen;
        private System.Windows.Forms.Button BtnCambioImagen;
        private System.Windows.Forms.Button BtnCerrarImagen;
    }
}