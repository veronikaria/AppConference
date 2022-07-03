using System;
using System.Collections.Generic;

namespace AppConference
{
    public partial class Place
    {
        public Place()
        {
            Sections = new HashSet<Section>();
        }

        public string Name { get; set; } = null!;

        public virtual ICollection<Section> Sections { get; set; }
    }
}
