using System;
using System.Text.RegularExpressions;

namespace LAB_2._3_Validating_Input_With_Regex
{
    class Program
    {
            static void Names(string name)
            {
                Console.Write("Please enter a valid Name:");
                string input = Console.ReadLine();
                Regex reg = new Regex(@"^[A-Z][a-z]{0,29}$"); // First Letter Capital A-Z, followed by up 0-29 additional letters a-z only.

                bool matched = reg.IsMatch(input);

                if (matched == false)
                {
                    Console.WriteLine("Please use valid names only.)");
                }
                else
                {
                    Console.WriteLine("Name is valid!");
                }
            }

            static void Email(string email)
            {
                Console.Write("Please enter a valid Email:");
                string input = Console.ReadLine();
                Regex reg = new Regex(@"^([A-Z]|[a-z]|[0-9]){5,30}\@([A-Z]|[a-z]|[0-9]){5,10}\.([A-Z]|[a-z]|[0-9]){2,3}$"); //5-30 characters long. All letters and numbers valid. Followed by a @ 5-10
                                                                                                                           // chararcter comain, letters onlt followed by 2-3 char domain suffix
                bool matched = reg.IsMatch(input);

                if (matched == false)
                {
                Console.WriteLine("Please use valid Emails Only.");
                }
                else
                {
                    Console.WriteLine("Email is valid!");
                }
            }

            static void PhoneNumbers(string phoneNumber)
            {
                Console.Write("Please enter a valid Phone Number:");
                string input = Console.ReadLine();

                
                Regex reg = new Regex(@"^[(]?|[0-9]{3}([)-])\-|\.[0-9]{3}\-|\.[0-9]{4}$");


                bool matched = reg.IsMatch(input);

                if (matched == false)
                {
                    Console.WriteLine("Please use valid phone numbers only.");
                }
                else
                {
                    Console.WriteLine("Phone Number is valid!");
                }
            }
            
            static void Date(string date)
            {
                Console.Write("Please enter a valid Date:");
                string input = Console.ReadLine();

                Regex reg = new Regex(@"^(3[0-1]|2[0-9]|1[0-9]|[1-9])\/(1[0,1,2]|0[1-9]|[1-9])\/[0-9]{4}$");

            


                bool matched = reg.IsMatch(input);

                if (matched == false)
                {
                    Console.WriteLine("Please use valid Dates only.");
                }
                else
                {
                    Console.WriteLine("Date is valid!");
                }

            }
    




            static void Main(string[] args)
            {
                string nameInput = "";
                string phoneInput = "";
                string dateInput = "";
                string emailInput = "";


                Names(nameInput);
                PhoneNumbers(phoneInput);
                Date(dateInput);
                Email(emailInput);
            }
    }
}
