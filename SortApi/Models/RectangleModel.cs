using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SortApi.Models
{
    public class RectangleModel
    {
        public class Rectangle
        {
            public float Height { get; set; }
            public float Width { get; set; }
        }
        public class Rectangles
        {
            public List<Rectangle> RectanglesList { get; set; }
        }
    }
}