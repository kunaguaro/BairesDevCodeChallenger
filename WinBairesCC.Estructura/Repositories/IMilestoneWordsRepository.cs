using System.Collections.Generic;

namespace WinBairesCC.Estructura.Repositories
{
    public interface IMilestoneWordsRepository
    {
        IDictionary<string, double> GetMilestoneWords();
    
    }
}
