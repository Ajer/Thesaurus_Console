using System;
using System.Collections.Generic;
using Thesaurus.BusinessModel;

namespace Thesaurus_Console
{
    internal class Program
    {
        private static BusinessLogic bl = new BusinessLogic();

        private static List<string> AllWords;

        private static List<string> Syns;


        private static void writeWords(List<string>? wordList,int type,string words="")
        {
            if (wordList != null)
            {
                string header = "";

                if (type == 0)  // AllWords
                {
                    header = "-------------All Words-------------------";
                }
                else if (type == 1)   // Synonymes
                {
                    header = "------------- Synonymes for " + words + "-------------------";
                }

                Console.WriteLine();
                Console.WriteLine(header);

                if (wordList.Count == 0)
                {
                    Console.WriteLine("No Words ...");
                    Console.WriteLine("-----------------------------------------");
                }
                else
                {                 

                    foreach (var w in wordList)
                    {

                        Console.WriteLine(w);

                    }
                    Console.WriteLine("-----------------------------------------");

                }
            }
            else
            {
                Console.WriteLine("Error in inData or application.The searchresult for List of synonymes is possibly>1");
            }
        }

        private static void writeAllWordsToConsole()
        {
            AllWords = (List<string>)bl.GetWords();
            writeWords(AllWords, 0);
        }

        private static void writeAllSynonymesToConsole(string word)
        {
            Syns = (List<string>)bl.GetSynonyms(word);
            writeWords(Syns, 1, word);
        }



        static void Main(string[] args)
        {

            writeAllWordsToConsole();

            writeAllSynonymesToConsole("Trevlig");


            var newSyns = new List<string> { "Agent", "Spion", "JamesBond-typ" };
            bl.AddSynonyms(newSyns);


            writeAllWordsToConsole();      

            writeAllSynonymesToConsole("JamesBond-typ");

            writeAllWordsToConsole();

           
        }
    }
}
