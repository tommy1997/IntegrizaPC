using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ClinicaMedica
{
    class ClasePacientes
    {
        FrameBD TablaPacientes = new FrameBD("localhost", 3306, "root", "admin", "clinica");

        public void AgregarPaciente(string nombre, string apelidopat, string apellidomat,ComboBox genero, DateTimePicker fechanaciemieto, string ciudad,string direccion, string telcel, string correo, DateTimePicker fecharegistro, ComboBox tiposangre, string foto)
        {
              try
              {
                  string Addpaciente = "INSERT INTO paciente(nombre,apellido_pat,apellido_mat,genero,fecha_nacimiento,ciudad,direccion,tel_cel,correo,fecha_registro,tipo_sangre,foto) VALUES('" + nombre + "','" + apelidopat + "','" + apellidomat + "','" + genero.SelectedItem + "','" + fechanaciemieto.Value.ToString("yyyy-MM-dd") + "','"+ ciudad + "','" + direccion + "','" + telcel + "','" + correo + "','" + fecharegistro.Value.ToString("yyyy-MM-dd") + "','" + tiposangre.SelectedItem + "','" + foto + "')";
                  TablaPacientes.SQLIDU(Addpaciente);

                  MessageBox.Show("Datos ingresados");
              }
              catch (Exception)
              {

                  MessageBox.Show("Hubo Un Error En El Registro");
              }
            
        }

        public void CargarImagen(TextBox TxtLogotipo, PictureBox PicImg)
        {
            try
            {
                OpenFileDialog SELECCIONAR = new OpenFileDialog();
                SELECCIONAR.Title = "SELECCIONE UNA IMAGEN";
                SELECCIONAR.Filter = "IMAGEN|*.jpg; *.png";
                SELECCIONAR.FileName = "";

                if (SELECCIONAR.ShowDialog() == DialogResult.OK)
                {
                    string ruta = SELECCIONAR.FileName;
                    TxtLogotipo.Text = ruta;
                    PicImg.Image = Image.FromFile(ruta);

                    // PicImg.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo cargar la imagen");
            }

        }


        public void Buscar()
        {
            
        }

        public void FiltroDePacientes(DataGridView DgvPacientes)
        {
            try
            {
                string filtro = "SELECT id_paciente as ID, nombre as NOMBRE, apellido_pat as 'APELLIDO PATERNO',apellido_mat as 'APELLIDO MATERNO' FROM paciente WHERE `status`='A'";
                                DgvPacientes.DataSource = TablaPacientes.SQLSEL(filtro);
                                DgvPacientes.DataMember = "datos";
            }
            catch (Exception)
            {

                MessageBox.Show("No Se Pudieron Filtrar Los Datos");
            }

        }

        public void FiltroDePacientesBajas(DataGridView DgvPacientesBajas)
        {
            try
            {
                string filtro = "SELECT id_paciente as ID, nombre as NOMBRE, apellido_pat as 'APELLIDO PATERNO',apellido_mat as 'APELLIDO MATERNO' FROM paciente WHERE `status`='D'";
                DgvPacientesBajas.DataSource = TablaPacientes.SQLSEL(filtro);
                DgvPacientesBajas.DataMember = "datos";
            }
            catch (Exception)
            {

                MessageBox.Show("No Se Pudieron Filtrar Los Datos");
            }

        }

        public void Buscar( DataGridView DgvPacientes, string Nombre, string Apellido)
        {
            string BuscarPacientes = "SELECT id_paciente as ID, nombre as NOMBRE, apellido_pat as 'APELLIDO PATERNO',apellido_mat as 'APELLIDO MATERNO' FROM paciente WHERE `status`='A' AND nombre LIKE '%" + Nombre + "%' AND apellido_pat LIKE '%" + Apellido + "%'";
            DgvPacientes.DataSource = TablaPacientes.SQLSEL(BuscarPacientes);
            DgvPacientes.DataMember = "datos";
        }


        public void BuscarBajas(DataGridView DgvPacientes, string Nombre, string Apellido)
        {
            string BuscarPacientes = "SELECT id_paciente as ID, nombre as NOMBRE, apellido_pat as 'APELLIDO PATERNO',apellido_mat as 'APELLIDO MATERNO' FROM paciente WHERE `status`='D' AND nombre LIKE '%" + Nombre + "%' AND apellido_pat LIKE '%" + Apellido + "%'";
            DgvPacientes.DataSource = TablaPacientes.SQLSEL(BuscarPacientes);
            DgvPacientes.DataMember = "datos";
        }

        ///DAR BAJAS A PACIENTES
        ///
        public void DarBajasPacientes(DataGridView DgvPacientesBuscar)
        {


            string DarBaja = "UPDATE paciente SET `status`='D'" +
                                " WHERE id_paciente='" + Convert.ToString(DgvPacientesBuscar[0, DgvPacientesBuscar.CurrentCellAddress.Y].Value) + "'";
            TablaPacientes.SQLIDU(DarBaja);
        }
    }
}
