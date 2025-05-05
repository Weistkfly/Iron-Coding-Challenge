namespace Iron.Coding.Challenge.Test
{
    public class DeleteInputTests
    {
        [Fact]
        public void DeleteInputTests_Single_Delete()
        {
            string input = "6 666 66* 32999#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("MODAY", result);
        }

        [Fact]
        public void DeleteInputTests_Double_Delete()
        {
            string input = "6 666 66* 3*2999#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("MOAY", result);
        }
    }
}
