using System;
using System.Collections.Generic;
using System.Linq;
using Thesaurus.DataAccessing;
using Thesaurus.Models;

namespace Thesaurus.BusinessModel
{                                              

    public class BusinessLogic : IThesaurus
    {

        public Dictionary<int, List<string>> SynonymeLists { get; set; }  // 1,{"Fartyg","Skepp","Skuta"} 2,{....}


        public List<Word> Words { get; set; }  // 
        public List<SynonymeList> SynLists { get; set; }


        public DataAccess DataAccess{ get; set; }


        public BusinessLogic()
        {

            DataAccess = new DataAccess();

            Words = DataAccess.Words;
            SynLists = DataAccess.SynLists;
            SynonymeLists = new Dictionary<int, List<string>>();

            CreateSynonymeLists();         
        }

        private Dictionary<int,List<string>> CreateSynonymeLists()
        {
            //var i = 1;
            foreach (var word in Words)   
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
            List<string> newSyn = (List<string>)synonyms;

            //bool b = DataAccess.AddOneSynonym(newSyn);
        }

        
        public IEnumerable<string> GetSynonyms(string word)
        {
            var ent = SynonymeLists.Where(item => item.Value.Contains(word)).ToList();  // keyvaluepair ent.Count = 0 eller 1 

            if (ent.Count > 1)   // error vid sökresultat-antal 2,3.. osv
            {
                return null;
            }
            else
            {
                List<string> s = new List<string>();

                foreach (var e in ent)
                {
                    s = e.Value.ToList();
                    //var k = e.Key;
                }

                return s;
            }
        }

        public IEnumerable<string> GetWords()
        {

            List<string> s = new List<string>();

            foreach (var word in Words)
            {
                s.Add(word.Name);
            }

            return s;

        }
    }
}
