using System.ComponentModel.DataAnnotations;

namespace Slight.Alexa.Framework.Models.Responses
{
    public class PlainTextOutputSpeech : IOutputSpeech
    {
        /// <summary>
        /// A string containing the type of output speech to render. Valid types are:
        /// - "PlainText" - Indicates that the output speech is defined as plain text.
        /// - "SSML" - Indicates that the output speech is text marked up with SSML.
        /// </summary>
        public string Type => "PlainText";

        /// <summary>
        /// A string containing the speech to render to the user. Use this when type is "PlainText"
        /// </summary>
        [Required]
        public string Text { get; set; }
    }
}