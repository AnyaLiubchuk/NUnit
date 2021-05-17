using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work
{
    class Employee
    {
        private string name;
        private string surname;
        private int work_experience;
        private int qualification;
        private int bonus_percent;

        public Employee(string name, string surname, int work_experience, int qualification, int bonus_percent)
        {
            this.name = name;
            this.surname = surname;
            this.work_experience = work_experience;
            this.qualification = qualification;
            this.bonus_percent = bonus_percent;
            PrintAll();
        }
        public void PrintAll()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surmane: " + surname);
            Console.WriteLine("Work experience (years): " + work_experience);
            Console.WriteLine("Qualification: " + qualification);

        }

        public int getbonus_percent()
        {
            if (work_experience < 1)
            {
                this.bonus_percent = 0;

            }
            else if (work_experience >= 1 && work_experience < 5)
            {
                this.bonus_percent = 5;
            }
            else if (work_experience >= 5 && qualification < 3)
            {
                this.bonus_percent = 10;
            }

            else if (work_experience > 5 && qualification >= 3 && qualification <= 4)
            {
                this.bonus_percent = 15;
            }
            else if (qualification == 5 && work_experience > 5)
            {
                this.bonus_percent = 20;
            }
            else
            {
                Console.WriteLine("Error!");
                this.bonus_percent = 0;
            }
            return this.bonus_percent;
        }


    }
}
