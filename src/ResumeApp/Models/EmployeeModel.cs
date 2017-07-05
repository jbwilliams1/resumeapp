using ResumeApp.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ResumeApp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public string Address { get; set; } 
        public string City { get; set; } 
        // Normally would use an enum entity class 
        public string State { get; set; } 
        // Skipping splitting by area/country codes for sake of brevity 
        public string Phone { get; set; } 

        public ICollection<Job> Jobs { get; set; }
        public ICollection<Skill> Skills { get; set; }
    }
}