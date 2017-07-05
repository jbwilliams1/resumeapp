using System.Linq;
using ResumeApp.Models;

namespace ResumeApp.Data
{
    public static class ResumeExtensions
    {
        public static void EnsureSeedData(this ResumeContext db)
        {
            if (!db.Employees.Any())
            {
                var employee = db.Employees.Add(
                    new Employee {
                        FirstName = "Jacob",
                        LastName  = "Williams",
                        Biography = "I am a 27 year old web developer based in Plymouth, MN. I have been programming since the age of 13 - starting with Visual Basic, Perl, and PHP. Many years of professional experience have exposed me to a wide range of challenges, from enterprise Java applications, legacy CRMs, to custom e-Commerce solutions and Asset Management Systems.",
                        Address   = "2765 Ranchview Ln N",
                        City      = "Plymouth",
                        State     = "MN",
                        Phone     = "6127087650"
                    }
                ).Entity;

                if (!db.Jobs.Any())
                {
                    db.Jobs.AddRange(
                        new Job { Title = "Senior Full Stack Software Engineer", CompanyName = "Resorts & Lodges", Description = "Team Lead & Lead Developer <br> Vacation Rental Software (a la AirBnB), CMS, CRM <br> PHP5, MySQL, MongoDB, AWS, Zf1, Zf2, Angular, Vagrant", StartDate = new System.DateTime(2017, 01, 05), EndDate = null, ImageUrl = "https://s3.us-east-2.amazonaws.com/resumeapp-assets/ral.png", Employee = employee },
                        new Job { Title = "Senior Web Developer", CompanyName = "Bluedoor Publishing", Description = "Lead Developer of Asset Management System <br> Co-Developer of Learning Management System <br> PHP5, MySQL, Self-managed VPSes, Laravel, Codeigniter, Wordpress, AngularJS", StartDate = new System.DateTime(2013, 05, 01), EndDate = new System.DateTime(2017, 01, 01), ImageUrl = "https://s3.us-east-2.amazonaws.com/resumeapp-assets/bluedoor.png", Employee = employee },
                        new Job { Title = "Lead Web Developer (Contract)", CompanyName = "Edbacker", Description = "Created back-end for crowdfunding application <br> Managed small team of contractors to meet tight deadlines <br> PHP5, MySQL, AWS, Yii 2.0, Stripe API, PayPal API", StartDate = new System.DateTime(2015, 01, 01), EndDate = new System.DateTime(2015, 12, 30), ImageUrl = "https://s3.us-east-2.amazonaws.com/resumeapp-assets/edbacker.png", Employee = employee },
                        new Job { Title = "Web Developer", CompanyName = "Internet Broadcasting", Description = "Full-stack application development <br> Heavy JavaScript, Java applications seeing 1m+ views per site (23 sites) <br> Java on Spring CMS, JavaScript (jQuery), LESS", StartDate = new System.DateTime(2012, 03, 01), EndDate = new System.DateTime(2013, 03, 01), ImageUrl = "https://s3.us-east-2.amazonaws.com/resumeapp-assets/ibsys.png", Employee = employee }
                    );
                }

                if (!db.Skills.Any())
                {
                    db.Skills.AddRange(
                        new Skill { Name = "PHP5", Description = "", Proficiency = 5, Employee = employee },
                        new Skill { Name = "MySQL", Description = "", Proficiency = 5, Employee = employee },
                        new Skill { Name = "HTML/CSS", Description = "", Proficiency = 5, Employee = employee },
                        new Skill { Name = "AWS", Description = "", Proficiency = 4, Employee = employee },                        
                        new Skill { Name = "JavaScript", Description = "", Proficiency = 4, Employee = employee },                        
                        new Skill { Name = "Ruby", Description = "", Proficiency = 4, Employee = employee },
                        new Skill { Name = "C#", Description = "", Proficiency = 3, Employee = employee }
                    );
                }

                db.SaveChanges();
            }
        }
    }
}