


using System.Collections.Generic;
using WinBairesCC.Estructura.Models;
using WinBairesCC.Estructura.StringMetrics;
using System.IO;

namespace WinBairesCC.Estructura.DataAccess
{
   public class LinkedinUserProfileParser : ILinkedinUserProfileDataAccess
    {
        private const char Separator = '|';
        private readonly string _filePath;
        private readonly IProfileRank _profileRank;

        private string CleanString(string s)
        {
            return s.Trim().ToLower();
        }


        public LinkedinUserProfileParser(string filePath, IProfileRank profileRank)
        {
            _filePath = filePath;
            _profileRank = profileRank;
        }

        public IEnumerable<LinkedinUserProfileModel> getAll()
        {
           return ParseFile(_filePath);
        }

        private IEnumerable<LinkedinUserProfileModel> ParseFile(string filePath)
        {
            List<LinkedinUserProfileModel> result = new List<LinkedinUserProfileModel>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    LinkedinUserProfileModel model = ParseLine(line, Separator);
                    int rank = _profileRank.Calculate(model);
                    ///<summary>
                    ///Registro relevantes para ser incluidos
                    ///</summary>
                    if (rank > 40)
                    {
                        model.Ranking = rank;
                        result.Add(model);
                    }

                    line = reader.ReadLine();
                }
            }

            return result;
        }

        private LinkedinUserProfileModel ParseLine(string line, char separator)
        {
            string[] tokens = line.Split(separator);

            return new LinkedinUserProfileModel(
                CleanString(tokens[0]),
                CleanString(tokens[1]),
                CleanString(tokens[2]),
                CleanString(tokens[3]),
                CleanString(tokens[4]),
                CleanString(tokens[5]),
                CleanString(tokens[6]),
                 CleanString(tokens[7])
            );
        }

       
    }
}
