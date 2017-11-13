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
    public partial class FrmClinicaPsicologia : Form
    {
        ClasePacientes Procesos = new ClasePacientes();
        public FrmClinicaPsicologia()
        {
            InitializeComponent();
        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            Procesos.CargarImagen(TxtFoto, PicFoto);
        }

        private void BtnGuardarPacientes_Click(object sender, EventArgs e)
        {
            Procesos.AgregarPaciente(TxtNombrePaciente.Text, TxtApellidoPPA.Text, TxtApellidoMPA.Text, CmbGeneroPA, DtpFechaNaciPA, TxtCiudad.Text, TxtDireccionPA.Text, TxtTelcelPA.Text, TxtCorreo.Text, DtpFechaResgisPA, CmbTipoSangre, TxtFoto.Text);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
