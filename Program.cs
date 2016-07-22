using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);

            var fileName = Path.Combine(directory.FullName, "SoccerGameResults.csv");
            var fileContent = ReadFile(fileName);
            Console.WriteLine(fileContent);
            Console.ReadLine();


        }
        
        public static string ReadFile(string filename)
        {

            using (var reader = new StreamReader(filename))
            {
                return reader.ReadToEnd();
            }
        }  
       

    }
    
    
}
