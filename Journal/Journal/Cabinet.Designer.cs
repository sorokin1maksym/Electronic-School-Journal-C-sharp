
namespace Journal
{
    partial class Cabinet
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
            this.buttonMath = new System.Windows.Forms.Button();
            this.buttonUkranian = new System.Windows.Forms.Button();
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMath
            // 
            this.buttonMath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMath.Location = new System.Drawing.Point(12, 12);
            this.buttonMath.Name = "buttonMath";
            this.buttonMath.Size = new System.Drawing.Size(258, 57);
            this.buttonMath.TabIndex = 0;
            this.buttonMath.Text = "Математика";
            this.buttonMath.UseVisualStyleBackColor = true;
            this.buttonMath.Click += new System.EventHandler(this.buttonMath_Click);
            // 
            // buttonUkranian
            // 
            this.buttonUkranian.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUkranian.Location = new System.Drawing.Point(12, 92);
            this.buttonUkranian.Name = "buttonUkranian";
            this.buttonUkranian.Size = new System.Drawing.Size(258, 57);
            this.buttonUkranian.TabIndex = 1;
            this.buttonUkranian.Text = "Українська мова";
            this.buttonUkranian.UseVisualStyleBackColor = true;
            this.buttonUkranian.Click += new System.EventHandler(this.buttonUkranian_Click);
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEnglish.Location = new System.Drawing.Point(12, 172);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(258, 57);
            this.buttonEnglish.TabIndex = 2;
            this.buttonEnglish.Text = "Англійська мова";
            this.buttonEnglish.UseVisualStyleBackColor = true;
            this.buttonEnglish.Click += new System.EventHandler(this.buttonEnglish_Click);
            // 
            // Cabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 241);
            this.Controls.Add(this.buttonEnglish);
            this.Controls.Add(this.buttonUkranian);
            this.Controls.Add(this.buttonMath);
            this.MaximizeBox = false;
            this.Name = "Cabinet";
            this.Text = "Cabinet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMath;
        private System.Windows.Forms.Button buttonUkranian;
        private System.Windows.Forms.Button buttonEnglish;
    }
}