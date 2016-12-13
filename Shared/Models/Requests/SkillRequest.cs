using Newtonsoft.Json;
using Slight.Alexa.Framework.Models.Requests.RequestTypes;
using System;

namespace Slight.Alexa.Framework.Models.Requests
{
    public class SkillRequest
    {
        /// <summary>
        /// The version specifier for the request with the value defined as: "1.0"
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// The session object provides additional context associated with the request.
        /// </summary>
        [JsonProperty("session")]
        public Session Session { get; set; }

        /// <summary>
        /// An object that is composed of associated parameters that further describes the user’s request. 
        /// </summary>
        [JsonProperty("request")]
        public RequestBundle Request { get; set; }

        /// <summary>
        /// Get's the compatible CLR type that can back the request.
        /// </summary>
        /// <returns></returns>
        public Type GetRequestType()
        {
            if (Request == null)
            {
                throw new InvalidOperationException("Request is null.");
            }

            return Request.GetRequestType();
        }
    }
}