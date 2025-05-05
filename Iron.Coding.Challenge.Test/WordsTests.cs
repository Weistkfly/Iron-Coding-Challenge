namespace Iron.Coding.Challenge.Test
{
    public class WordsTests
    {
        [Fact]
        public void WordsTests_Hello()
        {
            string input = "4433555 555666#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("HELLO", result);
        }

        [Fact]
        public void WordsTests_World()
        {
            string input = "96667775553#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("WORLD", result);
        }

        [Fact]
        public void WordsTests_Monday()
        {
            string input = "6 666 66 32999#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("MONDAY", result);
        }

        [Fact]
        public void WordsTests_Quest()
        {
            string input = "77883377778#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("QUEST", result);
        }

        [Fact]
        public void WordsTests_Jesus()
        {
            string input = "5337777887777#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("JESUS", result);
        }
    }
}
