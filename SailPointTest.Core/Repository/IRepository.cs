using SailPointTest.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SailPointTest.Core.Repository
{
    public interface IRepository
    {

        List<City> GetCities(string search);
    }
}
