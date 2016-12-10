namespace Slight.Alexa.Framework.Models.Types
{
    public class BuiltInIntent
    {
        /// <summary>
        /// Purpose: 
        /// - Let the user cancel a transaction or task (but remain in the skill)
        /// - Let the user completely exit the skill
        /// 
        /// Common Utterances: cancel, never mind, forget it
        /// </summary>
        public const string Cancel = "AMAZON.CancelIntent";

        /// <summary>
        /// Purpose: 
        /// Provide help about how to use the skill.
        /// 
        /// Common Utterances: help, help me, can you help me
        /// </summary>
        public const string Help = "AMAZON.HelpIntent";

        /// <summary>
        /// Purpose: 
        /// - Let the user stop an action (but remain in the skill)
        /// - Let the user completely exit the skill
        /// 
        /// Common Utterances: stop, off, shut up
        /// </summary>
        public const string Stop = "AMAZON.StopIntent";
    }
}