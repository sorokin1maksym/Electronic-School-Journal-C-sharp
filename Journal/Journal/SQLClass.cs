using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace Journal
{
    public static class SQLClass
    {
        public static MySqlConnection connection;

        public static List<string> Select(string Text)
        {
            List<string> results = new List<string>();

            MySqlCommand command = new MySqlCommand(Text, connection);
            DbDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    results.Add(reader.GetString(i));
            }

            reader.Close();
            command.Dispose();
            return results;
        }
    }
}