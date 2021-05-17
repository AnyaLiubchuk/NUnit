using System;

namespace Home_Work
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee Andrey_Beloreckiy = new Employee("Andrey", "Beloreckiy", 15, 2, 0);
            int w = Andrey_Beloreckiy.getbonus_percent();
            Console.WriteLine("Bonus percent: " + w);
            Console.WriteLine();

            Employee Nadezhda_Yanovskaya = new Employee("Nadezhda", "Yanovskaya", 4, 0, 0);
            int s = Nadezhda_Yanovskaya.getbonus_percent();
            Console.WriteLine("Bonus persent: " + s);
            Console.WriteLine();

            Employee Grigoriy_Dubotovk = new Employee("Grigoriy", "Dubotovk", 5, 2, 0);
            int x = Grigoriy_Dubotovk.getbonus_percent();
            Console.WriteLine("Bonus persent: " + x);
            Console.WriteLine();

            Employee Ales_Vorona = new Employee("Ales'", "Vorona", 6, 3, 0);
            int e = Ales_Vorona.getbonus_percent();
            Console.WriteLine("Bonus persent: " + e);
            Console.WriteLine();

            Employee Andrey_Svetilovich = new Employee("Andrey", "Svetilovich", 7, 5, 0);
            int d = Andrey_Svetilovich.getbonus_percent();
            Console.WriteLine("Bonus persent: " + d);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
