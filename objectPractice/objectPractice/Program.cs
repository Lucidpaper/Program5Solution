using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            Course course2 = new Course("seedpath", "A");
            Console.WriteLine(course1.Name);
            Console.WriteLine(course2.Name);
            Console.ReadKey();
        }

    }
    class Course
    {
        private string _name;    
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _gradePoints;
        public int GradePoints
        {
            get { return _gradePoints; }
        }

        private string _letterGrade;
        public string LetterGrade
        {
            get { return _letterGrade; }
            set 
            {
                _letterGrade = value.ToUpper();
                switch (_letterGrade)
                {
                    case "A":
                       _gradePoints = 4;
                        break;
                    case "B":
                        _gradePoints = 3;
                        break;
                    case "C":
                        _gradePoints = 2;
                        break;
                    case "D":
                        _gradePoints = 1;
                        break;
                    case "F":
                        _gradePoints = 0;
                        break;
                    default:
                        _gradePoints = 0;
                        break;
                }
            }
        }

        public Course()
        {
            this.Name = "Undefined";
            this.LetterGrade = "F";
        }

        public Course(string courseName, string letterGrade)
        {
            this.Name = courseName;
            this.LetterGrade = letterGrade;
        }
    }
}
