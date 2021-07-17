using System;

namespace CODU.ai.interview.solution.Models
{
    public class PAYMENT
    {
        public PAYMENT(string bANK_NAME, string bORROWER_NAME, decimal lUMP_SUM_AMOUNT, int eMI_NO)
        {
            BANK_NAME = bANK_NAME ?? throw new ArgumentNullException(nameof(bANK_NAME));
            BORROWER_NAME = bORROWER_NAME ?? throw new ArgumentNullException(nameof(bORROWER_NAME));
            LUMP_SUM_AMOUNT = lUMP_SUM_AMOUNT;
            EMI_NO = eMI_NO;
        }

        public string BANK_NAME { get; set; }
        public string BORROWER_NAME { get; set; }
        public decimal LUMP_SUM_AMOUNT { get; set; }
        public int EMI_NO { get; set; }
    }
}
