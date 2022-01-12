using System;
using System.Collections.Generic;
using Thesaurus.BusinessModel;

namespace Thesaurus_Console
{
    internal class Program
    {
        private static BusinessLogic bl = new BusinessLogic();
        private static List<string> AllWords;

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
                    string header = "";

                    if (type == 0)  // AllWords
                    {
                        header = "-------------All Words-------------------";
                    }
                    else if (type == 1)   // Synonymes
                    {
                        header = "-------------Synonymes-------------------";
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
                Console.WriteLine("Error in inData or application.Searchresult for List of synonymes possibly>1");
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

            AllWords = (List<string>)bl.GetWords();

            writeWords(AllWords,0);

            List<string> Syns = (List<string>)bl.GetSynonyms("Sympatisk");

            writeWords(Syns, 1);

        }
    }
}
