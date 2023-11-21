using Naspinski.Messaging.Sms;
using Naspinski.Messaging.Sms.Twilio;
using Xunit;

namespace Naspinski.Messaging.Tests.Sms.Twilio
{
    public class TwilioSmsSenderTests : TestBase
    {
        private readonly ISmsSender _smsSender;

        public TwilioSmsSenderTests() {
            var helper = new TwilioHelper(TwilioAuthToken, TwilioSid, TwilioPhone);
            if (helper.IsValid)
            {
                _smsSender = new TwilioSmsSender(helper);
            }
        }

        [Fact]
        public void SendSends()
        {
            if (_smsSender != null && !string.IsNullOrWhiteSpace(ToPhone))
            {
                _smsSender.Send(TwilioPhone, $"+1{ToPhone}", "test message");
            }
        }
    }
}
