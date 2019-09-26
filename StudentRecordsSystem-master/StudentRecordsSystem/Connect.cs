using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentRecordsSystem
{
    public static class Connect
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=|DataDirectory|\Db\Database1.mdf;  
         Integrated Security=True";

        public static Users GetUsers(string Login, string Password)
        {
            Users user = new Users();
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand command2 = new SqlCommand(
                String.Format("SELECT * FROM [dbo].[Users] /*user*/ " +
                "WHERE Users.password = '{0}' AND Users.login = '{1}'", Password, Login), conn);
                SqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {

                    user.login = reader.GetValue(1).ToString();
                    user.password = reader["password"].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Введён неверный логин или пароль");
            }
            finally
            {
                conn.Close();
            }

            return user;
        }

    }
}
