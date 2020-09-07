using Microsoft.Extensions.Configuration;
using MyProject.Models.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data.Login
{
    public class LoginQueryCommand
    {
        private readonly IConfiguration Configuration;
        private SqlConnection connection;
        string cs = null;           

        public LoginQueryCommand()
        {
        }

        private string ConnectionString(string v)
        {
            var basePath = Directory.GetCurrentDirectory();
            var AppSetting = new ConfigurationBuilder()
               .SetBasePath(basePath)
               .AddJsonFile("appsettings.json")
               .Build();
            var res = AppSetting["ConnectionStrings:MyProjectContext"];
            return res;
        }

        public void Insert(LoginEntities loginEntities)
        {
            connection = new SqlConnection(ConnectionString(cs));
            var Query = "INSERT INTO Login(Username,Password,Email) VALUES(@Username,@Password,@Email)";
            SqlCommand com = new SqlCommand(Query, connection);
            com.CommandType = CommandType.Text;
            com.Parameters.Add("@Username", SqlDbType.VarChar).Value = loginEntities.Username;
            com.Parameters.Add("@Password", SqlDbType.VarChar).Value = loginEntities.Password;
            com.Parameters.Add("@Email", SqlDbType.VarChar).Value = "";
            connection.Open();
            com.ExecuteNonQuery();
            connection.Close();
            connection.Dispose();
        }
    }
}
