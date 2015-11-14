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
            var convertedObj = JsonConvert.DeserializeObject<SkillRequest<IntentRequest>>(json);

            Assert.NotNull(convertedObj);
        }

        [Fact]
        public void Can_read_LaunchRequest_example()
        {
            const string example = "LaunchRequest.json";
            var json = File.ReadAllText(Path.Combine(ExamplesPath, example));
            var convertedObj = JsonConvert.DeserializeObject<SkillRequest<LaunchRequest>>(json);

            Assert.NotNull(convertedObj);
        }

        [Fact]
        public void Can_read_SessionEndedRequest_example()
        {
            const string example = "SessionEndedRequest.json";
            var json = File.ReadAllText(Path.Combine(ExamplesPath, example));
            var convertedObj = JsonConvert.DeserializeObject<SkillRequest<SessionEndedRequest>>(json);

            Assert.NotNull(convertedObj);
        }

        [Fact]
        public void Can_accept_new_versions()
        {
            const string example = "SessionEndedRequest.json";
            var json = File.ReadAllText(Path.Combine(ExamplesPath, example));
            var convertedObj = JsonConvert.DeserializeObject<SkillRequest<SessionEndedRequest>>(json);

            Assert.NotNull(convertedObj);
        }
    }
}
