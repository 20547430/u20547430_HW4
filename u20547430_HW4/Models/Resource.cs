using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20547430_HW4.Models
{
    public abstract class Resource
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Subject { get; set; }

        //public Image Image { get; set; }
    }
}