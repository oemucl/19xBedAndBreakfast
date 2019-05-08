using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19xBedAndBreakfast
{
    class DataBaseManager
    {
        SqlConnection conn;
        SqlCommand com;
        private string GetConnectionString()
        {
            return "Server=EAL-00649; Initial Catalog=BB; Integrated Security=true";
        }
        private int ExecuteSQLCommand(string command)
        {
            conn = new SqlConnection(GetConnectionString());
            conn.Open();
            com = new SqlCommand(command, conn);
            int rows=com.ExecuteNonQuery();
            conn.Close();
            return rows;
        }
        public void InsertGuest(Guest g)
        {
            try
            {
                string InsertSqlString = $"Insert into Guest(pasnr,fnavn,enavn, adr, køn, tlf)" +
                                      $"values('{g.PassPortNo}','{g.FName}','{g.LName}','{g.Address}','{g.Gender}','{g.PhoneNo}')";
                ExecuteSQLCommand(InsertSqlString);
            }
            catch
                (SqlException ex)
            {
                Console.WriteLine("Der er fejl i din SQL");
                Console.WriteLine(com.CommandText);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void UpdateGuest(Guest g)
        {
            string UpdateSqlString = $"Update Guest set pasnr='{g.PassPortNo}',fnavn='{g.FName}',enavn='{g.LName}', adr='{g.Address}', køn='{g.Gender}', tlf={g.PhoneNo}" +
                                  $" where pasnr = '{g.PassPortNo}'";
            try
            {
                if (ExecuteSQLCommand(UpdateSqlString) == 0)
                {
                    throw new Exception("No rows updated");
                };
            }
            catch
                (SqlException ex)
            {
                Console.WriteLine("Der er fejl i din SQL");
                Console.WriteLine(com.CommandText);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteGuest(string pasnr)
        {
            string DeleteSqlString = $"Delete from Guest " +
                                  $" where pasnr = '{pasnr}'";
            try
            {
                if (ExecuteSQLCommand(DeleteSqlString) == 0)
                {
                    throw new Exception("No rows deleted");
                };
            }
            catch
                (SqlException ex)
            {
                Console.WriteLine("Der er fejl i din SQL");
                Console.WriteLine(com.CommandText);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public Guest GetGuestByPassPortNo(string pasnr)
        {
            string SelectSqlString = $"Select * from Guest " +
                                  $" where pasnr = '{pasnr}'";
            Guest g = new Guest("0", 0, "0", "0", '0', "0"); /* burde have def constructor */
            g = null; /* aht not found */
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();
                SqlCommand com = new SqlCommand(SelectSqlString, conn);
                SqlDataReader reader = com.ExecuteReader();
                if (!reader.HasRows)
                {
                    Console.WriteLine(" No rows found");
                }
                else
                {
                    while (reader.Read())
                    {
                        g = new Guest(reader["pasnr"].ToString(),
                               Convert.ToInt32(reader["tlf"].ToString()),
                               reader["fnavn"].ToString(),
                               reader["enavn"].ToString(),
                               Convert.ToChar(reader["køn"].ToString()),
                              reader["adr"].ToString());
                    }
                }
                reader.Close();
            }
            return g;
        }

        public List<Guest> GetAllGuests()
        {
            List<Guest> gæster = new List<Guest>();

            string SelectSqlString = $"select * from guest";
            conn = new SqlConnection(GetConnectionString());
            conn.Open();
            SqlCommand com = new SqlCommand(SelectSqlString, conn);

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Guest g = new Guest(reader["pasnr"].ToString(),
                    Convert.ToInt32(reader["tlf"].ToString()),
                    reader["fnavn"].ToString(),
                    reader["enavn"].ToString(),
                    Convert.ToChar(reader["køn"].ToString()), 
                    reader["adr"].ToString());
                gæster.Add(g);
            }
            reader.Close();
            conn.Close();
            return gæster;
        }
    }
}
