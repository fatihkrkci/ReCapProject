﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using(RentACarContext context = new RentACarContext())
            {
                var result = from re in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join ca in context.Cars
                             on re.CarId equals ca.CarId
                             join cu in context.Customers
                             on re.CustomerId equals cu.CustomerId
                             join us in context.Users
                             on cu.UserId equals us.UserId
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             select new RentalDetailDto {
                                 RentalId = re.RentalId,
                                 CarId = ca.CarId,
                                 UserId = us.UserId,
                                 BrandName = br.BrandName,
                                 User = us.FirstName + " " + us.LastName,
                                 UserEmail = us.Email,
                                 CompanyName = cu.CompanyName,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,
                                 ColorName = co.ColorName,
                                 ModelYear = ca.ModelYear,
                                 Description = ca.Description,
                                 DailyPrice = ca.DailyPrice
                             };
                return result.ToList();

            }
        }
    }
}