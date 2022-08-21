using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20547430_HW4.Models
{
    public class StudyGuide: Resource
    {
        public int Edition { get; set; }
        public string ISBN { get; set; }

        public StudyGuide() { }

        public StudyGuide(int _edition, string _isbn, int _paperNo, string _title, string _author, string _subject)
            : base(_author, _title, _subject)
        {

            Edition = _edition;
            ISBN = _isbn;
        }


        public override sealed string GetInfo()
        {
            return $"Author: {Author}</br>Subject: {Subject}</br>Edition: {Edition}</br>Province: {ISBN}</br>P";
        }

        public override sealed string ToString()
        {
            return "PastPaper";
        }
    }
}
    
