/*
 * File: cbk_gui.cs
 * Author: Kyle Dennison 
 * Allows user to choose existing checkbook or create a new one.
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
    public partial class cbk_gui : Form
    {
        //name of th checkbook.
        public string name;
        public double currBalance;
        public cbk_gui()
        {
            InitializeComponent();
        }

        //methods for each button click on the form. 
        private void openButton_Click(object sender, EventArgs e)
        {
            //opens whatever file was chosen. 
            string cbkName = this.checkbook.Text.ToString();
            name = this.checkbook.Text.ToString();
            open(cbkName);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //creates a new file with whatever name was given.
            string cbkName = this.newCheckbook.Text.ToString();
            name = this.checkbook.Text.ToString();
            create(cbkName);
        }

        public void open(string cbkName)
        {
            fileIO fIO = new fileIO();
            currBalance = fIO.getCurrentBalance(cbkName);
            transaction_gui t = new transaction_gui(cbkName);
            t.ShowDialog();
        }

        public void create(string cbkName)
        {
            //creates new checkbook in the folder. 
            fileIO fIO = new fileIO();
            fIO.makeNewCheckbook(cbkName);
            currBalance = 0.00;
            //Makes a new transaction_gui and opens it so the user can choose
            //what type of transaction to make. 
            transaction_gui t = new transaction_gui(cbkName);
            t.ShowDialog();
        }
    }
}
