using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using SortApi.Controllers;
using FakeItEasy;
using System.Web.Http.Results;
using SortApi.Models;
using Moq;
using SortApi.Business;
using System.Data.Objects;

namespace SortApi.UnitTests
{
    [TestClass]
    public class Test_SortArea
    {
        [TestMethod]
        public void SortingRectangles_returnsTrue()
        {
            var logic = new Mock<ILogic>();
            var controller = new ValuesController(logic.Object);

            var rectangles = new List<Rectangle>
            {
                new Rectangle()
                {
                    Length = 5,
                    Width = 10
                },
                new Rectangle()
                {
                    Length = 1,
                    Width = 2
                }
            };

            var result = controller.SortArea(rectangles, "abc");
            Assert.IsInstanceOfType(result, typeof(BadRequestResult));

        }

        [TestMethod]
        public void Get_Exception_ThrowsInternalServerError()
        {
            var logic = new Mock<ILogic>();
            var controller = new ValuesController(logic.Object);

            var rectangles = new List<Rectangle>
            {
                new Rectangle()
                {
                    Length = 5,
                    Width = 10
                },
                new Rectangle()
                {
                    Length = 1,
                    Width = 2
                }
            };

            logic.Setup(x => x.SortRectangle(rectangles, "asc")).Throws(new Exception());

            var result = controller.SortArea(rectangles, "asc");

            Assert.IsTrue(result.StatusCode.ToString() == "500");
        }

        
    }
}
