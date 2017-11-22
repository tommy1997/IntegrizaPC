using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace ClinicaMedica
{
    class ClaseClinica
    {
        FrameBD TablaClinica = new FrameBD("localhost", 3306, "root", "admin", "clinica");

        public void RegistroClinica(string NombreClinic, string RFC, string numclinic, string ciudad,string direccion, string telefono, string email, string web, string logotipo)
        {
            try
            {
                string clinica = "INSERT INTO clinica(nombre_clinica,RFC,num_consultorio,ciudad,direccion,telefono,email,web,logotipo) VALUES('" + NombreClinic + "','" + RFC + "','" + numclinic + "','" + ciudad + "','" + direccion + "','" + telefono + "','" + email + "','" + web + "','" + logotipo + "')";
                TablaClinica.SQLIDU(clinica);
                MessageBox.Show("Datos Registrados");
                
               
            }
            catch (Exception)
            {

                MessageBox.Show("No se a podido guardar los datos por favor verifique que los campos esten llenos correctamente");
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


    }
}
