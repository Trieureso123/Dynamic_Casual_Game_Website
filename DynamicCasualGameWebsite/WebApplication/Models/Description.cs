using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Description
    {
        public int IdDescription { get; set; }
        public int? IdLesson { get; set; }
        public string Time { get; set; }
        public string Description1 { get; set; }

        public virtual Lesson IdLessonNavigation { get; set; }
    }
}
