
using System;
using System.Collections.Generic;
namespace WinBairesCC.Estructura.Repositories
{
    public class IndustryWordsRepository : IIndustryWordsRepository
    {
        ///<summary>
        ///diccionario con las palabras hitos revelantes para el campo industria
        ///</summary>
        public IDictionary<string, double> GetIndustryWords()
        {
            return new Dictionary<string, double>
            {
                {"Information Technology and Services",0.5d},
                {"Internet",0.5d},
                {"Services",0.2d},
                {"network",0.5d},
                {"Computer & Network Security",0.4d},
                {"Electronics",0.4d},
                {"Computer",0.5d},
                {"Consultores",0.2d},
                {"computer software",0.5d},
                {"systems",0.4d},
                {"Management Consulting",0.5d},
                {"Software",0.4d},
                {"Telecommunications",0.4d},
                {"Media Production",0.2d},
                {"International Trade and Development",0.2d},
                {"web",0.3d}

        };
        }
    }
}
