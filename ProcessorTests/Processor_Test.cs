using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntroProject01;
namespace ProcessorTests
{
    [TestClass]
    public class Processor_Test
    {
        [TestMethod]
        public void processorTest()
        {
            //all possible test cases, Arrange
            double test1S = 7.67;
            double test10S = 86.10;
            double test100S = 578.93;
            double test1000S = 8759.30;
            double test10000S = 35856.14;
            double test100000S = 167459.46;
            double failTest = 1234567.89;

            string test1String = "seven and 67 / 100";
            string test10String = "eighty-six and 10 / 100";
            string test100String = "five hundred  and seventy-eight and 93 / 100";
            string test1000String = " eight thousand and seven hundred  and fifty-nine and 30 / 100";
            string test10000String = "thirty five thousand and eight hundred  and fifty-six and 14 / 100";
            string test100000String = "one hundred and sixty seven thousand and four hundred  and fifty-nine and 46 / 100";

            string failTestString = "one million and two hundred and thirty four thousand and five hundred and sixty-seven and 89 / 100";

            //Call each test, Act
            string result1s = Processor.calculateCheck(test1S);
            string result10s = Processor.calculateCheck(test10S);
            string result100s = Processor.calculateCheck(test100S);
            string result1000s = Processor.calculateCheck(test1000S);
            string result10000s = Processor.calculateCheck(test10000S);
            string result100000s = Processor.calculateCheck(test100000S);

            //this is the failed test since the processor should only accept input up to 250,000
            string resultFail = Processor.calculateCheck(failTest);

            //Assert and test if all of these are true
            Assert.AreEqual(result1s, test1String);
            Assert.AreEqual(result10s, test10String);
            Assert.AreEqual(result100s, test100String);
            Assert.AreEqual(result1000s, test1000String);
            Assert.AreEqual(result10000s, test10000String);
            Assert.AreEqual(result100000s, test100000String);
            Assert.AreEqual(resultFail, failTestString);

        }
    }
}
