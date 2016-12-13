using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slight.Alexa.Framework.Models.Responses
{
    public class SkillResponse
    {
        /// <summary>
        /// The version specifier for the response with the value to be defined as: "1.0"
        /// </summary>
        [JsonRequired]
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// A map of key-value pairs to persist in the session.
        /// </summary>
        /// <returns>
        /// The key is a string that represents the name of the attribute.
        /// The value is an object that represents the value of the attribute.
        /// </returns>
        [JsonProperty("sessionAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> SessionAttributes { get; set; }

        /// <summary>
        /// A response object that defines what to render to the user and whether to end the current session.
        /// </summary>
        [JsonRequired]
        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public Response Response { get; set; }
    }
}