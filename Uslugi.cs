using System;
using System.Collections.Generic;

#nullable disable

namespace SalonSaxap
{
    public partial class Uslugi
    {
        public Uslugi()
        {
            Entries = new HashSet<Entry>();
        }

        public long IdUslugi { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Entry> Entries { get; set; }
    }
}
