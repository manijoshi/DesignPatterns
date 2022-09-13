using Prototype.RemoteServer;
using Singleton;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreationalDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {



            // 1.************* SIMPLE FACTORY **************
            //IMobile mobile = MobileFactory.CreateMobile(BrandType.Xiaomi);
            //mobile.GetMobile();

            // 2.************** FACTORY METHOD *************
            //IMobileFactory mobileFactory = new XiaomiFactory();
            //IMobile mobile = mobileFactory.GetMobile(ModelType.RedmiPro);
            //mobile.GetMobile();
            //Console.ReadKey();

            // 3.************** ABSTRACT FACTORY *************
            //IMobileFactory mobileFactory = new XiaomiFactory();
            //mobileFactory.GetMobile(ModelType.RedmiPro).GetMobile();
            //mobileFactory.GetSignalStrength(ModelType.RedmiPro).ShowSignalStrength();            
            //Console.ReadKey();



            // 4.************** BUILDER *************
            //var loanAccount1 = new LoanAccountBuilder()
            //    .WithAccountNumber(12345)
            //    .WithCredential("john", "pwd")
            //    .WithLoanAmount(40000)
            //    .WithInterestRate(10.5)
            //    .Build();
            //var loanAccount = new LoanAccountBuilder()
            //    .LoanStatus(true)
            //    .WithLoanAmount(40000)
            //    .WithInterestRate(10.5)
            //    .Build();

            //IAccountBuilder builder = new LoanAccountBuilder();
            //AccountConfigurationBuilder configBuilder = new AccountConfigurationBuilder();
            //var loanAccount = configBuilder.BuildLoanAccount(builder);
            //Console.WriteLine($"The loan account detail - Account Number:{loanAccount.AccountNumber}"+
            //    $" Loan Amount:{loanAccount.LoanAmount}");

            //IAccountBuilder builder = new SavingAccountBuilder();
            //AccountConfigurationBuilder configBuilder = new AccountConfigurationBuilder();
            //var savingAccount = configBuilder.BuildSavingAccount(builder);
            //Console.WriteLine($"The saving account detail - Account Number:{savingAccount.AccountNumber}" +
            //    $" saving Amount:{savingAccount.Balance}");



            // 5.************** SINGLETON *************
            // mulithreaded environment
            //Parallel.Invoke(() =>
            //{
            //    CustomerOrder order_1 = new CustomerOrder();
            //    order_1.PlaceOrder(1);
            //},
            //() =>
            //{
            //    CustomerOrder order_2 = new CustomerOrder();
            //    order_2.PlaceOrder(2);
            //});


            //new Thread(() =>
            //{
            //    CustomerOrder order_1 = new CustomerOrder();
            //    order_1.PlaceOrder(1);
            //}).Start();
            //new Thread(() =>
            //{
            //    CustomerOrder order_2 = new CustomerOrder();
            //    order_2.PlaceOrder(2);
            //}).Start();
            //CustomerOrder order_1 = new CustomerOrder();
            //order_1.PlaceOrder(1);
            //CustomerOrder order_2 = new CustomerOrder();
            //order_2.PlaceOrder(2);

            //var container = new UnityContainer();
            //container.RegisterType<Logger>();
            //container.RegisterType<ILogger, Logger>(new ContainerControlledLifetimeManager());
            //CustomerOrder order_1 = container.Resolve<CustomerOrder>();
            //order_1.PlaceOrder(1);
            //CustomerOrder order_2 = container.Resolve<CustomerOrder>();
            //order_2.PlaceOrder(2);

            //6. ******************* PROTOTYPE *********************
            SoftwareAgreement agreement = new SoftwareAgreement("ABC Consultancy",
                new NonDisclosureAgreement
                {
                    Id = 123,
                    NDAgreementName = "Source Code"
                });
            agreement.Print("Initial agreement");

            var clonedAgreement = (SoftwareAgreement)agreement.DeepCopy();
            clonedAgreement.Print("Cloned agreement");
            clonedAgreement.NonDisclosureAgreement.Id = 5555;
            clonedAgreement.Print("Agreement with updated non disclosure id");


            agreement.Print("Initial agreement");
            Console.ReadKey();
        }
    }
}
