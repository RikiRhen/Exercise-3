namespace Exercise_3
{
    //F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
    //I Bird klassen vore ju rimligt, för att säkerställa att alla subklasser ärver det nya attributet.
    //F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
    //Med samma logik, då i Animal klassen för att säkerställa att alla subklasser får det nya attributet.
    //F: Försök lägga till en häst i listan av hundar. Varför fungerar det inte?
    //För att antingen har vi lagt in flera hundar i en lista och kompilatorn har satt ihop att det ska vara en lista av hund-objekt eller så har vi specificerat
    //att listan ska vara av just hund-objekt och då försöka lägga in en häst kommer inte att fungera.
    //F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans
    //Den typ som alla klasser ärver från, i detta fall Animal.
    //F: Kommer du åt den metoden från Animals listan?
    //Om jag castar om elementet till Dog. Animal har inte metoden och programmet kommer inte kunna hitta den klass-unika metoden så den måste castas om för att bli en Dog först.
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new(25, "Adam", "Bertilsson", 178.5, 78.2);
            //Console.WriteLine(person);
            //Kan jag komma åt variablerna direkt? Nej. De är privata. Det enda sättet för mig att komma åt dem nu är via deras getters och setters.

            
            List<Animal> animals = new()
            {
                new Dog("Vovvan", 6, 36),
                new Flamingo("Solo", 3, 15, 1),
                new Hedgehog("Sniffles", 1, 0.8),
                new Horse("P.P", 7, 220),
                new Pelican("Swala", 4, 8, true),
                new Swan("Her Majesty", 2, 6, true),
                new Wolf("Asterias", 6 , 53),
                new Worm("VDEM", 1, 0.01),
                new Wolfman("Johan", 31, 192, true)
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());
                if (animal is IPerson person)
                {
                    person.Talk();
                } else if (animal is Dog dog)
                {
                    Console.WriteLine(dog.WantsPats());
                }else 
                {
                    animal.DoSound();
                }
            }
            


            /*
            List<UserError> errorList = new()
            {
                new TextInputError(),
                new NumericInputError(),
                new DoubleInputError(),
                new CharInputError(),
                new EmptyInputError()
            };
            
            
            foreach (var error in errorList)
            {
                Console.WriteLine(error.GetMessage());
            }
            */
            /*
            PersonHandler ph = new PersonHandler();
            Person test = ph.CreatePerson(15, "Test", "One", 145.5, 41.3);
            Console.WriteLine(test);
            test.SetAge(0); //Should fail
            test.SetAge(1); //Should pass, "< 1" is inclusive in C#?
            test.SetAge(16); //Should pass
            test.SetFName("N"); //Should fail
            test.SetFName("NNNNNNNNNNN"); //Should fail
            test.SetFName("Blarg"); //Should pass
            test.SetLName("NN"); //Should fail
            test.SetLName("NNNNNNNNNNNNNNNN"); //Should fail
            test.SetLName("Hargh"); //Should pass
            Console.WriteLine(test);
            */
        }
    }
}
