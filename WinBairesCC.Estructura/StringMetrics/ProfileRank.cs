using WinBairesCC.Estructura.Repositories;

using WinBairesCC.Estructura.Models;


namespace WinBairesCC.Estructura.StringMetrics
{
    public class ProfileRank : IProfileRank
    {
        private readonly IMilestoneWordsRepository _milestoneRepository;
        private readonly IIndustryWordsRepository _industryRepository;
        private readonly ITokenizer _tokenizer;
        
        public ProfileRank(IMilestoneWordsRepository milestoneRepository, IIndustryWordsRepository industryRepository, ITokenizer tokenizer)
        {
            _industryRepository = industryRepository;
            _milestoneRepository = milestoneRepository;
            _tokenizer = tokenizer;
        }

        /// <summary>
        /// Calculates the user's probability 
        /// </summary>
        public int Calculate(LinkedinUserProfileModel model)
        {
            double result = 0;
            result += GetKeywordFactor(model);
            result += GetIndustryFactor(model);
            result *= 100;

            if (result > 100)
            {
                result = 100;
            }

            return (int) result;
        }

        
        /// <summary>
        /// calcule the milestoneword 
        /// </summary>
        private double GetKeywordFactor(LinkedinUserProfileModel model)
        {
            var keywords = _milestoneRepository.GetMilestoneWords();
            var roleTokens = _tokenizer.Tokenize(model.CurrentRole);
            var titleTokens = _tokenizer.Tokenize(model.Country);
            double result = 0.0d;

            foreach (var role in roleTokens)
            {
                if (keywords.ContainsKey(role.Key))
                {
                    result += keywords[role.Key];
                }
            }

            foreach (var title in roleTokens)
            {
                if (keywords.ContainsKey(title.Key))
                {
                    result += keywords[title.Key];
                }
            }

            return result;
        }

        /// <summary>
        /// Calcule the industrywords
        /// </summary>
        private double GetIndustryFactor(LinkedinUserProfileModel model)
        {
            var areas = _industryRepository.GetIndustryWords();
            double result = 0.0d;

            if (areas.ContainsKey(model.Industry))
            {
                result += areas[model.Industry];
            }

            return result;
        }
    }
}
