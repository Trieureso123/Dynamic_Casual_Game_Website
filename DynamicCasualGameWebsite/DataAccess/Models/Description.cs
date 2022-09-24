using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class Description
    {
        public int IdDescription { get; set; }
        public int? IdLesson { get; set; }
        public string Time { get; set; }
        public string Description1 { get; set; }

        public virtual Lesson IdLessonNavigation { get; set; }
    }
}
