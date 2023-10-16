using Reservation.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Repository
{
    public interface IRepo
    {
        IEnumerable<Reservations> Reservations { get; }
        Reservations this[int id] { get; }
        Reservations AddReservation(Reservations reservation);
        Reservations UpdateReservation(Reservations reservation);
        void DeleteReservation(int id);
    }
}
