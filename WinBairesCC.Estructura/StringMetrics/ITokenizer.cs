using System.Collections.Generic;

namespace WinBairesCC.Estructura.StringMetrics
{

    public interface ITokenizer
    {
        IDictionary<string, int> Tokenize(string s);
    }
}