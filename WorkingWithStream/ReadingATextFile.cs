using System;
using System.IO;

namespace WorkingWithStream
{
    class ReadingATextFile
    {
        static void Main(string[] args)
        {

            //Change the path to the text file

            StreamReader reader = new StreamReader(@"C:\Users\JESULAYO\Documents\EEG 324\eeg324.txt");

            string firstLine = reader.ReadLine();
            string allLines = reader.ReadToEnd();

            Console.WriteLine(allLines);

            reader.Close();
        }
    }
}
