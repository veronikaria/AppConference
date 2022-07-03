using System;
using System.Collections.Generic;

namespace AppConference
{
    public partial class Speaker
    {
        public Speaker()
        {
            Performances = new HashSet<Performance>();
        }

        public int SpeakerId { get; set; }
        public string Lastname { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string? Middlename { get; set; }
        public string? Degree { get; set; }
        public string? Work { get; set; }
        public string? PostName { get; set; }
        public string? Biography { get; set; }

        public virtual ICollection<Performance> Performances { get; set; }
    }
}
