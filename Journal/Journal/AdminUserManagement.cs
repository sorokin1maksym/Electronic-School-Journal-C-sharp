using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Journal
{
    public partial class AdminUserManagement : Form
    {
        private MySqlDataAdapter adapter = null;
        private DataSet dataset = null;
        private MySqlConnection connection = null;

        public AdminUserManagement()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            adapter = new MySqlDataAdapter("SELECT users.user_id, users.user_name, users.user_surname, subjects.subject_name, marks.mark FROM users, marks, subjects WHERE users.user_id=marks.user_id AND subjects.subject_id = marks.subject_id", connection);
            dataset = new DataSet();
            adapter.Fill(dataset, "Users");
            dataGridView1.DataSource = dataset.Tables["Users"];
        }

        private void AdminUserManagement_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=journal");
            LoadData();
        }
    }
}
