using System;
using Xunit;
using LibraryOne;

namespace LibraryOne.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void First_Has_Hello()
        {
            var messages = new Messages();
            var firstMessage = messages.FirstMessage();
            Assert.Contains("Hello", firstMessage);
        }

        [Fact]
        public void First_Has_World()
        {
            var messages = new Messages();
            var firstMessage = messages.FirstMessage();

            Assert.Contains("world", firstMessage);
        }
    }
}
