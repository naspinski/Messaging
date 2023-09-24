using Naspinski.Messaging.Email;
using System.Threading.Tasks;
using Xunit;

namespace Naspinski.Messaging.Tests
{
    public class EmailTests : TestBase
    {
        public EmailTests() : base() { }

        [Fact]
        public async Task BasicSend()
        {
            await EmailSender.Send(SendgridApiKey, 
                "Naspinski.Messaging.Tests.EmailTests.BasicSend", 
                "test message", 
                ToEmail, 
                FromEmail);
            Assert.True(true);
        }
    }
}
