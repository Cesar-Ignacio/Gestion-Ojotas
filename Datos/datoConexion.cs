using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Chancletas.Datos
{
    internal class datoConexion
    {

        private String candenaDeConexion = "Data Source=LAPTOP-VDD24BSI\\SQLEXPRESS;Initial Catalog=Chanclas;Integrated Security=True";
       
        SqlConnection conexion;

        public SqlConnection establecerConexion()
        {
            conexion=new SqlConnection(candenaDeConexion);
            conexion.Open();
            return conexion;
        }

        public bool verificarConexion()
        {
            try
            {
                
                SqlCommand coman = new SqlCommand();

                coman.CommandText = "select * from Chancletas";

                coman.Connection = establecerConexion();
               
                coman.ExecuteNonQuery();//ejecuat la consulta
                conexion.Close();


                return true;

            }
            catch (Exception ex)
            {
                return false;

            }

           
        }

        public DataSet obtenerTablaChancletas(String color)
        {
            string consulta = "select Chancletas.IdColor,Talle,NombreColor,CantidadPares,NombreMarca from Chancletas inner join Colores on Chancletas.IdColor = Colores.IdColor inner join Marcas on Marcas.CodMarca = Chancletas.CodMarca where NombreColor ='"+color+"'";
            SqlDataAdapter apadp = new SqlDataAdapter(consulta,establecerConexion());
            DataSet ds = new DataSet();
            apadp.Fill(ds,"Tabla");
            conexion.Close();
            return ds;
        }

    }
}
