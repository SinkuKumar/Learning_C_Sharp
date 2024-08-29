using System;
using System.IO;

namespace BeginnerProjects.TextFileAnalyzer
{
    class TextFileAnalyzer
    {
        static void Main(string[] args)
        {
            int charCount = 0;
            int wordCount = 0;
            int sentenceCount = 0;
            int paragraphCount = 1;
            Console.WriteLine("Welcome to text file analyzer.\n");
            Console.Write("Enter the path of the file: ");
            string filePath = Console.ReadLine();
            List<string> fileContent = new List<string>(File.ReadAllLines(filePath));
            sentenceCount = fileContent.Count;

            foreach (string line in fileContent)
            {
                charCount += line.Length;
                if (line.Length == 0)
                {
                    wordCount--;
                    paragraphCount++;
                }
                wordCount += line.Split(' ').Length;
            }

            Console.WriteLine("\nFile analysis:");
            Console.WriteLine($"Character(s): {charCount}");
            Console.WriteLine($"Word(s): {wordCount}");
            Console.WriteLine($"Sentence(s): {sentenceCount}");
            Console.WriteLine($"Paragraph(s): {paragraphCount}");
            Console.WriteLine("\nThank you for using file analyzer.");
        }
    }
}