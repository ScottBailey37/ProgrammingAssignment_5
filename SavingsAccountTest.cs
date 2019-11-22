/* CODE OF HONOR: I have not discussed the source code in my program with anyone other than my 
 * instructor’s approved human sources. I have not used source code obtained from another student, 
 * or any other unauthorized source, either modified or unmodified. If any source code or documentation 
 * used in my program was obtained from another source, such as a textbook or course notes, that 
 * has been clearly noted with a proper citation in the comments of my program. I have not knowingly 
 * designed this program in such a way as to defeat or interfere with the normal operation of any 
 * machine it is graded on or to produce apparently correct results when in fact it does not. */

using System;


namespace ProgrammingAssignment_5
{
    class SavingsAccountTest
    {
        static void Main(string[] args)
        {
            // Declare and initialize 3 SavingsAccount objects
            SavingsAccount saver1 = new SavingsAccount(2000, "Saver_One");
            SavingsAccount saver2 = new SavingsAccount(3000, "Saver_Two");
            SavingsAccount saver3 = new SavingsAccount(); // Initialize with default constructor
            
            // Set current interest rate
            SavingsAccount.setAnnualInterestRate(.04);

            // Update saver3 object variables
            saver3.setSavingsAccountName("Saver_Three");
            saver3.setSavingsBalance(50000);

            // Print the account information for each object
            Console.WriteLine("Initial savings account balances:");
            saver1.PrintSavingsAccount();
            saver2.PrintSavingsAccount();
            saver3.PrintSavingsAccount();

            // Calculate accrued interest of each object and add to balances
            saver1.CalculateMonthlyInterest();
            saver2.CalculateMonthlyInterest();
            saver3.CalculateMonthlyInterest();

            // Print the updated account information for each object
            Console.WriteLine("\nSavings account balances after calculating monthly interest at 4%:");
            saver1.PrintSavingsAccount();
            saver2.PrintSavingsAccount();
            saver3.PrintSavingsAccount();

            // Change interest rate to 5% for all objects
            SavingsAccount.setAnnualInterestRate(.05);

            // Calculate accrued interest after rate change and add to balances
            saver1.CalculateMonthlyInterest();
            saver2.CalculateMonthlyInterest();
            saver3.CalculateMonthlyInterest();

            // Print final updated account information for each object
            Console.WriteLine("\nSavings account balances after calculating monthly interest at 5%:");
            saver1.PrintSavingsAccount();
            saver2.PrintSavingsAccount();
            saver3.PrintSavingsAccount();

            // Wait for user to press the enter key before exiting
            Console.WriteLine("\nPress the [enter] key to continue.");
            // Intercept all other keys except enter key
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
