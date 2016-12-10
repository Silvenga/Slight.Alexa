namespace Slight.Alexa.Framework.Models.Requests.RequestTypes
{
    public interface ISessionEndedRequest : IRequest
    {
        /// <summary>
        /// Describes why the session ended. Possible values:
        /// 
        /// - USER_INITIATED - The user explicitly ended the session.
        /// - ERROR - An error occurred that caused the session to end.
        /// - EXCEEDED_MAX_REPROMPTS - The user either did not respond or 
        ///   responded with an utterance that did not match any of the intents 
        ///   defined in your voice interface.
        /// </summary>
        string Reason { get; set; }
    }
}