using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace StudentGrades
{
    internal class GradesDB
    {
        private MySqlConnection connect = new MySqlConnection("server=localhost;user=root;database=nacit;port=3306;password=J900)9ew&AA$#");
        // initializing the dbconnection and storing it into the variable connect
        public MySqlConnection Conn 
        {
            get { return connect; }
        }
        public void OpenConn()
        {
            if (connect.State == System.Data.ConnectionState.Closed) // This opens the db connection if it is off
            {
                connect.Open();
            }

        }
        public void CloseConn()
        {
            if (connect.State == System.Data.ConnectionState.Open) // closes the db connection if it is on for secuirity purpose
            {
                connect.Close();
            }

        }
        

    }
}
