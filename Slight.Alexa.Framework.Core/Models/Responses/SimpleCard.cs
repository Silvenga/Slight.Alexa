namespace Slight.Alexa.Framework.Models.Responses
{
    public class SimpleCard : ICard
    {
        /// <summary>
        /// A string describing the type of card to render. Valid types are:
        /// - "Simple" - A card that contains a title and plain text content.
        /// - "LinkAccount" - a card that displays a link to an authorization URL 
        ///   that the user can use to link their Alexa account with a user in 
        ///   another system. 
        /// </summary>
        public string Type
        {
            get { return "Simple"; }
        }

        /// <summary>
        /// A string containing the title of the card. 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A string containing the contents of the card.
        /// 
        /// Note that you can include line breaks in the content for a card of type "Simple". 
        /// Use either “\r\n” or “\n” within the text of the card to insert line breaks.
        /// </summary>
        public string Content { get; set; }
    }
}