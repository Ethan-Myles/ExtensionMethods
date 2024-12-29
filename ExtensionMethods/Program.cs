using ExtensionMethods;

class Program
{
    static void Main()
    {
        //First Extension method
        var i = 101;
        var isLessThan = i.IsLessThan(100);

        //Console.WriteLine(isLessThan);

        //Second extension method
        var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        var chunks = numbers.ChunkBy(3);

        /*
        foreach (var chunk in chunks)
        {
            Console.WriteLine(string.Join(", ", chunk));
        }
        */

        //Third extension method

        //var animals = new List<string> { "fish", "CAT", "dOg", "ELEphant", "Koala" };
        //var animals = new HashSet<string> { "fish", "CAT", "dOg", "ELEphant", "Koala" };

        string[] animals = { "fish", "CAT", "dOg", "ELEphant", "Koala" };

        var capitalisedAnimals = animals.Capitalise();

        foreach (var animal in capitalisedAnimals)
        {
            Console.WriteLine(animal);
        }

    }


}