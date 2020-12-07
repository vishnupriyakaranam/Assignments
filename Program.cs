using System;
using System.IO;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Create a file using Create method
            string filePath = @"D:\Vishnupriya\DemoFile1.txt";
            string text = "Hello\nWelcome to C# tutorial\nLet's learn File Operations in C#\n";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            using (FileStream fs = File.Create(filePath))
            {
                byte[] info = new System.Text.UTF8Encoding(true).GetBytes(text);
                fs.Write(info);
                fs.Close();
            }

            //Create a file using WriteAllText method
            File.WriteAllText(@"D:\Vishnupriya\DemoFile2.txt", text);

            //Read file using ReadAllLines method
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            
            Console.WriteLine();

            //Read file using StreamReader
            if (File.Exists(filePath))
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string temp = "";
                    while ((temp = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(temp);
                    }
                }
            }

            //Append to a file using StreamWriter
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine("Appended Text");
                sw.Close();
            }

            //Read last line from the file
            if (File.Exists(filePath))
            {
                string[] fileLines = File.ReadAllLines(filePath);
                Console.WriteLine("\nLast line: " + fileLines[fileLines.Length - 1]);
            }

            //Count number of lines in a file
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine("Count of lines in the file : " + lines.Length);
            }

            //Uncomment the below code: 

            //Delete the file and read that file

            /*if (File.Exists(filePath))
            {
                File.Delete(filePath);
                //Reading deleted file
                try
                {
                    using (StreamReader sr = File.OpenText(filePath))
                    {
                        string temp = "";
                        while ((temp = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(temp);
                        }
                    }
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("\nException caught:\n" + e.GetType().ToString() + " : " + e.Message);
                }
            }*/

            Console.ReadKey();

        }
    }
}
