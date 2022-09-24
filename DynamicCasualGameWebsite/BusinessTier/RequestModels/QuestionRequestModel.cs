using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier.RequestModels
{
    public class QuestionRequestModel
    {
        public int IdQuestion { get; set; }
        public string Question1 { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
