using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MobilesBases.Models;
namespace MobilesBases.ViewModel
{
    public class MobileInformationViewModel
    {
        public IEnumerable<ManufacturerInformation> Mff { get; set; }
        public MobileInformation Mii { get; set; }
    }
}