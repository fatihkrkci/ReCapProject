using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        [SecuredOperation("category.add,admin")]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Add(Category category)
        {
            IResult result = BusinessRules.Run(CheckIfCategoryNameExists(category.CategoryName));

            if (result != null)
            {
                return result;
            }

            _categoryDal.Add(category);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Category>> GetAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<Category>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.CategoriesListed);
        }

        [CacheAspect]
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.Id == categoryId));
        }

        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        private IResult CheckIfCategoryNameExists(string categoryName)
        {
            var result = _categoryDal.GetAll(c => c.CategoryName == categoryName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CategoryNameAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
