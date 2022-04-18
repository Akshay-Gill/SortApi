using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SortApi.Models
{
    public class Rectangle
    {
        [Required]
        public double Length { get; set; }
        [Required]
        public double Width { get; set; }

    }
}