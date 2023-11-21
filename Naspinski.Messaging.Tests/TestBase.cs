using Microsoft.Extensions.Configuration;

namespace Naspinski.Messaging.Tests
{
    public class TestBase
    {
        protected readonly string SendgridApiKey;
        protected readonly string FromEmail;
        protected readonly string ToEmail;
        protected readonly string TwilioSid;
        protected readonly string TwilioAuthToken;
        protected readonly string TwilioPhone;
        protected readonly string ToPhone;

        public TestBase()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<TestBase>()
                .Build();
            SendgridApiKey = config["SENDGRID_API_KEY"];
            FromEmail = config["FROM_EMAIL"];
            ToEmail = config["TO_EMAIL"];
            
            TwilioSid = config["TWILIO_SID"];
            TwilioAuthToken = config["TWILIO_AUTH_TOKEN"]; 
            TwilioPhone = config["TWILIO_PHONE"];

            ToPhone = config["TO_PHONE"];
        }
    }
}
