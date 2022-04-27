using System;

namespace UserRegestration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            string firstName=Console.ReadLine();
            if(Validations.ValidateFirstName(firstName))
            {
                Console.WriteLine("First Name validated");
            }
            else
            {
                Console.WriteLine("First name invalid");
            }
        }
    }

}