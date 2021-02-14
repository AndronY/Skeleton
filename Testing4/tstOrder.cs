using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class TstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            Assert.IsNotNull(AnOrder);
        }
    }
}
