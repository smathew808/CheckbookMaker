//
//File: out_gui.cs
//Author: Kyle Dennison
//Displays check.
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

namespace IntroProject01
{
    public partial class out_gui : Form
    {
        
        private PictureBox innerBorder;
        private TextBox checkNameBox;
        private TextBox checkNumberBox1;
        private PictureBox payToOrderOfLine;
        private TextBox payToOrderOfText;
        private TextBox nameText;
        private PictureBox dateLine;
        private Label dateText;
        private TextBox date;
        private Label dollarSign;
        private TextBox amountBox;
        private PictureBox amountLine;
        private Label dollarsText;
        private TextBox amountText;
        private TextBox schoolText;
        private PictureBox memoLine;
        private Label memoText;
        private TextBox memo;
        private PictureBox voidLine;
        private TextBox voidText;
        private TextBox acctRouting;
        private TextBox checkNumberBox2;
        private PictureBox outerBorder;

        public out_gui()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.outerBorder = new System.Windows.Forms.PictureBox();
            this.innerBorder = new System.Windows.Forms.PictureBox();
            this.checkNameBox = new System.Windows.Forms.TextBox();
            this.checkNumberBox1 = new System.Windows.Forms.TextBox();
            this.payToOrderOfLine = new System.Windows.Forms.PictureBox();
            this.payToOrderOfText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.dateLine = new System.Windows.Forms.PictureBox();
            this.dateText = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.dollarSign = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.amountLine = new System.Windows.Forms.PictureBox();
            this.dollarsText = new System.Windows.Forms.Label();
            this.amountText = new System.Windows.Forms.TextBox();
            this.schoolText = new System.Windows.Forms.TextBox();
            this.memoLine = new System.Windows.Forms.PictureBox();
            this.memoText = new System.Windows.Forms.Label();
            this.memo = new System.Windows.Forms.TextBox();
            this.voidLine = new System.Windows.Forms.PictureBox();
            this.voidText = new System.Windows.Forms.TextBox();
            this.acctRouting = new System.Windows.Forms.TextBox();
            this.checkNumberBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.outerBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.innerBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payToOrderOfLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voidLine)).BeginInit();
            this.SuspendLayout();
            // 
            // outerBorder
            // 
            this.outerBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outerBorder.Location = new System.Drawing.Point(12, 12);
            this.outerBorder.Name = "outerBorder";
            this.outerBorder.Size = new System.Drawing.Size(700, 282);
            this.outerBorder.TabIndex = 0;
            this.outerBorder.TabStop = false;
            // 
            // innerBorder
            // 
            this.innerBorder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.innerBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.innerBorder.Location = new System.Drawing.Point(21, 23);
            this.innerBorder.Name = "innerBorder";
            this.innerBorder.Size = new System.Drawing.Size(680, 261);
            this.innerBorder.TabIndex = 1;
            this.innerBorder.TabStop = false;
            // 
            // checkNameBox
            // 
            this.checkNameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkNameBox.Font = new System.Drawing.Font("Arial", 13F);
            this.checkNameBox.Location = new System.Drawing.Point(31, 32);
            this.checkNameBox.Name = "checkNameBox";
            this.checkNameBox.Size = new System.Drawing.Size(194, 20);
            this.checkNameBox.TabIndex = 2;
            this.checkNameBox.Text = "Millennium Intro Project 1";
            // 
            // checkNumberBox1
            // 
            this.checkNumberBox1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.checkNumberBox1.Location = new System.Drawing.Point(635, 32);
            this.checkNumberBox1.Name = "checkNumberBox1";
            this.checkNumberBox1.Size = new System.Drawing.Size(47, 27);
            this.checkNumberBox1.TabIndex = 3;
            // 
            // payToOrderOfLine
            // 
            this.payToOrderOfLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payToOrderOfLine.Location = new System.Drawing.Point(31, 122);
            this.payToOrderOfLine.Name = "payToOrderOfLine";
            this.payToOrderOfLine.Size = new System.Drawing.Size(531, 2);
            this.payToOrderOfLine.TabIndex = 4;
            this.payToOrderOfLine.TabStop = false;
            // 
            // payToOrderOfText
            // 
            this.payToOrderOfText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payToOrderOfText.Font = new System.Drawing.Font("Arial", 6F);
            this.payToOrderOfText.Location = new System.Drawing.Point(31, 102);
            this.payToOrderOfText.Multiline = true;
            this.payToOrderOfText.Name = "payToOrderOfText";
            this.payToOrderOfText.Size = new System.Drawing.Size(58, 20);
            this.payToOrderOfText.TabIndex = 5;
            this.payToOrderOfText.Text = "PAY TO THE ORDER OF";
            // 
            // nameText
            // 
            this.nameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameText.Font = new System.Drawing.Font("Arial", 20F);
            this.nameText.Location = new System.Drawing.Point(83, 91);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(479, 31);
            this.nameText.TabIndex = 6;
            // 
            // dateLine
            // 
            this.dateLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLine.Location = new System.Drawing.Point(568, 86);
            this.dateLine.Name = "dateLine";
            this.dateLine.Size = new System.Drawing.Size(115, 2);
            this.dateLine.TabIndex = 7;
            this.dateLine.TabStop = false;
            // 
            // dateText
            // 
            this.dateText.AutoSize = true;
            this.dateText.Font = new System.Drawing.Font("Arial", 6F);
            this.dateText.Location = new System.Drawing.Point(566, 73);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(25, 10);
            this.dateText.TabIndex = 8;
            this.dateText.Text = "DATE";
            // 
            // date
            // 
            this.date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.date.Font = new System.Drawing.Font("Arial", 12F);
            this.date.Location = new System.Drawing.Point(596, 65);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(86, 19);
            this.date.TabIndex = 9;
            this.date.Text = "01/24/2018";
            // 
            // dollarSign
            // 
            this.dollarSign.AutoSize = true;
            this.dollarSign.Font = new System.Drawing.Font("Arial", 12F);
            this.dollarSign.Location = new System.Drawing.Point(565, 106);
            this.dollarSign.Name = "dollarSign";
            this.dollarSign.Size = new System.Drawing.Size(17, 18);
            this.dollarSign.TabIndex = 10;
            this.dollarSign.Text = "$";
            // 
            // amountBox
            // 
            this.amountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountBox.Font = new System.Drawing.Font("Arial", 12F);
            this.amountBox.Location = new System.Drawing.Point(583, 98);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(100, 26);
            this.amountBox.TabIndex = 11;
            // 
            // amountLine
            // 
            this.amountLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountLine.Location = new System.Drawing.Point(30, 162);
            this.amountLine.Name = "amountLine";
            this.amountLine.Size = new System.Drawing.Size(652, 2);
            this.amountLine.TabIndex = 12;
            this.amountLine.TabStop = false;
            // 
            // dollarsText
            // 
            this.dollarsText.AutoSize = true;
            this.dollarsText.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarsText.Location = new System.Drawing.Point(642, 149);
            this.dollarsText.Name = "dollarsText";
            this.dollarsText.Size = new System.Drawing.Size(41, 10);
            this.dollarsText.TabIndex = 13;
            this.dollarsText.Text = "DOLLARS";
            // 
            // amountText
            // 
            this.amountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountText.Font = new System.Drawing.Font("Arial", 12F);
            this.amountText.Location = new System.Drawing.Point(30, 140);
            this.amountText.Name = "amountText";
            this.amountText.Size = new System.Drawing.Size(605, 19);
            this.amountText.TabIndex = 14;
            // 
            // schoolText
            // 
            this.schoolText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.schoolText.Font = new System.Drawing.Font("Arial", 12F);
            this.schoolText.Location = new System.Drawing.Point(30, 186);
            this.schoolText.Name = "schoolText";
            this.schoolText.Size = new System.Drawing.Size(652, 19);
            this.schoolText.TabIndex = 15;
            this.schoolText.Text = "Southern Illinois University Edwardsville";
            // 
            // memoLine
            // 
            this.memoLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memoLine.Location = new System.Drawing.Point(31, 243);
            this.memoLine.Name = "memoLine";
            this.memoLine.Size = new System.Drawing.Size(230, 2);
            this.memoLine.TabIndex = 16;
            this.memoLine.TabStop = false;
            // 
            // memoText
            // 
            this.memoText.AutoSize = true;
            this.memoText.Font = new System.Drawing.Font("Arial", 6F);
            this.memoText.Location = new System.Drawing.Point(29, 230);
            this.memoText.Name = "memoText";
            this.memoText.Size = new System.Drawing.Size(30, 10);
            this.memoText.TabIndex = 17;
            this.memoText.Text = "MEMO";
            // 
            // memo
            // 
            this.memo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memo.Font = new System.Drawing.Font("Arial", 12F);
            this.memo.Location = new System.Drawing.Point(65, 223);
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(196, 19);
            this.memo.TabIndex = 18;
            // 
            // voidLine
            // 
            this.voidLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voidLine.Location = new System.Drawing.Point(382, 243);
            this.voidLine.Name = "voidLine";
            this.voidLine.Size = new System.Drawing.Size(300, 2);
            this.voidLine.TabIndex = 19;
            this.voidLine.TabStop = false;
            // 
            // voidText
            // 
            this.voidText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.voidText.Font = new System.Drawing.Font("Arial", 12F);
            this.voidText.Location = new System.Drawing.Point(382, 223);
            this.voidText.Name = "voidText";
            this.voidText.Size = new System.Drawing.Size(300, 19);
            this.voidText.TabIndex = 20;
            this.voidText.Text = "//VOID//";
            this.voidText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // acctRouting
            // 
            this.acctRouting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.acctRouting.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.acctRouting.Location = new System.Drawing.Point(30, 255);
            this.acctRouting.Name = "acctRouting";
            this.acctRouting.Size = new System.Drawing.Size(254, 17);
            this.acctRouting.TabIndex = 21;
            this.acctRouting.Text = "|:(987654321 325001182018";
            // 
            // checkNumberBox2
            // 
            this.checkNumberBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkNumberBox2.Font = new System.Drawing.Font("OCR A Extended", 10F);
            this.checkNumberBox2.Location = new System.Drawing.Point(290, 252);
            this.checkNumberBox2.Name = "checkNumberBox2";
            this.checkNumberBox2.Size = new System.Drawing.Size(39, 21);
            this.checkNumberBox2.TabIndex = 22;
            // 
            // out_gui
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(724, 314);
            this.Controls.Add(this.checkNumberBox2);
            this.Controls.Add(this.acctRouting);
            this.Controls.Add(this.voidText);
            this.Controls.Add(this.voidLine);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.memoText);
            this.Controls.Add(this.memoLine);
            this.Controls.Add(this.schoolText);
            this.Controls.Add(this.amountText);
            this.Controls.Add(this.dollarsText);
            this.Controls.Add(this.amountLine);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.dollarSign);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.dateLine);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.payToOrderOfText);
            this.Controls.Add(this.payToOrderOfLine);
            this.Controls.Add(this.checkNumberBox1);
            this.Controls.Add(this.checkNameBox);
            this.Controls.Add(this.innerBorder);
            this.Controls.Add(this.outerBorder);
            this.Name = "out_gui";
            ((System.ComponentModel.ISupportInitialize)(this.outerBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.innerBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payToOrderOfLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voidLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void setData(string name, double amount, string memo, string amtString, uint checkNum, double totalAmt, uint numChecks)
        {
            this.nameText.Text = name;
            this.amountText.Text = amtString;
            this.amountBox.Text = amount.ToString();
            this.memo.Text = memo;
            this.checkNumberBox1.Text = checkNum.ToString();
            this.checkNumberBox2.Text = checkNum.ToString();        
        }
    }
}