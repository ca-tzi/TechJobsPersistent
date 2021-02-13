using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
        public int EmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public static List<Skill> AllSkills { get; set; }

       

        public AddJobViewModel()
        {

        }

        public AddJobViewModel( List<Employer> employers, List<Skill> allSkills)
        {
            Employers = new List<SelectListItem>();

            foreach (var emp in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = emp.Id.ToString(),
                    Text = emp.Name
                });
            }

            AllSkills = allSkills;

           
        }

    }
}



//Skills = new List<SelectListItem>();

//foreach (var skill in possibleSkills)
//{
//    Skills.Add(new SelectListItem
//    {
//        Value = skill.Id.ToString(),
//        Text = skill.Name
//    });
//}

//Job = theJob;
