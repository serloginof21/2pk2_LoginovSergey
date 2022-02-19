using System;

namespace pz2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingTicket pt1 = new ParkingTicket(8923, "12", "14", "21342354252341");
            ParkingTicket pt2 = new ParkingTicket(65645357, "1", "2", "6576576");
            ParkingTicket pt3 = new ParkingTicket(2543, "2", "6", "24542626");
            ParkingTicket pt4 = new ParkingTicket(245246, "7", "13", "98564332");

            pt1.GetTicketInfo();
            pt2.GetTicketInfo();
            pt3.GetTicketInfo();
            pt4.GetTicketInfo();
        }

    }
}