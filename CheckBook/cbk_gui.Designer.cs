namespace IntroProject01
{
    partial class cbk_gui
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
            this.enterCheckbookText = new System.Windows.Forms.TextBox();
            this.checkbook = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.newCheckbook = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterCheckbookText
            // 
            this.enterCheckbookText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterCheckbookText.Enabled = false;
            this.enterCheckbookText.Font = new System.Drawing.Font("Arial", 12F);
            this.enterCheckbookText.Location = new System.Drawing.Point(12, 27);
            this.enterCheckbookText.Multiline = true;
            this.enterCheckbookText.Name = "enterCheckbookText";
            this.enterCheckbookText.Size = new System.Drawing.Size(388, 43);
            this.enterCheckbookText.TabIndex = 0;
            this.enterCheckbookText.Text = "Please enter the name of the checkbook you would like to open, or create a new ch" +
    "eckbook:";
            // 
            // checkbook
            // 
            this.checkbook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkbook.Font = new System.Drawing.Font("Arial", 12F);
            this.checkbook.Location = new System.Drawing.Point(12, 96);
            this.checkbook.Name = "checkbook";
            this.checkbook.Size = new System.Drawing.Size(273, 26);
            this.checkbook.TabIndex = 1;
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Arial", 12F);
            this.openButton.Location = new System.Drawing.Point(291, 96);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(109, 26);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // newCheckbook
            // 
            this.newCheckbook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newCheckbook.Font = new System.Drawing.Font("Arial", 12F);
            this.newCheckbook.Location = new System.Drawing.Point(12, 168);
            this.newCheckbook.Name = "newCheckbook";
            this.newCheckbook.Size = new System.Drawing.Size(273, 26);
            this.newCheckbook.TabIndex = 3;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Arial", 12F);
            this.createButton.Location = new System.Drawing.Point(291, 171);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(109, 23);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cbk_gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(412, 272);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.newCheckbook);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.checkbook);
            this.Controls.Add(this.enterCheckbookText);
            this.Name = "cbk_gui";
            this.Text = "Select Checkbook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterCheckbookText;
        private System.Windows.Forms.TextBox checkbook;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox newCheckbook;
        private System.Windows.Forms.Button createButton;
    }
}