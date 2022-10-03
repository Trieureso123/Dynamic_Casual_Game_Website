using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier.ViewModels
{
    public class LessonResponseModel
    {
        public int IdLesson { get; set; }
        public int? IdCategory { get; set; }
        public string NameLesson { get; set; }
        public string VideoUrl { get; set; }

    }
}
