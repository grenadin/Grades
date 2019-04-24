namespace Grades
{

    //Hold only Gradestatistic information
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;//
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}