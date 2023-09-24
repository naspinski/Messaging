using Microsoft.Extensions.Configuration;

namespace Naspinski.Messaging.Tests
{
    public class TestBase
    {
        protected readonly string SendgridApiKey;
        protected readonly string FromEmail;
        protected readonly string ToEmail;

        public TestBase()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<TestBase>()
                .Build();
            SendgridApiKey = config["SENDGRID_API_KEY"];
            FromEmail = config["FROM_EMAIL"];
            ToEmail = config["TO_EMAIL"];
        }
    }
}
