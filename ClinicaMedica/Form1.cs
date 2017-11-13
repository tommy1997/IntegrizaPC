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
    public partial class FrmClinica : Form
    {
        public FrmClinica()
        {
            InitializeComponent();
        }
        ClasePacientes Procesos = new ClasePacientes();
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmClinica_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Procesos.AgregarPaciente(TxtNombrePaciente.Text, TxtApellidoPPA.Text, TxtApellidoMPA.Text, CmbGeneroPA, DtpFechaNaciPA, TxtCiudad.Text, TxtDireccionPA.Text, TxtTelcelPA.Text, TxtCorreo.Text, DtpFechaResgisPA, CmbTipoSangre, TxtFoto.Text);
        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            Procesos.CargarImagen(TxtFoto, PicFoto);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
