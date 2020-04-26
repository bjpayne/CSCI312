using System;
using System.Collections;
using System.IO;
using System.Text;

namespace HuffmanEncodingProject
{
    public class Program
    {
        public static void Main(String[] args)
        {
            String fileName;

            StreamReader inputReader = null;

            do
            {
                try
                {
                    Console.Write("Please enter the file name: ");

                    fileName = Console.ReadLine();

                    inputReader = new StreamReader(fileName);
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);

                    fileName = null;
                }
                catch (Exception)
                {
                    fileName = null;
                }
            } while (String.IsNullOrEmpty(fileName));

            Console.WriteLine("Reading input...");

            String input = inputReader.ReadToEnd();

            inputReader.Close();

            DateTime buildingTreeStartTime = DateTime.Now;

            Console.WriteLine("Building tree...");

            Tree tree = new Tree();

            tree.Hydrate(input);
            
            Console.WriteLine("Building tree done. Time elapsed {0}s", DateTime.Now.Subtract(buildingTreeStartTime).TotalSeconds);

            DateTime encodingInputStartTime = DateTime.Now;

            Console.WriteLine("Encoding input...");

            BitArray encoded = tree.Encode(input);
            
            Console.WriteLine("Encoding input done. Time elapsed {0}s", DateTime.Now.Subtract(encodingInputStartTime).TotalSeconds);

            Console.WriteLine("Writing encoded output to encoded.txt");

            StreamWriter encodedWriter = new StreamWriter("encoded.txt");
            
            StringBuilder encodedBuilder = new StringBuilder();

            for (Int32 i = 0; i < encoded.Count; i++)
            {
                encodedBuilder.Append(encoded[i]);
            }
            
            encodedWriter.WriteLine(encodedBuilder);

            encodedWriter.Close();

            DateTime decodingEncodedOutputStartTime = DateTime.Now;
            
            Console.WriteLine("Decoding encoded output...");

            String decoded = tree.Decode(encoded);
            
            Console.WriteLine("Decoding encoded output done. Time elapsed {0}s", DateTime.Now.Subtract(decodingEncodedOutputStartTime).TotalSeconds);

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