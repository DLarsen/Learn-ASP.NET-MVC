using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcApplication3.Models;

namespace MvcApplication3.Infrastructure.Data
{
    public class FeedbackContext : DbContext
    {
        public DbSet<Feedback> FeedbackItems { get; set; }
    }
}