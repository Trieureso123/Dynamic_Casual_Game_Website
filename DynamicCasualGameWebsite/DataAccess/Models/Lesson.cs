using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class Lesson
    {
        public Lesson()
        {
            Descriptions = new HashSet<Description>();
            Feedbacks = new HashSet<Feedback>();
        }

        public int IdLesson { get; set; }
        public int? IdCategory { get; set; }
        public string NameLesson { get; set; }
        public string VideoUrl { get; set; }

        public virtual Category IdCategoryNavigation { get; set; }
        public virtual ICollection<Description> Descriptions { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
