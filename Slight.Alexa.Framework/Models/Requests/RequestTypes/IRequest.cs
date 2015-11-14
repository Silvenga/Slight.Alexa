namespace Slight.Alexa.Framework.Models.Requests.RequestTypes
{
    using System;

    public interface IRequest
    {
        /// <summary>
        /// Describes the request type with the value as:
        /// LaunchRequest, IntentRequest, or SessionEndedRequest
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// Represents a unique identifier for the specific request.
        /// </summary>
        string RequestId { get; set; }

        /// <summary>
        /// Provides the date and time when Alexa sent the request. 
        /// Use this to verify that the request is current and not 
        /// part of a “replay” attack. Timestamp is provided as an 
        /// ISO 8601 formatted string (for example, 2015-05-13T12:34:56Z).
        /// </summary>
        DateTime Timestamp { get; set; }
    }
}