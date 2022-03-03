using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

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
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;  // Banco de Dados já foi populado
            }

            Department d1 = new Department(1, "Computadores");
            Department d2 = new Department(2, "Eletronicos");
            Department d3 = new Department(3, "Moda");
            Department d4 = new Department(4, "Livros");

            Seller s1 = new Seller(1, "Getulio", "getulio.crosa@gmail.com", new DateTime(1985, 7, 19), 2000.0, d1);
            Seller s2 = new Seller(2, "Lais", "lais.orosa@gmail.com", new DateTime(1994, 8, 27), 2000.0, d1);
            Seller s3 = new Seller(3, "Leila", "leila.oliveira@gmail.com", new DateTime(1981, 7, 19), 2000.0, d2);
            Seller s4 = new Seller(4, "Lilian", "lilian.oliveira@gmail.com", new DateTime(1984, 3, 05), 2000.0, d3);
            Seller s5 = new Seller(5, "Anderson", "anderson.crosa@gmail.com", new DateTime(1982, 7, 08), 2000.0, d4);
            Seller s6 = new Seller(6, "Simone", "simone.leite@gmail.com", new DateTime(1971, 4, 25), 2000.0, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 8, 22), 6000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 8, 12), 8000.0, SaleStatus.Billed, s4);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 8, 1), 2000.0, SaleStatus.Canceled, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 8, 25), 5000.0, SaleStatus.Billed, s2);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2021, 8, 16), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 8, 10), 7000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2021, 8, 3), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 8, 9), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2021, 8, 25), 3000.0, SaleStatus.Pending, s5);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2021, 8, 17), 5000.0, SaleStatus.Billed, s3);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2021, 8, 8), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2021, 8, 23), 8000.0, SaleStatus.Pending, s2);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2021, 8, 12), 6000.0, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2021, 8, 5), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2021, 8, 20), 10000.0, SaleStatus.Billed, s6);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2021, 8, 15), 1000.0, SaleStatus.Billed, s2);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2021, 8, 13), 8000.0, SaleStatus.Canceled, s3);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2021, 8, 9), 7000.0, SaleStatus.Billed, s1);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2021, 8, 3), 3000.0, SaleStatus.Billed, s4);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2021, 8, 24), 6000.0, SaleStatus.Billed, s6);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2021, 8, 16), 11000.0, SaleStatus.Pending, s3);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2021, 8, 19), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2021, 8, 26), 10000.0, SaleStatus.Billed, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2021, 8, 10), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2021, 8, 15), 8000.0, SaleStatus.Billed, s2);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2021, 8, 22), 4000.0, SaleStatus.Billed, s6);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2021, 8, 8), 6000.0, SaleStatus.Canceled, s5);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2021, 8, 3), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2021, 8, 29), 5000.0, SaleStatus.Billed, s3);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2021, 8, 18), 3000.0, SaleStatus.Pending, s1);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}
