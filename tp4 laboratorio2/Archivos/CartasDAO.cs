using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Archivos
//{
//    public static class CartasDAO
//    {

//        private static SqlCommand comando;
//        private static SqlConnection conexion;


//        static CartasDAO()
//        {
//            comando = new SqlCommand();
//            conexion = new SqlConnection("Data Source = localhost; DataBase = Master; Trusted_Connection = True;");

//        }


//        public static bool Insertar( persona)
//        {
//            bool retorno = false;

//            try
//            {
//                comando.Parameters.Clear();
//                conexion.Open();
//                comando.Connection = conexion;
//                comando.CommandType = CommandType.Text;
//                comando.CommandText = "INSERT INTO Clientes_Facturacion1([codigoCliente],[FacturacionTotal])" + "VALUES (@codCliente, @facturacion)";

//                comando.Parameters.AddWithValue("@codCliente", persona.CodigoPersona);
//                comando.Parameters.AddWithValue("@facturacion", persona.MontoTotal);
//                comando.ExecuteNonQuery();
//                retorno = true;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//            finally
//            {
//                if (conexion.State == ConnectionState.Open)
//                {
//                    conexion.Close();

//                }
//            }


//            return retorno;



//        }

//    }
//}
