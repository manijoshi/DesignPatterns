using Builder.Builder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.ConcreteBuilder
{
    public class LoanAccountBuilder : IAccountBuilder
    {
        private Account _loanAccount = new Account();
        public void AddAccountNumber(long accountNumber)
        {
            _loanAccount.AccountNumber = accountNumber;
        }

        public void AddCredential(string userName, string password)
        {
            _loanAccount.UserName = userName;
            _loanAccount.Password = password;
        }

        public void AddInterestRate(double interestRate)
        {
            _loanAccount.InterestRate = interestRate;
        }

        
        public void WithLoanAmount(double loanAmount)
        {
            _loanAccount.LoanAmount = loanAmount;
        }
        public Account GetAccount()
        {
            return _loanAccount;
        }

        public void WithSavingBalance()
        {
            _loanAccount.Balance = 40000;
        }
    }
}
