using System;
using System.Collections;
using System.IO;

namespace CharacterCounter
{
    internal class Program
    {
        private const Int32 NumberOfAsciiCharacters = 255;

        public static void Main(String[] args)
        {
            try
            {
                String inputFile;

                String outputFile;

                if (args.Length == 2)
                {
                    inputFile = args[0];

                    outputFile = args[1];
                }
                else
                {
                    Console.Write("Please provide an input file name: ");

                    inputFile = Console.ReadLine();

                    Console.Write("Please provide an output file name: ");

                    outputFile = Console.ReadLine();
                }

                StreamReader reader = new StreamReader(inputFile);

                String contents = reader.ReadToEnd();

                reader.Close();

                ArrayList characterFrequencies = new ArrayList();

                characterFrequencies = ResolveCharacterCounts(contents, characterFrequencies);

                SetOutput(characterFrequencies, outputFile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static ArrayList ResolveCharacterCounts(String haystack, ArrayList characterFrequencies)
        {
            Int32 index = 0;

            while (haystack.Length > 0)
            {
                // The first character in the haystack is the next character to count
                Char needle = haystack[0];

                // Remove the needle from the haystack
                String newHaystack = haystack.Replace(needle.ToString(), "");

                // Set the character to the needle
                CharacterFrequency character = new CharacterFrequency()
                {
                    Character = needle,
                    Frequency = haystack.Length - newHaystack.Length // Difference is the number of removed characters
                };

                // Push the new character class onto the array
                characterFrequencies.Add(character);

                // Update the haystack with the removed character haystack
                haystack = newHaystack;

                index++;
            }

            // Return all the characters
            return characterFrequencies;
        }

        private static void SetOutput(ArrayList characterFrequencies, String outputFile)
        {
            StreamWriter writer = new StreamWriter(outputFile);

            foreach (CharacterFrequency character in characterFrequencies)
            {
                writer.WriteLine($"{character.Character}({(Int32) character.Character})\t\t{character.Frequency}");
            }

            writer.Close();
        }
    }
}