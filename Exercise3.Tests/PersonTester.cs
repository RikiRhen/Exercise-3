using Exercise_3;

namespace Exercise3.Tests
{
    public class PersonTester
    {
        [Fact]
        public void Person_VerifyConstructorWorksProperly()
        {
            Person person = new(15, "A", "B", 120, 45.2);
            string result = person.ToString();
            string expected = "Age: 15, Name: B, A, Height: 120, Weight: 45,2";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Person_VerifyFNameGetter()
        {
            Person person = new(15, "A", "B", 120, 45.2);
            string result = person.GetFName();
            string expected = "A";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Person_VerifyFNameSetter()
        {
            //Verifying that new first name has to be atleast 2 letters.
            Person person = new(15, "A", "B", 120, 45.2);
            person.SetFName("C");
            string result = person.GetFName();
            string expected = "A";
            Assert.Equal(expected, result);

            person.SetFName("CC");
            result = person.GetFName();
            expected = "CC";
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void Person_VerifyLNameGetter()
        {
            Person person = new(15, "A", "B", 120, 45.2);
            string result = person.GetLName();
            string expected = "B";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Person_VerifyLNameSetter()
        {
            //Verifying that new last name has to be atleast 5 letters.
            Person person = new(15, "A", "B", 120, 45.2);
            person.SetLName("DDDD");
            string result = person.GetLName();
            string expected = "B";
            Assert.Equal(expected, result);

            person.SetLName("DDDDD");
            result = person.GetLName();
            expected = "DDDDD";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Person_VerifyAgeGetter()
        {
            Person person = new(15, "A", "B", 120, 45.2);
            int result = person.GetAge();
            int expected = 15;
            Assert.Equal(expected, result);
        }

        
        [Fact]
        public void Person_VerifyAgeSetter()
        {
            //Verifying that new age has to be atleast 1.
            Person person = new(15, "A", "B", 120, 45.2);
            person.SetAge(0);
            int result = person.GetAge();
            int expected = 15;
            Assert.Equal(expected, result);

            person.SetAge(16);
            result = person.GetAge();
            expected = 16;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Person_VerifyHeightGetter()
        {
            Person person = new(15, "A", "B", 120, 45.2);
            double result = person.GetHeight();
            double expected = 120;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Person_VerifyHeightSetter()
        {
            //Height does not have a verification implemented.
            Person person = new(15, "A", "B", 120, 45.2);
            person.SetHeight(0);
            double result = person.GetHeight();
            double expected = 0;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Person_VerifyWeightGetter()
        {
            Person person = new(15, "A", "B", 120, 45.2);
            double result = person.GetWeight();
            double expected = 45.2;
            Assert.Equal(expected, result);
        }

        [Fact]

        //Weight does not have a verification implemented.
        public void Person_VerifyWeightSetter()
        {
            Person person = new(15, "A", "B", 120, 45.2);
            person.SetWeight(0);
            double result = person.GetWeight();
            double expected = 0;
            Assert.Equal(expected, result);
        }
        
    }
}
