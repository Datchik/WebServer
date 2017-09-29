using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace WebApplication1.Tests.Controllers
{
    [TestClass]
    class DeviseControllerTest
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
            Assert.AreEqual(new Devise(1, "Dollar", 1.08), result.ElementAt(0));
            Assert.AreEqual(new Devise(2, "Franc Suisse", 1.07), result.ElementAt(1));
            Assert.AreEqual(new Models.Devise(3, "Yen", 120), result.ElementAt(2));
        }

        [TestMethod]
        public void GetById()
        {
            // Réorganiser
            DeviseController controller = new DeviseController();

            // Agir
            //string result = controller.Get(5);

            // Déclarer
            Assert.AreEqual(4, 3);
        }

        [TestMethod]
        public void Post()
        {
            // Réorganiser
            DeviseController controller = new DeviseController();

            // Agir
            //controller.Post("value");

            // Déclarer
        }

        [TestMethod]
        public void Put()
        {
            // Réorganiser
            DeviseController controller = new DeviseController();

            // Agir
            //controller.Put(5, "value");

            // Déclarer
        }

        [TestMethod]
        public void Delete()
        {
            // Réorganiser
            DeviseController controller = new DeviseController();

            // Agir
            controller.Delete(5);

            // Déclarer
        }
    }
}
