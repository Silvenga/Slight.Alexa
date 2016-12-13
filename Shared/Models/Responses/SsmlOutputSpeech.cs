using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Responses
{
    class SsmlOutputSpeech : IOutputSpeech
    {
        /// <summary>
        /// A string containing the type of output speech to render. Valid types are:
        /// - "PlainText" - Indicates that the output speech is defined as plain text.
        /// - "SSML" - Indicates that the output speech is text marked up with SSML.
        /// </summary>
        [JsonRequired]
        [JsonProperty("type")]
        public string Type
        {
            get { return "SSML"; }
        }

        /// <summary>
        /// A string containing text marked up with SSML to render to the user. Use this when type is "SSML"
        /// </summary>
        [JsonRequired]
        [JsonProperty("ssml")]
        public string Ssml { get; set; }
    }
}