using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Home_Work
{
    public class TestClass
    {
        [Test]
        public void checkExperienceLessThan0()
        {
            Employee empl = new Employee("Andrey", "Beloreckiy", 0, 0, 0);
            Assert.IsTrue(empl.getbonus_percent() == 0);
        }

        [Test]
        public void checkExperienceLessThan5()
        {
            Employee empl = new Employee("Nadezhda", "Yanovskaya", 4, 0, 0);
            Assert.IsTrue(empl.getbonus_percent() == 5);
        }

        [Test]
        public void checkExperienceLessThan10()
        {
            Employee empl = new Employee("Grigoriy", "Dubotovk", 5, 2, 0);
            Assert.IsTrue(empl.getbonus_percent() == 10);
        }


        [Test]
        public void checkExperienceLessThan15()
        {
            Employee empl = new Employee("Ales'", "Vorona", 6, 3, 0);
            Assert.IsTrue(empl.getbonus_percent() == 15);
        }


        [Test]
        public void checkExperienceLessThan20()
        {
            Employee empl = new Employee("Andrey", "Svetilovich", 7, 5, 0);
            Assert.IsTrue(empl.getbonus_percent() == 20);
        }



        [Test]
        public void broken()
        {
            Employee empl = new Employee("Andrey", "Svetilovich", 2, 5, 0);
            Assert.IsTrue(empl.getbonus_percent() == 20);
        }
    }
}
