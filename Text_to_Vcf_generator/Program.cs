using System;
using System.IO;

namespace Text_to_Vcf_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputData = File.ReadLines("input.txt");
            using (StreamWriter writer = new StreamWriter("output.vcf")) {
                foreach (var person in inputData)
                {
                    int length = person.IndexOf(",");
                    var name = person.Substring(0, length);
                    var number = person.Substring(length + 1, 14);

                    Console.WriteLine("BEGIN:VCARD\nVERSION:4.0\nFN:" + name + "\nTEL; WORK; VOICE:" + number + "\nEND:VCARD");
                    writer.WriteLine("BEGIN:VCARD\nVERSION:4.0\nFN:" + name + "\nTEL; WORK; VOICE:" + number + "\nEND:VCARD");
                }
            }
            Console.WriteLine("\n\tAll done! see 'output.vcf'\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}