using System;
using System.Collections.Generic;

namespace Tasl.Repository.Entities
{
    public partial class Task
    {
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string? TaskTitle { get; set; }
        public string TaskDescription { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}
