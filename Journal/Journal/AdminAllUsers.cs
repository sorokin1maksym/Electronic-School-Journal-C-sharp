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
    public partial class AdminAllUsers : Form
    {
        private MySqlConnection connection = null;
        private MySqlDataAdapter adapter = null;
        private DataSet dataset = null;

        public AdminAllUsers()
        {
            InitializeComponent();
        }

        private void AdminAllUsers_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=journal");
            LoadData();
        }

        private void LoadData()
        {
            adapter = new MySqlDataAdapter("SELECT users.user_id, users.user_name, users.user_surname, users.user_password FROM users", connection);
            dataset = new DataSet();
            adapter.Fill(dataset, "Users");
            dataGridView1.DataSource = dataset.Tables["Users"];
        }
    }
}
