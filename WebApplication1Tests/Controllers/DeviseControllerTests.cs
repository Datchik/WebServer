using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers.Tests
{
    [TestClass()]
    public class DeviseControllerTests
    {
        public List<Models.Devise> deviseList;

        [TestInitialize]
        public void InitialisationTest()
        {
            deviseList = new List<Models.Devise>();
            Models.Devise deviseDollar = new Models.Devise(1, "Dollar", 1.08);
            Models.Devise deviseFSuisse = new Models.Devise(2, "Franc Suisse", 1.07);
            Models.Devise deviseYen = new Models.Devise(3, "Yen", 120);
            deviseList.Add(deviseDollar);
            deviseList.Add(deviseFSuisse);
            deviseList.Add(deviseYen);
        }

        [TestMethod]
        public void Get()
        {
            // Réorganiser
            DeviseController controller = new DeviseController();

            // Agir
            IEnumerable<Devise> result = controller.Get();

            // Déclarer
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
            CollectionAssert.Equals(deviseList, result.ToList());
        }
    }
}