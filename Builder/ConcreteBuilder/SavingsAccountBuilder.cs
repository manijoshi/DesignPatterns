using Builder.Builder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.ConcreteBuilder
{
    public class SavingAccountBuilder : IAccountBuilder
    {
        private Account _savingAccount = new Account();
        public void AddAccountNumber(long accountNumber)
        {
            _savingAccount.AccountNumber = accountNumber;
        }

        public void AddCredential(string userName, string password)
        {
            _savingAccount.UserName = userName;
            _savingAccount.Password = password;
        }

        public void AddInterestRate(double interestRate)
        {
            return;
        }


        public void WithLoanAmount(double loanAmount)
        {
            _savingAccount.LoanAmount = loanAmount;
        }
        public Account GetAccount()
        {
            return _savingAccount;
        }

        public void WithSavingBalance()
        {
            _savingAccount.Balance = 400000;
        }
    }
}
