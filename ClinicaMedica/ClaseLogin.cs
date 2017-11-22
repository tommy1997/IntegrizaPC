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
        public void ExistenciaUsuarios()
        {
           
            try
            {

                // TablaMedico = new FrameBD("localhost", 3306, "root", "admin", "clinica");

                string Consulta = "SELECT COUNT(id_clinica) FROM clinica";
                string contar = "COUNT(id_clinica)";
                FrmRegistroClinica abrir = new FrmRegistroClinica();

                //TablaMedico.Formularios(Consulta, contar, abrir);

               


            }
            catch (Exception)
            {

                //MessageBox.Show("Las Especilidades No Se pueden Filtrar");
            }
            

        }

        
    }
}
