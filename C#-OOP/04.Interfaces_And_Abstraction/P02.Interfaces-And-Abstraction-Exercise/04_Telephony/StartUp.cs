namespace Telephony
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] phoneNumbersInput = Console.ReadLine().Split().ToArray();
            string[] sitesInput = Console.ReadLine().Split().ToArray();

            foreach (var phoneNumber in phoneNumbersInput)
            {
                try
                {
                    ICallable smartphone = new Smartphone { PhoneNumber = phoneNumber };

                    Console.WriteLine(smartphone.Call());
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var url in sitesInput)
            {
                try
                {
                    IBrowsable smartphone = new Smartphone { URL = url };

                    Console.WriteLine(smartphone.Browse());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}