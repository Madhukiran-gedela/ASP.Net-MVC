using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Company.DataLayer;
using Company.DomainModels;
namespace usingDB.ApiControllers
{
    public class BrandsController : ApiController
    {
        public List<Brands>GetBrands()
        {
        CompanyDbContext db = new CompanyDbContext();
        List<Brands> brands = db.Brands.ToList();
            return brands;
        }
        public Brands GetBrandByBrandID(long BrandID)
        {
            CompanyDbContext db = new CompanyDbContext();
            Brands brands = db.Brands.Where(temp => temp.BrandID ==BrandID).FirstOrDefault();
            return brands;
        }
    }
}
