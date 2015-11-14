namespace Slight.Alexa.Framework.Models.Responses
{
    using System.ComponentModel.DataAnnotations;

    public interface IOutputSpeech
    {
        /// <summary>
        /// A string containing the type of output speech to render. Valid types are:
        /// - "PlainText" - Indicates that the output speech is defined as plain text.
        /// - "SSML" - Indicates that the output speech is text marked up with SSML.
        /// </summary>
        [Required]
        string Type { get; }
    }
}