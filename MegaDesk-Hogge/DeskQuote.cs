using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Hogge
{
    public class DeskQuote
    {
        public enum Delivery
        {
            FourteenDays, SevenDays, FiveDays, ThreeDays
        }
        public string CustomerName { get; set; }

        public Delivery DeliveryType { get; set; }

        public decimal GetQuotePrice()
        {
            return 1000;
        }
    }
}
