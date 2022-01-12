using System;
using System.Collections.Generic;
using Thesaurus.DataAccessing;
using Thesaurus.Models;

namespace Thesaurus.BusinessLogic
{
    public class BusinessLogic:IThesaurus
    {

        private Dictionary<int, List<string>> SynonymeLists;

        private DataAccess dataAccess;


        public BusinessLogic()
        {
            dataAccess = new DataAccess();
            FillSynonymeLists();         
        }

        private Dictionary<int,List<string>> FillSynonymeLists()
        {
            


            List<Word> words = dataAccess.Words;
            
            //List<SynonymeList> synList = dataAccess.SynList;


            SynonymeLists = new Dictionary<int, List<string>>();


            List<List<string>> theList = new List<List<string>>();

            

            //var i = 1;
            foreach (var word in words)
            {
                if(!SynonymeLists.ContainsKey(word.SynonymeList_ID))  // ny key
                {
                    List<string> s = new List<string>();
                    s.Add(word.Name);
                    SynonymeLists.Add(word.SynonymeList_ID,s);
                }
                else  
                {
                    List<string> val;

                    bool hasValue = SynonymeLists.TryGetValue(word.SynonymeList_ID, out val);

                    if (hasValue)
                    {
                        val.Add(word.Name);
                    }

                }
                    
            }


            return SynonymeLists;

        }

        public void AddSynonyms(IEnumerable<string> synonyms)
        {
            // to be implemented
        }

        public IEnumerable<string> GetSynonyms(string word)
        {
            return null;  // to be implemented
        }

        public IEnumerable<string> GetWords()
        {
            return null;  // to be implemented
        }
    }
}
