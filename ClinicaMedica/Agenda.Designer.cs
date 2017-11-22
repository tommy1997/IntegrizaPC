namespace ClinicaMedica
{
    partial class Agenda
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelUser = new System.Windows.Forms.Panel();
            this.LblNombre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblHora = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblNivel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LblIdMedico = new System.Windows.Forms.Label();
            this.BtnConfigurar = new System.Windows.Forms.Button();
            this.BtnCerrarS = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAyuda = new System.Windows.Forms.Button();
            this.BtnBackup = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnExpedientes = new System.Windows.Forms.Button();
            this.BtnTurnos = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.PanelUser.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(0, 150);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1038, 150);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // PanelUser
            // 
            this.PanelUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelUser.Controls.Add(this.LblNombre);
            this.PanelUser.Location = new System.Drawing.Point(12, 124);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(449, 30);
            this.PanelUser.TabIndex = 11;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(3, 3);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(0, 20);
            this.LblNombre.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.LblHora);
            this.panel2.Location = new System.Drawing.Point(740, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 30);
            this.panel2.TabIndex = 12;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Location = new System.Drawing.Point(3, 3);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(44, 20);
            this.LblHora.TabIndex = 2;
            this.LblHora.Text = "Hora";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.LblFecha);
            this.panel3.Location = new System.Drawing.Point(887, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 30);
            this.panel3.TabIndex = 13;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(3, 3);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(54, 20);
            this.LblFecha.TabIndex = 3;
            this.LblFecha.Text = "Fecha";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.LblNivel);
            this.panel4.Location = new System.Drawing.Point(467, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 30);
            this.panel4.TabIndex = 12;
            // 
            // LblNivel
            // 
            this.LblNivel.AutoSize = true;
            this.LblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNivel.Location = new System.Drawing.Point(3, 3);
            this.LblNivel.Name = "LblNivel";
            this.LblNivel.Size = new System.Drawing.Size(64, 20);
            this.LblNivel.TabIndex = 0;
            this.LblNivel.Text = "Usuario";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblIdMedico
            // 
            this.LblIdMedico.AutoSize = true;
            this.LblIdMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdMedico.Location = new System.Drawing.Point(942, 61);
            this.LblIdMedico.Name = "LblIdMedico";
            this.LblIdMedico.Size = new System.Drawing.Size(64, 20);
            this.LblIdMedico.TabIndex = 1;
            this.LblIdMedico.Text = "Usuario";
            this.LblIdMedico.Visible = false;
            // 
            // BtnConfigurar
            // 
            this.BtnConfigurar.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnConfigurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfigurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnConfigurar.ForeColor = System.Drawing.Color.White;
            this.BtnConfigurar.Image = global::ClinicaMedica.Properties.Resources.iEngrenages_241821;
            this.BtnConfigurar.Location = new System.Drawing.Point(558, 37);
            this.BtnConfigurar.Name = "BtnConfigurar";
            this.BtnConfigurar.Size = new System.Drawing.Size(85, 69);
            this.BtnConfigurar.TabIndex = 17;
            this.toolTip1.SetToolTip(this.BtnConfigurar, "Configuraciones");
            this.BtnConfigurar.UseVisualStyleBackColor = false;
            this.BtnConfigurar.Click += new System.EventHandler(this.BtnConfigurar_Click);
            this.BtnConfigurar.DragEnter += new System.Windows.Forms.DragEventHandler(this.button1_DragEnter);
            this.BtnConfigurar.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.BtnConfigurar.MouseLeave += new System.EventHandler(this.BtnConfigurar_MouseLeave);
            // 
            // BtnCerrarS
            // 
            this.BtnCerrarS.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnCerrarS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCerrarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnCerrarS.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarS.Image = global::ClinicaMedica.Properties.Resources.logout_icon_icons_com_51025;
            this.BtnCerrarS.Location = new System.Drawing.Point(740, 37);
            this.BtnCerrarS.Name = "BtnCerrarS";
            this.BtnCerrarS.Size = new System.Drawing.Size(85, 69);
            this.BtnCerrarS.TabIndex = 15;
            this.toolTip1.SetToolTip(this.BtnCerrarS, "Cerrar Sesion");
            this.BtnCerrarS.UseVisualStyleBackColor = false;
            this.BtnCerrarS.Click += new System.EventHandler(this.button1_Click);
            this.BtnCerrarS.MouseEnter += new System.EventHandler(this.BtnCerrarS_MouseEnter);
            this.BtnCerrarS.MouseLeave += new System.EventHandler(this.BtnCerrarS_MouseLeave);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnSalir.BackgroundImage = global::ClinicaMedica.Properties.Resources.exit_closethesession_close_6317;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(831, 37);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(85, 69);
            this.BtnSalir.TabIndex = 10;
            this.toolTip1.SetToolTip(this.BtnSalir, "Salir");
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.BtnSalir.MouseEnter += new System.EventHandler(this.BtnSalir_MouseEnter);
            this.BtnSalir.MouseLeave += new System.EventHandler(this.BtnSalir_MouseLeave);
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnAyuda.BackgroundImage = global::ClinicaMedica.Properties.Resources.help_question_15661;
            this.BtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnAyuda.ForeColor = System.Drawing.Color.White;
            this.BtnAyuda.Location = new System.Drawing.Point(649, 37);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(85, 69);
            this.BtnAyuda.TabIndex = 9;
            this.toolTip1.SetToolTip(this.BtnAyuda, "Ayuda");
            this.BtnAyuda.UseVisualStyleBackColor = false;
            this.BtnAyuda.MouseEnter += new System.EventHandler(this.BtnAyuda_MouseEnter);
            this.BtnAyuda.MouseLeave += new System.EventHandler(this.BtnAyuda_MouseLeave);
            // 
            // BtnBackup
            // 
            this.BtnBackup.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnBackup.BackgroundImage = global::ClinicaMedica.Properties.Resources.blue_external_drive_backup_folder_12388;
            this.BtnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnBackup.ForeColor = System.Drawing.Color.White;
            this.BtnBackup.Location = new System.Drawing.Point(467, 37);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Size = new System.Drawing.Size(85, 69);
            this.BtnBackup.TabIndex = 8;
            this.toolTip1.SetToolTip(this.BtnBackup, "Backup");
            this.BtnBackup.UseVisualStyleBackColor = false;
            this.BtnBackup.MouseEnter += new System.EventHandler(this.BtnBackup_MouseEnter);
            this.BtnBackup.MouseLeave += new System.EventHandler(this.BtnBackup_MouseLeave);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnImprimir.BackgroundImage = global::ClinicaMedica.Properties.Resources.printer_6029;
            this.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnImprimir.ForeColor = System.Drawing.Color.White;
            this.BtnImprimir.Location = new System.Drawing.Point(376, 37);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(85, 69);
            this.BtnImprimir.TabIndex = 7;
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnImprimir, "Imprimir");
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            this.BtnImprimir.DragEnter += new System.Windows.Forms.DragEventHandler(this.BtnImprimir_DragEnter);
            this.BtnImprimir.MouseEnter += new System.EventHandler(this.BtnImprimir_MouseEnter);
            this.BtnImprimir.MouseLeave += new System.EventHandler(this.BtnImprimir_MouseLeave);
            // 
            // BtnExpedientes
            // 
            this.BtnExpedientes.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnExpedientes.BackgroundImage = global::ClinicaMedica.Properties.Resources.businessapplication_distributor_report_document_negocio_2319;
            this.BtnExpedientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExpedientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExpedientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnExpedientes.ForeColor = System.Drawing.Color.White;
            this.BtnExpedientes.Location = new System.Drawing.Point(285, 37);
            this.BtnExpedientes.Name = "BtnExpedientes";
            this.BtnExpedientes.Size = new System.Drawing.Size(85, 69);
            this.BtnExpedientes.TabIndex = 6;
            this.toolTip1.SetToolTip(this.BtnExpedientes, "Expediente");
            this.BtnExpedientes.UseVisualStyleBackColor = false;
            this.BtnExpedientes.MouseEnter += new System.EventHandler(this.BtnExpedientes_MouseEnter);
            this.BtnExpedientes.MouseLeave += new System.EventHandler(this.BtnExpedientes_MouseLeave);
            // 
            // BtnTurnos
            // 
            this.BtnTurnos.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnTurnos.ForeColor = System.Drawing.Color.White;
            this.BtnTurnos.Image = global::ClinicaMedica.Properties.Resources.organizer_calendar_clock_pencil_10047;
            this.BtnTurnos.Location = new System.Drawing.Point(194, 37);
            this.BtnTurnos.Name = "BtnTurnos";
            this.BtnTurnos.Size = new System.Drawing.Size(85, 69);
            this.BtnTurnos.TabIndex = 5;
            this.toolTip1.SetToolTip(this.BtnTurnos, "Turno");
            this.BtnTurnos.UseVisualStyleBackColor = false;
            this.BtnTurnos.MouseEnter += new System.EventHandler(this.BtnTurnos_MouseEnter);
            this.BtnTurnos.MouseLeave += new System.EventHandler(this.BtnTurnos_MouseLeave);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Image = global::ClinicaMedica.Properties.Resources.business_man_usersearch_thesearch_theclient_2356;
            this.BtnBuscar.Location = new System.Drawing.Point(103, 37);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(85, 69);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnBuscar, "Buscar");
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            this.BtnBuscar.MouseEnter += new System.EventHandler(this.BtnBuscar_MouseEnter);
            this.BtnBuscar.MouseLeave += new System.EventHandler(this.BtnBuscar_MouseLeave);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Image = global::ClinicaMedica.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevo.Location = new System.Drawing.Point(12, 37);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(85, 69);
            this.BtnNuevo.TabIndex = 3;
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnNuevo, "Agregar Paciente");
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            this.BtnNuevo.MouseEnter += new System.EventHandler(this.BtnNuevo_MouseEnter);
            this.BtnNuevo.MouseLeave += new System.EventHandler(this.BtnNuevo_MouseLeave);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 518);
            this.Controls.Add(this.LblIdMedico);
            this.Controls.Add(this.BtnConfigurar);
            this.Controls.Add(this.BtnCerrarS);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelUser);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.BtnBackup);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnExpedientes);
            this.Controls.Add(this.BtnTurnos);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Agenda_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelUser.ResumeLayout(false);
            this.PanelUser.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnTurnos;
        private System.Windows.Forms.Button BtnExpedientes;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnBackup;
        private System.Windows.Forms.Button BtnAyuda;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblNivel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnCerrarS;
        private System.Windows.Forms.Button BtnConfigurar;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Panel PanelUser;
        public System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblIdMedico;

    }
}