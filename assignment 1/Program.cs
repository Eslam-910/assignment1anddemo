using System.Collections.Specialized;
using System.Drawing;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment_1
{
    internal class Program
    {
        static void Main()
        {
            #region Q1
            //1-Write a program that allows the user to enter a number then print it
            //Console.WriteLine("Enter Number");
            //int Number = 0;
            //bool Flag= int.TryParse(Console.ReadLine(), out Number);
            //Console.WriteLine("Number = " + Number);
            //Console.WriteLine("Flag = "+Flag);
            #endregion
            #region Q2
            //2-Write C# program that converts a string to an integer,
            //but the string contains non-numeric characters.
            //And mention what will happen 
            //string Name = "Lmncd";
            //int test = Convert.ToInt32(Name);
            //Console.WriteLine(test);
            //error it's about The input string 'Lmncd' was not in a correct format


            #endregion
            #region Q3
            //3-	Write C# program that Perform a simple arithmetic operation
            //with floating-point numbers
            //And mention what will happen
            //float Number1 = 25.5f;
            //float Number2 = 25.5F;
            //Console.WriteLine(Number2+Number2);
            #endregion
            #region Q4
            //4-Write C# program that Extract a substring from a given string
            //string Text = "Hello,Welcome To Egypt ";

            //Console.WriteLine(Text.Substring(6,7));



            #endregion
            #region Q5
            //5-Write C# program that Assigning one value type variable to another
            //and modifying the value of one variable and mention what will happen
            //-----------------------------------------------------------
            //int Number1 = 3;
            //int Number2 = 8;
            //Number2 = Number1;
            //Console.WriteLine(Number2);//3
            //-----------------------------------------------------------
            //what happened here: that variable Numbaer1 become value 
            //inside variable Number2
            //and will stored at stack



            #endregion
            #region Q6
            //6-Write C# program that Assigning
            //one reference type variable to another and modifying the object through one
            //variable and mention what will happen
            //-----------------------------------------------------------------
            //Point P01 = new Point();
            //P01.Y = 10;
            //Console.WriteLine(P01.Y);
            //Point P02 = new Point();
            //P02.X = 5;
            //Console.WriteLine(P02.X);
            //P01.Y = P02.X;
            //Console.WriteLine(P01.Y);
            //----------------------------------------------------------------------
            // what happened here: that did with work declare to object point
            // p01.Y=10 and P02.x=5 then we did change address and become P01.Y=P02.X
            // and become the output=5 and that take 8bytes at stack
            #endregion
            #region Q7
            //7-Write C# program that take two string variables and print them
            //as one variable 
            //-----------------------------------------------------------
            //Console.WriteLine("Enter First Name");
            //string Fname= Console.ReadLine();
            //Console.WriteLine("Enter Last Name");
            //string Lname= Console.ReadLine(); 
            //Console.WriteLine(Fname +" " + Lname);

            #endregion
            #region Q8
            //8-Write a program that calculates the simple interest given
            //the principal amount, rate of interest, and time. The formula
            //for simple interest is 
            //Interest = (principal * rate * time) / 100.
            //---------------------------------------------------------------------
            //int Principal = 0;
            //bool Pri =int.TryParse( Console.ReadLine(),out Principal);
            //int Rate = 0;
            //bool Rated = int.TryParse(Console.ReadLine(), out Rate);
            //int Time = 0;
            //bool Tm = int.TryParse(Console.ReadLine(), out Time);
            //int interest = (Principal * Rate * Time) / 100;
            //Console.WriteLine(interest);

            #endregion
            #region Q9
            //9-	Write a program that calculates the Body Mass Index (BMI)
            //given a person's weight in kilograms and height in meters.
            //The formula for BMI is BMI = (Weight) / (Height * Height)
            //Console.WriteLine("Enter Your Weight");
            //int Weight =int.Parse( Console.ReadLine());
            //Console.WriteLine("Enter Your Height");
            //int Height=int.Parse( Console.ReadLine());
            //int BMI = (Height * Height);
            //Console.WriteLine((double)BMI/ Weight );


            #endregion
            #region Q10
            //10-Write a program that uses the ternary operator to check
            //if the temperature is too hot,
            //too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold",
            //above 30 degrees is "Just Hot", and anything else is "Just Good".
            //string Temperature = 1 < 10 ? "Just Cold";
            //string Teperature1 = 10 > 30 ? "just hot";
            //Console.WriteLine(Temperature);
            #endregion
            #region Q11

            #endregion
            #region Q12
            // the correct answer is The event is on 06/14/2024
            #endregion
            #region Q13

            // the correct answer is i)	The code snippet will work correctly if ! is replaced by Not.
            #endregion
            #region Q14

            //d)6 1
            #endregion
            #region Q15
            //d)7 7
            #endregion
        }
    }
}
