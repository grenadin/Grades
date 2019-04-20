namespace Grades
{

    //Hold only Gradestatistic information
    internal class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;//
        }

        internal float AverageGrade;
        internal float HighestGrade;
        internal float LowestGrade;
    }
}