using System;

namespace InventoryManagementSystem
{
    public class Scanner
    {
        private readonly int COMPARABLE_CHARACTER;

        private int[] Matches;

        public int DoublesCounter { get; set; }

        public int TriplesCounter { get; set; }

        public int Checksum { get; set; }
        private bool doubleFound;
        private bool tripleFound;

        public Scanner()
        {
            doubleFound = false;
            tripleFound = false;
            COMPARABLE_CHARACTER = 0;
        }

        public void CalculateDoubles(string[] ID)
        {
            doubleFound = false;
            tripleFound = false;

            for(int i = COMPARABLE_CHARACTER; i < ID.Length - 1; i++)
            {
                Matches = new int[ID.Length];

                for (int j = i + 1; j < ID.Length; j++)
                {
                    if(ID[i] == ID[j])
                    {
                        Matches[j] = 1;
                    }
                    else
                    {
                        Matches[j] = 0;
                    }
                }

                int NumberOfDuplicates = 1;
                for(int k = 0; k < Matches.Length; k++)
                {
                    NumberOfDuplicates += Matches[k];
                }

                if (!doubleFound && NumberOfDuplicates == 2) doubleFound = true;
                if (!tripleFound && NumberOfDuplicates == 3) tripleFound = true;
                if (tripleFound && doubleFound) break; // to avoid searching when both found for an ID
            }

            if (doubleFound) DoublesCounter += 1;
            if (tripleFound) TriplesCounter += 1;
        }
    }
}
