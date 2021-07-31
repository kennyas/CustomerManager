using CustomerManager.Shared.Settings;
using System.Threading.Tasks;
using CustomerManager.Shared.Wrapper;

namespace CustomerManager.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}