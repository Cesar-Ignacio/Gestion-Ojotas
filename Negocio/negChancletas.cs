using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chancletas.Datos;
using System.Data;
using System.Data.SqlClient;
namespace Chancletas.Negocio
{
    internal class negChancletas
    {
       /*public String codColor { get; set; }
        public int talle { get; set; }
        public String codMarca { get; set; }
        public int cantidadPares { get; set; }
        */

        public DataTable ObtenerChancletas(String color)
        {
        
            datoConexion da=new datoConexion();

            DataSet ds=new DataSet();
            ds=da.obtenerTablaChancletas(color);
            return ds.Tables["Tabla"];
        }

    }
}
