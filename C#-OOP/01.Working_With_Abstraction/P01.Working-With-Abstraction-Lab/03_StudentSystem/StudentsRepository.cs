using System.Collections.Generic;

namespace _03_StudentSystem
{
    public class StudentsRepository
    {
        private Dictionary<string, Student> repository;

        public StudentsRepository()
        {
            repository = new Dictionary<string, Student>();
        }

        public void Add(string name, int age, double grade)
        {
            if (!repository.ContainsKey(name))
            {
                Student student = new Student(name, age, grade);
                repository[name] = student;
            }
        }

        public Student Find(string name)
        {
            if (repository.ContainsKey(name))
            {
                return repository[name];
            }

            return null;
        }
    }
}
