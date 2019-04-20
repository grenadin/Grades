using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
    class GradeBook
    {
        private List<float> _grades;

        public void AddGrade(float grade)
        {
            _grades.Add(grade);
        }

        
    }
}
