using System.Collections.Generic;

using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Requests
{
    public class Session
    {
        /// <summary>
        /// A boolean value indicating whether this is a new session. 
        /// </summary>
        /// <returns>True for a new session or false for an existing session.</returns>
        [JsonProperty("new")]
        public bool New { get; set; }

        /// <summary>
        /// A string that represents a unique identifier per a user’s active session.
        /// Note: A sessionId is consistent for multiple subsequent requests 
        /// for a user and session. If the session ends for a user, then a new 
        /// unique sessionId value is provided for subsequent requests for the same user.
        /// </summary>
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// A map of key-value pairs. 
        /// The attributes map is empty for requests 
        /// where a new session has started with the attribute new set to true.
        /// </summary>
        /// <returns>
        /// The key is a string that represents the name of the attribute.
        /// The value is an object that represents the value of the attribute.
        /// </returns>
        [JsonProperty("attributes")]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// An object containing an application ID. 
        /// </summary>
        [JsonProperty("application")]
        public Application Application { get; set; }

        /// <summary>
        /// An object that describes the user making the request.
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }
    }
}