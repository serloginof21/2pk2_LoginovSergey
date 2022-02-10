using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz2_3
{
    class ParkingTicket
    {
        public int ID;
        public int summ;
        public string startTime;
        public string endTime;
        public string carID;

        public ParkingTicket(int _ID, string _startTime, string _endTime, string _carID, int _summ = 100)
        {
            ID = _ID;
            summ = _summ;
            startTime = _startTime;
            endTime = _endTime;
            carID = _carID;
        }

        public void GetTicketInfo()
        {
            Console.WriteLine($"ID = {ID}, summ = {summ}, startTime = {startTime}, endTime = {endTime}, carID = {carID}");
        }
    }
}
