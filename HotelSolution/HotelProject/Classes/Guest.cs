using System;

namespace HotelProject
{
    public class Guest
    {
        private int id;
        private string name;
        private DateTime birthDay;
        private bool hasAnimals;
        private string status;
        private short roomNumber;

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public DateTime BirthDay
        {
            get { return birthDay; }
        }

        public bool HasAnimals
        {
            get { return hasAnimals; }
        }

        public string Status
        {
            get { return status; }
        }

        public short RoomNumber
        {
            get { return roomNumber; }
        }

        public Guest(int id, string name, DateTime birthDay, bool hasAnimals, string status, short roomNumber)
        {
            this.id = id;
            this.name = name;
            this.birthDay = birthDay;
            this.hasAnimals = hasAnimals;
            this.status = status;
            this.roomNumber = roomNumber;
        }
    }
}
