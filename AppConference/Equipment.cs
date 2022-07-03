using System;
using System.Collections.Generic;

namespace AppConference
{
    public partial class Equipment
    {
        public Equipment()
        {
            Performances = new HashSet<Performance>();
        }

        public int EquipmentId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Performance> Performances { get; set; }
    }
}
