﻿using Naspinski.Data.Helpers;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Naspinski.Messaging.Sms.Twilio
{
    public class TwilioSmsSender : ISmsSender
    {
        private readonly string _twilioSid;
        private readonly string _twilioAuthToken;

        public TwilioSmsSender(string twilioSid, string twilioAuthToken)
        {
            _twilioSid = twilioSid;
            _twilioAuthToken = twilioAuthToken;
        }
        public TwilioSmsSender(TwilioHelper helper)
        {
            _twilioSid = helper.Sid;
            _twilioAuthToken = helper.AuthToken;
        }

        public void Send(string from, string to, string message)
        {
            TwilioClient.Init(_twilioSid, _twilioAuthToken);
            MessageResource.Create(
                from: new PhoneNumber($"+1{RegexHelper.DigitsOnly(from)}"),
                to: new PhoneNumber($"+1{RegexHelper.DigitsOnly(to)}"),
                body: message
            );
        }
    }
}
