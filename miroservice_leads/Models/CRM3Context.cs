using Microsoft.EntityFrameworkCore;

namespace miroservice_leads.Models
{
    public class CRM3Context : DbContext
    {
        public CRM3Context()
        {
        }

        public CRM3Context(DbContextOptions<CRM3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Leads> Leads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(
                    "Data Source=devsrv\\devsql;Initial Catalog=CRM3;user id=devuser;password=njucrho;multipleactiveresultsets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Leads>(entity =>
            {
                entity.HasKey(e => e.LeadId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.AssignedToUserId)
                    .HasName("MX14_AssighnToUserID");

                entity.HasIndex(e => e.ParentLeadId)
                    .HasName("IDX_Leads_ParentLeadID");

                entity.HasIndex(e => new {e.DateEntered, e.LeadId})
                    .HasName("IX_Leads")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new {e.LeadId, e.PlacementId})
                    .HasName("IX_Leads_1");

                entity.HasIndex(e => new {e.AssignedToUserId, e.LeadStatusId, e.ParentLeadId, e.OfficeId})
                    .HasName("MX11");

                entity.HasIndex(e => new {e.AssignedToUserId, e.ParentLeadId, e.OfficeId, e.DateEntered})
                    .HasName("MX3_AssignedToUserID_ParentLeadID_OfficeID_DateEntered");

                entity.HasIndex(e =>
                        new {e.AssignedToUserId, e.ParentLeadId, e.OfficeId, e.LastAssignmentDate, e.CountryId})
                    .HasName("MX12");

                entity.HasIndex(e =>
                        new {e.LeadId, e.LeadAssignmentTypeId, e.AssignedToUserId, e.OfficeId, e.LastAssignmentDate})
                    .HasName("MX10_LeadAssignmentTypeID_AssignedToUserID_OfficeID_LastAssignmentDate_INCL_LeadID");

                entity.HasIndex(e => new
                    {
                        e.AssignedToDeskId,
                        e.AssignedToUserId,
                        e.LastActivity,
                        e.LeadId,
                        e.ModifyDate,
                        e.ParentLeadId
                    })
                    .HasName("MX8_ParentLeadID_INCL");

                entity.HasIndex(e => new {e.LeadId, e.Email, e.FirstName, e.LastName, e.Phone, e.OfficeId})
                    .HasName("IX_")
                    .IsUnique();

                entity.HasIndex(e => new
                    {
                        e.AssignedToDeskId,
                        e.AssignedToUserId,
                        e.LastActivity,
                        e.LastAssignmentDate,
                        e.LeadId,
                        e.ModifyDate,
                        e.ParentLeadId
                    })
                    .HasName("MX9_ParentLeadID_INCL");

                entity.HasIndex(e => new
                    {
                        e.LeadId,
                        e.AssignedToDeskId,
                        e.DateEntered,
                        e.LanguageId,
                        e.FirstName,
                        e.LastName,
                        e.Email,
                        e.OfficeId,
                        e.CountryId
                    })
                    .HasName("MX4_OfficeID_incl");

                entity.HasIndex(e => new
                    {
                        e.AssignedToDeskId,
                        e.CountryId,
                        e.DateEntered,
                        e.Email,
                        e.FirstName,
                        e.LanguageId,
                        e.LastAssignmentDate,
                        e.LastName,
                        e.LeadId,
                        e.ModifyDate,
                        e.Phone,
                        e.ParentLeadId
                    })
                    .HasName("MX7_ParentLeadID_INCL");

                entity.HasIndex(e => new
                    {
                        e.Serial,
                        e.LeadAssignmentTypeId,
                        e.AssignedToUserId,
                        e.AssignedToDeskId,
                        e.LeadStatusId,
                        e.DateEntered,
                        e.LanguageId,
                        e.CountryId,
                        e.Email,
                        e.Phone,
                        e.ParentLeadId,
                        e.OfficeId,
                        e.LeadId
                    })
                    .HasName("MX1_ParentLeadID_OfficeID_LeadID_INCL");

                entity.HasIndex(e => new
                    {
                        e.LeadId,
                        e.LeadProviderId,
                        e.LeadAssignmentTypeId,
                        e.AssignedToUserId,
                        e.AssignedToDeskId,
                        e.LeadStatusId,
                        e.IsConverted,
                        e.CountryId,
                        e.FirstName,
                        e.LastName,
                        e.Email,
                        e.Phone,
                        e.Mobile,
                        e.IsMale,
                        e.DateOfBirth,
                        e.IsForexTrader,
                        e.IsGeneralTrader,
                        e.LeadRankId,
                        e.ParentLeadId,
                        e.OfficeId,
                        e.LanguageId,
                        e.DateEntered
                    })
                    .HasName("MX5_ParentLeadID_OfficeID_LanguageID_DateEntered");

                entity.HasIndex(e => new
                    {
                        e.LeadProviderId,
                        e.IsConverted,
                        e.Phone,
                        e.Mobile,
                        e.IsMale,
                        e.DateOfBirth,
                        e.IsForexTrader,
                        e.IsGeneralTrader,
                        e.LeadRankId,
                        e.Email,
                        e.LeadAssignmentTypeId,
                        e.OfficeId,
                        e.DateEntered,
                        e.CountryId,
                        e.FirstName,
                        e.LastName,
                        e.LanguageId,
                        e.LeadId,
                        e.AssignedToDeskId,
                        e.AssignedToUserId,
                        e.ParentLeadId,
                        e.LeadStatusId
                    })
                    .HasName(
                        "_dta_index_Leads_29_462220997__K27_K7_K22_K12_K24_K25_K26_K23_K1_K10_K9_K21_K11_5_20_28_29_37_43_45_46_47");

                entity.HasIndex(e => new
                    {
                        e.LeadProviderId,
                        e.IsConverted,
                        e.Phone,
                        e.Mobile,
                        e.IsMale,
                        e.DateOfBirth,
                        e.IsForexTrader,
                        e.IsGeneralTrader,
                        e.LeadRankId,
                        e.FirstName,
                        e.LeadAssignmentTypeId,
                        e.OfficeId,
                        e.DateEntered,
                        e.CountryId,
                        e.Email,
                        e.LastName,
                        e.LanguageId,
                        e.LeadId,
                        e.AssignedToDeskId,
                        e.AssignedToUserId,
                        e.ParentLeadId,
                        e.LeadStatusId
                    })
                    .HasName(
                        "_dta_index_Leads_29_462220997__K25_K7_K22_K12_K24_K27_K26_K23_K1_K10_K9_K21_K11_5_20_28_29_37_43_45_46_47");

                entity.HasIndex(e => new
                    {
                        e.LeadProviderId,
                        e.IsConverted,
                        e.Phone,
                        e.Mobile,
                        e.IsMale,
                        e.DateOfBirth,
                        e.IsForexTrader,
                        e.IsGeneralTrader,
                        e.LeadRankId,
                        e.LastName,
                        e.LeadAssignmentTypeId,
                        e.OfficeId,
                        e.DateEntered,
                        e.CountryId,
                        e.Email,
                        e.FirstName,
                        e.LanguageId,
                        e.LeadId,
                        e.AssignedToDeskId,
                        e.AssignedToUserId,
                        e.ParentLeadId,
                        e.LeadStatusId
                    })
                    .HasName(
                        "_dta_index_Leads_29_462220997__K26_K7_K22_K12_K24_K27_K25_K23_K1_K10_K9_K21_K11_5_20_28_29_37_43_45_46_47");

                entity.HasIndex(e => new
                    {
                        e.LeadId,
                        e.PlacementId,
                        e.LeadProviderId,
                        e.LeadAssignmentTypeId,
                        e.AssignedToDeskId,
                        e.LeadStatusId,
                        e.DateEntered,
                        e.IsConverted,
                        e.ParentLeadId,
                        e.LanguageId,
                        e.CountryId,
                        e.FirstName,
                        e.LastName,
                        e.Email,
                        e.Phone,
                        e.Mobile,
                        e.IsMale,
                        e.DateOfBirth,
                        e.IsForexTrader,
                        e.IsGeneralTrader,
                        e.LeadRankId,
                        e.AssignedToUserId,
                        e.OfficeId
                    })
                    .HasName("IX_LeadsAssignedToUserIDOfficeID");

                entity.HasIndex(e => new
                    {
                        e.LeadId,
                        e.PlacementId,
                        e.LeadProviderId,
                        e.LeadAssignmentTypeId,
                        e.AssignedToUserId,
                        e.AssignedToDeskId,
                        e.LeadStatusId,
                        e.DateEntered,
                        e.IsConverted,
                        e.ParentLeadId,
                        e.LanguageId,
                        e.CountryId,
                        e.FirstName,
                        e.LastName,
                        e.Email,
                        e.Phone,
                        e.Mobile,
                        e.IsMale,
                        e.DateOfBirth,
                        e.IsForexTrader,
                        e.IsGeneralTrader,
                        e.LeadRankId,
                        e.OfficeId
                    })
                    .HasName("IX_LeadsOfficeID");

                entity.HasIndex(e => new
                    {
                        e.LeadId,
                        e.PlacementId,
                        e.LeadProviderId,
                        e.LeadAssignmentTypeId,
                        e.AssignedToUserId,
                        e.AssignedToDeskId,
                        e.LeadStatusId,
                        e.IsConverted,
                        e.ParentLeadId,
                        e.LanguageId,
                        e.CountryId,
                        e.FirstName,
                        e.LastName,
                        e.Email,
                        e.Phone,
                        e.Mobile,
                        e.IsMale,
                        e.DateOfBirth,
                        e.IsForexTrader,
                        e.IsGeneralTrader,
                        e.LeadRankId,
                        e.OfficeId,
                        e.LastAssignmentDate
                    })
                    .HasName("IX_LeadsOfficeIDLastAssignmentDate");

                entity.HasIndex(e => new
                    {
                        e.LeadId,
                        e.LeadProviderId,
                        e.LeadAssignmentTypeId,
                        e.AssignedToUserId,
                        e.AssignedToDeskId,
                        e.LeadStatusId,
                        e.IsConverted,
                        e.ParentLeadId,
                        e.LanguageId,
                        e.CountryId,
                        e.FirstName,
                        e.LastName,
                        e.Email,
                        e.Phone,
                        e.Mobile,
                        e.IsMale,
                        e.DateOfBirth,
                        e.IsForexTrader,
                        e.IsGeneralTrader,
                        e.LeadRankId,
                        e.EmailPromotionActionId,
                        e.EmailPromotionDate,
                        e.OfficeId,
                        e.DateEntered
                    })
                    .HasName("MX2_OfficeID_DateEntered_INCL_BIG");

                entity.HasIndex(e => new
                    {
                        e.LeadId,
                        e.LeadProviderId,
                        e.LeadAssignmentTypeId,
                        e.AssignedToUserId,
                        e.IsConverted,
                        e.LanguageId,
                        e.CountryId,
                        e.FirstName,
                        e.LastName,
                        e.Email,
                        e.Phone,
                        e.Mobile,
                        e.IsMale,
                        e.DateOfBirth,
                        e.IsForexTrader,
                        e.IsGeneralTrader,
                        e.LeadRankId,
                        e.EmailPromotionActionId,
                        e.EmailPromotionDate,
                        e.AssignedToDeskId,
                        e.LeadStatusId,
                        e.ParentLeadId,
                        e.OfficeId,
                        e.DateEntered
                    })
                    .HasName("MX6_INCL_BIG");

                entity.HasIndex(e => new
                    {
                        e.LeadId,
                        e.LeadProviderId,
                        e.LeadAssignmentTypeId,
                        e.AssignedToDeskId,
                        e.LeadStatusId,
                        e.IsConverted,
                        e.LanguageId,
                        e.CountryId,
                        e.FirstName,
                        e.LastName,
                        e.Email,
                        e.Phone,
                        e.Mobile,
                        e.IsMale,
                        e.DateOfBirth,
                        e.IsForexTrader,
                        e.IsGeneralTrader,
                        e.LeadRankId,
                        e.EmailPromotionActionId,
                        e.EmailPromotionDate,
                        e.LeadRisk,
                        e.LastActivity,
                        e.AssignedToUserId,
                        e.ParentLeadId,
                        e.OfficeId,
                        e.LastAssignmentDate
                    })
                    .HasName("MX14");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'P.O. box 54')");

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'P.O. box 54')");

