using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Alma 7:27  ");
        Console.WriteLine("And now, may the peace of God rest upon you, and upon your houses and lands, and upon your flocks and herds, and all that you possess, your women and your children, according to your faith and good works, from this time forth and forever. And thus I have spoken. Amen.");
        string word = "And now, may the peace of God rest upon you, and upon your houses and lands, and upon your flocks and herds, and all that you possess, your women and your children, according to your faith and good works, from this time forth and forever. And thus I have spoken. Amen.";

        // List<string> Word_Randomizer = new List<string> { "And, now, may, the, peace, of, God, rest, upon, you, and, upon, your, houses, and, lands, and upon your flocks and herds and all that you possess your women and your children according to your faith and good works from this time forth and forever And thus I have spoken Amen" };


        char[] delimiter = new char[] { ' ' };

        string[] output = word.Split(delimiter);

        Random rand = new Random();



        Console.WriteLine("Please press any key to continue of type 'quit' to end:  ");
        string response = Console.ReadLine();


        while (response != "quit")
        {
            Console.WriteLine("Please press any key to continue of type 'quit' to end:  ");
            int index = rand.Next(output.Length);

            output[Array.IndexOf(output, output[index])] = "___";

            string separator = " ";

            string result = String.Join(separator, output);
            if (response == "y")
            {


                Console.WriteLine(result);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Bye");
                response = "quit";

            }



        }

    }
}