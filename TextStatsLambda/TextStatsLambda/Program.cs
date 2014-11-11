using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            TextStats("May the force be with you");
            Console.ReadKey();

        }

        static void TextStats(string input)
        {
            List<string> words = input.Split(' ').ToList();
            Console.WriteLine("Original Input: " + input);
            Console.WriteLine("Amount of Words: " + words.Count());
            Console.WriteLine("Amount of characters: " + input.Length);
            Console.WriteLine(("Amount of vowels: ") + input.Count(x => "aeiou".Contains(x.ToString().ToLower())));
            Console.WriteLine(("Amount of Consonants: ") + input.Count(x => !"aeiou ".Contains(x.ToString().ToLower())));
            Console.WriteLine(("Amount of Special Characters: ") + input.Count(x => " !.?".Contains(x.ToString().ToLower())));
            Console.WriteLine(("Longest Word: ") + string.Join(", ", words.OrderByDescending(x => x.Length).First()));
            Console.WriteLine(("Shortest Word: ") + string.Join(", ", words.OrderBy(x => x.Length).First()));
            
           
        }
    }
}
