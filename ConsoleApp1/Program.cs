using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a=20, b=30;
            // int c = a + b;
            // Console.WriteLine(c);
            // string inp= Console.ReadLine();
            //int a = 50;
            //float b = 43.5f;
            //double c = 99.3d;
            //Console.WriteLine(a+b);

            // TypeCasting 
            // implicit TypeCasting (convert small to Large)
            // char to int to long to float to double
            //int x = (int)3.5;

            //Console.WriteLine(x);

            //input
            Console.WriteLine("enter your name");

            String name=Console.ReadLine();
            Console.WriteLine("hey hi"+"-"+name); 
            
            
            
            Console.WriteLine("how much swt");
            String swt=Console.ReadLine();
            Console.WriteLine("gift 4 my side:"+ (Convert.ToInt32(swt) + 4));



            Console.ReadLine();


        }
    }
}
