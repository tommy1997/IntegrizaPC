using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    class Conect
    {
        public void conectando(string localhost, uint puerto, string user, string pass,string database)
        {
            FrameBD MiConect = new FrameBD(Convert.ToString(localhost), Convert.ToUInt32(puerto), Convert.ToString(user), Convert.ToString(pass), Convert.ToString(database));
        } 


    }
}
