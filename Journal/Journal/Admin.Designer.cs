
namespace Journal
{
    partial class buttonAllUsers
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
            this.buttonMathResult = new System.Windows.Forms.Button();
            this.buttonUkrResult = new System.Windows.Forms.Button();
            this.buttonEngResult = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonUserManagement = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMathResult
            // 
            this.buttonMathResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMathResult.Location = new System.Drawing.Point(71, 46);
            this.buttonMathResult.Name = "buttonMathResult";
            this.buttonMathResult.Size = new System.Drawing.Size(397, 55);
            this.buttonMathResult.TabIndex = 0;
            this.buttonMathResult.Text = "Виставити результати з математики";
            this.buttonMathResult.UseVisualStyleBackColor = true;
            this.buttonMathResult.Click += new System.EventHandler(this.buttonMathResult_Click);
            // 
            // buttonUkrResult
            // 
            this.buttonUkrResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUkrResult.Location = new System.Drawing.Point(71, 107);
            this.buttonUkrResult.Name = "buttonUkrResult";
            this.buttonUkrResult.Size = new System.Drawing.Size(397, 55);
            this.buttonUkrResult.TabIndex = 1;
            this.buttonUkrResult.Text = "Виставити результати з української мови";
            this.buttonUkrResult.UseVisualStyleBackColor = true;
            this.buttonUkrResult.Click += new System.EventHandler(this.buttonUkrResult_Click);
            // 
            // buttonEngResult
            // 
            this.buttonEngResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEngResult.Location = new System.Drawing.Point(71, 168);
            this.buttonEngResult.Name = "buttonEngResult";
            this.buttonEngResult.Size = new System.Drawing.Size(397, 55);
            this.buttonEngResult.TabIndex = 2;
            this.buttonEngResult.Text = "Виставити результати з англійської мови";
            this.buttonEngResult.UseVisualStyleBackColor = true;
            this.buttonEngResult.Click += new System.EventHandler(this.buttonEngResult_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddUser.Location = new System.Drawing.Point(71, 229);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(397, 55);
            this.buttonAddUser.TabIndex = 3;
            this.buttonAddUser.Text = "Додати абітурієнта";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonUserManagement
            // 
            this.buttonUserManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUserManagement.Location = new System.Drawing.Point(71, 351);
            this.buttonUserManagement.Name = "buttonUserManagement";
            this.buttonUserManagement.Size = new System.Drawing.Size(397, 55);
            this.buttonUserManagement.TabIndex = 4;
            this.buttonUserManagement.Text = "Список оцінених абітурієнтів";
            this.buttonUserManagement.UseVisualStyleBackColor = true;
            this.buttonUserManagement.Click += new System.EventHandler(this.buttonUserManagement_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteUser.Location = new System.Drawing.Point(71, 290);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(397, 55);
            this.buttonDeleteUser.TabIndex = 5;
            this.buttonDeleteUser.Text = "Видалити абітурієнта";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(71, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(397, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Список всіх абітурієнтів";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonUserManagement);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonEngResult);
            this.Controls.Add(this.buttonUkrResult);
            this.Controls.Add(this.buttonMathResult);
            this.MaximizeBox = false;
            this.Name = "buttonAllUsers";
            this.Text = "Список всіх абітурієнтів";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMathResult;
        private System.Windows.Forms.Button buttonUkrResult;
        private System.Windows.Forms.Button buttonEngResult;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonUserManagement;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button button1;
    }
}