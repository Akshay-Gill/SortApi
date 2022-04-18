using SortApi.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortApi.UnitTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public void CheckAscendingSort()
        {
            var logic = new Logic();

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
                },

                new Rectangle()
                {
                    Length = 10,
                    Width = 10
                }
            };

            var result = logic.SortRectangle(rectangles, "asc");
            Assert.Equals(1, result[0].Length);
            Assert.Equals(2, result[0].Width);

        }
        [TestMethod]
        public void CheckDescendingSort()
        {
            var logic = new Logic();

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
                },

                new Rectangle()
                {
                    Length = 10,
                    Width = 10
                }
            };

            var result = logic.SortRectangle(rectangles, "desc");
            Assert.Equals(10, result[0].Length);
            Assert.Equals(10, result[0].Width);

        }
    }
}
