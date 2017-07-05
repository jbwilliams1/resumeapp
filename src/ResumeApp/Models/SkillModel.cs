using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ResumeApp.Models
{
    public class Skill
    {
        public int ID { get; set; }        
        public string Name { get; set; }
        public string Description { get; set; }
        public int Proficiency { get; set; } 
           
        public virtual Employee Employee { get; set; }
    }
}