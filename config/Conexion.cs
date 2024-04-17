using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MATRICULA.config
{
    class Conexion
    {
        public static SqlConnection Conectar()
            {

            SqlConnection Conexion = new SqlConnection("server=DESKTOP-0I3N4F0\\SQLEXPRESS; database= BD_CRUD; Trusted_Connection=True;");
            Conexion.Open();


            return Conexion;

        }
    }
}
