﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier.ViewModels
{
    public class FeedbackResponeModel
    {
        public int IdFeedback { get; set; }
        public int? IdLesson { get; set; }
        public string LessonFeedback { get; set; }
        public string PhoneNumber { get; set; }
        public int? Rating { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
