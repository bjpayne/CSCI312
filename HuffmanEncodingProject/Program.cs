using System;
using System.Collections;
using System.IO;

namespace HuffmanEncodingProject
{
    public class Program
    {
        public static void Main(String[] args)
        {
            String fileName;

            do
            {
                Console.Clear();

                Console.Write("Please enter the file name: ");

                fileName = Console.ReadLine();
            } while (String.IsNullOrEmpty(fileName));

            Console.WriteLine("Reading input...");

            StreamReader inputReader = new StreamReader(fileName);

            String input = inputReader.ReadToEnd();

            inputReader.Close();

            Console.WriteLine("Building tree...");

            Tree tree = new Tree();

            tree.Build(input);

            Console.WriteLine("Encoding input...");

            BitArray encoded = tree.Encode(input);

            Console.WriteLine("Writing encoded output to encoded.txt");

            StreamWriter encodedWriter = new StreamWriter("encoded.txt");

            foreach (Boolean bit in encoded)
            {
                encodedWriter.Write(bit ? "1" : "0");
            }

            encodedWriter.Close();

            Console.WriteLine("Decoding encoded output...");

            String decoded = tree.Decode(encoded);

            Console.WriteLine("Writing decoded output to decoded.txt");

            StreamWriter decodedWriter = new StreamWriter("decoded.txt");

            decodedWriter.Write(decoded);

            decodedWriter.Close();

            Console.WriteLine("Validating results.");

            StreamReader decodedReader = new StreamReader("decoded.txt");

            Boolean validated = decodedReader.ReadToEnd().Equals(input);

            Console.WriteLine("Results validated: {0}", validated);

            Console.WriteLine("Done!");
        }
    }
}
