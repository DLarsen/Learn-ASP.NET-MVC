using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public DateTime Created { get; set; }
        public string Author { get; set; }
        public string Message { get; set; }
        public string URL { get; set; }
    }
}