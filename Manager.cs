using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    public class Manager :User
    {
        public Manager(string n,int a) 
        {
            this.Age = a;
            this.Name = n;
        }
        // properties 
        public void Add(Bank b,string name, int age, int money)
        {
            b.Add(name,age,money);
        }
        public void Remove(Bank b,string name)
        {
            b.Remove(name);
        }
        public void Display(Bank b)
        {
            for (int i = 0; i<b.NormuserCount; i++)
            {
                Console.WriteLine("Name : "+b.normuser[i].Name);
                Console.WriteLine("Age : " + b.normuser[i].Age);
                Console.WriteLine("Money : " + b.normuser[i].Money);
                Console.WriteLine("********************************\n");
            }
        }
    }
}