                entity.Property(e => e.AssignedToDeskId).HasColumnName("AssignedToDeskID");

                entity.Property(e => e.AssignedToUserId).HasColumnName("AssignedToUserID");

                entity.Property(e => e.Browser).HasMaxLength(50);

                entity.Property(e => e.CfdKnowledge).HasColumnName("CFD_Knowledge");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasDefaultValueSql("((31))");

                entity.Property(e => e.CountryIdCitizenship).HasColumnName("CountryID_Citizenship");

                entity.Property(e => e.CountryIdResidence).HasColumnName("CountryID_Residence");

                entity.Property(e => e.DateEntered).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1970-01-01 00:00:00.000')");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'Error@Error.com')");

                entity.Property(e => e.EmailPromotionActionId)
                    .HasColumnName("EmailPromotionActionID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailPromotionDate).HasColumnType("datetime");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Im)
                    .HasColumnName("IM")
                    .HasMaxLength(50);

                entity.Property(e => e.Industry).HasMaxLength(50);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'127.0.0.1')");

                entity.Property(e => e.IpAddress).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IsAllowedNewsLetter).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDepositPixel).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDupulicate)
                    .HasColumnName("isDupulicate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPendingAssignment)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Keyword).HasMaxLength(300);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LastActivity)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LeadAssignmentTypeId).HasColumnName("LeadAssignmentTypeID");

                entity.Property(e => e.LeadProviderId).HasColumnName("LeadProviderID");

                entity.Property(e => e.LeadProviderParam).HasMaxLength(250);

                entity.Property(e => e.LeadRankId).HasColumnName("LeadRankID");

                entity.Property(e => e.LeadRisk).HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadStatusId)
                    .HasColumnName("LeadStatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.MobileOriginal)
                    .HasColumnName("Mobile_Original")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Neighberhood).HasMaxLength(50);

                entity.Property(e => e.OfficeId)
                    .HasColumnName("OfficeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OriginLeadId).HasColumnName("originLeadID");

                entity.Property(e => e.Over18Declaration)
                    .HasColumnName("Over18_Declaration")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentLeadId).HasColumnName("ParentLeadID");

                entity.Property(e => e.PepRelated)
                    .HasColumnName("PEP_Related")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PhoneOriginal)
                    .HasColumnName("Phone_Original")
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneValidationStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlacementId).HasColumnName("PlacementID");

                entity.Property(e => e.ReferrerUrl).HasMaxLength(500);

                entity.Property(e => e.RegStep).HasDefaultValueSql("((2))");

                entity.Property(e => e.RegUrl).HasMaxLength(500);

                entity.Property(e => e.Serial).HasMaxLength(250);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('12345')");
            });
        }
    }
}