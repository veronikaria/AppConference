using System;
using System.Collections.Generic;

namespace AppConference
{
    public partial class Building
    {
        public Building()
        {
            Conferences = new HashSet<Conference>();
        }

        public string Name { get; set; } = null!;

        public virtual ICollection<Conference> Conferences { get; set; }
    }
}
