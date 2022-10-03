using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Category
    {
        public int IdCategory { get; set; }
        public string NameCategory { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
