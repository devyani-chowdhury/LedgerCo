using geektrust_family_demo.Models.Interfaces;
using geektrust_family_demo.ProcessedModels.Interfaces;
using System.Collections.Generic;

namespace geektrust_family_demo.Models.Processors.Interface
{
    public interface IModelProcessor<T, T1> where T : IProcessedModels where T1 : IModels
    {
        List<T> GetprocessedModel(List<T1> model);
    }
}
