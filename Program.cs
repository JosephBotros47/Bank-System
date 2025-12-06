using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bool systemRunning = true;

            while (systemRunning)
            {
                Display.System();
                char input = Console.ReadLine().ToUpper()[0];

                if (input == 'U')
                {
                    Display.Login();
                    Console.Write("\n                Name : ");
                    string name = Console.ReadLine();
                    Console.Write("                Age : ");
                    int age = int.Parse(Console.ReadLine());
                    NormalUser nus = new NormalUser(name, age);
                    bank.normuser[bank.NormuserCount] = nus;
                    bank.NormuserCount++;
                    bool userMode = true;
                    Display.PanelForNus();
                    while (userMode)
                    { 
                        char input1 = Console.ReadLine().ToUpper()[0];

                        switch (input1)
                        {
                            case 'D':
                                Console.WriteLine("********  Deposit Money  ********");
                                Console.Write("Enter the amount of money : ");
                                int money = int.Parse(Console.ReadLine());
                                nus.Deposit(money);
                                Console.WriteLine("Deposit Operation is done successfully");
                                break;
                            case 'W':
                                Console.WriteLine("********  Withdraw Money  ********");
                                Console.Write("Enter the amount of money you need : ");
                                money = int.Parse(Console.ReadLine());
                                nus.Withdraw(money);
                                Console.WriteLine("Withdraw Operation is done successfully");
                                break;
                            case 'T':
                                Console.WriteLine("Name : ");
                                string s = Console.ReadLine();
                                Console.WriteLine("Money : ");
                                int mo = int.Parse(Console.ReadLine());
                                nus.Transfer(bank, mo, s);
                                break;
                            case 'S':
                                UserCard.DisplayCard(nus);
                                break;
                            case 'E':
                                userMode = false;
                                Console.WriteLine("Exiting User Mode...\n");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                    }
                }
                else if (input == 'M')
                {
                    Display.Login();
                    Console.Write("\n                Name : ");
                    string name = Console.ReadLine();
                    Console.Write("                Age : ");
                    int age = int.Parse(Console.ReadLine());
                    Manager mus = new Manager(name, age);

                    bool managerMode = true;
                    Display.PanelForManager();
                    while (managerMode)
                    {
                        char input1 = Console.ReadLine().ToUpper()[0];

                        switch (input1)
                        {
                            case 'A':
                                Console.WriteLine("******* Adding Operation *******");
                                Console.Write("Name : ");
                                string n = Console.ReadLine();
                                Console.Write("Age : ");
                                int a = int.Parse(Console.ReadLine());
                                Console.Write("Initial Money : ");
                                int m = int.Parse(Console.ReadLine());
                                mus.Add(bank, n, a, m);
                                break;
                            case 'R':
                                Console.WriteLine("******* Removing Operation *******");
                                Console.Write("Name : ");
                                n = Console.ReadLine();
                                mus.Remove(bank, n);
                                break;
                            case 'S':
                                mus.Display(bank);
                                break;
                            case 'E':
                                managerMode = false;
                                Console.WriteLine("Exiting Manager Mode...\n");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                    }
                }
                else if (input == 'Q')
                {
                    systemRunning = false;
                    Console.WriteLine("Exiting System...");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter U, M, or Q to quit.");
                }
            }
        }
    }
}


