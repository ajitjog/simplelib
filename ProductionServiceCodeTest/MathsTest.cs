using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductionServiceCode;

namespace ProductionServiceCodeTest
{
    [TestClass]
    public class MathsTest
    {
        [TestMethod]
        public void TestAdd()
        {
            Maths m = new Maths();  
            Assert.IsNotNull(m);

            int r = m.Add(10, 20);

            Assert.AreEqual(30, r); 
        }
       
        [TestMethod]
        public void TestMultiply()
        {
            Maths m = new Maths();
            Assert.IsNotNull(m);

            int r = m.Multiply(10, 20);

            Assert.AreEqual(200, r);
        }
    }
}
