using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz2_3
{
    public class ParkingTicket
    {
        public static readonly int price = 50;
        static int allSumm = 0;
        static int count = 0;
        public static string analize = $"Общее кол-во билетов {count}, а их сумма {allSumm}";
        public int ID
        {
            get
            {
                return ID;
            }
            set
            {
                if (value != 0) ID = value;
            }
        }
        virtual public int summ
        {
            get
            {
                return (DateTime.Parse(endTime) - DateTime.Parse(startTime)).Hours * price;
            }

        }
        public string startTime
        {
            get
            {
                return startTime;
            }
            set
            {
                if (DateTime.Parse(value) < DateTime.Parse(endTime))
                    startTime = value;
            }
        }
        public string endTime;
        public string carID;

        public ParkingTicket(int _ID, string _startTime, string _endTime, string _carID)
        {
            ID = _ID;
            startTime = _startTime;
            endTime = _endTime;
            carID = _carID;
            count++;
            allSumm += summ;
        }
        ~ParkingTicket()
        {
            allSumm -= summ;
            count--;
        }
        public virtual void GetTicketInfo()
        {

            Console.WriteLine($"ID = {ID}, summ = {summ}, startTime = {startTime}, endTime = {endTime}, carID = {carID}");
        }
    }
    class SpecialParkingTicket : ParkingTicket
    {
        public int discount;

        public override int summ
        {
            get
            {
                return (DateTime.Parse(endTime) - DateTime.Parse(startTime)).Hours * price * discount / 100;
            }

        }
        SpecialParkingTicket(int _ID, string _startTime, string _endTime, string _carID, int _discount) : base(_ID, _startTime, _endTime, _carID)
        {
            discount = _discount;
        }
        public override void GetTicketInfo()
        {
            Console.WriteLine($"ID = {ID}, summ = {summ}, startTime = {startTime}, endTime = {endTime}, carID = {carID},  discount ={ discount}");
        }
    }
}


