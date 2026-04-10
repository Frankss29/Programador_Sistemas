using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hamburgueria
{
    public class Conexao
    {
       private static string conexao ="server=localhost;user=root;password=;database=hamburgueria";

        public MySqlConnection Conectar()
        {
            return new MySqlConnection(conexao);
        }
    }

}
