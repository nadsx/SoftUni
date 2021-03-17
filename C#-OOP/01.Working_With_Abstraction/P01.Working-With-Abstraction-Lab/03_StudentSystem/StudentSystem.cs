using System;
using System.Linq;

namespace _03_StudentSystem
{
    public class StudentSystem
    {
        private StudentsRepository students;

        public StudentSystem()
        {
            students = new StudentsRepository();
        }

        public void ParseCommands()
        {
            while (true)
            {
                string[] args = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = args[0];

                if (command == "Create")
                {
                    Create(args);
                }
                else if (command == "Show")
                {
                    Show(args);

                }
                else if (command == "Exit")
                {
                    return;
                }
            }
        }

        private void Show(string[] args)
        {
            string name = args[1];

            Student student = students.Find(name);

            if (student != null)
            {
                Console.WriteLine(student);
            }
        }

        private void Create(string[] args)
        {
            string name = args[1];
            int age = int.Parse(args[2]);
            double grade = double.Parse(args[3]);

            students.Add(name, age, grade);
        }
    }
}
