
using CustomerManager.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace CustomerManager.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}