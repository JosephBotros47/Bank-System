using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    public class Display
    {
        private Display()
        {
            // class for methods
        }
        public static void System()
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("\n                      wellcome                            ");
            Console.WriteLine("                       Bank-System                           ");
            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("\n        Who Are You ?");
            Console.WriteLine("        User OR Manager  (U / M)" +
                "\n                     Press (Q) for exit");
        }
        public static void PanelForNus()
        {
            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("\n                     Bank-System                           ");
            Console.WriteLine("                    | Control Panel |                   ");
            Console.WriteLine("         For Deposit money   PRESS -> (D)");
            Console.WriteLine("         For Withdraw money  PRESS -> (W)");
            Console.WriteLine("         For Transfer money  PRESS -> (T)");
            Console.WriteLine("\n                      To see your Card   PRESS -> (S)");
            Console.WriteLine("                      To exit from the mode -> (E)");
            Console.WriteLine("\n*********************************************************");
        }
        public static void Login()
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("\n                     Bank-System                           ");
            Console.WriteLine("                    | Login Operatin |                  ");
            Console.WriteLine("\n*********************************************************");
        }
        public static void PanelForManager()
        {
            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("\n                     Bank-System                           ");
            Console.WriteLine("                    | Control Panel |                   ");
            Console.WriteLine("         For Add Client       PRESS -> (A)");
            Console.WriteLine("         For Remove Client    PRESS -> (R)");
            Console.WriteLine("\n       To see your Clients  PRESS -> (S)");
            Console.WriteLine("       To exit from the mode -> (E)");
            Console.WriteLine("\n*********************************************************");
        }
    }
}
