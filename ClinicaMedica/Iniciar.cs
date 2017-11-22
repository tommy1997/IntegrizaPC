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
    public partial class Iniciar : Form
    {
        
        public Iniciar()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"img/izamalito.jpg");
            pictureBox1.Image = Image.FromFile(@"img/integriza.png");
            pictureBox2.Image = Image.FromFile(@"img/1.png");
            pictureBox3.Image = Image.FromFile(@"img/2.png");
            pictureBox4.Image = Image.FromFile(@"img/3.png");
            
            
        }

        private void Iniciar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        FrameBD TablaMedico = new FrameBD("localhost", 3306, "root", "admin", "clinica");
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(8);
            LblPorcentaje.Text = progressBar1.Value.ToString()+"%";

            if (LblPorcentaje.Text==Convert.ToString("100%"))
            {
                //timer1.Stop();
                timer1.Enabled = false;
                this.Hide();
                string Consulta = "SELECT COUNT(id_clinica) FROM clinica";
                string contar = "COUNT(id_clinica)";
                FrmRegistroClinica abrir = new FrmRegistroClinica();
                FrmLogin entrar = new FrmLogin();
                TablaMedico.Formularios(Consulta, contar, abrir, entrar);

            }


        }
    }
}
