using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LlamandoDB
{
    internal class conexion
    {
        public static SqlConnection coneccion()
        {
            SqlConnection Conn = new SqlConnection("Data Source = DESKTOP-O7IVTKT;Initial Catalog = ConociendoSQL;Integrated Security = true");
            Conn.Open();
            return Conn;
        }
    }
}
