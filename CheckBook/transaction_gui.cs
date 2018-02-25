/*
 * File: transaction_gui.cs
 * Author: Kyle Dennison
 * Allows user to choose which type of transaction they will be making.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroProject01
{
    public partial class transaction_gui : Form
    {
        private Button cashButton;
        private Button checkButton;
        private Button depositButton;
        private TextBox chooseTransaction;
        private string cbkName;

        public transaction_gui(string cbkName)
        {
            InitializeComponent();
            this.cbkName = cbkName;
        }

        // Set up click event handlers for each of the buttons that open
        // a new in_gui dialog for the different types of transactions.
        private void cashButton_Click(object sender, EventArgs e)
        {
            cash c = new cash(cbkName);
            c.cashSub();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            check ch = new check(cbkName);
            ch.checkSub();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            deposit d = new deposit(cbkName);
            d.depositSub();
        }

        private void InitializeComponent()
        {
            this.chooseTransaction = new System.Windows.Forms.TextBox();
            this.cashButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseTransaction
            // 
            this.chooseTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chooseTransaction.Font = new System.Drawing.Font("Arial", 12F);
            this.chooseTransaction.Location = new System.Drawing.Point(12, 24);
            this.chooseTransaction.Multiline = true;
            this.chooseTransaction.Name = "chooseTransaction";
            this.chooseTransaction.Size = new System.Drawing.Size(260, 42);
            this.chooseTransaction.TabIndex = 0;
            this.chooseTransaction.Text = "Please choose the type of transaction you want:";
            this.chooseTransaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cashButton
            // 
            this.cashButton.Font = new System.Drawing.Font("Arial", 12F);
            this.cashButton.Location = new System.Drawing.Point(70, 91);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(152, 23);
            this.cashButton.TabIndex = 1;
            this.cashButton.Text = "CASH";
            this.cashButton.UseVisualStyleBackColor = true;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Arial", 12F);
            this.checkButton.Location = new System.Drawing.Point(70, 137);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(152, 23);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "CHECK";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("Arial", 12F);
            this.depositButton.Location = new System.Drawing.Point(70, 186);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(152, 23);
            this.depositButton.TabIndex = 3;
            this.depositButton.Text = "DEPOSIT";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // transaction_gui
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.cashButton);
            this.Controls.Add(this.chooseTransaction);
            this.Name = "transaction_gui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //Classes for each different type of transaction. 
        class cash
        {
            string bookName;
            public cash(string name)
            {
                bookName = name;
            }
            public void cashSub()
            {
                in_gui ig = new in_gui(bookName, "cash", false);
                ig.ShowDialog();
            }
        }

        class check
        {
            string bookName;
            public check(string name)
            {
                bookName = name;
            }
            public void checkSub()
            {
                in_gui ig = new in_gui(bookName, "check", true);
                ig.ShowDialog();
            }
        }

        class deposit
        {
            string bookName;
            public deposit(string name)
            {
                bookName = name;
            }
            public void depositSub()
            {
                in_gui ig = new in_gui(bookName, "deposit", false);
                ig.ShowDialog();
            }
        }
    }
}
