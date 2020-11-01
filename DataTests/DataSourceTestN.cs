using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DBUtilities;
using System.Configuration;

namespace DataTests
{
    public class DataSourceTestN
    {
        public static DataTable Carga()
        {
            return DataSourceTestD.Carga();
        }

        public static DataTable CargaVentasEnc()
        {
            return DataSourceTestD.CargaVentasEnc();
        }

        public static DataTable CargaVentasDet(int numVenta)
        {
            return DataSourceTestD.CargaVentasDet(numVenta);
        }

        public static DataTable TotalVentasMesArticulo()
        {
            DataTable dt = DataSourceTestD.TotalVentasMesArticulo() ;
            return dt;
        }
    }
}
