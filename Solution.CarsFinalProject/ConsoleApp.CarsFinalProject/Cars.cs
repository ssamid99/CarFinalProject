using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CarsFinalProject
{
    internal class Cars:Models
    {
        static int counter = 0;
        public Cars()
        {
            CarId = ++ counter;
        }
        public int CarId { get; set; }
        public DateTime Year { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        //FuelTypes m = new FuelTypes();
        public override string ToString()
        {
            return $"Model Nº: {ModelId} | Marka adi: {BrandName} | Model adi: {ModelName} | Avtomobil Nº: {CarId} | Buraxiliş Ili: {Year} | " +
                $"Qiyməti: {Price} | Mühərrik həcmi: {Engine} ";
        }
    }
    //enum FuelTypes:byte
    //{
    //    Benzin = 1,
    //    Gas,
    //    Diesel,
    //    Hybrid,
    //    Electric
    //}
}
