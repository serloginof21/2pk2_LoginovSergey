using System;

namespace pz2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingTicket pt1 = new ParkingTicket(8923, "12:33", "2:55", "21342354252341", 39);
            ParkingTicket pt2 = new ParkingTicket(65645357, "1:34", "22:11", "6576576", 54);
            ParkingTicket pt3 = new ParkingTicket(2543, "2:22", "6:54", "24542626", 3124);
            ParkingTicket pt4 = new ParkingTicket(245246, "7:12", "4:12", "98564332");

            pt1.GetTicketInfo();
            pt2.GetTicketInfo();
            pt3.GetTicketInfo();
            pt4.GetTicketInfo();
        }

    }
}