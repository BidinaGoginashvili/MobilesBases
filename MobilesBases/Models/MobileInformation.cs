using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobilesBases.Models
{
    public class MobileInformation
    {
        public int Id { get; set; }
        public ManufacturerInformation MF { get; set; }
        public int MobileManufacturerId { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }
        public int ScreenSize { get; set; }
        public string Processor { get; set; }
        public string Memory { get; set; }
        public string OperationalSystem { get; set; }
        public double Price { get; set; }
        public string Imagepath { get; set; }
        public string Videopath { get; set; }
    }
}