using WinBairesCC.Estructura.Models;

namespace WinBairesCC.Estructura.StringMetrics
{
    public interface IProfileRank
    {
        int Calculate(LinkedinUserProfileModel model);
    }
}