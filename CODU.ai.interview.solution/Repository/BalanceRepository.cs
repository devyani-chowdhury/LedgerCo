using geektrust_family_demo.ProcessedModel;
using geektrust_family_demo.Repository.Interface;
using System;
using System.Collections.Generic;

namespace geektrust_family_demo.Repository
{
    public class BalanceRepository : IModelRepository<ProcessedBalance>
    {
        public List<ProcessedBalance> BalanceRecords = new List<ProcessedBalance>();
        public void AddModel(ProcessedBalance model)
        {
            throw new NotImplementedException();
        }

        public void DeleteModel(ProcessedBalance model)
        {
            throw new NotImplementedException();
        }

        public List<ProcessedBalance> GetAllModels()
        {
            throw new NotImplementedException();
        }

        public ProcessedBalance GetModel(string BANK_NAME, string BORROWER_NAME)
        {
            throw new NotImplementedException();
        }

        public ProcessedBalance UpdateModel(ProcessedBalance model)
        {
            throw new NotImplementedException();
        }
    }
}
