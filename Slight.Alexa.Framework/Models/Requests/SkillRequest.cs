namespace Slight.Alexa.Framework.Models.Requests
{
    using Slight.Alexa.Framework.Models.Requests.RequestTypes;

    public class SkillRequest<T> where T : IRequest
    {
        /// <summary>
        /// The version specifier for the request with the value defined as: "1.0"
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// The session object provides additional context associated with the request.
        /// </summary>
        public Session Session { get; set; }

        /// <summary>
        /// An object that is composed of associated parameters that further describes the user’s request. 
        /// </summary>
        public T Request { get; set; }
    }
}
