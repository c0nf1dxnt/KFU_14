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
        private string paymentType;
        private DateTime dayOfArrival;
        private DateTime dayOfDeparture;

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

        public string PaymentType
        {
            get { return paymentType; }
        }

        public DateTime DayOfArrival
        {
            get { return dayOfArrival; }
        }
        public DateTime DayOfDeparture
        {
            get { return dayOfDeparture; }
        }

        public Guest(int id, string name, DateTime birthDay, bool hasAnimals, string status, short roomNumber,
            string paymentType, DateTime dayOfArrival, DateTime dayOfDeparture)
        {
            this.id = id;
            this.name = name;
            this.birthDay = birthDay;
            this.hasAnimals = hasAnimals;
            this.status = status;
            this.roomNumber = roomNumber;
            this.paymentType = paymentType;
            this.dayOfArrival = dayOfArrival;
            this.dayOfDeparture = dayOfDeparture;
        }
    }
}
