using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Tecnocom_Wolf
{
    class BaseDeDatos
    {
        /*Patron de diseño proxy*/
        SqlConnection Conexion = new SqlConnection("server = DESKTOP-P381C99; Initial Catalog =cpu_fix ; integrated security = true");
        
    }
}
