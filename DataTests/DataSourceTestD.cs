using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using DBUtilities;

namespace DataTests
{
    public class DataSourceTestD
    {
        static string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        static string proveedorDatos = ConfigurationManager.ConnectionStrings["ConnString"].ProviderName;

        public static DataTable Carga()
        {

            DbOperations consulta = new DbOperations(cadenaConexion, proveedorDatos);
            DataTable dt = new DataTable();

            string cmdSQL = "SELECT * FROM ARTICULOS";
            dt = consulta.Seleccion(cmdSQL);
            return dt;
        }

        public static DataTable CargaVentasEnc()
        {
            DbOperations consulta = new DbOperations(cadenaConexion, proveedorDatos);
            DataTable dt = new DataTable();

            string cmdSQL = "SELECT * FROM VENTAS_ENC";
            dt = consulta.Seleccion(cmdSQL);
            return dt;
        }

        public static DataTable CargaVentasDet(int numVenta)
        {
            DbOperations consulta = new DbOperations(cadenaConexion, proveedorDatos);
            DataTable dt = new DataTable();

            string cmdSQL = "SELECT * FROM VENTAS_DET WHERE NumVenta = " + numVenta;
            dt = consulta.Seleccion(cmdSQL);
            return dt;
        }

        public static DataTable TotalVentasMesArticulo()
        {
            DbOperations consulta = new DbOperations(cadenaConexion, proveedorDatos);
            DataTable dt = new DataTable();

            string cmdSQL = @"SELECT MONTH(VE.FechaVenta) Mes, A.NombreArticulo, SUM(VE.TotalVenta) Total
                                FROM VENTAS_ENC VE
                                INNER JOIN VENTAS_DET VD ON VE.NumVenta = VD.NumVenta
                                INNER JOIN ARTICULOS A
                                ON VD.IdArticulo = A.IdArticulo
                                GROUP BY MONTH(VE.FechaVenta), A.NombreArticulo
                                ORDER BY MONTH(VE.FechaVenta)";
            dt = consulta.Seleccion(cmdSQL);
            return dt;
        }
    }

}
