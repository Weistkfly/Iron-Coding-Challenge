namespace Iron.Coding.Challenge.Test
{
    public class InvalidInputTests
    {
        [Fact]
        public void InvalidInputTests_Letter_Input_Type()
        {
            string input = "A#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("Input string contains unexpected values: A", result);
        }

        [Fact]
        public void InvalidInputTests_Hidden_Letter_Input_Type()
        {
            string input = "6 666 6A6 32999#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("Input string contains unexpected values: A", result);
        }

        [Fact]
        public void InvalidInputTests_Mutilple_Send_Input()
        {
            string input = "6 666# 66 32999#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("Input contains more than one send (#)", result);
        }

        [Fact]
        public void InvalidInputTests_Same_Pad_Violation()
        {
            string input = "666666 32999#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("Input string contains unexpected values: 666666", result);
        }
    }
}
