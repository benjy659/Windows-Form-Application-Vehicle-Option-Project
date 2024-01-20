
/*
 *Name: Benjamin Omoregie
 * Program: Business Information Technology
 * Course: ADEV - 2008 Programming 2
 * Created: 2024 - 01 - 19
 * Updated: 2024 - 01 - 19
 */

namespace Business.Benjamin.Omoregie
{
    /// <summary>
    /// public class for vehcile object with properties.
    /// </summary>
    public class Vehicle
    {
        private int Year { get; set; }
        private string Model { get; set; }
        private string Manufacturer { get; set; }
        private PaintColor Color { get; set; }
        private decimal SalePrice { get; set; }

        /// <summary>
        /// intializes the properties of the vehicle object.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="model"></param>
        /// <param name="manufacturer"></param>
        /// <param name="color"></param>
        /// <param name="saleprice"></param>
        public Vehicle(int year, string model, string manufacturer, PaintColor color, decimal saleprice)
        {
            Year = year;
            Model = model;
            Manufacturer = manufacturer;
            Color = color;
            SalePrice = saleprice;
        }
        /// <summary>
        /// default string constructor.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Year},{Manufacturer},{Model},{Color}";
        }
    }   
    

}
