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
    public partial class FrmBuscarPacientes : Form
    {

        ClasePacientes procesos = new ClasePacientes();
        public FrmBuscarPacientes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmBuscarPacientes_Load(object sender, EventArgs e)
        {
            procesos.FiltroDePacientes(DgvPacientesBuscar);
            procesos.FiltroDePacientesBajas(DgvPacientesBajas);

        }

        private void TxtNombreBajas_TextChanged(object sender, EventArgs e)
        {
            procesos.BuscarBajas(DgvPacientesBajas, TxtNombreBajas.Text, TxtApellidoBajas.Text);
        }

        private void TxtNombreBuscar_TextChanged(object sender, EventArgs e)
        {
            procesos.Buscar(DgvPacientesBuscar, TxtNombreBuscar.Text, TxtApellidoBuscar.Text);
        }

        private void TxtApellidoBuscar_TextChanged(object sender, EventArgs e)
        {
            procesos.Buscar(DgvPacientesBuscar, TxtNombreBuscar.Text, TxtApellidoBuscar.Text);
        }

        private void TxtApellidoBajas_TextChanged(object sender, EventArgs e)
        {
            procesos.BuscarBajas(DgvPacientesBajas, TxtNombreBajas.Text, TxtApellidoBajas.Text);
        }

        private void BtnCancelarBajas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalirBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Estás seguro de dar de baja?", "Se requiere confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                procesos.DarBajasPacientes(DgvPacientesBuscar);
                procesos.FiltroDePacientes(DgvPacientesBuscar);
                procesos.FiltroDePacientesBajas(DgvPacientesBajas);
            }
            else
            {
                procesos.FiltroDePacientes(DgvPacientesBuscar);
                procesos.FiltroDePacientesBajas(DgvPacientesBajas);
            }
            
        }
        FrameBD TablaMedico = new FrameBD("localhost", 3306, "root", "admin", "clinica");
        private void button2_Click(object sender, EventArgs e)
        {
            FrmClinica nue = new FrmClinica();

            string Consulta = "SELECT COUNT(id_tratamiento) FROM tratamiento";
            string contar = "COUNT(id_tratamiento)";
           // TablaMedico.Formularios(Consulta, contar, nue);
        }
    }
}
