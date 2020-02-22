using Naspinski.Messaging.Email;
using System.Threading.Tasks;
using Xunit;

namespace Naspinski.Messaging.Tests
{
    public class EmailTests
    {
        [Fact]
        public void BasicSend()
        {
            BasicSendAsync().Wait();
        }

        private async Task BasicSendAsync()
        { 
            await EmailSender.Send(Keys.SendgridApiKey, 
                "Naspinski.Messaging.Tests.EmailTests.BasicSend", 
                "test message", 
                Keys.ToEmail, 
                Keys.FromEmail);
            Assert.True(true);
        }
    }
}
