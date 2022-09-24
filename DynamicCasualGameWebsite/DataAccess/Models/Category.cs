using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class Category
    {
        public Category()
        {
            Lessons = new HashSet<Lesson>();
        }

        public int IdCategory { get; set; }
        public string NameCategory { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
