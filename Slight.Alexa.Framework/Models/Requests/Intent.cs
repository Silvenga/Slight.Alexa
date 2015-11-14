namespace Slight.Alexa.Framework.Models.Requests
{
    using System.Collections.Generic;

    public class Intent
    {
        /// <summary>
        /// A string representing the name of the intent.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A map of key-value pairs that further describes what
        /// the user meant based on a predefined intent schema.
        /// </summary>
        public Dictionary<string, Slot> Slots { get; set; }
    }
}