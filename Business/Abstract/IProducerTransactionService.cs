using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProducerTransactionService
    {
        IDataResult<List<ProducerTransaction>> GetAll();
        IDataResult<ProducerTransaction> GetById(int producerTransactionId);
        IResult Add(ProducerTransaction producerTransaction);
        IResult Update(ProducerTransaction producerTransaction);
        //IDataResult<List<ProducerDetailDto>> GetProducerDetails();
    }
}
