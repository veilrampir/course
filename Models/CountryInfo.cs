using System.Collections.Generic;

namespace course.Models
{
    internal class CountryInfo : PlaceInfo 
    { 
        public IEnumerable<ProvinceInfo> ProvinceCountd { get; set; }
    }


}


