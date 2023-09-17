using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.ConsoleMethods
{
    internal class _ConsoleMethods
    {
        private readonly string Name;
        private readonly int Age;
        private readonly string Email;
        private readonly long PhoneNo;

        public _ConsoleMethods (string name, int age, string email, long phone_no)
        {
            Name = name;
            Age = age;
            Email = email;
            PhoneNo = phone_no;
        }
        
        public void Hi ()
        {
            Console.WriteLine("Hello");
            Console.Write($"I am {Name}. ");
            Console.Write($"My age is {Age}");
            Console.Write($" and my email id {Email} & phone number is {PhoneNo}. ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
        }

        public void GetInput ()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hi {name}. What is your age?");
            string age = Console.ReadLine();
            bool isAge = int.TryParse(age, out int numAge);

            if (isAge)
            {
                if (numAge == 23)
                {
                    Console.WriteLine("Me also 23");
                } 
                else if (numAge < 23)
                {
                    Console.WriteLine("You are younger than me.");
                }
                else
                {
                    Console.WriteLine("You are Older than me.");
                }

                Console.WriteLine("Thank You!");
            } 
            else
            {
                Console.WriteLine("Please Enter Your Age.");
            }
            
        }
    }
}
