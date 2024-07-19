using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes190724
{
    
    internal class Program
    {
        public int show()
        {
            Console.WriteLine("hello1");
            Console.WriteLine("hello2");
            Console.WriteLine("hello3");
            return 0;
            Console.WriteLine("hello4");
        }

        static void Main(string[] args)
        {

            #region 
            //int type variable declare

            //int a;

            //float fp;

            //int radius_of_circle;
            //radius_of_circle = 78;
            //int x1 = radius_of_circle;
            //int y1 = radius_of_circle;

            //radius_of_circle = 3;

            //char ch1;

            //ch1 = '\n';
            //Console.WriteLine("this is my string");
            //Console.WriteLine(radius_of_circle);
            //Console.WriteLine(ch1);//\n
            #endregion

            //formula of area of circle  3.14*r*r===>int/ float /double

            //  int *int ==> int

            //float * int===> float     

            //int x = 4;
            //int k = 8;
            //float y = 3.14;

            //float dd1 = (float)56653545435435445645645645634456464365635546546463465645341.2349584935023059843058923450984645645645346546354364563583488584535342355;
            //float dd2 = (float)1.29083209523094503285489347589792987458995738922309;
            //Console.WriteLine("dd2=" + dd2);
            //3.14145254f
            //    2.145
            //var ans = 3.14 * k;
            //single line comment and multi line comment

            /*    
              this is my first line

                 second line
                and third line
            
            int radius;
           
            */
            //-----------------------------------------------------------
            // write a program to accept radius of circle from user 
            // and calculate area of circle
          
            int rad;
              double area;
            Console.WriteLine("enter radius of cirlce:");
            rad= int.Parse( Console.ReadLine());

              area   = 3.14 * rad * rad;

            Console.WriteLine($"area of Circle is {area}");

            Console.ReadKey();



        }
    }
}
