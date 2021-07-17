using geektrust_family_demo.ProcessedModels.Interfaces;

namespace geektrust_family_demo.ProcessedModel
{
    public class ProcessedBalance : IProcessedModels
    {
        public string BANK_NAME { get; set; }
        public string BORROWER_NAME { get; set; }

        public int EMI_NO { get; set; }
        public decimal AMOUNT_PAID { get; set; }
        public int NO_OF_EMIS_LEFT { get; set; }

    }
}
