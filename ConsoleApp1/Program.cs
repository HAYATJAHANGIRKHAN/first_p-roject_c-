﻿using System;
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
            //Console.WriteLine("enter your name");

            //String name=Console.ReadLine();
            //Console.WriteLine("hey hi"+"-"+name); 



            //Console.WriteLine("how much swt");
            //String swt=Console.ReadLine();
            //Console.WriteLine("gift 4 my side:"+ (Convert.ToInt32(swt) + 4));

            //int a = Math.Max(34, 345);
            //int b = Math.Min(34, 345);
            //double c = Math.Sqrt(36);
            //double d = Math.Abs(-3);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            //escape Sequence characters

            //String hello = "Hello Hayat \"Jahangir Khan ";
            //String hello1 = "Hello Hayat \nJahangir Khan ";
            //String hello2 = "Hello Hayat \tJahangir Khan ";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello. ToLower());
            //Console.WriteLine(hello. Normalize());
            //Console.WriteLine(hello. ToArray());
            //Console.WriteLine(String.Concat(hello+ "hi jaaniya"));

            //String name = Console.ReadLine();
            //String cands = Console.ReadLine();
            //Console.WriteLine($"Your Name is {name}. you will get {cands} cands");
            //Console.WriteLine($" {name}. {cands} cands");

            //String hello = "Hello world this is jaaniya";
            //Console.WriteLine(hello[2]);
            //Console.WriteLine(hello.IndexOf("world"));
            //Console.WriteLine(hello.Substring(5));

            //Console.WriteLine(hello);
            //Console.WriteLine(hello1);
            //Console.WriteLine(hello2);

            //loop
            //int a;
            Console.WriteLine("enter yur age");
            String ageStr = Console.ReadLine();
            int a = Convert.ToInt32(ageStr);
             
            if (a >= 18 )
            {
                Console.WriteLine("you Can Vote");
            }else
            {
                Console.WriteLine("not Vote ");
            }

            Console.WriteLine("enter yur age");
            String ageStr1 = Console.ReadLine();
            int b = Convert.ToInt32(ageStr1);

            //int b = 17;
            if (b <= 5)
            {
                Console.WriteLine("new born baby");

            }
            else if (b >= 6 && b <= 18)
            {
                Console.WriteLine("you youg");
            } else
            {
                Console.WriteLine("you elder");
            }


            Console.ReadLine();


        }
    }
}
