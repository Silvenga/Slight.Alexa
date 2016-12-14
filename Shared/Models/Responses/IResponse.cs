using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Responses
{
    public interface IResponse
    {
        [JsonRequired]
        string Type { get; }
    }
}
