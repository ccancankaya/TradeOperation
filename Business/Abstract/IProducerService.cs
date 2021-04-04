using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProducerService
    {
        IDataResult<List<Producer>> GetAll();
        IDataResult<Producer> GetById(int producerId);
        IResult Add(Producer producer);
        IResult Update(Producer producer);
        IResult Delete(int producerId);
        IDataResult<List<ProducerDetailDto>> GetProducerDetails();
    }
}
