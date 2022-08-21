using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20547430_HW4.Models
{
    public class PastPaper: Resource
    {
        public int Year { get; set; }
        public string Provine { get; set; }
        public int PaperNo { get; set; }


        public PastPaper() { }

        public Manga(int _Volume, string _Studio, string _Title, string _Author, double _Price, string _Genre, string _ISBN)
        {
            base.Title = _Title;
            base.Author = _Author;
            base.Price = _Price;
            base.Genre = _Genre;
            base.ISBN = _ISBN;

            this.Volume = _Volume;
            this.Studio = _Studio;
        }

        public override sealed string GetInfo()
        {
            return $"Author: {Author}</br>Genre: {Genre}</br>Volume: {Volume}</br>Studio: {Studio}</br>ISBN: {ISBN}</br>Price: R{Price}</br>";
        }

        public override sealed string ToString()
        {
            return "Manga";
        }
    }
}
    
