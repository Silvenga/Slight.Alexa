namespace Slight.Alexa.Framework.Models.Requests
{
    public class Slot
    {
        /// <summary>
        /// A string that represents the name of the slot.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A string that represents the value of the slot. The value is not required.
        /// 
        /// Note that AMAZON.LITERAL slot values sent to your service are always in all lower case.
        /// </summary>
        public string Value { get; set; }
    }
}