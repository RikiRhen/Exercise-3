namespace Exercise_3
{
    //F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
    //I Bird klassen vore ju rimligt, för att säkerställa att alla subklasser ärver det nya attributet.
    //F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
    //Med samma logik, då i Animal klassen för att säkerställa att alla subklasser får det nya attributet.
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new(25, "Adam", "Bertilsson", 178.5, 78.2);
            //Console.WriteLine(person);
            //Kan jag komma åt variablerna direkt? Nej. De är privata. Det enda sättet för mig att komma åt dem nu är via deras getters och setters.

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
