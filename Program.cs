using System;

namespace ExceptionDemo 
{
    internal class Program
    {
        private const long V = 8208508814;

        static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Exception");

            FirstName firstname = new FirstName();

            try
            {
                firstname.EnterFirstName("Pratik");
            }
            catch (FirstnameException e)
            {
                Console.WriteLine(e.Message);
            }

            LastName lastname = new LastName();

            try
            {
                lastname.EnterLastName("Chitruk");
            }
            catch (LastNameException e)
            {
                Console.WriteLine(e.Message);
            }

            Email email = new Email();

            try
            {
                email.EnterEmail("Pratik.chitruk@gmail.com");
            }
            catch (LastNameException e)
            {
                Console.WriteLine(e.Message);
            }
            MobileNo number = new MobileNo();

            try
            {
                number.EnterNumber(8208508814);
            }
            catch (MobileNoException e)
            {
                Console.WriteLine(e.Message);
            }
            Password password = new Password();

            try
            {
                password.EnterPassword(12345678);
            }
            catch (MobileNoException e)
            {
                Console.WriteLine(e.Message);
            }
            PasswordRule1 passwordrule1 = new PasswordRule1();

            try
            {
                passwordrule1.EnterPassword("12345678P");
            }
            catch (MobileNoException e)
            {
                Console.WriteLine(e.Message);
            }
            PasswordRule2 passwordrule2 = new PasswordRule2();

            try
            {
                passwordrule2.EnterPassword("12345678P@");
            }
            catch (MobileNoException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}