using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Feedback
    {
        public int IdFeedback { get; set; }
        public int? IdLesson { get; set; }
        public string LessonFeedback { get; set; }
        public string PhoneNumber { get; set; }
        public int? Rating { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual Lesson IdLessonNavigation { get; set; }
    }
}
