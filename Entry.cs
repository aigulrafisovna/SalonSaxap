using System;
using System.Collections.Generic;

#nullable disable

namespace SalonSaxap
{
    public partial class Entry
    {
        public long IdEntry { get; set; }
        public long IdUser { get; set; }
        public long IdUslugi { get; set; }
        public string Date { get; set; }
        public string Master { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual Uslugi IdUslugiNavigation { get; set; }
    }
}
