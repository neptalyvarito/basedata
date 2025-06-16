using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Libreria_Conexion
{
    public class Conexion
    {
        public static SqlConnection cn = new SqlConnection("Server=.\\SQLEXPRESS;Database=LATAM_Airlines;Trusted_Connection=True;");

        public static DataTable Obtener_Aeropuertos()
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand("Select Cod_Aeropuerto, Cod_Aeropuerto + ', ' + Pais + ', ' + Ciudad AS DescripcionCompleta from Aeropuerto", cn);
            cn.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tbl);
            cn.Close();
            return tbl;
        }

        public static DataTable Obtener_Aeropuerto_Excepto(string cod_Aeropuerto)
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand("Obtener_Aeropuertos_Excepto", cn);
            cn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Cod_Aeropuerto", cod_Aeropuerto));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tbl);
            cn.Close();
            return tbl;
        }

        public static DataTable Obtener_Cabinas()
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand("Select Cod_Cabina, Tipo_Cabina from Cabina", cn);
            cn.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tbl);
            cn.Close();
            return tbl;
        }

        public static DataTable Obtener_Vuelo_Por_Fecha(string cod_Origen, string cod_Destino, DateTime fecha)
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand("Obtener_Vuelo_Por_Fecha", cn);
            cn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Cod_Aeropuerto_Origen", cod_Origen));
            cmd.Parameters.Add(new SqlParameter("@Cod_Aeropuerto_Destino", cod_Destino));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Salida", fecha));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tbl);
            cn.Close();
            return tbl;
        }

        public static DataTable Tarifa_Mas_Costo_Vuelo(string cod_Vuelo, string cod_Cabina)
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand("Tarifa_Mas_Costo_Vuelo", cn);
            cn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Cod_Vuelo", cod_Vuelo));
            cmd.Parameters.Add(new SqlParameter("@Cod_Cabina", cod_Cabina));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tbl);
            cn.Close();
            return tbl;
        }

    }
}
