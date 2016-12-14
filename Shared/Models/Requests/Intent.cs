using Newtonsoft.Json;
using System.Collections.Generic;

namespace Slight.Alexa.Framework.Models.Requests
{
    public class Intent
    {
        /// <summary>
        /// A string representing the name of the intent.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A map of key-value pairs that further describes what
        /// the user meant based on a predefined intent schema.
        /// </summary>
        [JsonProperty("slots")]
        public Dictionary<string, Slot> Slots { get; set; }
    }
}