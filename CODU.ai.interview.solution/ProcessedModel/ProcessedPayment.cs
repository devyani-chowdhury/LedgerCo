using geektrust_family_demo.ProcessedModels.Interfaces;

namespace geektrust_family_demo.ProcessedModel
{
    public class ProcessedPayment : IProcessedModels
    {
        public string BANK_NAME { get; set; }
        public string BORROWER_NAME { get; set; }

        public decimal LUMP_SUM_AMOUNT { get; set; }
        public int EMI_NO { get; set; }
    }
}
