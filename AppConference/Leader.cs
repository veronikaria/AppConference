using System;
using System.Collections.Generic;

namespace AppConference
{
    public partial class Leader
    {
        public Leader()
        {
            Sections = new HashSet<Section>();
        }

        public int LeaderId { get; set; }
        public string Lastname { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string? Middlename { get; set; }

        public virtual ICollection<Section> Sections { get; set; }
    }
}
