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
    public partial class FrmMedico : Form
    {
        public FrmMedico()
        {
            InitializeComponent();
        }
        FrameBD TablaMedico = new FrameBD("localhost", 3306, "root", "admin", "clinica");

        ClaseMedico procesos = new ClaseMedico();
        private void FrmMedico_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
           // procesos.logotipos(TxtLogo, PicImagen,"avatar.png");

            procesos.especilidad(CmbEspecial);
          

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogo_Click(object sender, EventArgs e)
        {
            procesos.CargarImagen(TxtLogo,PicImagen);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtApellidoPat.Clear();
            TxtApellidoMat.Clear();
            TxtEdad.Clear();
            TxtCurp.Clear();
            TxtRFC.Clear();
            TxtDireccion.Clear();
            TxtTelcel.Clear();
            TxtEmail.Clear();

            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            GbResgistro.Visible = true;
            procesos.agregarmedico(CmbEspecial, TxtNombre.Text, TxtApellidoPat.Text, TxtApellidoMat.Text, TxtCedula.Text, DtpFechaNaciemiento, TxtEdad.Text, CmbGenero, TxtCurp.Text, TxtRFC.Text, TxtDireccion.Text, TxtTelcel.Text, TxtEmail.Text, TxtLogo.Text);
            procesos.FiltroClinica(CmbClinicaLogin);
            procesos.FiltroMedico(CmbMedicosFil);
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void GbResgistro_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelarRegistro_Click(object sender, EventArgs e)
        {
            TxtUsuario.Clear();
            TxtContrasenia.Clear();
            procesos.EliminarMedico(CmbMedicosFil);
            GbResgistro.Visible = false;
        }

        private void BtnGuardarRegistro_Click(object sender, EventArgs e)
        {
            procesos.RegistroUser(CmbClinicaLogin, CmbMedicosFil, TxtUsuario.Text, TxtContrasenia.Text);
            this.Hide();

            FrmLogin abrir = new FrmLogin();
            abrir.Show();

        }
    }
}
