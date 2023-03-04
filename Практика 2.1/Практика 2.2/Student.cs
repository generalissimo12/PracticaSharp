namespace Практика_2._2
{
    internal class Student
    {
        public string Surn
        {
            get;
            set;
        }
        public string Date
        {
            get;
            set;
        }
        public int Group
        {
            get;
            set;
        }
        public int[] Mark
        {
            get;
            set;
        }
        public Student()
        {
            Surn = "Подшибякин";
            Date = "12.11.2003";
            Group = 623;
            Mark = new int[] { 5, 4, 3, 4, 5, 3};
        }
    }
}