using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetNameTest()
        {
            TaskList taskList = new TaskList("test");

            Assert.AreEqual("test", taskList.GetName());
        }
    }
}
