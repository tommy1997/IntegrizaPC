using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica
{
    class ClaseLogin
    {
        FrameBD TablaMedico = new FrameBD("localhost", 3306, "root", "admin", "clinica");
        public void ExistenciaUsuarios(ComboBox CmbExis)
        {
           
            try
            { 
                string existe = "SELECT COUNT(id_usuario), nickname" +
                            "FROM usuario ";


                CmbExis.DataSource = TablaMedico.SQLCOMBO(existe);
                CmbExis.DisplayMember = "especialidad";
                CmbExis.ValueMember = "id_usuario";
            }
            catch (Exception)
            {

                //MessageBox.Show("Las Especilidades No Se pueden Filtrar");
            }
            

        }

        
    }
}
