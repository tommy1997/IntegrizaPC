using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    class ClaseConfig
    {
        FrameBD user = new FrameBD("localhost", 3306, "root", "admin", "clinica");

        public void TraerDoctor()
        {
           // string Dortor="SELECT "
        }


        public void ActualizarUser(string nickname,string pass, string iduser)
        {
            string Actualizar =  "UPDATE usuario SET nickname='"+nickname+"', password='"+pass+"'"+
                                 " WHERE id_usuario='"+iduser+"'";
            user.SQLIDU(Actualizar);



               /* string modifcitas =  "UPDATE citas SET citas.Fecha='"+Dtpfecha.Value.ToString("yyyy-MM-dd")+"', citas.IdHoras='"+Cmbhoras.SelectedValue+"'" +
                                " WHERE citas.IdPacientes='"+idpaciente+"'";
           citas.SQLIDU(modifcitas);*/

        }

    }
}
