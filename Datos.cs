using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;


namespace AccesoADatos
{
    internal class Datos
    {
        string cadenaConexion = "Data Source=LAPTOP-CPFTA2IF; integrated security=true; initial catalog=Agenda; encrypt=false";
        SqlConnection conexion;

        private SqlConnection abrirConexion()
        {
            try
            {


                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();// Abrir conexion  a BD
                return conexion;



            }
            catch (Exception ex) 
            { 
             Console.WriteLine("Erorr al abrir la conexion: "+ex.Message);
                return null; 
            }
        
        }
        public bool prueba()
        {
            try
            {
                abrirConexion();
                return true;

            }
            catch (Exception ex) 
            { 
            return false;
            
            }
        
        
        }

        public DataSet consulta(String consulta)
        {
            try
            {
                DataSet ds= new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(consulta, abrirConexion());
                da.Fill(ds);
                return ds; 



            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                return null; 
            
            
            }
        
        
        
        
        }

        public bool comando(string consult)
        {
            try
            {

                SqlCommand cmd= new SqlCommand(consult, abrirConexion());
                cmd . ExecuteNonQuery();
                return true;



            }
            catch (Exception ex) 
            { 
            Console.WriteLine(ex.ToString()); 
                return false;
            
            }
        
        
        
        
        
        }






    }
}
