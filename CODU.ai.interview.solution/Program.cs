using CODU.ai.interview.solution.Helpers;
using System;
using System.IO;

namespace CODU.ai.interview.solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = args[0];

            ProgramHelper programHelper = new ProgramHelper();

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"No file with path {filePath} found.");
            }
            else
            {
                string[] fileContents = File.ReadAllLines(filePath);


                foreach (string line in fileContents)
                {
                    programHelper.PopulateObjects(line);
                }

                programHelper.OutputManager();

            }


        }


    }


}
