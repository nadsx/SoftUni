using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class Department
    {
        public Department(string name)
        {
            this.Name = name;
            this.Rooms = new List<Room>();
            this.CreateRooms();
        }

        public string Name { get; set; }

        public List<Room> Rooms { get; set; }

        public void AddPatientInRoom(Patient patient)
        {
            Room currentRoom = this.Rooms.FirstOrDefault(r => !r.IsFull);

            if (currentRoom != null)
            {
                currentRoom.AddPatient(patient);
            }
        }

        private void CreateRooms()
        {
            for (int i = 0; i < 20; i++)
            {
                this.Rooms.Add(new Room());
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var room in this.Rooms)
            {
                foreach (var patient in room.Patients)
                {
                    sb.AppendLine(patient.Name);
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
