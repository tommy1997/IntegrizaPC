using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClinicaMedica
{

    
    class Auth
    {
        private string tabla;
        private string campousuario;
        private string campopass;
        private string valoruser;
        private string valorpass;
        private Boolean statususer;
        private Boolean statuspass;
        private string UsuarioQueAccede;
        private string NivelUsuarioAccede;

        private string IdMedic;
        private string tabla2;
             

        FrameBD TablaUser = new FrameBD("localhost", 3306, "root", "admin", "clinica");
        //Constructor de la clase
        public Auth(string tabla, string campousuario, string campopass,string valoruser,string valorpass, string tabla2)
        {
            this.tabla = tabla;
            this.campousuario = campousuario;
            this.campopass = campopass;
            this.valoruser = valoruser;
            this.valorpass = valorpass;
            this.tabla2 = tabla2;

        }

        public void DatosUser()
        {

            /*string GetDatos = "SELECT " + campousuario + "," + campopass + ", usuario, IdTipoUsuario "+
                              " FROM " + tabla + 
                              " WHERE " + campousuario + "='" + valoruser + "'";*/


            string GetDatos = "SELECT " + campousuario + "," + campopass + ",medico.nombre,medico.apellido_pat,medico.apellido_mat, usuario.nivel,medico.id_medico" +
                         " FROM " + tabla + 
                         " INNER JOIN "+ tabla2 +" ON usuario.id_medico=medico.id_medico"+
                         " WHERE " + campousuario + "='" + valoruser + "'";

            MySqlDataReader Drus = TablaUser.SQLReader(GetDatos);

        if (Drus.HasRows== true)
            {
            ExisteUsuario=true;
                while (Drus.Read())
                {
                    string pass= Drus.GetString(1);
                    string usuario = Drus.GetString(2) + " " + Drus.GetString(3) + " " + Drus.GetString(4);
                    string nivel = Drus.GetString(5);
                    string IdMedico = Drus.GetString(6);
                    this.IdMedic = IdMedico;
                    this.UsuarioQueAccede = usuario;
                    this.NivelUsuarioAccede = nivel;

                    if (pass==valorpass)
                    
                        PassOk = true;
                    else
                        PassOk=false;

                    
                        


                }
         
            }

        else
            ExisteUsuario=false;


            

        }


        public Boolean ExisteUsuario
        {
            get
            {
                return this.statususer;
            }
            set
            {
                this.statususer =value;
            }
        }


        public Boolean PassOk
        {
            get
            {
                return this.statuspass;
            }
            set
            {
                this.statuspass = value;
            }
        }


        public String MIdMedic
        {
            get
            {
                return this.IdMedic;
            }

            set
            {
                this.IdMedic = value;
            }


        }

        public String QueUsuarioAccede
        {
            get
            {
                return this.UsuarioQueAccede;
            }

            set
            {
                this.UsuarioQueAccede = value;
            }


        }


        public String QueNivelUsuarioAccede
        {
            get
            {
                return this.NivelUsuarioAccede;
            }

            set
            {
                this.NivelUsuarioAccede = value;
            }


        }



    }

    


}
