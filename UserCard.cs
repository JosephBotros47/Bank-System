using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    public class UserCard
    {
        private UserCard()
        {
            // I need this
        }
        public static void DisplayCard( NormalUser us1)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("**************User-Card****************");
            Console.WriteLine("* Name : " + us1.Name);
            Console.WriteLine("* Age : " + us1.Age);
            Console.WriteLine($"* Money you have : {us1.Money}$");
            Console.WriteLine("\n***************************************");
        }
    }
}
