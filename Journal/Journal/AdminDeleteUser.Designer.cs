
namespace Journal
{
    partial class AdminDeleteUser
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
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.textboxUserName = new System.Windows.Forms.TextBox();
            this.textboxUserSurname = new System.Windows.Forms.TextBox();
            this.textboxUserID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteUser.Location = new System.Drawing.Point(268, 64);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(147, 76);
            this.buttonDeleteUser.TabIndex = 0;
            this.buttonDeleteUser.Text = "Видалити";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // textboxUserName
            // 
            this.textboxUserName.Location = new System.Drawing.Point(23, 23);
            this.textboxUserName.Multiline = true;
            this.textboxUserName.Name = "textboxUserName";
            this.textboxUserName.Size = new System.Drawing.Size(200, 35);
            this.textboxUserName.TabIndex = 1;
            this.textboxUserName.Text = "Ім\'я";
            // 
            // textboxUserSurname
            // 
            this.textboxUserSurname.Location = new System.Drawing.Point(23, 64);
            this.textboxUserSurname.Multiline = true;
            this.textboxUserSurname.Name = "textboxUserSurname";
            this.textboxUserSurname.Size = new System.Drawing.Size(200, 35);
            this.textboxUserSurname.TabIndex = 2;
            this.textboxUserSurname.Text = "Прізвище";
            // 
            // textboxUserID
            // 
            this.textboxUserID.Location = new System.Drawing.Point(23, 105);
            this.textboxUserID.Multiline = true;
            this.textboxUserID.Name = "textboxUserID";
            this.textboxUserID.Size = new System.Drawing.Size(200, 35);
            this.textboxUserID.TabIndex = 3;
            this.textboxUserID.Text = "ID";
            // 
            // AdminDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 164);
            this.Controls.Add(this.textboxUserID);
            this.Controls.Add(this.textboxUserSurname);
            this.Controls.Add(this.textboxUserName);
            this.Controls.Add(this.buttonDeleteUser);
            this.MaximizeBox = false;
            this.Name = "AdminDeleteUser";
            this.Text = "AdminDeleteUser";
            this.Load += new System.EventHandler(this.AdminDeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.TextBox textboxUserName;
        private System.Windows.Forms.TextBox textboxUserSurname;
        private System.Windows.Forms.TextBox textboxUserID;
    }
}