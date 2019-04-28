using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Person
    {
        public static int num = 1;

        public void Count()
        {
            num++;
        }
        public int GetNum()
        {
            return num;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthday { get; set; }
        public string Card_ID { get; set; }
    }
}
