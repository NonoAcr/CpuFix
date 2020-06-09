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
        SqlConnection Conexion = new SqlConnection("server = LAPTOP-43NCBRR5\\SQLEXPRESS; Initial Catalog =cpu_fix ; integrated security = true");
        
    }
}
