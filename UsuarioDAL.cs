using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LlamandoDB
{
    internal class UsuarioDAL
    {
        public static int CrearCuenta(string NombreUsuario, string Pasword)
        {
            int Resultado = 0;
            SqlConnection Conn = conexion.coneccion();
            {
                SqlCommand Comando = new SqlCommand(String.Format("Insert Into Cuenta(NombreUsuario,Pasword)Values('{0}',HashBytes('MD5','{1}'))", NombreUsuario, Pasword), Conn);
                Resultado = Comando.ExecuteNonQuery();
            }return Resultado;
        }

        public static int Autenticar(string Nombre, string Contra, string Rol)
        {
            int Resultado = -1;
            SqlConnection Conn = conexion.coneccion();
            {
                SqlCommand Comando = new SqlCommand(string.Format("Select * From Cuenta Where NombreUsuario='{0}'and Pasword=HashBytes('MD5','{1}') and Rol='{2}'", Nombre, Contra, Rol ), Conn);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    Resultado = 50;
                }

            }
            Conn.Close();
            return Resultado;
        }
    }
}
