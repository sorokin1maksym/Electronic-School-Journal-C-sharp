using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Journal
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SQLClass.connection = new MySql.Data.MySqlClient.MySqlConnection();
            SQLClass.connection.ConnectionString = "server=localhost;port=3306;username=root;password=root;database=journal";
            SQLClass.connection.Open();

            Application.Run(new LoginForm());

            SQLClass.connection.Close();
        }
    }
}
