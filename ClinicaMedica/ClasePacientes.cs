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

        public void mayor()
        {

        }


    }
}
