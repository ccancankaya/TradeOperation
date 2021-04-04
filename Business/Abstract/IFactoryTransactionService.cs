using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFactoryTransactionService
    {
        IDataResult<List<FactoryTransaction>> GetAll();
        IDataResult<FactoryTransaction> GetById(int factoryTransactionId);
        IResult Add(FactoryTransaction factoryTransaction);
        IResult Update(FactoryTransaction factoryTransaction);
        //IDataResult<List<ProducerDetailDto>> GetProducerDetails();
    }
}
