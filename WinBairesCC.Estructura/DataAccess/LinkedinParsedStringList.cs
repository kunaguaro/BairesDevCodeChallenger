using System;
using System.Collections.Generic;
using WinBairesCC.Estructura.Models;
using System.Linq;

namespace WinBairesCC.Estructura.DataAccess
{
    ///<summary>
    ///para convertir del modelo a una cadena de texto
    ///</summary>
    public class LinkedinParsedStringList
    {
        private const char Separator = '|';
        private const int topclients = 100;
        public List<string> ListToString( List<LinkedinUserProfileModel> ListLinkedinUserProfile)
        {
            List<string> listStringLinkedinUser = new List<string>();
            string line = "";
            int pos = 0;
            foreach (LinkedinUserProfileModel s in ListLinkedinUserProfile.Take(topclients))
            {
                pos = pos+1;
                line =pos.ToString()+Separator+ s.Ranking.ToString() + Separator + s.PersonId + Separator + s.Name + Separator +
                    s.LastName + Separator + s.CurrentRole + Separator + s.Country + Separator + s.Industry + Separator
                    + s.NumberOfRecommendations + Separator + s.NumberOfConnections;
                listStringLinkedinUser.Add(line);
            }

            return listStringLinkedinUser;
            
        }

    }
}
