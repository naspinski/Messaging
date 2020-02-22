using System;
using System.Collections.Generic;
using System.Text;

namespace Naspinski.Messaging.Sms
{
    public interface ISmsSender
    {
        void Send(string from, string to, string message);
    }
}
