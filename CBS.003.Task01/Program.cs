using System;
using System.Diagnostics;
using System.IO;

namespace CBS._003.Task01
{
    class Program
    {
        const string FILENAME = @"tmp.txt";
        const int COUNT_OF_LINES = 3;
        private static readonly string NEW_LINE = Environment.NewLine;

        static void Main(string[] args)
        {
            try
            {
                using (var fs = new FileStream(FILENAME, FileMode.OpenOrCreate))
                {
                    using (var underlineWriter = new StreamWriters.UnderlineStreamWriter(fs))
                    {
                        using (var uppercaseWriter = new StreamWriters.UpperCaseStreamWriter(underlineWriter))
                        {
                            var addLine = string.Concat("New Program Test");
                            Console.WriteLine($"Lines [{addLine}] are adding to {FILENAME}...");
                            for (int i = 0; i < COUNT_OF_LINES; i++)
                            {
                                var testLine = string.Concat(addLine, i);
                                uppercaseWriter.WriteLine(testLine);                                                        
                                Console.WriteLine($"Line [{testLine}] has been added");

                            }
                            Console.WriteLine($"{NEW_LINE}Reading {FILENAME}...");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ERROR: {ex.Message}");
            }

            if (File.Exists(FILENAME))
            {
                try
                {
                    using (var fs = new FileStream(FILENAME, FileMode.Open))
                    {
                        using (var reader = new StreamReader(fs, true))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                Console.WriteLine($"[{line}]");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"ERROR: {ex.Message}");
                }                
            }
            Console.ReadKey();
        }
    }
}
