using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    public class SchoolFacede
    {
        private SchoolDataStroage _dataStorage;

        public SchoolFacede()
        {
            _dataStorage = SchoolDataStroage.GetInstance();
        }

        public void AddStudent(Student student)
        {
            _dataStorage.Students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            _dataStorage.Teachers.Add(teacher);
        }

        public void AddSubject(Subject subject)
        {
            _dataStorage.Subjects.Add(subject);
        }

        public List<Student> GetStudentsInClass(string className)
        {
            return _dataStorage.Students.Where(s => s.Class == className).ToList();
        }

        public List<Subject> GetSubjectsTaughtByTeacher(string teacherName)
        {
            var teacher = _dataStorage.Teachers.FirstOrDefault(t => t.Name == teacherName);
            if (teacher != null)
            {
                return _dataStorage.Subjects.Where(s => s.Teacher == teacher).ToList();
            }
            return new List<Subject>();
        }

        public Teacher GetTeacherByName(string teacherName)
        {
            return _dataStorage.Teachers.FirstOrDefault(t => t.Name == teacherName);
        }
    }


}
