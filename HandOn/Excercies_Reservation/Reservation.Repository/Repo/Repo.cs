using Reservation.Repository.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Repository.Repo
{
    public class Repo : IRepo
    {
        private Dictionary<int, Reservations> items;

        public Repo()
        {
            items = new Dictionary<int, Reservations>();
            new List<Reservations> {
                new Reservations {Id=1, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservations {Id=2, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservations {Id=3, Name = "Jacky", StartLocation = "London", EndLocation="Paris" }
                }.ForEach(r => AddReservation(r));
        }

        public Reservations this[int id] => items.ContainsKey(id) ? items[id] : null;

        public IEnumerable<Reservations> Reservations => items.Values;

        public Reservations AddReservation(Reservations reservation)
        {
            if (reservation.Id == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; };
                reservation.Id = key;
            }
            items[reservation.Id] = reservation;
            return reservation;
        }

        public void DeleteReservation(int id) => items.Remove(id);

        public Reservations UpdateReservation(Reservations reservation) => AddReservation(reservation);
    }
}
