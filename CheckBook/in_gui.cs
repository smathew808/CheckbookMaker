//
//in_gui.cs
//By Kade Walter
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace IntroProject01
{
    public partial class in_gui : Form
    {
        private Label toLineLabel;
        private Label amountLabel;
        private Label memoLabel;
        private TextBox toLineTextBox;
        private TextBox amountTextBox;
        private TextBox memoTextBox;
        private TextBox infoText;
        private string typeTrans;
        private string name;

        public in_gui(string cbkName, string type, bool tf)
        {
            InitializeComponent();
            infoText.Font = new Font("Arial", 14, FontStyle.Regular);
            this.toLineTextBox.Enabled = tf;
            typeTrans = type;
            name = cbkName;
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            fileIO fIO1 = new fileIO();
            double newBalance;
            //gathers the info in the textboxes when the user clicks the submit button
            Submit s = new Submit();
            string toLine = toLineTextBox.Text.ToString();
            string amount = amountTextBox.Text.ToString();
            string memo = memoTextBox.Text.ToString();
            //sends the info to the submit class
            s.submit(toLine, amount, memo, this.viewCheck.Checked);

            //today's date in MM/dd/yyyy format
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            //writes new transaction to the .cbk file given. 
            double amountDoub = Convert.ToDouble(amount);
            transaction_gui t = new transaction_gui(name);
            
            if (typeTrans == "deposit")
            {
                newBalance = fIO1.getCurrentBalance(name) + amountDoub;
                fIO1.writeTransaction(name, date, typeTrans.ToUpper(), amountDoub, toLine, memo, newBalance);
                MessageBox.Show("Current Account Balance: $" + newBalance);
                t.ShowDialog();
            }
            else
            {
                newBalance = fIO1.getCurrentBalance(name) - amountDoub;
                if(newBalance >= 0.00)
                {
                    fIO1.writeTransaction(name, date, typeTrans.ToUpper(), amountDoub, toLine, memo, fIO1.getCurrentBalance(name) - amountDoub);
                    MessageBox.Show("Current Account Balance: $" + newBalance);
                    t.ShowDialog();
                }
                else
                {
                    MessageBox.Show("This transaction will result in a negative account balance.\nContinue?");
                    MessageBox.Show("Current Account Balance: $" + newBalance);
                    t.ShowDialog();
                }
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.infoText = new System.Windows.Forms.TextBox();
            this.toLineLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.memoLabel = new System.Windows.Forms.Label();
            this.toLineTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.viewCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // infoText
            // 
            this.infoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoText.Location = new System.Drawing.Point(50, 34);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(195, 13);
            this.infoText.TabIndex = 0;
            this.infoText.Text = "Enter information:";
            this.infoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toLineLabel
            // 
            this.toLineLabel.AutoSize = true;
            this.toLineLabel.Location = new System.Drawing.Point(40, 86);
            this.toLineLabel.Name = "toLineLabel";
            this.toLineLabel.Size = new System.Drawing.Size(46, 13);
            this.toLineLabel.TabIndex = 1;
            this.toLineLabel.Text = "To Line:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(40, 140);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(46, 13);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "Amount:";
            // 
            // memoLabel
            // 
            this.memoLabel.AutoSize = true;
            this.memoLabel.Location = new System.Drawing.Point(47, 187);
            this.memoLabel.Name = "memoLabel";
            this.memoLabel.Size = new System.Drawing.Size(39, 13);
            this.memoLabel.TabIndex = 3;
            this.memoLabel.Text = "Memo:";
            // 
            // toLineTextBox
            // 
            this.toLineTextBox.Location = new System.Drawing.Point(120, 79);
            this.toLineTextBox.Name = "toLineTextBox";
            this.toLineTextBox.Size = new System.Drawing.Size(152, 20);
            this.toLineTextBox.TabIndex = 4;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(120, 133);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(152, 20);
            this.amountTextBox.TabIndex = 5;
            // 
            // memoTextBox
            // 
            this.memoTextBox.Location = new System.Drawing.Point(120, 180);
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.Size = new System.Drawing.Size(152, 20);
            this.memoTextBox.TabIndex = 6;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Arial", 12F);
            this.submitButton.Location = new System.Drawing.Point(59, 285);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(165, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // viewCheck
            // 
            this.viewCheck.AutoSize = true;
            this.viewCheck.Font = new System.Drawing.Font("Arial", 12F);
            this.viewCheck.Location = new System.Drawing.Point(43, 233);
            this.viewCheck.Name = "viewCheck";
            this.viewCheck.Size = new System.Drawing.Size(193, 22);
            this.viewCheck.TabIndex = 8;
            this.viewCheck.Text = "View completed check?";
            this.viewCheck.UseVisualStyleBackColor = true;
            this.viewCheck.CheckedChanged += new System.EventHandler(this.viewCheck_CheckedChanged);
            // 
            // in_gui
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 344);
            this.Controls.Add(this.viewCheck);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.memoTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.toLineTextBox);
            this.Controls.Add(this.memoLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.toLineLabel);
            this.Controls.Add(this.infoText);
            this.Name = "in_gui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void viewCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    class Submit
    {
        uint checkNum;
        double totalAmount;
        uint numOfChecks;
        //event handler for when submit button is clicked
        public void submit(string name, string amount, string memo, bool tf)
        {
            //variables
            double amountDouble;

            //converts the amount string into a double (used to keep track of the overall amount 
            if (Double.TryParse(amount, NumberStyles.Currency, null, out amountDouble))
            {
                amountDouble = Convert.ToDouble(amount);
                amountDouble = Math.Floor(amountDouble * 100) / 100;
            }
            else
            {
                MessageBox.Show("Invalid amount, please try again. This section is looking for a dollar amount value (ex: 15.50).");
                return;
            }
            //error check
            if (amountDouble > 250000.00)
            {
                MessageBox.Show("Invalid amount, please try again. Number was too high.");
            }
            else if (amountDouble < 0)
            {
                MessageBox.Show("Invalid amount, please try again. Number was too low.");
            }

            
            //Tally t = new Tally();
            
            //passes data to the processor class
            string amountString = Processor.calculateCheck(amountDouble);
            //passes data to the tally class
            totalAmount = Tally.updateAmountSpent(amountDouble);
            numOfChecks = Tally.updateChecksWritten();
            checkNum = Tally.updateCheckNum();
            checkNum += 1000;
            Tally.Out();

            //checks to see if the view check checkbox is checked.
            //if it is checked, it creates the check and lets the user see it.
            if (tf)
            {
                out_gui og = new out_gui();
                //passes data to the out_gui class
                og.setData(name, amountDouble, memo, amountString, checkNum, totalAmount, numOfChecks);
                og.ShowDialog();
            }
        }
        public void getTally(uint num, double amt, uint numChecks)
        {
            checkNum = num;
            totalAmount = amt;
            numOfChecks = numChecks;
        }
    }
}