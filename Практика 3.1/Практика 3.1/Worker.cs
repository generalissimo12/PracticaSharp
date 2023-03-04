using System;
using System.Reflection.Metadata;
namespace Практика_3._1
{
    internal class Worker
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Rate { get; set; }

        public int Days { get; set; }


        public Worker()
        {
            Name = "Ivan";
            Surname = "Ivanov";
            Rate = 1378;
            Days = 15;
        }
        public void GetSalary()
        {
            Console.WriteLine($"Зарплата сотрудника {Name} {Surname} составляет {Rate * Days}");
        }


    }
}

