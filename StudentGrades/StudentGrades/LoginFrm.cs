using MySql.Data.MySqlClient;
using System.Data.Common;

namespace StudentGrades
{
    public partial class LoginFrm : Form
    {
        private GradesDB gdb;
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            //
            //return;
            gdb = new GradesDB();
            gdb.OpenConn();
            MessageBox.Show("Conection succesful");



            /*string query = "SELECT * FROM subjects;";
            using (var cmd = new MySqlCommand(query, gdb.Conn)) 
            {
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        MessageBox.Show(rdr.GetString("subjectname"));
                    }
                }
            }*/

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // TODO: validate username
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string sql = $"SELECT * FROM teacher WHERE username = {username} AND passworduser = {password}";

            // 3. Create and Execute Command
            using (MySqlCommand cmd = new MySqlCommand(sql, gdb.Conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                   // 4. Read Data
                        while (reader.Read())
                    {
                        // Access data by column name or index
                        MessageBox.Show($"Name: {reader["username"]}");
                    }
                }
            }
        }
    }

}
