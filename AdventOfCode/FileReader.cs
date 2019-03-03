using System;

namespace ChronalCalibration
{
    public class FileReader
    {
        public long SumNumbersFromFile(string FilePath)
        {
            long sum = 0;
            
            // Read the file
            string[] textLines = System.IO.File.ReadAllLines(FilePath);

            //convert each line to int32
            foreach (var line in textLines)
            {
                int convertedInt = Int32.Parse(line);

                sum += convertedInt;
            }
            
            return sum;
        }
   
    }
}
