using System.IO;

namespace WriteIntoATextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a .txt file with the content of string[] lines
            string[] lines = { "First line", "Second line", "Third line" };

            File.WriteAllLines(@"C:\Users\david.reina\Documents\Personal Devs\Ruta N Udemy - C#\20 - Write Into A Text File\Writeme.txt", lines);

            //Write in a text file the highest score of the next array
            int[] scores = { 10, 20, 100 };

            int highestScore = scores.Max(s => s);

            string[] highestScoreString = { highestScore.ToString() };

            File.WriteAllLines(@"C:\Users\david.reina\Documents\Personal Devs\Ruta N Udemy - C#\20 - Write Into A Text File\HighestScore.txt", highestScoreString);

            //Create a .txt file (method 2)
            Console.WriteLine("Please enter a name for the file:\n");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the content of the file:\n");
            string fileContent = Console.ReadLine();

            File.WriteAllText(@"C:\Users\david.reina\Documents\Personal Devs\Ruta N Udemy - C#\20 - Write Into A Text File\" + fileName + ".txt", fileContent);
        }
    }
}