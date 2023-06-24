using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TRPOCUR
{
    class DataBase
    {
        MySqlConnection connect = new MySqlConnection("server=localhost;" + "port=3306;" + "username=root;" + "password=;" + "database=CURSE");


        public void OpenConnection()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }

        public void CloseConnection()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }

        public MySqlConnection GetConnection { get { return connect; } }




    }



}
