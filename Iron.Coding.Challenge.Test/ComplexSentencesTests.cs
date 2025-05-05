namespace Iron.Coding.Challenge.Test
{
    public class ComplexSentencesTests
    {
        [Fact]
        public void ComplexSentencesTests_I_Wanted_A_Burrito_For_Breakfast_But_Got_Two_Tacos_Instead_Because_Thats_What_Was_Available()
        {
            string input = "44409266833 30202288777 777 444866603336667770227773325533327777802288 80466680 89666082 222 666777704446677778332302233222 28877773308442811777709442809277770288824445552 2255533#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("I WANTED A BURRITO FOR BREAKFAST BUT GOT TWO TACOS INSTEAD BECAUSE THAT'S WHAT WAS AVAILABLE", result);
        }
    }
}
