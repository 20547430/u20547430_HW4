using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20547430_HW4.Models
{
    public class ListRepository
    {
        //past paper
        

        public static readonly List<PastPaper> pastPapers = new List<PastPaper>
        {
            new PastPaper{Year=2021, Author= "Department of Basic Education", PaperNo=1, Province="South Africa", Subject="Consumer Studies", Title="NSC Consumer Studies", ExamType="November"},
            new PastPaper{Year=2021, Author= "Department of Basic Education", PaperNo=1, Province="South Africa", Subject="Consumer Studies", Title="NSC Consumer Studies", ExamType="November"},
            new PastPaper{Year=2021, Author= "Department of Basic Education", PaperNo=1, Province="South Africa", Subject="Consumer Studies", Title="NSC Consumer Studies", ExamType="November"},
            new PastPaper{Year=2021, Author= "Department of Basic Education", PaperNo=1, Province="South Africa", Subject="Consumer Studies", Title="NSC Consumer Studies", ExamType="November"},
            new PastPaper{Year=2021, Author= "Department of Basic Education", PaperNo=1, Province="South Africa", Subject="Consumer Studies", Title="NSC Consumer Studies", ExamType="November"},
            new PastPaper{Year=2021, Author= "Department of Basic Education", PaperNo=1, Province="South Africa", Subject="Consumer Studies", Title="NSC Consumer Studies", ExamType="November"},
            new PastPaper{Year=2021, Author= "Department of Basic Education", PaperNo=1, Province="South Africa", Subject="Consumer Studies", Title="NSC Consumer Studies", ExamType="November"},
        };

        //study guide

        public static readonly List<StudyGuide> studyGuides = new List<StudyGuide>
        {
            new StudyGuide{Subject="Accounting", Author="Department of Basic Education", Edition=2, ISBN="978-1-4315-1950--7", Title="(CAPS) Mind the Gap Grade 12 Study Guide Accounting"},
            new StudyGuide{Subject="Accounting", Author="Department of Basic Education", Edition=2, ISBN="978-1-4315-1950--7", Title="(CAPS) Mind the Gap Grade 12 Study Guide Accounting"},
            new StudyGuide{Subject="Accounting", Author="Department of Basic Education", Edition=2, ISBN="978-1-4315-1950--7", Title="(CAPS) Mind the Gap Grade 12 Study Guide Accounting"},
            new StudyGuide{Subject="Accounting", Author="Department of Basic Education", Edition=2, ISBN="978-1-4315-1950--7", Title="(CAPS) Mind the Gap Grade 12 Study Guide Accounting"},
            new StudyGuide{Subject="Accounting", Author="Department of Basic Education", Edition=2, ISBN="978-1-4315-1950--7", Title="(CAPS) Mind the Gap Grade 12 Study Guide Accounting"},
            new StudyGuide{Subject="Accounting", Author="Department of Basic Education", Edition=2, ISBN="978-1-4315-1950--7", Title="(CAPS) Mind the Gap Grade 12 Study Guide Accounting"},
            new StudyGuide{Subject="Accounting", Author="Department of Basic Education", Edition=2, ISBN="978-1-4315-1950--7", Title="(CAPS) Mind the Gap Grade 12 Study Guide Accounting"},

        };

        //textbook

        public static readonly List<Textbook> textbooks = new List<Textbook>
        {
            new Textbook{Subject="Mathematics(maths)", Author="Various Volunteers", Edition=1, ISBN="-", Title="Everything Grade 12 Maths"},
            new Textbook{Subject="Mathematics(maths)", Author="Various Volunteers", Edition=1, ISBN="-", Title="Everything Grade 12 Maths"},
            new Textbook{Subject="Mathematics(maths)", Author="Various Volunteers", Edition=1, ISBN="-", Title="Everything Grade 12 Maths"},
            new Textbook{Subject="Mathematics(maths)", Author="Various Volunteers", Edition=1, ISBN="-", Title="Everything Grade 12 Maths"},
            new Textbook{Subject="Mathematics(maths)", Author="Various Volunteers", Edition=1, ISBN="-", Title="Everything Grade 12 Maths"},
            new Textbook{Subject="Mathematics(maths)", Author="Various Volunteers", Edition=1, ISBN="-", Title="Everything Grade 12 Maths"},
            new Textbook{Subject="Mathematics(maths)", Author="Various Volunteers", Edition=1, ISBN="-", Title="Everything Grade 12 Maths"}

        };

    }
}