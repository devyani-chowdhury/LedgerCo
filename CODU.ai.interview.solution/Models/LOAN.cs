using geektrust_family_demo.Models.Interfaces;
using System;

namespace CODU.ai.interview.solution.Models
{
    public class LOAN : IModels
    {
        public string BANK_NAME { get; set; }
        public string BORROWER_NAME { get; set; }
        public Decimal PRINCIPAL { get; set; }
        public int NO_OF_YEARS { get; set; }
        public Decimal RATE_OF_INTEREST { get; set; }
    }
}
