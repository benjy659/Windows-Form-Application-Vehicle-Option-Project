    

namespace Business.Benjamin.Omoregie
{
    /// <summary>
    /// public class for quote with saleprice and taxrate properties.       
    /// 
   /// </summary>
    public class Quote
    {
        public decimal SalePrice {  get; set; }
        public decimal TaxRate { get; set; }

        /// <summary>
        /// Quote constructor with saleprice and taxrate parameters.
        /// </summary>
        /// <param name="saleprice"></param>
        /// <param name="taxrate"></param>
        public Quote(decimal saleprice, decimal taxrate)
        {
            SalePrice = saleprice;
            TaxRate = taxrate;
        }
        /// <summary>
        /// Default Quote constructor.
        /// </summary>
        public Quote()
        {
            SalePrice = 0;
            TaxRate= 0;
        }
        /// <summary>
        /// method to calculate salestax and total.
        /// </summary>
        /// <returns> total calculatioin</returns>
        public decimal CalculateSaleTax()
        { 
            return SalePrice * TaxRate;
        }
        /// <summary>
        /// method to calculate the totalcost.
        /// </summary>
        /// <returns> Total calculation</returns>
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
