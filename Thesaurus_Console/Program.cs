using System;
using System.Collections.Generic;
using Thesaurus.BusinessModel;

namespace Thesaurus_Console
{
    internal class Program
    {
        private static BusinessLogic bl = new BusinessLogic();

        //private static List<string> AllWords;

        private static void writeWords(List<string>? wordList,int type)
        {
            if (wordList != null)
            {
                if (wordList.Count == 0)
                {
                    Console.WriteLine("No Words Yet...");
                }
                else
                {
                    string header="";
                    

                    if (type == 0)  // AllWords
                    {
                        header = "-------------All Words-------------------";
                    }
                    else if (type == 1)   // Synonymes
                    {
                        header = "-------------Synonymes for " + wordList[0] + "-------------------";
                    }

                    Console.WriteLine();
                    Console.WriteLine(header);

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

        private static void writeWordsWithListIDs()
        {

            //if (AllWords.Count == 0)
            //{
            //    Console.WriteLine("No Words Yet...");
            //}
            //else
            //{
            //    foreach (var w in AllWords)
            //    {
                    
            //    }
            //}
        }

        static void Main(string[] args)
        {

            List<string> AllWords = (List<string>)bl.GetWords();

            writeWords(AllWords,0);

            List<string> Syns = (List<string>)bl.GetSynonyms("Trevlig");

            writeWords(Syns, 1);

        }
    }
}
