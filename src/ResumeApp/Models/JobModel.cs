using ResumeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ResumeApp.Models
{
    public class Job
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string ImageUrl { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        
        public virtual Employee Employee { get; set; }
    }
}