using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Responses
{
    public class Response
    {
        /// <summary>
        /// The object containing the speech to render to the user
        /// </summary>
        [JsonProperty("outputSpeech", NullValueHandling = NullValueHandling.Ignore)]
        public IOutputSpeech OutputSpeech { get; set; }

        /// <summary>
        /// The object containing a card to render to the Amazon Alexa App. 
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public ICard Card { get; set; }

        /// <summary>
        /// The object containing the outputSpeech to use if a re-prompt is necessary.
        /// 
        /// This is used if the your service keeps the session open after 
        /// sending the response, but the user does not respond with anything 
        /// that maps to an intent defined in your voice interface while the audio 
        /// stream is open.
        /// 
        /// If this is not set, the user is not re-prompted.
        /// </summary>
        [JsonProperty("reprompt", NullValueHandling = NullValueHandling.Ignore)]
        public Reprompt Reprompt { get; set; }

        /// <summary>
        /// A boolean value with true meaning that the session should end, 
        /// or false if the session should remain active.
        /// </summary>
        [JsonProperty("shouldEndSession", NullValueHandling = NullValueHandling.Ignore)]
        public bool ShouldEndSession { get; set; }
    }
}