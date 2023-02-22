using System;
using System.Collections.Generic;

#nullable disable

namespace SalonSaxap
{
    public partial class User
    {
        public User()
        {
            Entries = new HashSet<Entry>();
        }

        public long IdUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Entry> Entries { get; set; }
    }
}
