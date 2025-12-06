using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    public class NormalUser : User
    {
        public NormalUser(string n, int a)
        {
            this.Name = n;
            this.Age = a;
        }
        // field 
        private int money;
        public int Money { get { return money; } set { money = value; } }

        // methods
        public void Deposit (int m)
        {
            Money += m;
        }
        public void Withdraw(int money)
        {
            Money -= money;
        }
        public void Transfer(Bank b,int money , string name)
        {
            if (this.Money<money)
            {
                Console.WriteLine("Your Money is less thsn the money you need transfer");
                return;
            }
            for (int i = 0; i < b.NormuserCount; i++)
            {
                if (b.normuser[i].Name==name)
                {
                    Console.WriteLine($"{b.normuser[i].Name} is recieved {money}");
                    b.normuser[i].Deposit(money);
                    this.Money -= money;
                    Console.WriteLine("The Operation is done successfully");
                }
            }
        }

    }
}
