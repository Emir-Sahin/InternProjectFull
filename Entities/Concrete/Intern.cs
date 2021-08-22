using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Intern : IEntity
    {
        public int InternId { get; set; }
        public string InternName { get; set; }
        public int InternAge { get; set; }
        public string InternSchool { get; set; }
        public string InternshipStartDate { get; set; }
        public string InternshipEndDate { get; set; }
        public string InternshipDuration { get; set; }
        public string InternshipDepartment { get; set; }
        public string InternshipSupervisor { get; set; }
    }
}
