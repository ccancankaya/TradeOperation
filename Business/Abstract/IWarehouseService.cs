using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IWarehouseService
    {
        IDataResult<List<Warehouse>> GetAll();
        IDataResult<Warehouse> GetById(int warehouseId);
        IResult Add(Warehouse warehouse);
        IResult Update(Warehouse warehouse);
        //IDataResult<List<ProducerDetailDto>> GetProducerDetails();
    }
}
