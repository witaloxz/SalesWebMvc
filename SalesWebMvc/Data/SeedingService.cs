using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;


namespace SalesWebMvc.Data {
    public class SeedingService {

        private SalesWebMvcContext salesWebMvcContext;


        public SeedingService(SalesWebMvcContext salesWebMvcContext) {
            this.salesWebMvcContext = salesWebMvcContext;
        }

        public void Seed() {

            if (salesWebMvcContext.Department.Any() ||
                salesWebMvcContext.Seller.Any() ||
                salesWebMvcContext.SallesRecord.Any()) {
                return; // DB has been seeded
            }

            Department d1 = new Department { Id = 1, Name = "Computers" };
            Department d2 = new Department { Id = 2, Name = "Electronics" };
            Department d3 = new Department { Id = 3, Name = "Fashion" };
            Department d4 = new Department { Id = 4, Name = "Books" };
            Department d5 = new Department { Id = 5, Name = "Food" };
            Department d6 = new Department { Id = 6, Name = "Health" };

            Seller s1 = new Seller { Id = 1, Name = "Bob Brown", Email = "bob@gmail.com", BirthDate = new DateTime(2005, 09, 30), BaseSalary = 4000, Department = d1 };
            Seller s2 = new Seller { Id = 2, Name = "Maria Green", Email = "maria@gmail.com", BirthDate = new DateTime(2006, 02, 07), BaseSalary = 5000, Department = d3 };

            SallesRecord r1 = new SallesRecord { Id = 1, Date = new DateTime(2023, 09, 25), Amount = 11000, Status = SaleStatus.BILLED, Seller = s1 };
            SallesRecord r2 = new SallesRecord { Id = 2, Date = new DateTime(2023, 09, 26), Amount = 7000, Status = SaleStatus.BILLED, Seller = s2 };
            SallesRecord r3 = new SallesRecord { Id = 3, Date = new DateTime(2023, 09, 27), Amount = 4000, Status = SaleStatus.BILLED, Seller = s1 };
            SallesRecord r4 = new SallesRecord { Id = 4, Date = new DateTime(2023, 09, 28), Amount = 8000, Status = SaleStatus.BILLED, Seller = s2 };

            salesWebMvcContext.Department.AddRange(d1, d2, d3, d4, d5, d6);
            salesWebMvcContext.Seller.AddRange(s1, s2);
            salesWebMvcContext.SallesRecord.AddRange(r1, r2, r3, r4);
            salesWebMvcContext.SaveChanges();
        }

    }
}
