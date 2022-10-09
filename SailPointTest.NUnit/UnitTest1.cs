using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using NUnit.Framework;
using SailPointTest.Core.Helper;
using SailPointTest.Core.Model;
using SailPointTest.Core.Repository;
using System.Collections.Generic;
using Unity;
using System.Linq;

namespace SailPointTest.NUnit
{
    public class Tests
    {
        protected UnityContainer container;
        [SetUp]
        public void Setup()
        {
            container = new UnityContainer();
            container.RegisterType<IRepository, Repository>();
            container.RegisterType<IAppSettings, AppSettings>();
        }

        [Test]
        public void Test1()
        {
            var repository = container.Resolve<Repository>();
            var result = repository.GetCities("a");
            bool check = CheckIfSearchOk(result , "a");
            Assert.True(check);
        }

        private bool CheckIfSearchOk(List<City> cities, string search)
        {
            int count = cities.Count;
            var res = cities.Where(x => x.Name.Contains(search)).ToList();

            if (count > 0 && res.Count == count)
            {
                return true;
            }
            return false;
        }
    }
}