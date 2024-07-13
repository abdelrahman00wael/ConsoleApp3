using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
        class Student
        {

            int id;
            string name;
            int age;

            public void setData(int id, string name = "Student", int age = 15)
            {
                this.id = id;
                this.name = name;
                this.age = age;

            }
            public void getData()
            {
                Console.WriteLine($"{name}  -  {id}  -  {age}");
            }
            public string is_over_age()
            {
                if (age > 60)
                    return "yes is over age";

                return "yes is not over age";
            }


        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Student s1 = new Student();
                Student s2 = new Student();

                s1.setData(63563, "abdelrahman", 20);
                s2.setData(357, "wael", 66);

                s1.getData();
                s2.getData();

                Console.WriteLine(s1.is_over_age());
                Console.WriteLine(s2.is_over_age());
            }
        }
    }