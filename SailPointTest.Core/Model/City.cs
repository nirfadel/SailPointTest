using System;
using System.Collections.Generic;
using System.Text;

namespace SailPointTest.Core.Model
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string SubCountry { get; set; }
        public int GeoNameId { get; set; }
    }
}
