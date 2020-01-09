using System;
using System.Collections.Generic;
using System.IO;

namespace CharacterCounter
{
  internal class Program
  {
    public static void Main(String[] args)
    {
      StreamReader reader = new StreamReader("wap.txt");

      String contents = reader.ReadToEnd();

      Int32 len = contents.Length;
      
      CharacterFrequency[] characterFrequencies = new CharacterFrequency[len];
      
      reader.Close();

      Int32 i = 0;

      for (; i < len; i++)
      {
        CharacterFrequency characterFrequency = new CharacterFrequency {Character = contents[i]};

        characterFrequencies[i] = characterFrequency;
        
        Console.WriteLine(contents[i]);
      }
    }
  }
}