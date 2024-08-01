using System;
using System.Collections.Generic;

namespace Tasl.Repository.Entities
{
    public partial class User
    {
        public User()
        {
            Tasks = new HashSet<Task>();
        }

        public int UserId { get; set; }
        public string Name { get; set; } = null!;
        public string Family { get; set; } = null!;

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
