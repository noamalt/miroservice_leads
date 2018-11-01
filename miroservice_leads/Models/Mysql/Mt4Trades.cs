using System;
using System.Collections.Generic;

namespace miroservice_leads.Models.Mysql
{
    public partial class Mt4Trades
    {
        public int Ticket { get; set; }
        public int Login { get; set; }
        public string Symbol { get; set; }
        public int Digits { get; set; }
        public int Cmd { get; set; }
        public int Volume { get; set; }
        public DateTime OpenTime { get; set; }
        public double OpenPrice { get; set; }
        public double Sl { get; set; }
        public double Tp { get; set; }
        public DateTime CloseTime { get; set; }
        public DateTime Expiration { get; set; }
        public int Reason { get; set; }
        public double ConvRate1 { get; set; }
        public double ConvRate2 { get; set; }
        public double Commission { get; set; }
        public double CommissionAgent { get; set; }
        public double Swaps { get; set; }
        public double ClosePrice { get; set; }
        public double Profit { get; set; }
        public double Taxes { get; set; }
        public string Comment { get; set; }
        public int InternalId { get; set; }
        public double MarginRate { get; set; }
        public int Timestamp { get; set; }
        public int Magic { get; set; }
        public int GwVolume { get; set; }
        public int GwOpenPrice { get; set; }
        public int GwClosePrice { get; set; }
        public DateTime ModifyTime { get; set; }
    }
}
