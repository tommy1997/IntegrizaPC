using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            timer1.Start();
            
            
            //DatosAcceso(LblNivel.Text, LblNivel.Text);

        }

        public void DatosAcceso(string user, string nivel)
        {
           this.LblNombre.Text = user;
           this.LblNivel.Text = nivel;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmClinica Abrir = new FrmClinica();
            Abrir.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.Close();
            FrmLogin abrir = new FrmLogin();
            abrir.Show();
        }

        private void BtnNuevo_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightSlateGray;
            btn.ForeColor = Color.White;
        }

        private void BtnNuevo_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DeepSkyBlue;
            btn.ForeColor = Color.White;
        }

        private void BtnBuscar_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DeepSkyBlue;
            btn.ForeColor = Color.White; 
        }

        private void BtnBuscar_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightSlateGray;
            btn.ForeColor = Color.White;
        }

        private void BtnTurnos_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightSlateGray;
            btn.ForeColor = Color.White;
        }

        private void BtnTurnos_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DeepSkyBlue;
            btn.ForeColor = Color.White;
        }

        private void BtnExpedientes_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DeepSkyBlue;
            btn.ForeColor = Color.White;
        }

        private void BtnExpedientes_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightSlateGray;
            btn.ForeColor = Color.White;
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void BtnImprimir_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void BtnImprimir_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DeepSkyBlue;
            btn.ForeColor = Color.White;
        }

        private void BtnImprimir_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightSlateGray;
            btn.ForeColor = Color.White;
        }

        private void BtnBackup_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DeepSkyBlue;
            btn.ForeColor = Color.White;
        }

        private void BtnBackup_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightSlateGray;
            btn.ForeColor = Color.White;
        }

        private void BtnAyuda_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DeepSkyBlue;
            btn.ForeColor = Color.White;
        }

        private void BtnAyuda_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightSlateGray;
            btn.ForeColor = Color.White;
        }

        private void BtnCerrarS_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DeepSkyBlue;
            btn.ForeColor = Color.White;
        }

        private void BtnCerrarS_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightSlateGray;
            btn.ForeColor = Color.White;
        }

        private void BtnSalir_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.White;
        }

        private void BtnSalir_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightSlateGray;
            btn.ForeColor = Color.White;
        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DeepSkyBlue;
            btn.ForeColor = Color.White;
        }

        private void BtnConfigurar_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightSlateGray;
            btn.ForeColor = Color.White;
        }

        
    }
}
