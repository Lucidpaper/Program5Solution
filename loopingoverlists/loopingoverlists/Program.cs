using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopingoverlists
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopOverAList();
            LoopOverWordsInAstring(" the quick brown fox jumps over the lazy dog");
            Console.ReadKey();
        }

        static void LoopOverAList ()
        {
            //create a list of sports
            List<string> sportsList = new List<string> {"baseball","tenis"};
            
            //add football to the sportslist
            sportsList.Add("football");

            //loop over sportslist and display the word ball
            for (int i = 0; i < sportsList.Count(); i++)
			{
			    //get thee current sport lout of sports list
                string currentSport = sportsList[i];
                //display elements with the word ball
                if (currentSport.Contains("ball"))
	            {
        		    //
                    Console.WriteLine(currentSport);
	            }
			}

        }

        static void LoopOverWordsInAstring(string inputString)
        {
            List<string> wordList = inputString.Split(' ').ToList();
            for (int i = 0; i < wordList.Count(); i++)
            {
                Console.WriteLine(wordList[i]);
            }
        }

        public static object newlist { get; set; }
    }
}
