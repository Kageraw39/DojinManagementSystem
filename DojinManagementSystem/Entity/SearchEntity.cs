using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojinManagementSystem
{
    public class SearchEntity
    {
        public string Title { get; set; }

        public string CircleName { get; set; }

        public int? CircleId { get; set; }

        public string Author { get; set; }

        public int? EventId { get; set; }

        public DateTime? PubulishDateFrom { get; set; }

        public DateTime? PubulishDateTo { get; set; }
        
        public int? GenreId { get; set; }

        public int? OriginalId { get; set; }

        public int? CharaId { get; set; }

        public bool? FlgR18 { get; set; }

        public bool? FlgOmnibus { get; set; }

        public bool? FlgJoint { get; set; }

        public bool? FlgCopy { get; set; }

    }
}
