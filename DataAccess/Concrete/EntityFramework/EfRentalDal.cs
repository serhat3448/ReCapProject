using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectDbContext>, IRentalDal
    {
        private Func<Rental, bool> filter;

        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                var result = from rentals in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join cars in context.Cars on rentals.CarId equals cars.Id
                             join colors in context.Colors on cars.ColorId equals colors.Id
                             join brands in context.Brands on cars.BrandId equals brands.Id
                             join customers in context.Customers on rentals.CustomerId equals customers.Id
                             join users in context.Users on customers.UserId equals users.Id
                             select new RentalDetailDto
                             {
                                 RentalId = rentals.Id,
                                 FirstName = users.FirstName,
                                 LastName = users.LastName,
                                 CompanyName = customers.CompanyName,
                                 CarName = cars.Description,
                                 ColorName = colors.Name,
                                 BrandName = brands.Name,
                                 RentDate = rentals.RentDate,
                                 ReturnDate = rentals.ReturnDate
                             };

                return result.ToList();
            }       
        }
    }
}
