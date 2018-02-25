/*tally.cs
 Alex Raymond*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProject01
{
    class Tally
    {
        private static double totalAmountSpent { get; set ; }
        private static uint checkNum { get; set; }
        private static uint numOfChecksWritten { get; set; }

        public Tally()
        {
            numOfChecksWritten = 0;
            totalAmountSpent = 0;
            checkNum = 1000;

        }

        public Tally(double amount, uint checkNumber, uint checksWritten)
        {
            totalAmountSpent = amount;
            checkNum = checkNumber;
            numOfChecksWritten = checksWritten;
        }
        public Tally(double amount, uint checkNumber)
        {
            totalAmountSpent = amount;
            checkNum = checkNumber;
        }
        public Tally(double amount)
        {
            totalAmountSpent = amount;
        }

        public static uint updateCheckNum()
        {
            checkNum++;
            return checkNum;
        }
        public static uint updateChecksWritten()
        {
            numOfChecksWritten++;
            return numOfChecksWritten;
        }
        public static double updateAmountSpent(double amount)
        {
            totalAmountSpent = totalAmountSpent + amount;
            return totalAmountSpent;
        }
        public static void Out()
        {
            Submit s = new Submit();
            s.getTally(checkNum, totalAmountSpent, numOfChecksWritten);
        }
    }
}
