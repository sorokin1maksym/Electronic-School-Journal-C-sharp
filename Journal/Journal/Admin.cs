using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Journal
{
    public partial class buttonAllUsers : Form
    {
        public buttonAllUsers()
        {
            InitializeComponent();
        }

        private void buttonMathResult_Click(object sender, EventArgs e)
        {
            AdminMath am = new AdminMath();
            am.ShowDialog();
        }

        private void buttonUkrResult_Click(object sender, EventArgs e)
        {
            AdminUkranian au = new AdminUkranian();
            au.ShowDialog();
        }

        private void buttonEngResult_Click(object sender, EventArgs e)
        {
            AdminEnglish ae = new AdminEnglish();
            ae.ShowDialog();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AdminAddUser aau = new AdminAddUser();
            aau.ShowDialog();
        }

        private void buttonUserManagement_Click(object sender, EventArgs e)
        {
            AdminUserManagement aum = new AdminUserManagement();
            aum.ShowDialog();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            AdminDeleteUser adu = new AdminDeleteUser();
            adu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminAllUsers aau = new AdminAllUsers();
            aau.ShowDialog();
        }
    }
}
