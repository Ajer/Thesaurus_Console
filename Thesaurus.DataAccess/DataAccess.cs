using System;
using System.Collections.Generic;
using Thesaurus.Models;

namespace Thesaurus.DataAccessing
{
    public class DataAccess
    {
        public DataAccess()
        {
            Words = GetWords();
            SynLists = GetSynList();
            MaxWordID = 8;
            MaxSynListID = 2;
        }

        public List<Word> Words { get; set; }

        public List<SynonymeList> SynLists { get; set; }


        public int MaxWordID { get; set; }  // Hade ej använts vid riktig DB-anslutn.
        public int MaxSynListID { get; set; } // Hade ej använts vid riktig DB-anslutn.


        private List<Word> GetWords()
        {
            return new List<Word>
            {
                new Word { Id = 1, Name = "Skepp", SynonymeList_ID = 1 },
                new Word { Id = 2, Name = "Fartyg", SynonymeList_ID = 1 },
                new Word { Id = 3, Name = "Skuta", SynonymeList_ID = 1 },

                new Word { Id = 4, Name = "Sympatisk", SynonymeList_ID = 2 },
                new Word { Id = 5, Name = "Charmig", SynonymeList_ID = 2 },
                new Word { Id = 6, Name = "Älskvärd", SynonymeList_ID = 2 },
                new Word { Id = 7, Name = "Behaglig", SynonymeList_ID = 2 },
                new Word { Id = 8, Name = "Trevlig", SynonymeList_ID = 2 }
            };
        }


        private List<SynonymeList> GetSynList()
        {
            return new List<SynonymeList>
            {
                new SynonymeList{Id=1,Description="Skepp"},
                new SynonymeList{Id=2,Description="Sympatisk"}
            };
        }


        public bool AddOneSynonymeGroup(List<string> synonymes)  // synonymes={"Agent",Spion,"JamesBond-typ"}
        {
            MaxSynListID++;
            for(int i=0;i<synonymes.Count;i++)
            {
                MaxWordID++;
                Word wItem = new Word { Id = MaxWordID,Name = synonymes[i],SynonymeList_ID = MaxSynListID };
                Words.Add(wItem);
            }

            SynonymeList sItem = new SynonymeList {Id=MaxSynListID,Description=synonymes[0] };

            SynLists.Add(sItem);

            return true;
        }

    }
}
