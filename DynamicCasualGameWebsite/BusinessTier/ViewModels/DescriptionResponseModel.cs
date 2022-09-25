using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier.ViewModels
{
    public class DescriptionResponseModel
    {
        public int IdDescription { get; set; }
        public int? IdLesson { get; set; }
        public string Time { get; set; }
        public string Description1 { get; set; }
    }
}
