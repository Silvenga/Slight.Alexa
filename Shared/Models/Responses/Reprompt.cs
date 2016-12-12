namespace Slight.Alexa.Framework.Models.Responses
{
    public class Reprompt
    {
        /// <summary>
        /// An OutputSpeech object containing the text or SSML to render as a re-prompt.
        /// </summary>
        public IOutputSpeech OutputSpeech { get; set; }
    }
}