using System.Collections.Generic;
using WinBairesCC.Estructura.Models;

namespace WinBairesCC.Estructura.DataAccess
{
    public interface ILinkedinUserProfileDataAccess
    {
        IEnumerable<LinkedinUserProfileModel> getAll();
    }
}
