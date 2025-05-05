namespace Iron.Coding.Challenge.Test
{
    public class PhonePadKeysTests
    {
        [Fact]
        public void PhonePadKeys_AND_Char()
        {
            string input = "1#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("&", result);
        }

        [Fact]
        public void PhonePadKeys_Apostrophe_Char()
        {
            string input = "11#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("'", result);
        }

        [Fact]
        public void PhonePadKeys_Bracket_Char()
        {
            string input = "111#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("(", result);
        }

        [Fact]
        public void PhonePadKeys_A_Char()
        {
            string input = "2#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("A", result);
        }

        [Fact]
        public void PhonePadKeys_B_Char()
        {
            string input = "22#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("B", result);
        }

        [Fact]
        public void PhonePadKeys_C_Char()
        {
            string input = "222#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("C", result);
        }

        [Fact]
        public void PhonePadKeys_D_Char()
        {
            string input = "3#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("D", result);
        }

        [Fact]
        public void PhonePadKeys_E_Char()
        {
            string input = "33#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("E", result);
        }

        [Fact]
        public void PhonePadKeys_F_Char()
        {
            string input = "333#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("F", result);
        }

        [Fact]
        public void PhonePadKeys_G_Char()
        {
            string input = "4#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("G", result);
        }

        [Fact]
        public void PhonePadKeys_H_Char()
        {
            string input = "44#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("H", result);
        }

        [Fact]
        public void PhonePadKeys_I_Char()
        {
            string input = "444#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("I", result);
        }

        [Fact]
        public void PhonePadKeys_J_Char()
        {
            string input = "5#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("J", result);
        }

        [Fact]
        public void PhonePadKeys_K_Char()
        {
            string input = "55#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("K", result);
        }

        [Fact]
        public void PhonePadKeys_L_Char()
        {
            string input = "555#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("L", result);
        }
        
        [Fact]
        public void PhonePadKeys_M_Char()
        {
            string input = "6#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("M", result);
        }
        
        [Fact]
        public void PhonePadKeys_N_Char()
        {
            string input = "66#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("N", result);
        }
        
        [Fact]
        public void PhonePadKeys_O_Char()
        {
            string input = "666#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("O", result);
        }

        [Fact]
        public void PhonePadKeys_P_Char()
        {
            string input = "7#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("P", result);
        }

        [Fact]
        public void PhonePadKeys_Q_Char()
        {
            string input = "77#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("Q", result);
        }

        [Fact]
        public void PhonePadKeys_R_Char()
        {
            string input = "777#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("R", result);
        }

        [Fact]
        public void PhonePadKeys_S_Char()
        {
            string input = "7777#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("S", result);
        }

        [Fact]
        public void PhonePadKeys_T_Char()
        {
            string input = "8#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("T", result);
        }

        [Fact]
        public void PhonePadKeys_U_Char()
        {
            string input = "88#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("U", result);
        }

        [Fact]
        public void PhonePadKeys_V_Char()
        {
            string input = "888#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("V", result);
        }

        [Fact]
        public void PhonePadKeys_W_Char()
        {
            string input = "9#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("W", result);
        }

        [Fact]
        public void PhonePadKeys_X_Char()
        {
            string input = "99#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("X", result);
        }

        [Fact]
        public void PhonePadKeys_Y_Char()
        {
            string input = "999#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("Y", result);
        }

        [Fact]
        public void PhonePadKeys_Z_Char()
        {
            string input = "9999#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal("Z", result);
        }

        [Fact]
        public void PhonePadKeys_0_Char()
        {
            string input = "0#";
            string result = OldPhone.OldPhonePad(input);

            Assert.Equal(" ", result);
        }
    }
}