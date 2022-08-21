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
            new PastPaper{Year=2021, Author= "Department of Basic Education", PaperNo=2, Province="South Africa", Subject="Physical SCiences", Title="NSC Physical Sciences", ExamType="November"},
            new PastPaper{Year=2021, Author= "Department of Basic Education", PaperNo=1, Province="Gauteng", Subject="English", Title="NSC English Home Language", ExamType="June"},
            new PastPaper{Year=2021, Author= "Department of Basic Education", PaperNo=1, Province="South Africa", Subject="Accounting", Title="NSC Accounting", ExamType="Preliminary"},
            new PastPaper{Year=2021, Author= "Department of Basic Education", PaperNo=1, Province="Western Province", Subject="Life Sciences", Title="NSC Life Sciences", ExamType="November"},
            new PastPaper{Year=2021, Author= "Department of Basic Education", PaperNo=3, Province="South Africa", Subject="Afrikaans", Title="NSC Afrikaans First Additional Language", ExamType="Expemplar"},
            new PastPaper{Year=2021, Author= "Department of Basic Education", PaperNo=1, Province="South Africa", Subject="History", Title="NSC History", ExamType="November"},
        };

        //study guide

        public static readonly List<StudyGuide> studyGuides = new List<StudyGuide>
        {
            new StudyGuide{Subject="Accounting", Author="Department of Basic Education", Edition=2, ISBN="978-1-4315-1950--7", Title="(CAPS) Mind the Gap Grade 12 Study Guide Accounting"},
            new StudyGuide{Subject="Accounting", Author="Department of Basic Education", Edition=2, ISBN="978-1-4315-1950--7", Title="(CAPS) Mind the Gap Grade 12 Study Guide Life Sciences"},
            new StudyGuide{Subject="Accounting", Author="Department of Basic Education", Edition=2, ISBN="978-1-4315-1950--7", Title="(CAPS) Mind the Gap Grade 12 Study Guide Physical Sciences"},
            new StudyGuide{Subject="Accounting", Author="Department of Basic Education", Edition=2, ISBN="978-1-4315-1950--7", Title="(CAPS) Mind the Gap Grade 12 Study Guide Mathematics"},
            new StudyGuide{Subject="Accounting", Author="Department of Basic Education", Edition=2, ISBN="978-1-4315-1950--7", Title="(CAPS) Mind the Gap Grade 12 Study Guide Business Studies"},
            new StudyGuide{Subject="Accounting", Author="Department of Basic Education", Edition=2, ISBN="978-1-4315-1950--7", Title="(CAPS) Mind the Gap Grade 12 Study Guide Geography"},
            new StudyGuide{Subject="Accounting", Author="Department of Basic Education", Edition=2, ISBN="978-1-4315-1950--7", Title="(CAPS) Mind the Gap Grade 12 Study Guide Mathematical Literacy"},

        };

        //textbook

        public static readonly List<Textbook> textbooks = new List<Textbook>
        {
            new Textbook{Subject="Mathematics(maths)", Author="Various Volunteers", Edition=1, ISBN="-", Title="Everything Grade 12 Maths"},
            new Textbook{Subject="Mathematics(maths)", Author="Various Volunteers", Edition=1, ISBN="-", Title="Everything Grade 12 Science: Life Sciences"},
            new Textbook{Subject="Mathematics(maths)", Author="Various Volunteers", Edition=1, ISBN="-", Title="Everything Grade 12 Science: Physical Sciences"},

        };

    }
}