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
    class DeviseControllerTest
    {
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
            Assert.AreEqual("1", result.ElementAt(0));
            Assert.AreEqual("2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Réorganiser
            DeviseController controller = new DeviseController();

            // Agir
            string result = controller.Get(5);

            // Déclarer
            Assert.AreEqual(List, 3);
        }

        [TestMethod]
        public void Post()
        {
            // Réorganiser
            DeviseController controller = new DeviseController();

            // Agir
            controller.Post("value");

            // Déclarer
        }

        [TestMethod]
        public void Put()
        {
            // Réorganiser
            DeviseController controller = new DeviseController();

            // Agir
            controller.Put(5, "value");

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
