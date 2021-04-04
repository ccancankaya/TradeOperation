using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPersonelExpenseService
    {
        IDataResult<List<PersonelExpense>> GetAll();
        IDataResult<PersonelExpense> GetById(int personelExpenseId);
        IResult Add(PersonelExpense personelExpense);
        IResult Update(PersonelExpense personelExpense);
        //IDataResult<List<ProducerDetailDto>> GetProducerDetails();
    }
}
