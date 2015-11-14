namespace Slight.Alexa.Framework.Models.Requests.RequestTypes
{
    using System;

    public class IntentRequest : IRequest
    {
        /// <summary>
        /// An object that represents what the user wants.
        /// </summary>
        Intent Intent { get; set; }

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
    }
}