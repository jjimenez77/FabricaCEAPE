using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Datos
{
    class Conexion
    {
        public static string conexion = "data source=VIVOBOOK\\SQLEXPRESS; initial catalog = FabricaCEAPE; integrated security=true";
        public static string Connection
        {
            get { return conexion; }
        }
    }
}
