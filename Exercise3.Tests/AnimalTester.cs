using Exercise_3;

namespace Exercise3.Tests
{
    public class AnimalTester
    {
        [Fact]
        public void BirdClass_MakesCorrectSound()
        {
            Bird bird = new("Birb", 5, 15);
            string result = bird.DoSound();
            string expected = "Chirp!";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FlamingoClass_StatsAreReturnedProperly()
        {
            Flamingo flamingo = new("Birb", 5, 15, 1);
            string result = flamingo.Stats();
            string expected = "Birb, Age: 5, 15kg, stands on 1 leg(s).";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FlamingoClass_MakesCorrectSound()
        {
            Flamingo flamingo = new("Birb", 5, 15, 1);
            string result = flamingo.DoSound();
            string expected = "Chirp!";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void PelicanClass_MakesCorrectSound()
        {
            Pelican pelican = new("Birb", 5, 15, true);
            string result = pelican.DoSound();
            string expected = "Chirp!";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void PelicanClass_StatsAreReturnedProperly()
        {
            Pelican pelican = new("Birb", 5, 15, true);
            string result = pelican.Stats();
            string expected = "Birb, Age: 5, 15kg, it is True that this bird has a gular pouch.";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SwanClass_MakesCorrectSound()
        {
            Swan swan = new("Birb", 5, 15, true);
            string result = swan.DoSound();
            string expected = "Honk!";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SwanClass_StatsAreReturnedProperly()
        {
            Swan swan = new("Birb", 5, 15, true);
            string result = swan.Stats();
            string expected = "Birb, Age: 5, 15kg, it is True that cygnets are adorable.";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void DogClass_MakesCorrectSound()
        {
            Dog dog = new("Doggo", 5, 15);
            string result = dog.DoSound();
            string expected = "Bork!";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void DogClass_StatsAreReturnedProperly()
        {
            Dog dog = new("Doggo", 5, 15);
            string result = dog.Stats();
            string expected = "Doggo, Age: 5, 15kg.";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void HedgehogClass_MakesCorrectSound()
        {
            Hedgehog hedgehog = new("Sanic", 3, 13);
            string result = hedgehog.DoSound();
            string expected = "Snuffles...";
            
            Assert.Equal(expected, result);
        }

        [Fact]
        public void HedgehogClass_StatsAreReturnedProperly()
        {
            Hedgehog hedgehog = new("Sanic", 3, 13);
            string result = hedgehog.Stats();
            string expected = "Sanic, Age: 3, 13kg.";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void HorseClass_MakesCorrectSound()
        {
            Horse horse = new("P.P", 5, 155);
            string result = horse.DoSound();
            string expected = "Neigh!";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void HorseClass_StatsAreReturnedProperly()
        {
            Horse horse = new("P.P", 5, 155);
            string result = horse.Stats();
            string expected = "P.P, Age: 5, 155kg.";
            
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WormClass_MakesCorrectSound()
        {
            Worm worm = new("W", 1, 0.01);
            string result = worm.DoSound();
            string expected = "...";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void WormClass_StatsAreReturnedProperly()
        {
            Worm worm = new("W", 1, 0.01);
            string result = worm.Stats();
            string expected = "W, Age: 1, 0,01kg.";

            Assert.Equal(expected, result);
        }


        [Fact]
        public void WolfClass_MakesCorrectSound()
        {
            Wolf wolf = new("Grey", 10, 45);
            string result = wolf.DoSound();
            string expected = "Awoo!";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void WolfClass_StatsAreReturnedProperly()
        {

            Wolf wolf = new("Grey", 10, 45);

            string result = wolf.Stats();
            string expected = "Grey, Age: 10, 45kg.";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void WolfmanClass_MakesCorrectSound()
        {
            Wolfman wolfman = new("James", 33, 195, true);
            string result = wolfman.Talk();
            string expected = "AwooOoOOo I say!";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void WolfmanClass_StatsAreReturnedProperly()
        {
            Wolfman wolfman = new("James", 33, 195, true);
            string result = wolfman.Stats();
            string expected = "James, Age: 33, 195kg, it is True that this beast walks on two legs.";

            Assert.Equal(expected, result);
        }
    }
}