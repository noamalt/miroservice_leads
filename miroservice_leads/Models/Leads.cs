using System;
using System.ComponentModel.DataAnnotations;

namespace miroservice_leads.Models
{
    public class Leads
    {
        [Key]
        public int LeadId { get; set; }

        public int? OriginLeadId { get; set; }
        public string Serial { get; set; }
        public int? PlacementId { get; set; }
        public int? LeadProviderId { get; set; }
        public string LeadProviderParam { get; set; }
        public int? LeadAssignmentTypeId { get; set; }
        public bool? IsPendingAssignment { get; set; }
        public int? AssignedToUserId { get; set; }
        public int? AssignedToDeskId { get; set; }
        public int? LeadStatusId { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime? LastDupDate { get; set; }
        public DateTime? LastAssignmentDate { get; set; }
        public decimal IpAddress { get; set; }
        public string Ip { get; set; }
        public string Browser { get; set; }
        public string ReferrerUrl { get; set; }
        public string RegUrl { get; set; }
        public bool IsConverted { get; set; }
        public int? ParentLeadId { get; set; }
        public int OfficeId { get; set; }
        public int LanguageId { get; set; }
        public int? CountryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Neighberhood { get; set; }
        public bool? IsMale { get; set; }
        public int? Age { get; set; }
        public int? InvestmentExperience { get; set; }
        public bool? IsEmployed { get; set; }
        public string Industry { get; set; }
        public string Keyword { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsAllowedNewsLetter { get; set; }
        public bool? IsForexTrader { get; set; }
        public bool? IsGeneralTrader { get; set; }
        public int? LeadRankId { get; set; }
        public bool? IsDepositPixel { get; set; }
        public string PhoneOriginal { get; set; }
        public string MobileOriginal { get; set; }
        public string Comment { get; set; }
        public bool? IsDupulicate { get; set; }
        public string Im { get; set; }
        public int? EmailPromotionActionId { get; set; }
        public DateTime? EmailPromotionDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool? LeadRisk { get; set; }
        public DateTime? LastActivity { get; set; }
        public string Gender { get; set; }
        public int? CountryIdCitizenship { get; set; }
        public int? CountryIdResidence { get; set; }
        public int? EducationalBackground { get; set; }
        public int? CfdKnowledge { get; set; }
        public int? FinancialServiceBackground { get; set; }
        public int? TradingFrequency { get; set; }
        public int? PurposeOfTrading { get; set; }
        public int? AnticipatedAmountOfDeposit { get; set; }
        public int? IncomeSource { get; set; }
        public int? AnnualIncome { get; set; }
        public int? InvestmentsValue { get; set; }
        public bool? PepRelated { get; set; }
        public bool? Over18Declaration { get; set; }
        public int? RegStep { get; set; }
        public int? PhoneValidationStatus { get; set; }
    }
}