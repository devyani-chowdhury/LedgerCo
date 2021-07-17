using geektrust_family_demo.ProcessedModel;
using geektrust_family_demo.Repository.Interface;
using System;
using System.Collections.Generic;

namespace geektrust_family_demo.Repository
{
    public class LoanRepository : IModelRepository<ProcessedLoan>
    {
        public List<ProcessedLoan> loansRecords = new List<ProcessedLoan>();

        public void AddModel(ProcessedLoan model)
        {
            throw new NotImplementedException();
        }

        public void DeleteModel(ProcessedLoan model)
        {
            throw new NotImplementedException();
        }

        public List<ProcessedLoan> GetAllModels()
        {
            throw new NotImplementedException();
        }

        public ProcessedLoan GetModel(string BANK_NAME, string BORROWER_NAME)
        {
            throw new NotImplementedException();
        }

        public ProcessedLoan UpdateModel(ProcessedLoan model)
        {
            throw new NotImplementedException();
        }
    }
}
