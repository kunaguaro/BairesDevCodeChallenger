using System;
namespace WinBairesCC.Estructura.Models
{
    ///<summary>
    ///Modelo para el perfil de usuario en Linkedin
    ///Linkedin user profile model
    ///</summary>

    public class LinkedinUserProfileModel
    {
        public int Ranking { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CurrentRole { get; set; }
        public string Country { get; set; }
        public string Industry { get; set; }
        public uint NumberOfRecommendations { get; set; }
        public uint NumberOfConnections { get; set; }

        ///<summary>
        ///Inicializar las propiedades
        ///Initialize properties
        ///</summary>
        public LinkedinUserProfileModel(string personid, string name, string lastname,
           string currentrole, string country, string industry, string numberofrecommendations,
            string numberofconnetions)
        {
            PersonId = Convert.ToInt32(personid) ;
            Name = name;
            LastName = lastname;
            CurrentRole = currentrole;
            Country = country;
            Industry = industry;
            NumberOfRecommendations = StringToUint(numberofrecommendations);
            NumberOfConnections = StringToUint(numberofconnetions);

        }

        private uint StringToUint(string n)
        {

            uint.TryParse(n, out uint result);

            return result;
        }
    }
}
