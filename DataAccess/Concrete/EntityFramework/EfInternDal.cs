using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfInternDal : EfEntityRepositoryBase<Intern, InternTabContext>, IInternDal
    {
        public List<Intern> GetInternDetails()
        {
            using (InternTabContext context = new InternTabContext())
            {
                return context.Interns.ToList();
            }
        }
    }
}