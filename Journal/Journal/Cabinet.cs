using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Journal
{   
    public partial class Cabinet : Form
    {
        public Cabinet()
        {
            InitializeComponent();
        }

        public void buttonMath_Click(object sender, EventArgs e)
        {
            string userCheck =
                SQLClass.Select("SELECT COUNT(*) FROM `marks` WHERE user_id = '" + DataBank.UserID + "' AND subject_id = 1")[0];

            if (userCheck == "0")
            {
                MessageBox.Show("Ви не сдавали цей предмет або Вас ще не оцінили.");
            }
            else
            {
                string mathResult =
                    SQLClass.Select("SELECT mark FROM `marks` WHERE subject_id = 1 AND user_id = '" + DataBank.UserID + "'")[0];
                MessageBox.Show(mathResult);
            }
        }

        private void buttonUkranian_Click(object sender, EventArgs e)
        {
            string userCheck = 
                SQLClass.Select("SELECT COUNT(*) FROM `marks` WHERE user_id = '" + DataBank.UserID + "' AND subject_id = 2")[0];

            if (userCheck == "0")
            {
                MessageBox.Show("Ви не сдавали цей предмет або Вас ще не оцінили.");
            }
            else
            {
                string ukrResult = 
                    SQLClass.Select("SELECT mark FROM `marks` WHERE subject_id = 2 AND user_id = '" + DataBank.UserID + "'")[0];
                MessageBox.Show(ukrResult);
            }
        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            string userCheck =
                SQLClass.Select("SELECT COUNT(*) FROM `marks` WHERE user_id = '" + DataBank.UserID + "' AND subject_id = 3")[0];

            if (userCheck == "0")
            {
                MessageBox.Show("Ви не сдавали цей предмет або Вас ще не оцінили.");
            }
            else
            {
                string engResult =
                    SQLClass.Select("SELECT mark FROM `marks` WHERE subject_id = 3 AND user_id = '" + DataBank.UserID + "'")[0];
                MessageBox.Show(engResult);
            }
        }
    }
}
