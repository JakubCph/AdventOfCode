using System;
using System.Collections.Generic;

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

        public long CalculateFirstRepeatedFrequency(string FilePath)
        {
            long sum = 0;
            var savedValues = new List<long>();
            savedValues.Add(0);

            // Read the file
            string[] sequence = System.IO.File.ReadAllLines(FilePath);

            //convert each line to int32
            while (true)
            {

                foreach (var line in sequence)
                {
                    int freqChange = Int32.Parse(line);

                    sum += freqChange;

                    // do we have a duplicate
                    if (savedValues.Contains(sum))
                    {
                        return sum;
                    }

                    savedValues.Add(sum);
                }     
                
            }

       
        }

    

    }
}
