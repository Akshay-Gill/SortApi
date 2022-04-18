using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using static SortApi.Models.RectangleModel;
using SortApi.Controllers;
using FakeItEasy;

namespace SortApi.UnitTests
{
    [TestClass]
    public class Test_SortArea
    {
        [TestMethod]
        public void SortingRectangles_returnsTrue()
        {
            //Arrange
            Rectangles rectangles = new Rectangles();
            List<Rectangle> list = new List<Rectangle>();
            List<Rectangle> expected_response = new List<Rectangle>();


            Rectangle r1 = new Rectangle();
            r1.Height = 2;
            r1.Width = 4;

            Rectangle r2 = new Rectangle();
            r2.Height = 55;
            r2.Width = 0;

            Rectangle r3 = new Rectangle();
            r2.Height = 9;
            r2.Width = 9;

            Rectangle r4 = new Rectangle();
            r2.Height = 1;
            r2.Width = 6;

            list.Add(r1);
            list.Add(r2);
            list.Add(r3);
            list.Add(r4);
            expected_response.Add(r2);
            expected_response.Add(r4);
            expected_response.Add(r1);
            expected_response.Add(r3);
            //HttpResponseMessage Expected_Response = 
            //Act
            ValuesController valuesController = new ValuesController();
            HttpResponseMessage Response = valuesController.SortArea(list);

            //Asset
            List<Rectangle> list01 = new List<Rectangle>();
            Assert.IsTrue(Response.TryGetContentValue<List<Rectangle>>(out list01));
            Assert.AreEqual(expected_response,list01);
        }

        //[TestMethod]
        //public void InvalidCheck_returnsTrue()
        //{
        //    //Arrange
        //    Rectangles rectangles = new Rectangles();
        //    List<Rectangle> list = new List<Rectangle>();

        //    Rectangle r_valid = new Rectangle();
        //    r_valid.Height = 2;
        //    r_valid.Width = 4;

        //    Rectangle r_invalid = new Rectangle();
        //    r_invalid.Height = -2;
        //    r_invalid.Width = -4;

        //    list.Add(r_valid);
        //    list.Add(r_invalid);

        //    //HttpResponseMessage Expected_Response = 
        //    //Act
        //    ValuesController valuesController = new ValuesController();
        //    HttpResponseMessage Response = valuesController.SortArea(list);
        //    //Asset
        //    Assert.IsTrue(Response.StatusCode == System.Net.HttpStatusCode.Forbidden);
        //}
    }
}
