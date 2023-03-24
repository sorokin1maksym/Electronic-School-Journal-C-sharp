
namespace Journal
{
    partial class AdminAddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.textboxAddName = new System.Windows.Forms.TextBox();
            this.textboxAddSurname = new System.Windows.Forms.TextBox();
            this.textboxAddPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddUser.Location = new System.Drawing.Point(264, 70);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(154, 72);
            this.buttonAddUser.TabIndex = 0;
            this.buttonAddUser.Text = "Додати";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // textboxAddName
            // 
            this.textboxAddName.Location = new System.Drawing.Point(30, 31);
            this.textboxAddName.Multiline = true;
            this.textboxAddName.Name = "textboxAddName";
            this.textboxAddName.Size = new System.Drawing.Size(198, 33);
            this.textboxAddName.TabIndex = 1;
            this.textboxAddName.Text = "Ім\'я";
            // 
            // textboxAddSurname
            // 
            this.textboxAddSurname.Location = new System.Drawing.Point(30, 70);
            this.textboxAddSurname.Multiline = true;
            this.textboxAddSurname.Name = "textboxAddSurname";
            this.textboxAddSurname.Size = new System.Drawing.Size(198, 33);
            this.textboxAddSurname.TabIndex = 2;
            this.textboxAddSurname.Text = "Прізвище";
            // 
            // textboxAddPassword
            // 
            this.textboxAddPassword.Location = new System.Drawing.Point(30, 109);
            this.textboxAddPassword.Multiline = true;
            this.textboxAddPassword.Name = "textboxAddPassword";
            this.textboxAddPassword.Size = new System.Drawing.Size(198, 33);
            this.textboxAddPassword.TabIndex = 3;
            this.textboxAddPassword.Text = "Пароль";
            // 
            // AdminAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 160);
            this.Controls.Add(this.textboxAddPassword);
            this.Controls.Add(this.textboxAddSurname);
            this.Controls.Add(this.textboxAddName);
            this.Controls.Add(this.buttonAddUser);
            this.MaximizeBox = false;
            this.Name = "AdminAddUser";
            this.Text = "AdminAddUser";
            this.Load += new System.EventHandler(this.AdminAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.TextBox textboxAddName;
        private System.Windows.Forms.TextBox textboxAddSurname;
        private System.Windows.Forms.TextBox textboxAddPassword;
    }
}