namespace Slight.Alexa.Framework.Models.Requests
{
    using System.Collections.Generic;

    public class Intent
    {
        /// <summary>
        /// A string that represents the name of the slot.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A string that represents the value of the slot. The value is not required.
        /// Note that AMAZON.LITERAL slot values sent to your service are always in all lower case.
        /// </summary>
        public Dictionary<string, Slot> Slots { get; set; }
    }
}