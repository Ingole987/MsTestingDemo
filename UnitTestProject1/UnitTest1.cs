using AdditionOf2Numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Demo program = new Demo();//1000
        [TestMethod]
        public void TestMethod1()
        {
            //A-> Arrangement  A->Act  A->Assert
            //Arrangement
            program = new Demo();
            //Act
            var result = program.Add(5, 10);
            Assert.AreEqual(15, result);
        }
    }
}
