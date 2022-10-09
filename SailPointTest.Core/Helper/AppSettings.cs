using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailPointTest.Core.Helper
{
    public class AppSettings : IAppSettings
    {
        public AppSettings()
        {

        }
        public int TopNumber { get; set; }
    }
}
