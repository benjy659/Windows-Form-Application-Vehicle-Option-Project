using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Name: Benjamin Omoregie
 * Program: Business Information Technology
 * Course: ADEV - 2008 Programming 2
 * Created: 2024 - 01 - 19
 * Updated: 2024 - 03 - 19
 */

namespace Business.Benjamin.Omoregie
{
    /// <summary>
    /// 
    /// </summary>
    public class Vehicle
    {
        private int Year { get; set; }
        private string Model { get; set; }
        private string Manufacturer { get; set; }
        private PaintColor Color { get; set; }
        private decimal SalePrice { get; set; }


        public Vehicle(int year, string model, string manufacturer, PaintColor color, decimal saleprice)
        {
            Year = year;
            Model = model;
            Manufacturer = manufacturer;
            Color = color;
            SalePrice = saleprice;
        }

        public override string ToString()
        {
            return $"{Year},{Manufacturer},{Model},{Color}";
        }
    }   
    

}
