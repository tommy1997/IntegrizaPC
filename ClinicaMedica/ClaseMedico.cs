using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace ClinicaMedica
{
    class ClaseMedico
    {
        FrameBD TablaMedico = new FrameBD("localhost", 3306, "root", "admin", "clinica");

        public void agregarmedico(ComboBox idespecialidad, string Nombre, string ApellidoP, string ApellidoM, string Cedulaprof, DateTimePicker FechaNacimiento,string Edad, ComboBox CmbGen, string curp, string RFC, string dirrecion, string telefono, string imail, string logo, GroupBox Res)
        {
           try
            {
            string AddMedico = "INSERT INTO medico(id_especialidad,nombre,apellido_pat,apellido_mat,cedula_prof,fecha_nacimiento,edad,genero,curp,RFC,direccion,telefono,email,logo) VALUES('" + idespecialidad.SelectedValue + "','" + Nombre + "','" + ApellidoP + "','" + ApellidoM + "','" + Cedulaprof + "','" + FechaNacimiento.Value.ToString("yyyy-MM-dd") + "','" + Edad + "','" + CmbGen.SelectedItem + "','" + curp + "','" + RFC + "','" + dirrecion + "','" + telefono + "','" + imail + "','" + logo + "')";
                TablaMedico.SQLIDU(AddMedico);

                MessageBox.Show("Datos Ingresados Correctamente");
                Res.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo Un Error En El Registro");
            }

        }

        public void especilidad(ComboBox CmbEspecialidades)
        {
            try
            {
                string especialidades = "SELECT * " +
                                       " FROM especialidad ";

                CmbEspecialidades.DataSource = TablaMedico.SQLCOMBO(especialidades);
                CmbEspecialidades.DisplayMember = "especialidad";
                CmbEspecialidades.ValueMember = "id_especialidad";
            }
            catch (Exception)
            {

                MessageBox.Show("Las Especilidades No Se pueden Filtrar");
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

                MessageBox.Show("No se puede cargar la imagen");
            }
            
        }

        public void logotipos(TextBox TxtLogo, PictureBox PicImagen, string avantar)
        {
            TxtLogo.Text = @"C:\Users\MARTIN\Documents\Visual Studio 2012\Projects\ClinicaMedica\ClinicaMedica\Resources\" + avantar;

            PicImagen.Image = Image.FromFile(TxtLogo.Text);
        }
        /// <summary>
        /// //////////
        /// </summary>
        /// <param name="CmbClinicaLogin"></param>
        public void FiltroClinica(ComboBox CmbClinicaLogin)
        {
            try
            {
                string clinica = "SELECT * " +
                                       " FROM clinica";

                CmbClinicaLogin.DataSource = TablaMedico.SQLCOMBO(clinica);
                CmbClinicaLogin.DisplayMember = "nombre_clinica";
                CmbClinicaLogin.ValueMember = "id_clinica";
            }
            catch (Exception)
            {

                MessageBox.Show("Las clinica No Se pueden Filtrar");
            }
        }

        public void FiltroMedico(ComboBox CmbMedico)
        {
            try
            {
                string medico = "SELECT * " +
                                       " FROM medico "+
                                       "ORDER BY id_medico DESC ";

                CmbMedico.DataSource = TablaMedico.SQLCOMBO(medico);
                CmbMedico.DisplayMember = "nombre";
                CmbMedico.ValueMember = "id_medico";
            }
            catch (Exception)
            {

               // MessageBox.Show("Las Especilidades No Se pueden Filtrar");
            }
        }

        public void RegistroUser(ComboBox CmbClinicaLogin, ComboBox idmedico, string nickname, string password)
        {
            try
            {
                string Registro = "INSERT INTO usuario(id_clinica,id_medico,nickname,password)VALUES('" + CmbClinicaLogin.SelectedValue + "','" + idmedico.SelectedValue + "','" + nickname + "','" + password + "')";
                TablaMedico.SQLIDU(Registro);
            }
            catch (Exception)
            {

                MessageBox.Show("Datos Registrados Correctamente");
            }
            
        }

        public void EliminarMedico(ComboBox CmbIdmedico)
        {
            string Eliminar = "DELETE FROM medico WHERE id_medico = '"+CmbIdmedico.SelectedValue+"'";
            TablaMedico.SQLIDU(Eliminar);


            /*string Eliminaruser = "DELETE FROM usuario WHERE id_medico = '" + CmbIdmedico.ValueMember + "'";
            TablaMedico.SQLIDU(Eliminaruser);*/


        }

        public void EliminarClinica(ComboBox CmbIdClinica)
        {
            string Eliminar = "DELETE FROM clinica WHERE id_clinica='" + CmbIdClinica.SelectedValue + "'";
            TablaMedico.SQLIDU(Eliminar);
        }



    }
}
