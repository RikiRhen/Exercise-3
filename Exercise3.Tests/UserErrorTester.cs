using Exercise_3;
using Exercise3;

namespace Exercise3.Tests
{
    public class UserErrorTester
    {
        [Fact]
        public void CharInputError_ThrowsExpectedException()
        {
            CharInputError test = new CharInputError();
            string result = test.GetMessage();
            string expected = "You tried to use multiple letters in a single-character only field. This fired an error!";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void DoubleInputError_ThrowsExpectedException()
        {
            DoubleInputError test = new DoubleInputError();
            string result = test.GetMessage();
            string expected = "You tried to use a text input in a double only field. This fired an error!";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void EmptyInputError_ThrowsExpectedException()
        {
            EmptyInputError test = new EmptyInputError();
            string result = test.GetMessage();
            string expected = "You tried to leave an obligatory field empty. This fired an error!";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void NumericInputError_ThrowsExpectedException()
        {
            NumericInputError test = new NumericInputError();
            string result = test.GetMessage();
            string expected = "You tried to use a numeric input in a text only field. This fired an error!";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TextInputError_ThrwsExpectedException()
        {
            TextInputError test = new TextInputError();
            string result = test.GetMessage();
            string expected = "You tried to use a text input in a numeric only field. This fired an error!";

            Assert.Equal(expected, result);
        }
    }
}
