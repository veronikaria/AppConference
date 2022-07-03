using System;
using System.Collections.Generic;

namespace AppConference
{
    public partial class Performance
    {
        public Performance()
        {
            Equipment = new HashSet<Equipment>();
        }

        public int PerformanceId { get; set; }
        public string Theme { get; set; } = null!;
        public int? SpeakerId { get; set; }
        public int? SectionId { get; set; }
        public DateTime? DateTimeStart { get; set; }
        public TimeSpan? Duration { get; set; }

        public virtual Section? Section { get; set; }
        public virtual Speaker? Speaker { get; set; }

        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
