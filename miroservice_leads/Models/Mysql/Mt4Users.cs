using System;
using System.Collections.Generic;

namespace miroservice_leads.Models.Mysql
{
    public partial class Mt4Users
    {
        public int Login { get; set; }
        public string Group { get; set; }
        public int Enable { get; set; }
        public int EnableChangePass { get; set; }
        public int EnableReadonly { get; set; }
        public int EnableOtp { get; set; }
        public string PasswordPhone { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Address { get; set; }
        public string LeadSource { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public string Id { get; set; }
        public string Status { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime Lastdate { get; set; }
        public int Leverage { get; set; }
        public int AgentAccount { get; set; }
        public int Timestamp { get; set; }
        public double Balance { get; set; }
        public double Prevmonthbalance { get; set; }
        public double Prevbalance { get; set; }
        public double Credit { get; set; }
        public double Interestrate { get; set; }
        public double Taxes { get; set; }
        public int SendReports { get; set; }
        public uint Mqid { get; set; }
        public int UserColor { get; set; }
        public double Equity { get; set; }
        public double Margin { get; set; }
        public double MarginLevel { get; set; }
        public double MarginFree { get; set; }
        public string Currency { get; set; }
        public byte[] ApiData { get; set; }
        public DateTime ModifyTime { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string ComplianceNotes { get; set; }
    }
}
