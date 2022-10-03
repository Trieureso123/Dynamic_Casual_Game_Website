using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.APIPath
{
    public static class APIPath
    {
        public static string APIBaseUrl = "https://localhost:44379/";
        public static string DescriptionAPIPath = "";
        public static string FeedbackAPIPath = "";
        public static string LessonAPIPath = "";
        public static string QuestionAPIPath = APIBaseUrl + "api/Question";
    }
}
