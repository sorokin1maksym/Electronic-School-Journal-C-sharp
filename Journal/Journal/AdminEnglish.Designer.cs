
namespace Journal
{
    partial class AdminEnglish
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
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textboxSurname = new System.Windows.Forms.TextBox();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.textboxMark = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(12, 12);
            this.textboxName.Multiline = true;
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(207, 36);
            this.textboxName.TabIndex = 2;
            this.textboxName.Text = "Ім\'я";
            // 
            // textboxSurname
            // 
            this.textboxSurname.Location = new System.Drawing.Point(12, 54);
            this.textboxSurname.Multiline = true;
            this.textboxSurname.Name = "textboxSurname";
            this.textboxSurname.Size = new System.Drawing.Size(207, 36);
            this.textboxSurname.TabIndex = 3;
            this.textboxSurname.Text = "Прізвище";
            // 
            // textboxID
            // 
            this.textboxID.Location = new System.Drawing.Point(12, 96);
            this.textboxID.Multiline = true;
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(207, 36);
            this.textboxID.TabIndex = 4;
            this.textboxID.Text = "ID";
            // 
            // textboxMark
            // 
            this.textboxMark.Location = new System.Drawing.Point(12, 138);
            this.textboxMark.Multiline = true;
            this.textboxMark.Name = "textboxMark";
            this.textboxMark.Size = new System.Drawing.Size(207, 36);
            this.textboxMark.TabIndex = 5;
            this.textboxMark.Text = "Оцінка";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(250, 96);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 78);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Виставити нову оцінку";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate.Location = new System.Drawing.Point(250, 12);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(170, 78);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Оновити стару оцінку";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // AdminEnglish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 189);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textboxMark);
            this.Controls.Add(this.textboxID);
            this.Controls.Add(this.textboxSurname);
            this.Controls.Add(this.textboxName);
            this.MaximizeBox = false;
            this.Name = "AdminEnglish";
            this.Text = "AdminEnglish";
            this.Load += new System.EventHandler(this.AdminEnglish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.TextBox textboxSurname;
        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.TextBox textboxMark;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
    }
}