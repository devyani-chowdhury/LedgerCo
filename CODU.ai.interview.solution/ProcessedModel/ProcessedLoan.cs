using geektrust_family_demo.ProcessedModels.Interfaces;
using System.Collections.Generic;

namespace geektrust_family_demo.ProcessedModel
{
    public class ProcessedLoan : IProcessedModels
    {
        public string BANK_NAME { get; set; }
        public string BORROWER_NAME { get; set; }
        public decimal PRINCIPAL { get; set; }
        public int NO_OF_YEARS { get; set; }
        public decimal RATE_OF_INTEREST { get; set; }
        public decimal Amount { get; set; }
        public decimal EMI_AMOUNT { get; set; }
        public int NO_OF_EMIS { get; set; }

        public List<ProcessedPayment> Payments = new List<ProcessedPayment>();
        //     = nO_OF_YEARS;

        //    NO_OF_EMIS = (Int32)(Math.Ceiling(NO_OF_YEARS * 12));
        //    RATE_OF_INTEREST = rATE_OF_INTEREST;
        //    Interest = (this.PRINCIPAL * NO_OF_YEARS * this.RATE_OF_INTEREST) / 100;
        //    Amount = this.Interest + this.PRINCIPAL;
        //    var tempEMI = Amount / NO_OF_EMIS;
        //    EMI_AMOUNT = (Int32)(Math.Ceiling(tempEMI));
    }
}
