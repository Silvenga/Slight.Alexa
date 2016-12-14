using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Requests
{
    public class Application
    {
        /// <summary>
        /// The target's Application ID.
        /// This is used to verify that the request was intended for your service.
        /// </summary>
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }
    }
}