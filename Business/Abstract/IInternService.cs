using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInternService
    {
        IDataResult<List<Intern>> GetAll();
        IDataResult<Intern> GetById(int internId);
        IResult Add(Intern intern);
    }
}
