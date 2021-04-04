using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProducerManager : IProducerService
    {
        IProducerDal _producerDal;

        public ProducerManager(IProducerDal producerDal)
        {
            _producerDal = producerDal;
        }

        //[SecuredOperation("product.add,admin")]
        //[ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect("IProducerService.Get")]
        public IResult Add(Producer producer)
        {

            //Aynı isimde ürün eklenemez
            //Eğer mevcut kategori sayısı 15'i geçtiyse sisteme yeni ürün eklenemez. ve 
            //IResult result = BusinessRules.Run(CheckIfProductNameExists(product.ProductName)
            //    //CheckIfProductCountOfCategoryCorrect(product.CategoryId), CheckIfCategoryLimitExceded());

            //if (result != null)
            //{
            //    return result;
            //}

            _producerDal.Add(producer);

            return new SuccessResult(Messages.ProducerAdded);

        }

        public IResult Delete(int producerId)
        {
            throw new NotImplementedException();
        }

        //public IResult Delete(int producerId)
        //{
        //    _producerDal.Delete(producerId);
        //    return new SuccessResult(Messages.ProducerDeleted);
        //}

        [CacheAspect]
        public IDataResult<List<Producer>> GetAll()
        {
            //if (DateTime.Now.Hour == 1)
            //{
            //    return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            //}

            return new SuccessDataResult<List<Producer>>(_producerDal.GetAll(), Messages.ProductsListed);
        }

        //public IDataResult<List<Producer>> GetAllByCategoryId(int id)
        //{
        //    return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        //}

        [CacheAspect]
        public IDataResult<Producer> GetById(int producerId)
        {
            return new SuccessDataResult<Producer>(_producerDal.Get(p => p.Id == producerId));
        }

        //public IDataResult<List<Producer>> GetByUnitPrice(decimal min, decimal max)
        //{
        //    return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        //}

        public IDataResult<List<ProducerDetailDto>> GetProducerDetails()
        {
            //if (DateTime.Now.Hour == 23)
            //{
            //    return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
            //}
            //return new SuccessDataResult<List<ProducerDetailDto>>(_producerDal.);
            return null;
        }

        //[ValidationAspect(typeof(ProductValidator))]
        //[CacheRemoveAspect("IProductService.Get")]
        public IResult Update(Producer producer)
        {
            //var result = _producerDal.GetAll(p => p.CategoryId == product.CategoryId).Count;
            //if (result >= 10)
            //{
            //    return new ErrorResult(Messages.ProductCountOfCategoryError);
            //}
            //throw new NotImplementedException();

            _producerDal.Update(producer);
            return new SuccessResult(Messages.ProducerAdded);
        }

        //private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
        //{
        //    //Select count(*) from products where categoryId=1
        //    var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count;
        //    if (result >= 15)
        //    {
        //        return new ErrorResult(Messages.ProductCountOfCategoryError);
        //    }
        //    return new SuccessResult();
        //}

        //private IResult CheckIfProducerNameExists(string producerName)
        //{
        //    var result = _productDal.GetAll(p => p.pr == productName).Any();
        //    if (result)
        //    {
        //        return new ErrorResult(Messages.ProductNameAlreadyExists);
        //    }
        //    return new SuccessResult();
        //}

        //private IResult CheckIfCategoryLimitExceded()
        //{
        //    var result = _categoryService.GetAll();
        //    if (result.Data.Count>15)
        //    {
        //        return new ErrorResult(Messages.CategoryLimitExceded);
        //    }

        //    return new SuccessResult();
        //}

        //public IResult AddTransactionalTest(Product product)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
