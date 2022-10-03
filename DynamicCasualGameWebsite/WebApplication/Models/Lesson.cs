using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Lesson
    {
        public int IdLesson { get; set; }
        public int? IdCategory { get; set; }
        public string NameLesson { get; set; }
        public string VideoUrl { get; set; }

        public virtual Category IdCategoryNavigation { get; set; }
        public virtual ICollection<Description> Descriptions { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
