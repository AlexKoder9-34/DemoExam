using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exam
{
    public class UsersController
    {
        string connectionString = "Data Source=DESKTOP-1A6GQ2D\\SQLEXPRESS;Initial Catalog = practiceDB;Integrated Security=True;Persist Security Info=False;";
        public bool LoginUser(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand select = new SqlCommand(@"SELECT [Логин],[Пароль] FROM Employees WHERE([Логин] = @login AND [Пароль] = @password)", connection);
                select.Parameters.AddWithValue("@login", email);
                select.Parameters.AddWithValue("@password", password);
                using (SqlDataReader reader = select.ExecuteReader())
                {
                    if (reader.Read()) 
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void AddUser(string role, string name, string secondName, string lastname, string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();
                SqlCommand addUser = new SqlCommand(@"INSERT INTO Employees 
                ([Роль сотрудника],[Имя],[Фамилия],[Отчество],[Логин],[Пароль]) 
                VALUES (@role, @name, @secondName, @lastname, @login, @password)", connection);

                addUser.Parameters.AddWithValue("@role", role);
                addUser.Parameters.AddWithValue("@name", name);
                addUser.Parameters.AddWithValue("@secondName", secondName);
                addUser.Parameters.AddWithValue("@lastname", lastname);
                addUser.Parameters.AddWithValue("@login", email);
                addUser.Parameters.AddWithValue("@password", password);

                addUser.ExecuteNonQuery();
            }
        }
    }
}
