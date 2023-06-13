using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    public class TaskManaging
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string conStr;
        public TaskManaging()
        {
            //connection string
            conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\TasksDb.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(conStr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public DataTable GetData(string query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(query, conStr);
            sda.Fill(dt);
            return dt;
        }
        public int SetData(string query)
        {
            int count = 0;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = query;
            count = cmd.ExecuteNonQuery();
            return count;
        }
        public int GetTaskCount(string taskName)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();
                string query = $"Select count(*) from TasksTbl where Task_name = '{taskName}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Task_name", taskName);
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return count;
        }
    }
}
