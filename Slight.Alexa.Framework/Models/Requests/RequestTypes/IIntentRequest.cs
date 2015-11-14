namespace Slight.Alexa.Framework.Models.Requests.RequestTypes
{
    using System;

    public interface IIntentRequest : IRequest
    {
        /// <summary>
        /// An object that represents what the user wants.
        /// </summary>
        Intent Intent { get; set; }
    }
}