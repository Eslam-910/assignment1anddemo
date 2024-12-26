using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace c_basic01G03_demo
{
    internal class program
    {
        static void Main()
        {
            #region revision
            //revision
            //Console.WriteLine("Helo World!");
            //Console.WriteLine("Helo Ahmed");
            //Console.WriteLine("Helo World!");
            //Console.WriteLine("Helo World!");
            #endregion revision
            #region variable
            //variable declaration
            //datatype variableName;
            //int Number; //declar variable
            //allocte uninitialized 4 bytes at momery
            //Console.WriteLine(Number);//invalid
            //Number = 5;
            //variable
            //name
            //datatype
            //size
            //value
            //address
            //Console.WriteLine(Number);//5

            //int Number = 5;
            //declare and initialization for the number
            //Console.WriteLine(Number);
            //int number01;
            //int number02;
            //int number03;
            //int Number01 = 2, Number02 = 3, Number03;
            //Console.WriteLine(Number01);
            //Number01 = 7;
            //Console.WriteLine(Number01);
            //Console.WriteLine(Number03);
            #endregion variable
            #region DataType(Value Type): Stack
            ////DataType(Value Type): Stack
            ////Decrale Variable
            //int Number;
            ////allocate uninitializtion 4bytes at stack
            ////int C# KeyWord
            ////BCL:Int32
            //Int32 Number02;
            //Number = 12;
            ////Console.WriteLine(Number02);
            #endregion
            #region  reference type
            //point P01;//reference
            //          //declare reference from type point
            //          //P01:can refer to object from type 'point'
            //          //8bytes will be allocated at stack for the 'P01' 
            //          //0bytes will be allocated at heap

            ////Console.WriteLine(P01);

            //P01 = new point();
            ////new
            ////1.allocated the required number of bytes for the object at heap(8+)
            ////2.initialized alllocated bytes at heap with the (default value=0)
            ////3.call user defind constructor if exists
            ////4.assign the object reference(p01)
            //Console.WriteLine(P01.X);//0
            //Console.WriteLine(P01.Y);//0
            //Console.WriteLine(P01);

            //point P02 = new point();
            //P02.X = 12;
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P02.X);

            //P01 = P02;
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P02.X);
            #endregion
            #region object
            //object O01;

            ////dclare for reference from datatype'object'
            ////can refer to instance from 'object'or any type inherited from object 
            //O01 = new object();
            //O01 = 1;
            ////O01 = 'a';
            ////O01 = 1.2;
            ////O01 = true;
            ////O01 = new point();
            ////Console.WriteLine(O01);

            //point P1= new point();
            //Console.WriteLine(P1.GetHashCode());
            //Console.WriteLine(P1.ToString());
            //Console.WriteLine(P1);
            ////P1.GetHashCode();
            ////P1.Equals();
            ////P1.GetType();

            #endregion
            #region Casting

            //implicit casting
            //int X = 5;
            //double Y = X;
            //Console.WriteLine(Y);
            //explicit casting
            //double X = 2.5;
            //int Y =(int) X;
            //Console.WriteLine(Y);

            //long X = 1111111111111111111;
            //int Y =(int) X;
            //Console.WriteLine(Y);

            #endregion
            #region parse and try parse
            //Console.WriteLine("Enter Your Age: ");
            //int Age=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Your GPA");
            //double GPA=double.Parse(Console.ReadLine());
            //Console.WriteLine("Age: " + Age);
            //Console.WriteLine("GPA: " + GPA);
            //Console.WriteLine("Enter Your Age");
            //int Age=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Age: "+Age);
            //Console.WriteLine("Enter Your Age");
            //int Age;
            //bool Flag=int.TryParse(Console.ReadLine(), out Age);
            //Console.WriteLine("Age : "+Age);
            //Console.WriteLine("Falg: "+Flag);
            #endregion

            





        }
    }
}
