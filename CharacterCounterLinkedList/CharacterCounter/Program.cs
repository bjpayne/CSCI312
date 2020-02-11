using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace CharacterCounter
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            try
            {
                String inputFile = "";

                String outputFile = "";

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

                LinkedList<CharacterFrequency> characterFrequencies = new LinkedList<CharacterFrequency>();

                characterFrequencies = ResolveCharacterCounts(reader, characterFrequencies);

                reader.Close();

                SetOutput(characterFrequencies, outputFile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static LinkedList<CharacterFrequency> ResolveCharacterCounts(
            StreamReader reader,
            LinkedList<CharacterFrequency> characterFrequencies
        )
        {
            // Keep characterFrequency classes in a hash table so retrieval is O(1)
            Hashtable characterFrequencyState = new Hashtable();
            
            Int32 value = reader.Read();
            
            while (value != -1)
            {
                Char character = (Char) value;
                
                if (! characterFrequencyState.Contains(character))
                {
                    CharacterFrequency characterFrequency = new CharacterFrequency()
                    {
                         Character = (Char) value,
                         Frequency = 1
                    };
                    
                    characterFrequencyState.Add(character, characterFrequency);
                    
                    characterFrequencies.AddLast(characterFrequency);
                }
                else
                {
                    CharacterFrequency characterFrequency = (CharacterFrequency) characterFrequencyState[character];
                    
                    characterFrequency.Increment();
                }

                value = reader.Read();
            }

            // Return all the characters
            return characterFrequencies;
        }

        private static void SetOutput(LinkedList<CharacterFrequency> characterFrequencies, String outputFile)
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