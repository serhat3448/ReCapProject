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
                //var result = from rentals in filter == null ? context.Rentals : context.Rentals.Where(filter)
                //             join cars in context.Cars on rentals.CarId equals cars.Id
                //             join colors in context.Colors on cars.ColorId equals colors.Id
                //             join brands in context.Brands on cars.BrandId equals brands.Id
                //             join customers in context.Customers on rentals.CustomerId equals customers.Id
                //             join users in context.Users on customers.UserId equals users.Id


                //             select new RentalDetailDto
                //             {
                //                 RentalId = rentals.Id,
                //                 FirstName = users.FirstName,
                //                 LastName = users.LastName,
                //                 CompanyName = customers.CompanyName,
                //                 CarName = cars.Description,
                //                 ColorName = colors.Name,
                //                 BrandName = brands.Name,
                //                 RentDate = rentals.RentDate,
                //                 ReturnDate = rentals.ReturnDate
                //             };
                var result2 = from r in context.Rentals
                              join c in context.Cars on r.CarId equals c.Id
                              join b in context.Brands on c.BrandId equals b.Id
                              join cu in context.Customers on r.CustomerId equals cu.Id
                              join u in context.Users on cu.UserId equals u.Id
                              select new RentalDetailDto
                              {
                                  RentalId = r.Id,
                                  FirstName = u.FirstName,
                                  LastName = u.LastName,
                                  CompanyName = cu.CompanyName,
                                  CarName = c.Description,
                                  BrandName = b.Name,
                                  RentDate = r.RentDate,
                                  ReturnDate = r.ReturnDate
                              };

                return result2.ToList();
            }       
        }
    }
}
