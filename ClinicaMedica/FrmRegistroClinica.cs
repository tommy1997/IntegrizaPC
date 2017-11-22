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
    public partial class FrmRegistroClinica : Form
    {

        ClaseClinica clinica = new ClaseClinica();
        public FrmRegistroClinica()
        {
            InitializeComponent();
        }

        private void FrmRegistroClinica_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void TxtInstitucion_TextChanged(object sender, EventArgs e)
        {
            LblNombreClinica.Text = TxtNombreClinica.Text;
        }

        private void PicLogoHead_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            FrmMedico abrir = new FrmMedico();
            //FrmRegistroClinica cerrar = new FrmRegistroClinica();
            clinica.RegistroClinica(TxtNombreClinica.Text, TxtRfc.Text, TxtNumConsultorio.Text, TxtCiudad.Text,TxtDireccion.Text, TxtTelefono.Text, TxtEmail.Text, TxtWeb.Text, TxtLogoClinica.Text);
            abrir.Show();
            this.Hide();
            
            
        }

        private void BtnLogotipoClinica_Click(object sender, EventArgs e)
        {
            clinica.CargarImagen(TxtLogoClinica, PicLogotipo);
        }

        private void BtnCancelarClinica_Click(object sender, EventArgs e)
        {
            TxtNombreClinica.Clear();
            TxtRfc.Clear();
            TxtNumConsultorio.Clear();
            TxtCiudad.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
            TxtWeb.Clear();
            TxtLogoClinica.Clear();
            this.Close();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
