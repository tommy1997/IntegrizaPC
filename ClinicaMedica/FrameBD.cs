using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
namespace ClinicaMedica

{
   
  class FrameBD
    {
        //string ser;
        //string por;
        //string pas;
        //string use;
        //string db;
        MySqlConnection conex = new MySqlConnection();
       
        private string servidor;
        private uint puerto;
        private string usuario;
        private string password;
        private string bd;
        

      public FrameBD(string servidor, uint puerto, string usuario, string password, string bd)
        {
            // TODO: Complete member initialization
            this.servidor = servidor;
            this.puerto= puerto;
            this.usuario= usuario;
            this.password= password;
            this.bd= bd;


            conex.Close();
            MySqlConnectionStringBuilder conexs = new MySqlConnectionStringBuilder();
            conexs.Server = servidor;
            conexs.Port = puerto;//Convert.ToUInt32(por);
            conexs.Password = password; //pas;
            conexs.UserID = usuario; //use;
            conexs.Database = bd;

            //MySqlConnection conex = new MySqlConnection(conexs.ToString() );
            conex.ConnectionString = conexs.ConnectionString;
            //MySqlConnection conn = new MySqlConnection(builder.ToString());


            conex.Open(); 
            
        }

      public FrameBD()
      {
          // TODO: Complete member initialization
      }
         
      public void conectar() 
        {
            conex.Close(); 
            conex.Open(); 
              
        }


      public  DataSet SQLSEL(string sql)
      {
          conectar();

          MySqlDataAdapter Adaptador = new MySqlDataAdapter(sql, conex);
          DataSet RsDatos = new DataSet();
          Adaptador.Fill(RsDatos, "datos");
          //SQLSEL = RsDatos;
          return (RsDatos);
          //conex.Close(); 
      }

      //TRABAJA CON COMBOBOX

      public DataTable SQLCOMBO(string sql) 
      {
          conectar();
          MySqlDataAdapter Adap = new MySqlDataAdapter(sql,conex);
          DataTable DT = new DataTable();
          Adap.Fill(DT);
          return DT;
 
      }

      //Permite ejecutar comandos INSERT, DELETE Y UPDATE
      // De ahi deriva el IDU
      public void SQLIDU(string sql) 
      {
          try
          {
              conectar();
              MySqlCommand comando = new MySqlCommand(sql, conex);
              comando.ExecuteNonQuery();
              //conex.Close();

          }
          catch (MySqlException) 
          {
              
               throw;
          }
          
      }
      /////////7//////
     

      
      // <summary>
      /// /*/
      /// </summary>
      /// <param name="sql"></param>
      /// <returns></returns>
      public MySqlDataReader SQLReader(string sql) 
      {
          conectar();
          MySqlCommand comando = new MySqlCommand(sql, conex);
          
         MySqlDataReader Dr = comando.ExecuteReader();
          return Dr;


      }


     

      
      /*
       *Public Function SQLREADER(ByVal sql) As MySqlDataReader
        Try
            conectar()
            Dim comando As New MySqlCommand(sql, conex)
            Dim Dr As MySqlDataReader
            Dr = comando.ExecuteReader()
            Return Dr
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
       */

      public static DataTable Buscar(string nombre)
      {
          DataTable dt = new DataTable();

         // SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());//cadena conexion

         // string consulta = "SELECT id,apellido,edad FROM PERSONA WHERE nombre=@nombre"; //consulta

        //SqlCommand comando = new SqlCommand(consulta, conexion);
         //comando.Parameters.AddWithValue("@nombre", nombre);
         // SqlDataAdapter adap = new SqlDataAdapter(comando);
         // adap.Fill(dt);

          return dt;
      }

      public MySqlDataReader sqlreader(string sql)
      {
          conectar();
          
          MySqlCommand comando = new MySqlCommand(sql, conex);

          MySqlDataReader leer = comando.ExecuteReader();


          if (leer.Read()==true)
          {
              MessageBox.Show(Convert.ToString(leer));
          }
           return leer;
      }

    }





}
