    using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Prototype.RemoteServer
{
    public class NonDisclosureAgreement
    {
        public int Id { get; set; }
        public string NDAgreementName { get; set; }
    }
    public class SoftwareAgreement:IAgreement
    {
        private string _vendorName;
        private AgreementDto _agreementDto;
        public NonDisclosureAgreement NonDisclosureAgreement;
        public SoftwareAgreement(string vendorName, NonDisclosureAgreement nonDisclosureAgreement)
        {
            _vendorName = vendorName;
            NonDisclosureAgreement = nonDisclosureAgreement;

            Console.WriteLine("Fetching agreement clause from the remote server...");
            Thread.Sleep(4000);
            Console.Clear();
            AgreementClause clause = new AgreementClause();
            _agreementDto = clause.GetAgreementClause();
        }
        public void Print(string message)
        {
            Console.WriteLine("\n"+message);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n--------Agreement Prototype---------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nVendor Name:          {_vendorName}");
            Console.WriteLine($"\nNDA ID:               {NonDisclosureAgreement.Id}");
            Console.WriteLine($"\nDeveloper Clause:     {_agreementDto.DeveloperClause}");
            Console.WriteLine($"Post Delivery Clause:   {_agreementDto.PostDeliveryClause}");
            Console.WriteLine($"Termination Clause:     {_agreementDto.ProjectTerminationClause}");
        }

        public IAgreement ShallowCopy()
        {
            return (IAgreement)this.MemberwiseClone();
        }

        public IAgreement DeepCopy()
        {
            var agreementCopy = (SoftwareAgreement)this.MemberwiseClone();
            agreementCopy.NonDisclosureAgreement = new NonDisclosureAgreement
            {
                Id = this.NonDisclosureAgreement.Id,
                NDAgreementName = this.NonDisclosureAgreement.NDAgreementName
            };
            return agreementCopy;
        }
    }
}
