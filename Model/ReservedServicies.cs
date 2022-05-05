using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeSwap.Model
{
    public class ReservedServicies
    {
        private string title;
        private DateTime reservationDate;
        private short duration;
        private string user;
        private string img;

        public ReservedServicies() { }

        public ReservedServicies(DateTime reservationDate, string title, short duration, string user, string img)
        {
            Title = title;
            ReservationDate = reservationDate;
            Duration = duration;
            UserRes = user;
            Img = img;
        }

        public DateTime ReservationDate { get => reservationDate; set => reservationDate = value; }
        public string Title { get => title; set => title = value; }
        public short Duration { get => duration; set => duration = value; }
        public string UserRes { get => user; set => user = value; }
        public string Img { get => img; set => img = value; }

    }
}