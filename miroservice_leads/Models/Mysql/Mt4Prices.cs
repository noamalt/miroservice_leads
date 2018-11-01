using System;
using System.Collections.Generic;

namespace miroservice_leads.Models.Mysql
{
    public partial class Mt4Prices
    {
        public string Symbol { get; set; }
        public DateTime Time { get; set; }
        public double Bid { get; set; }
        public double Ask { get; set; }
        public double Low { get; set; }
        public double High { get; set; }
        public int Direction { get; set; }
        public int Digits { get; set; }
        public int Spread { get; set; }
        public DateTime ModifyTime { get; set; }
    }
}
