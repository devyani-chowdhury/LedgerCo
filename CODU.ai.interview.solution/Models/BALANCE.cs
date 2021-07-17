using System;

namespace CODU.ai.interview.solution.Models
{
    public class BALANCE
    {
        public BALANCE(string bANK_NAME, string bORROWER_NAME, int eMI_NO)
        {
            BANK_NAME = bANK_NAME ?? throw new ArgumentNullException(nameof(bANK_NAME));
            BORROWER_NAME = bORROWER_NAME ?? throw new ArgumentNullException(nameof(bORROWER_NAME));
            EMI_NO = eMI_NO;
        }

        public string BANK_NAME { get; set; }
        public string BORROWER_NAME { get; set; }
        public int EMI_NO { get; set; }
    }

}
