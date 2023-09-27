namespace TestProject1
{
    [TestClass]
    public class Class1Test
    {
        [TestMethod]
        public void AreCollectionsInOrder()
        {

            //arrange
            bool resutl = true;
            //act
            testpract.Class1 class1 = new testpract.Class1();
            List<int> collection1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> collection2 = new List<int> { 1, 2, 3, 4, 5 };
            bool actual = class1.CompareCollectionsByOrder(collection1, collection2);
            //assert
            Assert.AreEqual(resutl, actual);
        }
        [TestMethod]
        public void CompareCollectionsIgnoreOrder_12345_21345_true()
        {

            //arrange
            bool resutl = true;
            //act
            testpract.Class2 class2 = new testpract.Class2();
            List<int> collection1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> collection2 = new List<int> { 2, 1, 3, 4, 5 };
            bool actual = class2.CompareCollectionsIgnoreOrder(collection1, collection2);
            //assert
            Assert.AreEqual(resutl, actual);
        }
        [TestMethod]
        public void CalculatePercent_5_10_100()
        {

            //arrange
            double resutl = 100;
            //act
            testpract.Class3 class3 = new testpract.Class3();
            double initialValue = 5;
            double finalValue = 10;
            double actual = class3.CalculatePercent(initialValue, finalValue);
            //assert
            Assert.AreEqual(resutl, actual);
        }
    }
}