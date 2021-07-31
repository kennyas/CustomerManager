using System.Text.Json;
using CustomerManager.Application.Interfaces.Serialization.Options;

namespace CustomerManager.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}