namespace Iron.Coding.Challenge.Test
{
    public class SimpleSentencesTests
    {
        [Fact]
        public void SimpleSentencesTests_Hello_World()
        {
            string input = "4433555 555666096667775553#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("HELLO WORLD", result);
        }

        [Fact]
        public void SimpleSentencesTests_Jesus_Cedeno()
        {
            string input = "5337777887777022233 3 3366 666#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("JESUS CEDENO", result);
        }

        [Fact]
        public void SimpleSentencesTests_I_Like_Programming()
        {
            string input = "4440555444553307 777666477726 6444664#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("I LIKE PROGRAMMING", result);
        }

        [Fact]
        public void SimpleSentencesTests_Today_Is_Monday()
        {
            string input = "8666329990444777706 666 66 32999#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("TODAY IS MONDAY", result);
        }
    }
}
