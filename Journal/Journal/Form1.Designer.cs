
namespace Journal
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textboxSurname = new System.Windows.Forms.TextBox();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(13, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Дізнатися свої результати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(13, 13);
            this.textboxName.Multiline = true;
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(329, 43);
            this.textboxName.TabIndex = 1;
            this.textboxName.Text = "Ім\'я";
            // 
            // textboxSurname
            // 
            this.textboxSurname.Location = new System.Drawing.Point(13, 62);
            this.textboxSurname.Multiline = true;
            this.textboxSurname.Name = "textboxSurname";
            this.textboxSurname.Size = new System.Drawing.Size(329, 43);
            this.textboxSurname.TabIndex = 2;
            this.textboxSurname.Text = "Прізвище";
            // 
            // textboxPassword
            // 
            this.textboxPassword.Location = new System.Drawing.Point(13, 160);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Size = new System.Drawing.Size(329, 23);
            this.textboxPassword.TabIndex = 3;
            this.textboxPassword.Text = "Пароль";
            this.textboxPassword.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(329, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "Режим адміністратора";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textboxID
            // 
            this.textboxID.Location = new System.Drawing.Point(12, 111);
            this.textboxID.Multiline = true;
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(329, 43);
            this.textboxID.TabIndex = 5;
            this.textboxID.Text = "ID";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.textboxID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.textboxSurname);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.TextBox textboxSurname;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textboxID;
    }
}

