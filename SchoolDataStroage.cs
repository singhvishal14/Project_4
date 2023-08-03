using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    public class SchoolDataStroage
    {
        private static SchoolDataStroage _instance;
        public List<Student> Students { get; private set; }
        public List<Teacher> Teachers { get; private set; }
        public List<Subject> Subjects { get; private set; }

        private SchoolDataStroage()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
            Subjects = new List<Subject>();
        }

        public static SchoolDataStroage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SchoolDataStroage();
            }
            return _instance;
        }
    }
}
