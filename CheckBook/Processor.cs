using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProject01
{
    /*processor job starts here*/
    /*The processor takes one piece of data as input. That data is the checks value. This class processes that
     * value into a string */
    public class Processor
    {

        /*This function will take the input of how much money that check will be written for as a double
         * and will output a string that will be the equivalent value of the double */
        public static string calculateCheck(double total)
        {
            //Make an empty string to concatante each needed string value //the empty strings are in the array to make eachvalue parallel to the index number
            string checkTotal = "";

            //this creates two arrays that hold all the possible values needed for the check
            string[] onesList = new string[] { " ", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tensList = new string[] { "  ", "  ", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            //Used this webpage as a reference for the code below https://stackoverflow.com/questions/2729752/converting-numbers-in-to-words-c-sharp
            // This code below that was used for the reference was made by the user "nawfal"

            //The best order for these two if statements is hundred thousands, ten thousand, thousand, and hundred since 
            // a check is read from left to right, with the biggest, valued word on the very left. for example, 
            // seventy-five thousand two hundred and 3 has the biggest value'd strings thousand and hundred from left to right. 


            //deals with cents here first so total can be casted to a int which helps the code later down below, example: 250 % 250.01 = 0.01
            //this saves the decimal value, cents


            double checkTotalCents = total % ((int)(total));
            checkTotalCents = (checkTotalCents * 100);
            

            //This gives the proper value if the double is lower than it should be
            checkTotalCents = Math.Ceiling(checkTotalCents);


            //this converts the decimal value so it can be used in the X / 100 format
            //checkTotal += (checkTotalCents * 100) + " / " + "100";

            //this takes care of the hundred thousands place
            if ((total / 100000) >= 1)
            {
                int hundredThousandsPlace = ((int)total / 100000);
                if ((total / 100000) < 20)
                {
                    checkTotal += onesList[hundredThousandsPlace];

                }

                //if the else executes it means that the total is between 20 and 99
                else

                {
                    //this writes the twenty, thirty, etc onto the string
                    checkTotal += tensList[(int)total / 10];

                    //this writes the one, two, etc onto the string
                    if (((int)total) % 10 > 0)
                    {
                        checkTotal += "-" + onesList[(int)total % 10];

                    }
                }


                //"2"
                //this converts the int , for example if total is 249999.99, then hundredThousandsPlace is 2.49999.. this transforms into a string 




                int difference = (((int)(total / 100000)) * 100000);

                checkTotal += " hundred " + "and " + calculateCheck(((total) - difference));
                total /= 1000000;

            }

            //this takes care of the ten thousands place
            
                if ((total / 10000) >= 1)
                {
                    double tenThousandsPlace = (total / 10000);
                    if ((total / 1000) < 20)
                    {
                        checkTotal += onesList[(int)tenThousandsPlace];

                    }

                    //if the else executes it means that the total is between 20 and 99
                    else

                    {
                        //this writes the twenty, thirty, etc onto the string
                        checkTotal += tensList[(int)tenThousandsPlace];

                        //this writes the one, two, etc onto the string
                        //    if (((int)total) % 10 > 0)
                        //    {
                        //        checkTotal += "-" + onesList[(int)total % 10];

                        //    }
                        //}
                        int differenceTenThouandsPlace = (((int)(total / 10000)) * 10000);
                        total = total - differenceTenThouandsPlace;

                    //int differenceThouandsPlace = (((int)(total / 1000)) * 1000);

                    if (total < 9999)
                    {
                        checkTotal += calculateCheck(total);
                        total /= 100000;
                    }

                    else
                    {
                        checkTotal += " thousand " + calculateCheck(total);
                        total /= 100000;
                    }
                    }

                }
                //this if statement adds a thousand onto the string  if total's value is of a thousand or over
                if ((total / 1000) >= 1)
                {
                    //this is the thouands place
                    if ((total / 1000) >= 1)
                    {

                        if ((total / 1000) >= 1)
                        {
                            double thousandsPlace = (total / 1000);
                            if ((total / 100000) < 20)
                            {
                                checkTotal += " " + onesList[(int)thousandsPlace];

                            }

                            //if the else executes it means that the total is between 20 and 99
                            else

                            {
                                //this writes the twenty, thirty, etc onto the string
                                checkTotal += tensList[(int)total / 10];

                                //this writes the one, two, etc onto the string
                                if (((int)total) % 10 > 0)
                                {
                                    checkTotal += "-" + onesList[(int)total % 10];

                                }
                            }

                        }

                        int difference = (((int)(total / 1000)) * 1000);

                        checkTotal += " thousand " + "and " + calculateCheck(total - difference);
                        total /= 10000;

                    }
                }

                //this if statement adds a thousand onto the string  if total's value is of a hundred or over

                //this is the hundreds place
                if ((total / 100) >= 1)
                {

                    if ((total / 100) >= 1)
                    {
                        double hundredsPlace = (total / 100);
                        if ((total / 100) < 20)
                        {
                            checkTotal += onesList[(int)hundredsPlace];

                        }

                        //if the else executes it means that the total is between 20 and 99
                        else

                        {
                            //this writes the twenty, thirty, etc onto the string
                            checkTotal += tensList[(int)total / 10];

                            //this writes the one, two, etc onto the string
                            if (((int)total) % 10 > 0)
                            {
                                checkTotal += "-" + onesList[(int)total % 10];

                            }
                        }

                    }
                    int difference = (((int)(total / 100)) * 100);

                    checkTotal += " hundred " + " and " + calculateCheck(total - difference);
                    total /= 1000;

                }



                //handles the tens and ones place. this also handles when an "and" is needed
                if (total >= 1)
                {


                    //this If and else concatantes each check according to what the value of total is

                    //this deals with 1 through 19
                    if (total < 20)
                    {
                        checkTotal += onesList[(int)total] + " and " + (int)(checkTotalCents) + " / " + "100";

                    }

                    //if the else executes it means that the total is between 20 and 99
                    else

                    {
                        //this writes the twenty, thirty, etc onto the string
                        checkTotal += tensList[(int)total / 10];

                        //this writes the one, two, etc onto the string
                        if (((int)total) % 10 > 0)
                        {
                            checkTotal += "-" + onesList[(int)total % 10] + " and " + (int)(checkTotalCents) + " / " + "100";

                        }
                    }




                }



            

            return checkTotal;


        }

            
        
    }
}

