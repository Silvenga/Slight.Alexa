using System;

namespace Slight.Alexa.Framework.Models.Requests.RequestTypes
{
    public class RequestBundle : IIntentRequest, ILaunchRequest, ISessionEndedRequest
    {
        /// <summary>
        /// Describes the request type with the value as:
        /// LaunchRequest, IntentRequest, or SessionEndedRequest
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Represents a unique identifier for the specific request.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Provides the date and time when Alexa sent the request. 
        /// Use this to verify that the request is current and not 
        /// part of a “replay” attack. Timestamp is provided as an 
        /// ISO 8601 formatted string (for example, 2015-05-13T12:34:56Z).
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// An object that represents what the user wants.
        /// </summary>
        public Intent Intent { get; set; }

        /// <summary>
        /// Describes why the session ended. Possible values:
        /// 
        /// - USER_INITIATED - The user explicitly ended the session.
        /// - ERROR - An error occurred that caused the session to end.
        /// - EXCEEDED_MAX_REPROMPTS - The user either did not respond or 
        ///   responded with an utterance that did not match any of the intents 
        ///   defined in your voice interface.
        /// </summary>
        public string Reason { get; set; }

        public Type GetRequestType()
        {
            switch (Type)
            {
                case "IntentRequest":
                    return typeof(IIntentRequest);
                case "LaunchRequest":
                    return typeof(ILaunchRequest);
                case "SessionEndedRequest":
                    return typeof(ISessionEndedRequest);
                default:
                    throw new ArgumentOutOfRangeException(nameof(Type), $"Unknown request type: {Type}.");
            }
        }
    }
}