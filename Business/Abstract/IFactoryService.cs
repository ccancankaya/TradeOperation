using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFactoryService
    {
        IDataResult<List<Factory>> GetAll();
        IDataResult<Factory> GetById(int factoryId);
        IResult Add(Factory factory);
        IResult Update(Factory factory);
        IDataResult<List<FactoryDetailDto>> GetFactoryDetails();
    }
}
