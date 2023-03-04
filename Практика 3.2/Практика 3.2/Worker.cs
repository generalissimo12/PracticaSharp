using System;
namespace Практика_3._2
{
    internal class Worker
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Rate { get; set; }

        public int Days { get; set; }



        public Worker()
        {
            Name = "Ivan ivanov";
            Surname = "Bateman";
            Rate = 1378;
            Days = 15;
        }
        public void GetSalary()
        {
            Console.WriteLine($"Зарплата сотрудника {Name} {Surname} составляет {Rate * Days}");
        }


    }
}
