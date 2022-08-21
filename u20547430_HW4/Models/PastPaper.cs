using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20547430_HW4.Models
{
    public class PastPaper : Resource
    {
        public int Year { get; set; }
        public string Province { get; set; }
        public int PaperNo { get; set; }

        public PastPaper() { }

        public PastPaper(int _year, string _province, int _paperNo ,string _title, string _author, string _subject)
            : base(_author, _title, _subject)
        {
           
            Year = _year;
            Province = _province;
            PaperNo = _paperNo;
        }
    

       public override sealed string GetInfo()
        {
            return $"Author: {Author}</br>Subject: {Subject}</br>Year: {Year}</br>Province: {Province}</br>Paper Number: {PaperNo}</br>P";
        }

        public override sealed string ToString()
        {
            return "PastPaper";
        }
    }
}
    
