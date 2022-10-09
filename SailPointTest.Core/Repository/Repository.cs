using SailPointTest.Core.DB;
using SailPointTest.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SailPointTest.Core.Helper;

namespace SailPointTest.Core.Repository
{
    public class Repository : IRepository
    {
        private readonly SailPointDBContext _sailPointDBContext;
        protected readonly IAppSettings _appSettings;
        public Repository(SailPointDBContext sailPointDBContext, IAppSettings appSettings)
        {
            _sailPointDBContext = sailPointDBContext;
            _appSettings = appSettings;
        }
        public List<City> GetCities(string search)
        {
            int top = 10;
            if(_appSettings.TopNumber > 0)
            {
                top = _appSettings.TopNumber;
            }
            List<City> cities = new List<City>();

            using (_sailPointDBContext)
            {
                cities = _sailPointDBContext.Cities.Where(x => x.Name.Contains(search))
                    .OrderBy(c=>c.Name).Take(top).ToList();
            }

            return cities;
        }
    }
}
