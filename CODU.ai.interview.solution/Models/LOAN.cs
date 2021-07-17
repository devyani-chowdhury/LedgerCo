using geektrust_family_demo.Models.Interfaces;
using System;

namespace CODU.ai.interview.solution.Models
{
    public class LOAN : IModels
    {
        //TODO: Remove this
        //public LOAN(string bANK_NAME, string bORROWER_NAME, decimal pRINCIPAL, decimal nO_OF_YEARS, decimal rATE_OF_INTEREST)
        //{
        //    BANK_NAME = bANK_NAME ?? throw new ArgumentNullException(nameof(bANK_NAME));
        //    BORROWER_NAME = bORROWER_NAME ?? throw new ArgumentNullException(nameof(bORROWER_NAME));

        //    PRINCIPAL = pRINCIPAL;
        //    NO_OF_YEARS = nO_OF_YEARS;

        //    NO_OF_EMIS = (Int32)(Math.Ceiling(NO_OF_YEARS * 12));
        //    RATE_OF_INTEREST = rATE_OF_INTEREST;
        //    Interest = (this.PRINCIPAL * NO_OF_YEARS * this.RATE_OF_INTEREST) / 100;
        //    Amount = this.Interest + this.PRINCIPAL;
        //    var tempEMI = Amount / NO_OF_EMIS;
        //    EMI_AMOUNT = (Int32)(Math.Ceiling(tempEMI));
        //}

        public string BANK_NAME { get; set; }
        public string BORROWER_NAME { get; set; }
        public Decimal PRINCIPAL { get; set; }
        public int NO_OF_YEARS { get; set; }
        public Decimal RATE_OF_INTEREST { get; set; }
    }
}
