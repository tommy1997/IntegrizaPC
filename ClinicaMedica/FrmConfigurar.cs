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
    public partial class FrmConfigurar : Form
    {

        ClaseConfig configurar = new ClaseConfig();
        public FrmConfigurar()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfigurar_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnGuardarConfig_Click(object sender, EventArgs e)
        {
            if (TxtContraseniaNueva.Text==TxtRepetirContrasenia.Text)
            {
                configurar.ActualizarUser(TxtNickname.Text, TxtRepetirContrasenia.Text, LblIdMedicoConf.Text);
                MessageBox.Show("La Contraseña Ha Sido Modificada Es Necesario Iniciar Sesión De Nuevo");
                
                FrmLogin abrir = new FrmLogin();
                abrir.ShowDialog();
                this.Hide();


            }

            else
            {
                MessageBox.Show("La Contraseña No Coincide");
            }
        }
       
    }
}