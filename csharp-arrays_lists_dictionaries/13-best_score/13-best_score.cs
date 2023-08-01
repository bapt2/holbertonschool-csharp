using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static string BestScore(Dictionary<string, int> myList)
        {
            int score = -1;
            string none = "None";
            foreach (KeyValuePair<string, int> kvp in myList)
            {
                if (kvp.Value > score)  
                {
                    score = kvp.Value;
                    none = kvp.Key;
                }              
            }
            return none;
        }
    }
