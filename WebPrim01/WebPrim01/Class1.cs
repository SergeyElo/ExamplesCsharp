using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;

namespace WebPrim01
{
    public class ClassBD
    {
        public string ConnectionString()
        {
            return "Server=localhost;Port=5432;UserId=postgres;Password=1964;Database=chat;";
        }
        
        public void RuncmdBD(string cmd)
        {            
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(ConnectionString());
            npgSqlConnection.Open();
            NpgsqlCommand com1 = new NpgsqlCommand(cmd, npgSqlConnection);
            NpgsqlDataReader reader;
            reader = com1.ExecuteReader();
            
            npgSqlConnection.Close();
        }
                
        public void ZapListBoxFromBD(string cmd, ref System.Web.UI.WebControls.ListBox LBox)
        {
            LBox.Items.Clear();
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(ConnectionString());
            npgSqlConnection.Open();           
            NpgsqlCommand com1 = new NpgsqlCommand(cmd, npgSqlConnection);
            NpgsqlDataReader reader;
            reader = com1.ExecuteReader();

            Console.WriteLine("Messages:");
            string s = "";
            while (reader.Read())
            {
                s = "";
                try
                {
                    for (int n = 1; n <= 3; n++)
                    {
                        if (reader.GetDataTypeOID(n) == 1043)
                        {
                            s += reader.GetString(n);
                        }
                        else
                        {
                            s += Convert.ToString(reader.GetInt32(n));
                        }
                    }
                    LBox.Items.Add(s);
                }
                catch { }
            }
            npgSqlConnection.Close();            
        }

    }
}