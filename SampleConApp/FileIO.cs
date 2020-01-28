using System;
using System.IO;
//Files are of 2 types:Text based and Binary Files. Binary files are like images, media files where U read the streams of data stored in binary format and use Streams to access them. Anything that comes into the file is called as InputStream and anything that comes off the file is called OutputStream. Stream is more like contigenous memory or a pipe where data is transported from a certain source to a certain destination. 
//All classes related to File IO is available under System.IO. 
//There is a static class called File on which U could call various functions to perform common operations of a give file. 
namespace SampleConApp
{
    class FileExample
    {
        const string path = @"B:\Programs\NichiIn-2020\Nichi-InTraining\SampleConApp\FileIO.cs";
        static void Main(string[] args)
        {
            //checkForFile();
            //readExistingFile();
            //readLineByLine();
            //creatingFile();
            writingToFile();
        }

        private static void writingToFile()
        {
            string filename = "Example.txt";
            string content = MyConsole.GetString("Enter some content to write.\nPS: Pressing ENTER is considered as submit");
            //File.WriteAllText(filename, content);
            File.AppendAllText(filename, content);
        }

        private static void creatingFile()
        {
            var filename = MyConsole.GetString("Enter the file name to create");
            if (File.Exists(filename))
            {
                var res = MyConsole.GetString("File already exists, Do U want to replace it?\nPress Y to replace or N to cancel");
                if (res.ToLower() != "y")
                    return;
            }
            var stream = File.Create(filename);
            Console.WriteLine("File is created");
            stream.Close();
        }

        private static void readLineByLine()
        {
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                if(line.Contains("Console"))
                    Console.WriteLine(line.ToUpper());
            }
        }

        private static void readExistingFile()
        {
            var contents = File.ReadAllText(path);
            Console.WriteLine(contents);
        }

        private static void checkForFile()
        {
            if (File.Exists("Example.txt"))
                Console.WriteLine("File is there");
            else
                Console.WriteLine("File does not exist");
        }
    }
}
