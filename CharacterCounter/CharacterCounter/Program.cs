using System;
using System.IO;

namespace CharacterCounter
{
    internal class Program
    {
        private const String BasePath = "../../";

        private const Int32 numberOfAsciiCharacters = 255;

        public static void Main(String[] args)
        {
            StreamReader reader = new StreamReader(BasePath + "wap.txt");

            String contents = reader.ReadToEnd();

            reader.Close();

            CharacterFrequency[] characterFrequencies = new CharacterFrequency[numberOfAsciiCharacters];

            Int32 index = 0;

            characterFrequencies = GetCharacterFrequencies(contents, characterFrequencies, index);

            SetOutput(characterFrequencies);
        }

        private static CharacterFrequency[] GetCharacterFrequencies(String contents, CharacterFrequency[] characterFrequencies, Int32 index)
        {
            Int32 len = contents.Length;

            String needle = contents[0].ToString();

            String newContents = contents.Replace(needle, "");

            CharacterFrequency character = new CharacterFrequency()
            {
                Character = contents[0],
                Frequency = contents.Length - newContents.Length
            };

            characterFrequencies[index] = character;

            index++;

            if (newContents.Length != 0)
            {
                GetCharacterFrequencies(newContents, characterFrequencies, index);
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
                    $"{characterFrequency.Character}({(Int32)characterFrequency.Character})\t\t{characterFrequency.Frequency}");
            }

            writer.Close();
        }
    }
}