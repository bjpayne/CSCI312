using System;
using System.IO;

namespace CharacterCounter
{
    internal class Program
    {
        private const String BasePath = "/Users/benjaminpayne/Apps/CSCI312/Programs/CharacterCounter/CharacterCounter/";

        public static void Main(String[] args)
        {
            StreamReader reader = new StreamReader(BasePath + "wap.txt");

            String contents = reader.ReadToEnd();

            reader.Close();

            CharacterFrequency[] characterFrequencies = GetCharacterFrequencies(contents);

            SetOutput(characterFrequencies);
        }

        private static CharacterFrequency[] GetCharacterFrequencies(String contents)
        {
            Int32 len = contents.Length;

            CharacterFrequency[] characterFrequencies = new CharacterFrequency[256];

            Int32 i = 0;

            for (; i < len; i++)
            {
                Int32 j = 0;

                for (; j < 256; j++)
                {
                    if (characterFrequencies[j] != null && characterFrequencies[j].Character.Equals(contents[i]))
                    {
                        characterFrequencies[j].Increment();

                        break;
                    }

                    if (characterFrequencies[j] == null)
                    {
                        CharacterFrequency characterFrequency = new CharacterFrequency
                            {Character = contents[i], Frequency = 1};

                        characterFrequencies[j] = characterFrequency;

                        break;
                    }
                }
            }

            return characterFrequencies;
        }

        private static void SetOutput(CharacterFrequency[] characterFrequencies)
        {
            StreamWriter writer = new StreamWriter(BasePath + "output.txt");

            Int32 characterFrequenciesLength = characterFrequencies.Length;

            Int32 i = 0;

            for (; i < characterFrequenciesLength; i++)
            {
                if (characterFrequencies[i] == null)
                {
                    break;
                }
                
                CharacterFrequency characterFrequency = characterFrequencies[i];

                writer.WriteLine(
                    $"{characterFrequency.Character}({(Int32) characterFrequency.Character})\t\t{characterFrequency.Frequency}");
            }
        }
    }
}