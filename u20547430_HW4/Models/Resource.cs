using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20547430_HW4.Models
{
    public abstract class Resource //base
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }

        //public Image Image { get; set; }
        //public SelectList selectList { get; set; }

        //constuctors 
        public Resource() { }
        public Resource(string _title, string _author, string _subject) 
        {
            Title = _title;
            Author = _author;
            Subject = _subject;
        }
        public abstract string GetInfo();
        public abstract override string ToString();
    }
}