using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Benjamin.Omoregie
{
    public class Quote
    {
        public decimal SalePrice {  get; set; }
        public decimal TaxRate { get; set; }


        public Quote(decimal saleprice, decimal taxrate)
        {
            SalePrice = saleprice;
            TaxRate = taxrate;
        }
        public Quote()
        {
            SalePrice = 0;
            TaxRate= 0;
        }
        public decimal CalculateSaleTax()
        { 
            return SalePrice * TaxRate;
        }
        public decimal CalculateTotal()
        { 
            return SalePrice * CalculateSaleTax();
        }

        public override string ToString()
        {
            return $"Quote: {CalculateTotal():C}";
        }
    }
   
}
