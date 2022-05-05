using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace TimeSwap.Model
{
    public class User
    {
        private int id;
        private string lastName;
        private string firstName;
        private DateTime birthday;
        private string email;
        private string password;
        private string phone;
        private short earnedHours;
        private short spentHours;
        private short balance;
        private short performedServices;
        private short recievedServices;
        private string image;

        public User(){}

        public User(int id, string lastName, string firstName, DateTime birthday,
            string email, string password, string phone, short earnedHours, short spentHours,
            short balance, short performedServices, short recievedServices, string image)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Birthday = birthday;
            Email = email;
            Password = password;
            Phone = phone;
            EarnedHours = earnedHours;
            SpentHours = spentHours;
            Balance = balance;
            PerformedServices = performedServices;
            RecievedServices = recievedServices;
            Image = image;
        }

        public int Id { get => id; set => id = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Phone { get => phone; set => phone = value; }
        public short EarnedHours { get => earnedHours; set => earnedHours = value; }
        public short SpentHours { get => spentHours; set => spentHours = value; }
        public short Balance { get => balance; set => balance = value; }
        public short PerformedServices { get => performedServices; set => performedServices = value; }
        public short RecievedServices { get => recievedServices; set => recievedServices = value; }
        public string Image { get => image; set => image = value; }
    }
}