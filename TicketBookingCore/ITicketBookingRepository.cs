using System;
using System.Collections.Generic;
using System.Text;

namespace TicketBookingCore
{
    public interface ITicketBookingRepository
    {
        void Save(TicketBooking ticket);
    }
}
