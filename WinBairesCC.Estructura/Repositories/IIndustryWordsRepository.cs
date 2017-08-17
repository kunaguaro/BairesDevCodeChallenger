using System.Collections.Generic;

namespace WinBairesCC.Estructura.Repositories
{
    public interface IIndustryWordsRepository
    {
        IDictionary<string, double> GetIndustryWords();
    }
}
