using System.Linq;
using CustomerManager.Shared.Constants.Localization;
using CustomerManager.Shared.Settings;

namespace CustomerManager.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}