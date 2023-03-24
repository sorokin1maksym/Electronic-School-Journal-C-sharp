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
    public partial class AdminMath : Form
    {
        private MySqlConnection connection = null;
        private MySqlCommand command = null;

        public AdminMath()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string exitUser = SQLClass.Select($"SELECT COUNT(*) FROM `users` WHERE user_name = N'{textboxName.Text}' AND user_surname = N'{textboxSurname.Text}' AND user_id = N'{textboxID.Text}'")[0];

            if (exitUser == "0")
            {
                MessageBox.Show("Такого абітурієнта не існує!");
                return;
            }
            else
            {
                command = new MySqlCommand($"INSERT INTO `marks` (mark, user_id, subject_id) VALUES (N'{textboxMark.Text}', N'{textboxID.Text}', 1)", connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Додано!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string exitUser = SQLClass.Select($"SELECT COUNT(*) FROM `users` WHERE user_name = N'{textboxName.Text}' AND user_surname = N'{textboxSurname.Text}' AND user_id = N'{textboxID.Text}'")[0];

            if (exitUser == "0")
            {
                MessageBox.Show("Такого абітурієнта не існує!");
                return;
            }
            else
            {
                command = new MySqlCommand($"UPDATE marks SET mark = N'{textboxMark.Text}' WHERE marks.user_id = N'{textboxID.Text}' AND marks.subject_id = 1", connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Додано!");
            }
        }

        private void AdminMath_Load_1(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=journal");
            connection.Open();
        }
    }
}
