using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    public class TeachersSub
    {
        public Teacher Teacher { get; set; }
        public List<Subject> Subjects { get; set; }

        public TeachersSub()
        {
            Subjects = new List<Subject>();
        }
    }
}
