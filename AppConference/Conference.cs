using System;
using System.Collections.Generic;

namespace AppConference
{
    public partial class Conference
    {
        public Conference()
        {
            Sections = new HashSet<Section>();
        }

        public int ConferenceId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string? BuildingName { get; set; }

        public virtual Building? BuildingNameNavigation { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}
