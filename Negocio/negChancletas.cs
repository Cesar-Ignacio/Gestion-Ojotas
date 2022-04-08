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
        public DataTable obtenerChancletaPorTalle(String talle)
        {
            datoConexion con=new datoConexion();
            DataSet ds = new DataSet();
            ds = con.obtenerTablaChancletasPorTalle(talle);
            return ds.Tables["Tabla"];
        }
        public DataTable obtenerChancletasPorMarca(string marca)
        {
            datoConexion con = new datoConexion();
            DataSet ds = new DataSet();
            ds=con.obtenerTablaChancletasPorMarca(marca);
            return ds.Tables["Tabla"];
        }

        public DataTable obtenerChancletasPorColorTallMarca(string color,string talle,string marca)
        {
            datoConexion cn = new datoConexion();

            DataSet ds = new DataSet();
            ds = cn.obtenerTablaChancletaColorTallMarca(color,talle,marca);

            return ds.Tables["Tabla"];

        }

    }
}
