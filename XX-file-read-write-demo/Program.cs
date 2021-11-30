using System;
using System.IO;

namespace XX_file_read_write_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"d:\temp\demotext.txt";
            ///* najednou */            
            //string text = System.IO.File.ReadAllText(filename);
            //Console.WriteLine(text);

            /* po řádcích */
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }



        }
    }
}
