namespace Slight.Alexa.Framework.Models.Requests
{
    public class User
    {
        /// <summary>
        /// A string that represents the unique identifier for the user who made the request.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// A token identifying the user in another system. 
        /// This is only provided if the user has successfully linked their account.
        /// </summary>
        public string AccessToken { get; set; }
    }
}