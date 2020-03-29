using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
namespace Vsite.oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestGrid
    {
        [TestMethod]
        public void GetAvaillablePlacmentForShipReturns2PlacmentsForShipOfLength3InHorizontalGrid1x4()
        {
            Grid g = new Grid(1, 4);
            var result = g.GetAvailablePlacments(3);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual(3, result.First().Count());
            Assert.AreEqual(3, result.Last().Count());
        }

        [TestMethod]
        public void GetAvaillablePlacmentForShipReturns3PlacmentsForShipOfLength3InVerticalGrid5x1()
        {
            Grid g = new Grid(5, 1);
            var result = g.GetAvailablePlacments(3);
            Assert.AreEqual(3, result.Count());
            foreach (var sequence in result)

                Assert.AreEqual(3, result.Last().Count());
        }
    }
}
