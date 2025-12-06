using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    public class Bank
    {
        // fields 
        public NormalUser[] normuser =new NormalUser[100];
        public int NormuserCount = 0;
        // methods 
        public void Add(string n, int a,int money)
        {
            NormalUser nus1 = new NormalUser(n,a);
            nus1.Money = money;
            normuser[NormuserCount] = nus1;
            NormuserCount++;
        }
        public void Remove (string n)
        {
            bool exist = false;
            for (int i = 0; i<NormuserCount; i++)
            {
                if (normuser[i].Name == n)
                {
                    normuser[i] = null;
                    for (int j = i; j < NormuserCount - 1; j++)
                        normuser[j] = normuser[j + 1];
                    exist = true;
                    break;
                }
                else
                    continue;
            }
            if (exist)
            {
                Console.WriteLine("Client is removed successfully");
                NormuserCount--;
            }
            else
            {
                Console.WriteLine("You set unexisted client ....");
            }
        }
    }
}
