using System;

namespace Thesaurus.Models
{
    // Ej Entityframework_anpassad med nav.-properties , data-annotations etc
    public class Word
    {
        public  int Id { get; set; }  // pk_Word

        public string Name { get; set; }

        public int SynonymeList_ID{ get; set; }   // fk_ref_SynonymeList_pk
    }
}
