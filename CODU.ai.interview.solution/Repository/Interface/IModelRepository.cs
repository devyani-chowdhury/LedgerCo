using geektrust_family_demo.ProcessedModels.Interfaces;
using System.Collections.Generic;

namespace geektrust_family_demo.Repository.Interface
{
    public interface IModelRepository<T> where T : IProcessedModels
    {
        public void AddModel(T model);
        public List<T> GetAllModels();
        public T UpdateModel(T model);
        public void DeleteModel(T model);
        public T GetModel(string BANK_NAME, string BORROWER_NAME);

    }
}
