using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InternManager : IInternService
    {
        IInternDal _internDal;
        public InternManager(IInternDal internDal)
        {
            _internDal = internDal;
        }

        [ValidationAspect(typeof(InternValidator))]
        public IResult Add(Intern intern)
        {
            _internDal.Add(intern);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Intern>> GetAll()
        {
            if (DateTime.Now.Hour == 11)
            {
                return new ErrorDataResult<List<Intern>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Intern>>(_internDal.GetAll(), Messages.InternsListed);
        }

        public IDataResult<Intern> GetById(int internId)
        {
            return new SuccessDataResult<Intern>(_internDal.Get(i => i.InternId == internId));
        }
    }
}
