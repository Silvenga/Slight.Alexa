namespace Slight.Alexa.Framework.Tests.ModelTests
{
    using System.IO;

    using Newtonsoft.Json;

    using Slight.Alexa.Framework.Models.Requests;
    using Slight.Alexa.Framework.Models.Requests.RequestTypes;

    using Xunit;

    public class RequestTests
    {
        private const string ExamplesPath = @"ModelTests\Examples\";

        [Fact]
        public void Can_read_IntentRequest_example()
        {
            const string example = "IntentRequest.json";
            var json = File.ReadAllText(Path.Combine(ExamplesPath, example));
            var convertedObj = JsonConvert.DeserializeObject<SkillRequest>(json);

            Assert.NotNull(convertedObj);
            Assert.Equal(typeof(IIntentRequest), convertedObj.Request.GetRequestType());
            Assert.Equal(typeof(IIntentRequest), convertedObj.GetRequestType());
        }

        [Fact]
        public void Can_read_LaunchRequest_example()
        {
            const string example = "LaunchRequest.json";
            var json = File.ReadAllText(Path.Combine(ExamplesPath, example));
            var convertedObj = JsonConvert.DeserializeObject<SkillRequest>(json);

            Assert.NotNull(convertedObj);
            Assert.Equal(typeof(ILaunchRequest), convertedObj.Request.GetRequestType());
            Assert.Equal(typeof(ILaunchRequest), convertedObj.GetRequestType());
        }

        [Fact]
        public void Can_read_SessionEndedRequest_example()
        {
            const string example = "SessionEndedRequest.json";
            var json = File.ReadAllText(Path.Combine(ExamplesPath, example));
            var convertedObj = JsonConvert.DeserializeObject<SkillRequest>(json);

            Assert.NotNull(convertedObj);
            Assert.Equal(typeof(ISessionEndedRequest), convertedObj.Request.GetRequestType());
            Assert.Equal(typeof(ISessionEndedRequest), convertedObj.GetRequestType());
        }

        [Fact]
        public void Can_accept_new_versions()
        {
            const string example = "SessionEndedRequest.json";
            var json = File.ReadAllText(Path.Combine(ExamplesPath, example));
            var convertedObj = JsonConvert.DeserializeObject<SkillRequest>(json);

            Assert.NotNull(convertedObj);
            Assert.Equal(typeof(ISessionEndedRequest), convertedObj.Request.GetRequestType());
            Assert.Equal(typeof(ISessionEndedRequest), convertedObj.GetRequestType());
        }
    }
}
