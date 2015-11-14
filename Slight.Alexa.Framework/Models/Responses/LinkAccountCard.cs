namespace Slight.Alexa.Framework.Models.Responses
{
    public class LinkAccountCard : ICard
    {
        /// <summary>
        /// A string describing the type of card to render. Valid types are:
        /// - "Simple" - A card that contains a title and plain text content.
        /// - "LinkAccount" - a card that displays a link to an authorization URL 
        ///   that the user can use to link their Alexa account with a user in 
        ///   another system. 
        /// </summary>
        public string Type { get { return "LinkAccount"; } }
    }
}