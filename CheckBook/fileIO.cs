//
// fileIO.cs
// By Kade Walter
// reads and writes to and from the file. 
//  -reads the current balance
//  -writes to the end of the existing checkbook
//  -makes a new checkbook if needed
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IntroProject01
{
    class fileIO
    {
        //returns the current balance that is at the end of a checkbook
        public double getCurrentBalance(string book)
        {
            book += ".cbk";
            double currentBalance = 0.00;
            //reads the last line of the file
            //syntax help from stackoverflow article: https://stackoverflow.com/questions/11625595/read-last-line-of-text-file
            string lastLine = File.ReadLines(book).Last();
            //splits the last line into string array
            string[] l = lastLine.Split(',');
            int maxPos = (l.Length - 1);
            string end;
            //gets the current balance from the last position on the line
            end = l[maxPos];
            currentBalance = Convert.ToDouble(end);
            return currentBalance;
        }

        public int getCurrentCheckNum(string book)
        {
            string line;
            int checkNum = 0;
            //read the entire file to find the last used check number
            //syntax help from Microsoft C# documentation: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-a-text-file-one-line-at-a-time
            book += ".cbk";
            StreamReader checkbook = new StreamReader(book);
            while((line = checkbook.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                if((words[1] != "CASH") && (words[1]) != "DEPOSIT")
                {
                    checkNum =  Convert.ToInt32(words[1]);
                }
            }
            return checkNum;
        }

        //writes a transaction to the file
        public void writeTransaction(string book, string date, string transactionType, double amount, string toField, string memo, double newBalance)
        {
            //make the checkbook name into a checkbook file 
            book += ".cbk";
            string transaction = "";

            //add the date
            transaction += (date + ',');

            //add the transaction type
            //if the transaction is CASH or DEPOSIT, it adds that to the check, otherwise transactionType will hold the check number
            transaction += (transactionType + ',');

            //add the amount
            string a = amount.ToString();
            transaction += (a + ',');

            //add the "to" field
            transaction += (toField + ',');

            //add the memo
            transaction += (memo + ',');

            //add the new balance
            newBalance.ToString();
            transaction += (newBalance + "");

            //ends the line
            transaction += Environment.NewLine;

            //writes the transaction to the file
            File.AppendAllText(book, transaction);
            
        }

        //if the checkbook doesnt exist, this makes a new one
        public void makeNewCheckbook(string name)
        {
            string checkbook = (name + ".cbk");
            var file = File.Create(checkbook);
            file.Close();
        }
        
    }
}
