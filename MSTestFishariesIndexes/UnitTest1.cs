using FishariesIndexes;

namespace MSTestFishariesIndexes
{
    [TestClass]
    public class UnitTest1
    {
        Orders order = new Orders(119.99, "snoek", "chips", 2, "coke");

        [TestMethod]
        public void TestPrice()
        {
            double tPrice = 119.99;
            Assert.AreEqual(tPrice, order[0]);
        }

        [TestMethod]
        public void fTestFishType()
        {
            String fFishType = "hake";
            Assert.AreNotSame(fFishType, order[1]);
        }

        [TestMethod]
        public void TestSides()
        {
            String tSides = "chips";
            Assert.AreEqual(tSides, order[2]);
        }

        [TestMethod]
        public void fTestQuantity()
        {
            int fQuantity = 5;
            Assert.AreNotSame(fQuantity, order[3]);
        }

        [TestMethod]
        public void TestBeverage()
        {
            String tBeverage = "coke";
            Assert.AreEqual(tBeverage, order[4]);
        }

    }
}