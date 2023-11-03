using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
  
    
        internal class Bank
        {
            public string Ac_Holder;
            private int Bank_ac;

            private int balance;

            public Bank(String Ac_Holder, int Bank_ac, int balance)
            {

                this.Bank_ac = Bank_ac;
                this.balance = balance;
                this.Ac_Holder = Ac_Holder;
                Console.WriteLine($"{Ac_Holder} your account open Successfully");
                Console.WriteLine($"Your Ac number is {Bank_ac}");
                Console.WriteLine($"your account balnace is {balance}");



            }

            public void Deposit(int amount)
            {
                balance += amount;
                Console.WriteLine($"Amount {amount}rs Deposit successfully");
                Check_balance();
            }
            public void Check_balance()
            {
                Console.WriteLine($" Your current balance is {balance}");

            }

            public void withdrawal(int amount)
            {

                if (balance - amount > 0)
                {
                    balance -= amount;
                    Console.WriteLine($"Amount {amount}rs withdrawl successfully");
                    Check_balance();
                }
                else
                {
                    Console.WriteLine("insufficient Balance");
                }
            }


            static void Main(string[] args)
            {
              /*  Bank b1 = new Bank("AP Singh", 4896523, 5000);
                 b1.Deposit(1000);
                 b1.withdrawal(7000);*/

                
                 //car.Main(new string[] { });
                // User.main(new string[] { });
                //Temp.main(new String[] { });
                 //Season_enum.main(new string[] { });
                //Shape_Area.main(new string[] { });
                enum_permission.main(new string[] { });

                Console.ReadLine();

            }
        }
    }

    


