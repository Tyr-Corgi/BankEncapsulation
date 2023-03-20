namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customerAcct = new BankAccount(); // Calling the constructor

            customerAcct.GetBalance();

            //Console.WriteLine($"Current Balance: {customerAcct.GetBalance()}");

            //Console.Writeline();
            //Console.WriteLine("HOw Much do you want to deposit?");
            //var depAmount = double.Parse(Console.ReadLine());

            //customerAcct.Deposit(depAmount);

            //Console.WriteLine($"Current Balance:);


            //Console.WriteLine("How much are you depositing?");
            //Deposit =int.Parse.Console.ReadLine();
            //Console.WriteLine($"You balance is now{})

            customerAcct.Deposit();
        }






    }
}
