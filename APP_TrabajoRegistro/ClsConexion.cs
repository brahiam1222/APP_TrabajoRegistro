using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace APP_TrabajoRegistro
{
    public class ClsConexion
    {

        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-TPFOTU3;Initial Catalog=DBAspirantes;integrated Security = true");


    }
}