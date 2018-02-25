using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IntroProject01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new in_gui());

            //TESTING
            //create file
            fileIO fio = new fileIO();
            string filename = "test2";
            //error prevenetion in document name
            string[] file = filename.Split('.');
            if (!File.Exists(file[0] + ".cbk"))
            {
                fio.makeNewCheckbook(filename);
            }
            //tally checker
            int tally1 = 2001;
            int tally2 = 2002;
            string tallyOne = tally1.ToString();
            string tallyTwo = tally2.ToString();

            //write to the file
            fio.writeTransaction(filename, "1/21/2018", "CASH", 12.25, "CASH", "CASH", 12.25);
            fio.writeTransaction(filename, "1/21/2018", tallyOne, 12.25, "DEPOSIT", "PAY DAY", 34.50);
            fio.writeTransaction(filename, "1/21/2018", "DEPOSIT", 12.25, "DEPOSIT", "PAY DAY", 24.50);
            fio.writeTransaction(filename, "1/21/2018", "DEPOSIT", 12.25, "DEPOSIT", "PAY DAY", 34.50);
            fio.writeTransaction(filename, "1/21/2018", tallyTwo, 12.25, "DEPOSIT", "PAY DAY", 34.50);
            //get last balance back (read)
            double currentBalance = fio.getCurrentBalance(filename);
            string output = currentBalance.ToString();
            Console.WriteLine("Balance: " + output);
            //get last check number back
            int checkTally = fio.getCurrentCheckNum(filename);
            string checkNum = checkTally.ToString();
            if (checkTally != 0)
            {
                Console.WriteLine("Last check number: " + checkNum);
            }
            else
            {
                Console.WriteLine("No check created yet. Start at check 2001");
            }
            //find the .cbk files in the folder
            //received help from articel on stack overflow: https://stackoverflow.com/questions/1277222/how-to-list-text-files-in-the-selected-directory-in-a-listbox
            string folder = "";
            string[] Files = Directory.GetFiles(folder, "*.cbk");
            string fileNames = "Exisiting Checkbooks:\n";
            for(int i = 0; i < Files.Length; i++)
            {

                fileNames += Path.GetFileNameWithoutExtension(Files[i]) + "\n";
            }
            //display the folders
            Console.WriteLine(fileNames);
            Console.ReadLine();
        }
                
    }

}
