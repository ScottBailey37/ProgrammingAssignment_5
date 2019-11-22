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
    class SavingsAccount
    {
        // Declare some variables
        static Double annualInterestRate;
        private Double savingsBalance;
        private String savingsAccountName;
      

        /// <summary>
        /// Sets the current name on the account.
        /// </summary>
        /// <param name="name">The name of the account holder.</param>
        public void setSavingsAccountName(String name)
        {
            // Update account name
            this.savingsAccountName = name;
        }

        /// <summary>
        /// Gets the current name on the account.
        /// </summary>
        /// <returns>A string value containing the account holder name.</returns>
        public String getSavingsAccountName()
        {
            // Get the account name
            return this.savingsAccountName;
        }

        /// <summary>
        /// Sets the account balance.
        /// </summary>
        /// <param name="balance">The balance to set</param>
        public void setSavingsBalance(Double balance)
        {
            // Update savings balance
            this.savingsBalance = balance;
        }

        /// <summary>
        /// Gets the acount balance.
        /// </summary>
        /// <returns>A double containing the account balance.</returns>
        public Double getSavingsBalance()
        {
            // Get account balance
            return this.savingsBalance;
        }

        /// <summary>
        /// Initializes a new instance of the SavingsAccount class with default values.
        /// </summary>
        public SavingsAccount()
        {
            // No parameters supplied so initialize default
            this.savingsBalance = 0.0;
            this.savingsAccountName = "";
        }

        /// <summary>
        /// Initializes a new instance of the SavingsAccount class using the specified savings balance and account name.
        /// </summary>
        /// <param name="savingsBalance">The initial savings balance.</param>
        /// <param name="savingsAccountName">The initial account holder name.</param>
        public SavingsAccount(Double savingsBalance, String savingsAccountName)
        {   
            // Initialize balance and name variables with parameter values
            setSavingsBalance(savingsBalance);
            setSavingsAccountName(savingsAccountName);
        }

        /// <summary>
        /// Calculates the monthly interest accrued and updates the savings balance to reflect it.
        /// </summary>
        public void CalculateMonthlyInterest()
        {            
            // To get the updated savings balance, we increment savingsBalance
            // with the monthly accruement of interest using the set apr
            this.savingsBalance += (this.savingsBalance * (annualInterestRate / 12));           
        }

        /// <summary>
        /// Sets the annual interest rate using supplied value.
        /// </summary>
        /// <param name="rate">The annual interest rate to set.</param>
        public static void setAnnualInterestRate(Double rate)
        {
            // Update with new rate
            annualInterestRate = rate;
        }

        /// <summary>
        /// Prints the account holder name, balance, and current annual interest rate to console.
        /// </summary>
        public void PrintSavingsAccount()
        {
            Console.Write(savingsAccountName + "\t \t");

            // Because doubles get truncated when non-zero numbers are far on the right side,
            // this statement will align the columns of each instance properly.             
            if (savingsBalance % 1 == 0)// No decimals (integers)
            {
                Console.Write(savingsBalance + "\t \t \t");
            }
            else // Decimals places
            {                 
                Console.Write(savingsBalance.ToString("f9") + "\t \t");
            }

            Console.WriteLine(annualInterestRate.ToString());           
        }
    }
}
