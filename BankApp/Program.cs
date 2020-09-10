using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var newWithdrawalRequest = new Withdrawal();
            
            Console.WriteLine("Enter your account Number");
            newWithdrawalRequest.AccountNumber = Console.ReadLine();
            Console.WriteLine("Enter amount to be withdrawn in words");
            newWithdrawalRequest.AmountInWords = Console.ReadLine();

            Console.WriteLine("Are you sure you want to proceed with this withdrawal...Enter (Y/N)");
            bool shouldProceed = Console.ReadLine() == "Y" ? true : false;
            if (shouldProceed)
            {
                Console.WriteLine("..........Counting your Money........................................");
                Task.Delay(3000);
                Console.WriteLine("Enjoy your money");
            }

            else
            {
                 
                Console.WriteLine("Withdrawal Terminated");
                Console.WriteLine("........................Closing this transaction..........................");
                Task.Delay(1000);
                Console.WriteLine("........................Thanks for banking with us..........................");
                Task.Delay(1000);
                Console.ReadLine(); 
            }



        }
    }

    public class Withdrawal
    {
        
        public string AccountNumber { get; set; }
        public string AmountInWords { get; set; }


        public override string ToString()
        {
            return $"Customer with AccountNumber withdrew {AmountInWords} at {DateTime.Now.ToShortDateString()}";
        }
    }
}
