using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoWebAapp.Controllers;
using System.Web.Mvc;

namespace ToDoWebAapp.Tests
{
    [TestClass]
    public class MyVewTest
    {
        [TestMethod]
        public void MyTestView()
        {
            var controller = new MyTestController();
            var result = controller.MyTest(1) as ViewResult; 

        }
    }
}
