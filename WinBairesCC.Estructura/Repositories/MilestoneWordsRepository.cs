using System;
using System.Collections.Generic;

namespace WinBairesCC.Estructura.Repositories
{
   public class MilestoneWordsRepository : IMilestoneWordsRepository
    {
        ///<summary>
        ///diccionario con las palabras hitos revelantes para el campo role
        ///</summary>
        public IDictionary<string, double> GetMilestoneWords()
        {
            return new Dictionary<string, double>
            {
                {"Technology",0.5d},
                {"Tecnologia",0.5d},
                {"information",0.2d},
                {"informacion",0.2d},
                {"analyst",0.2d},
                {"developer",0.4d},
                {"network",0.5d},
                {"engineering",0.1d},
                {"ingeniero",0.1d},
                {"Program",0.5d},
                {"Programa",0.5d},
                {"desarrollador",0.5d},
                {"systems",0.4d},
                {"sistemas",0.4d},
                {"scrum",0.4d},
                {"backend",0.4d},
                {"frontend",0.4d},
                {"master",0.1d},
                {"web",0.3d}

        };

       
        }


    }
}
