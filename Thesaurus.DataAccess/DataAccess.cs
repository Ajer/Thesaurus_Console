using System;
using System.Collections.Generic;
using Thesaurus.Models;

namespace Thesaurus.DataAccessing
{
    public class DataAccess
    {
        public DataAccess()
        {

        }

        public List<Word> Words = new List<Word>
        {
            new Word{Id=1,Name="Skepp",SynonymeList_ID=1},
            new Word{Id=2,Name="Fartyg",SynonymeList_ID=1},
            new Word{Id=3,Name="Skuta",SynonymeList_ID=1},

            new Word{Id=4,Name="Sympatisk",SynonymeList_ID=2},
            //new Word{Id=5,Name="Charmig",SynonymeList_ID=2},
            //new Word{Id=6,Name="Älskvärd",SynonymeList_ID=2},
            //new Word{Id=7,Name="Behaglig",SynonymeList_ID=2},
            //new Word{Id=8,Name="Trevlig",SynonymeList_ID=2}
        };

        public List<SynonymeList> SynLists = new List<SynonymeList>
        {
            new SynonymeList{Id=1,Description="Skepp"},
            new SynonymeList{Id=2,Description="Sympatisk"}
        };
    }
}
