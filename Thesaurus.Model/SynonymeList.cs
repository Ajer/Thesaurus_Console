using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thesaurus.Models
{
    // Ej Entityframework_anpassad med nav.-properties ,data-annotations etc
    public class SynonymeList
    {
        public int Id { get; set; }   // pk_SynonymeList

        public string Description { get; set; }
    }
}
