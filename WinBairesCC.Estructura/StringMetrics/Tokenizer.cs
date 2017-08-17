using System.Collections.Generic;

namespace WinBairesCC.Estructura.StringMetrics
{

    public class Tokenizer : ITokenizer
    {

        public IDictionary<string, int> Tokenize(string s)
        {
            Dictionary<string, int> tokens = new Dictionary<string, int>();
            string[] words = s.Split();

            for (int i = 0; i < words.Length; i++)
            {
                string key = CleanString(words[i]);

                if (tokens.ContainsKey(key))
                {
                    tokens[key] = tokens[key] + 1;
                }
                else
                {
                    tokens[key] = 1;
                }
            }

            return tokens;
        }

        private string CleanString(string s)
        {
            return s.Trim(',', '.', '!', '?', '(', ')', ';');
        }
    }
}
