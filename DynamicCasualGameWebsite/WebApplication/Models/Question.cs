using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Question
    {
        public int IdQuestion { get; set; }
        public string Question1 { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
