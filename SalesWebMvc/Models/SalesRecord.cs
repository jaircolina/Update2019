using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amaunt { get; set; }
        public SaleStatus Stauts { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amaunt, SaleStatus stauts, Seller seller)
        {
            Id = id;
            Date = date;
            Amaunt = amaunt;
            Stauts = stauts;
            Seller = seller;
        }
    }
}
