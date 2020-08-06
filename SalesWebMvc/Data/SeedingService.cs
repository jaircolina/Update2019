using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; //Banco já populado
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Usual");
            Department d4 = new Department(4, "Books");
            Department d5 = new Department(5, "Fashion");

            Seller s1 = new Seller(1, "Bob Brow", "bob@gmail.com", 1000.0, new DateTime(1998, 4, 21), d1);
            Seller s2 = new Seller(2, "John", "john@gmail.com", 2000.0, new DateTime(1978, 3, 18), d2);
            Seller s3 = new Seller(3, "Mary Popins", "mary@gmail.com", 2800.0, new DateTime(1976, 2, 17), d3);
            Seller s4 = new Seller(4, "Paul Rabit", "paul@gmail.com", 3400.0, new DateTime(1972, 7, 22), d3);
            Seller s5 = new Seller(5, "Peter Selers", "peter@gmail.com", 2700.0, new DateTime(1969, 3, 25), d5);


            SalesRecord r1 = new SalesRecord(1, new DateTime(2020, 5, 17), 11000, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2020, 7, 22), 21000, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 8, 5), 23000, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2020, 6, 12), 9000, SaleStatus.Billed, s4);

            _context.Department.AddRange(d1, d2, d3, d4, d5);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecord.AddRange(r1, r2, r3, r4);

            _context.SaveChanges();
        }
    }
}
