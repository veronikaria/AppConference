using System;
using System.Collections.Generic;

namespace AppConference
{
    public partial class Section
    {
        public Section()
        {
            Performances = new HashSet<Performance>();
        }

        public int SectionId { get; set; }
        public string Name { get; set; } = null!;
        public int? OrdinalNumber { get; set; }
        public int? LeaderId { get; set; }
        public int? ConferenceId { get; set; }
        public string? PlaceName { get; set; }

        public virtual Conference? Conference { get; set; }
        public virtual Leader? Leader { get; set; }
        public virtual Place? PlaceNameNavigation { get; set; }
        public virtual ICollection<Performance> Performances { get; set; }
    }
}
