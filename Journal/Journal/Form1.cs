using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.textboxPassword.AutoSize = false;
            this.textboxPassword.Size = new Size(this.textboxPassword.Width, 41);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textboxName.Text;
            string surname = textboxSurname.Text;
            string ID = textboxID.Text;
            string password = textboxPassword.Text;

            string exitUser = SQLClass.Select($"SELECT COUNT(*) FROM users WHERE user_name = N'{name}' AND user_surname = N'{surname}' AND user_id = N'{ID}' AND user_password = N'{password}'")[0];
            
            if (exitUser == "0")
            {
                MessageBox.Show("Невірний пароль!");
                return;
            }
            else
            {
                DataBank.UserID = ID;
                Cabinet cb = new Cabinet();
                cb.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textboxName.Text;
            string surname = textboxSurname.Text;
            string ID = textboxID.Text;
            string password = textboxPassword.Text;

            string adminUser = SQLClass.Select($"SELECT COUNT(*) FROM users WHERE user_name = N'{name}' AND user_surname = N'{surname}' AND user_id = N'{ID}' AND user_password = N'{password}'")[0];

            if(name == "admin" && surname == "admin" && ID == "3" && password == "root")
            {
                buttonAllUsers adm = new buttonAllUsers();
                adm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Невірний пароль!");
                return;
            }
        }
    }
}
