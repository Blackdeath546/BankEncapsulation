namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount newUser = new BankAccount();
            Console.WriteLine("Enter amount of money: ");
            bool proceed = true;
            while (proceed = true)
            {
                string userInput = Console.ReadLine();

                if (double.TryParse(userInput, out double number))
                {
                    newUser.Deposit(number);
                    Console.WriteLine("Deposited ${0}", number);
                    newUser.GetBalance();
                    Console.WriteLine("Would you like to deposit more money? yes/no ");
                    string userInput2 = Console.ReadLine().ToLower();
                    if (userInput2 != "yes")
                    {
                        proceed = false;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Enter amount of money: ");
                    }

                }
                else
                {
                    Console.WriteLine($"That is not a valid number\nPlease try again.");
                }
            }
        }
    }
}
