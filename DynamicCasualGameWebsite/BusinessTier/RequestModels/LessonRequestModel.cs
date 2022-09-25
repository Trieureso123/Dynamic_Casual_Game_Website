using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier.RequestModels
{
    public class LessonRequestModel
    {
        public int? IdCategory { get; set; }
        public string NameLesson { get; set; }
        public string VideoUrl { get; set; }
    }
}
