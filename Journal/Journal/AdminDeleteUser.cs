using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Journal
{
    public partial class AdminDeleteUser : Form
    {
        private MySqlConnection connection = null;
        private MySqlCommand command = null;

        public AdminDeleteUser()
        {
            InitializeComponent();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            string exitUser = SQLClass.Select($"SELECT COUNT(*) FROM `users` WHERE users.user_name = N'{textboxUserName.Text}' AND users.user_surname = N'{textboxUserSurname.Text}' AND users.user_id = N'{textboxUserID.Text}'")[0];

            if (exitUser == "0")
            {
                MessageBox.Show("Такого абітурієнта не існує!");
                return;
            }
            else
            {
                command = new MySqlCommand($"DELETE FROM marks WHERE user_id = N'{textboxUserID.Text}'; DELETE FROM users WHERE user_id = N'{textboxUserID.Text}'", connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Видалено!");
            }
        }

        private void AdminDeleteUser_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=journal");
            connection.Open();
        }
    }
}
