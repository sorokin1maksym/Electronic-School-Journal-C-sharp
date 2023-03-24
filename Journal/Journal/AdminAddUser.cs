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
    public partial class AdminAddUser : Form
    {
        private MySqlConnection connection = null;
        private MySqlCommand command = null;

        public AdminAddUser()
        {
            InitializeComponent();
        }

        private void AdminAddUser_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=journal");
            connection.Open();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand($"INSERT INTO users (user_name, user_surname, user_password) VALUES (N'{textboxAddName.Text}', N'{textboxAddSurname.Text}', N'{textboxAddPassword.Text}')", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Додано!");
        }
    }
}
