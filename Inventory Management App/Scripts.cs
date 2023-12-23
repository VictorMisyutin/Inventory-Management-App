using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Inventory_Management_App
{

    internal static class Scripts
    {
        private static SqlConnection cn;
        private static SqlCommand cmd;
        private static SqlDataReader dr;

        static Scripts()
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\misyu\Desktop\Coding\Inventory Management App\Inventory Management App\Database.mdf"";Integrated Security=True");
            cn.Open(); 
        }

        public static bool CreateNewOrganization(string name, string location, int userId)
        {
            try
            {
                cmd = new SqlCommand("insert into Organizations (name, location, ownerId) values(@name,@location,@ownerId)", cn);
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("location", location == string.Empty ? "" : location);
                cmd.Parameters.AddWithValue("ownerId", userId);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch {
                return false;
            }
            finally
            {
                dr.Close();
            }

        }
    
        public static List<string> GetAllOrganizationNames()
        {
                List<string> names = new List<string>();
            try{
                cmd = new SqlCommand("select name from Organizations", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    names.Add(dr[0].ToString()); ;
                }
                return names;
            }
            catch
            {
                return names;
            }
            finally
            {
                dr.Close();
            }
        }   
    
        public static List<string> GetUserByUserName(string userName) 
        {
            List<string> result = new List<string>();
            try
            {
                cmd = new SqlCommand("select * from Users where username=@username", cn);
                cmd.Parameters.AddWithValue("username", userName);
                dr = cmd.ExecuteReader();
                foreach(string item in dr)
                {
                    result.Add(item);
                }
                return result;
            }
            catch { 
                return result; 
            }
            finally
            {
                dr.Close();
            }
        }
    
        public static bool CreateNewUser(string username, string password, string email, int orgoId)
        {
            try
            {
                cmd = new SqlCommand("insert into Users values(@username,@password,@email,@organization)", cn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("organization", orgoId);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    
        public static List<string> GetOrganizationByName(string name)
        {
            List<string> result = new List<string>();
            try{
                /*cmd = new SqlCommand("declare @name NVARCHAR(50) = '" + name + "'\n" + 
                    " select * from Organizations where [name] = @name",cn);*/
                /*cmd = new SqlCommand(@"declare @name NVARCHAR(50) = 'Victors Orgo'
                    select * from Organizations where [name] = @name",cn);*/
                cmd = new SqlCommand("select * from Organizations where [name] = name",cn);
                cmd.Parameters.AddWithValue("name", name);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount;i++)
                    {
                        result.Add(dr.GetValue(i).ToString());
                    }
                }
                return result;
            }
            catch { 
                return result; 
            }
            finally
            {
                dr.Close();
            }
        }
    
    
    }
}
