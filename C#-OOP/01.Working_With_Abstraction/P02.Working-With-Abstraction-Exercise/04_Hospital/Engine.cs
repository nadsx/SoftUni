using System;
using System.Linq;

namespace Hospital
{
    public class Engine
    {
        private Hospital hospital;

        public Engine()
        {
            this.hospital = new Hospital();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "Output")
            {
                string[] inputArgs = command
                    .Split()
                    .ToArray();

                string departament = inputArgs[0];
                string firstName = inputArgs[1];
                string secondName = inputArgs[2];
                string patient = inputArgs[3];

                string fullName = firstName + " " + secondName;

                this.hospital.AddDoctor(firstName, secondName);
                this.hospital.AddDepartment(departament);
                this.hospital.AddPatient(fullName, departament, patient);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (args.Length == 1)
                {
                    string deparmentName = args[0];

                    Department department = this.hospital.Departments.FirstOrDefault(x => x.Name == deparmentName);

                    Console.WriteLine(department);
                }
                else if (args.Length == 2)
                {
                    bool isRoom = int.TryParse(args[1], out int targetRoom);

                    if (isRoom)
                    {
                        string deparmentName = args[0];

                        Room room = this.hospital.Departments.FirstOrDefault(x => x.Name == deparmentName).Rooms[targetRoom - 1];

                        Console.WriteLine(room);
                    }
                    else
                    {
                        string fullName = args[0] + " " + args[1];

                        Doctor doctor = this.hospital.Doctors.FirstOrDefault(x => x.FullName == fullName);

                        Console.WriteLine(doctor);
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
