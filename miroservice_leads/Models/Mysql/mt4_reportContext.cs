using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace miroservice_leads.Models.Mysql
{
    public partial class mt4_reportContext : DbContext
    {
        public mt4_reportContext()
        {
        }

        public mt4_reportContext(DbContextOptions<mt4_reportContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mt4Config> Mt4Config { get; set; }
        public virtual DbSet<Mt4Daily> Mt4Daily { get; set; }
        public virtual DbSet<Mt4Prices> Mt4Prices { get; set; }
        public virtual DbSet<Mt4Trades> Mt4Trades { get; set; }
        public virtual DbSet<Mt4Users> Mt4Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=34.249.4.162;port=3306;user=finmarket_mt4_rw;password=06#fKL7Ad95C79Q#a3F7ciM;database=mt4_report");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mt4Config>(entity =>
            {
                entity.HasKey(e => e.Config);

                entity.ToTable("mt4_config");

                entity.Property(e => e.Config)
                    .HasColumnName("CONFIG")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValueInt)
                    .HasColumnName("VALUE_INT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValueStr)
                    .HasColumnName("VALUE_STR")
                    .HasColumnType("char(255)");
            });

            modelBuilder.Entity<Mt4Daily>(entity =>
            {
                entity.HasKey(e =>e.Login);

                entity.ToTable("mt4_daily");

                entity.Property(e => e.Login)
                    .HasColumnName("LOGIN")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Balance).HasColumnName("BALANCE");

                entity.Property(e => e.BalancePrev).HasColumnName("BALANCE_PREV");

                entity.Property(e => e.Bank)
                    .IsRequired()
                    .HasColumnName("BANK")
                    .HasColumnType("char(64)");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Deposit).HasColumnName("DEPOSIT");

                entity.Property(e => e.Equity).HasColumnName("EQUITY");

                entity.Property(e => e.Group)
                    .IsRequired()
                    .HasColumnName("GROUP")
                    .HasColumnType("char(16)");

                entity.Property(e => e.Margin).HasColumnName("MARGIN");

                entity.Property(e => e.MarginFree).HasColumnName("MARGIN_FREE");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("MODIFY_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Profit).HasColumnName("PROFIT");

                entity.Property(e => e.ProfitClosed).HasColumnName("PROFIT_CLOSED");
            });

            modelBuilder.Entity<Mt4Prices>(entity =>
            {
                entity.HasKey(e => e.Symbol);

                entity.ToTable("mt4_prices");

                entity.Property(e => e.Symbol)
                    .HasColumnName("SYMBOL")
                    .HasColumnType("char(16)");

                entity.Property(e => e.Ask).HasColumnName("ASK");

                entity.Property(e => e.Bid).HasColumnName("BID");

                entity.Property(e => e.Digits)
                    .HasColumnName("DIGITS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Direction)
                    .HasColumnName("DIRECTION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.High).HasColumnName("HIGH");

                entity.Property(e => e.Low).HasColumnName("LOW");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("MODIFY_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Spread)
                    .HasColumnName("SPREAD")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("TIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Mt4Trades>(entity =>
            {
                entity.HasKey(e => e.Ticket);

                entity.ToTable("mt4_trades");

                entity.HasIndex(e => e.CloseTime)
                    .HasName("INDEX_CLOSETIME");

                entity.HasIndex(e => e.Cmd)
                    .HasName("INDEX_CMD");

                entity.HasIndex(e => e.Login)
                    .HasName("INDEX_LOGIN");

                entity.HasIndex(e => e.OpenTime)
                    .HasName("INDEX_OPENTIME");

                entity.HasIndex(e => e.Timestamp)
                    .HasName("INDEX_STAMP");

                entity.Property(e => e.Ticket)
                    .HasColumnName("TICKET")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClosePrice).HasColumnName("CLOSE_PRICE");

                entity.Property(e => e.CloseTime)
                    .HasColumnName("CLOSE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cmd)
                    .HasColumnName("CMD")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("COMMENT")
                    .HasColumnType("char(32)");

                entity.Property(e => e.Commission).HasColumnName("COMMISSION");

                entity.Property(e => e.CommissionAgent).HasColumnName("COMMISSION_AGENT");

                entity.Property(e => e.ConvRate1).HasColumnName("CONV_RATE1");

                entity.Property(e => e.ConvRate2).HasColumnName("CONV_RATE2");

                entity.Property(e => e.Digits)
                    .HasColumnName("DIGITS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Expiration)
                    .HasColumnName("EXPIRATION")
                    .HasColumnType("datetime");

                entity.Property(e => e.GwClosePrice)
                    .HasColumnName("GW_CLOSE_PRICE")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GwOpenPrice)
                    .HasColumnName("GW_OPEN_PRICE")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GwVolume)
                    .HasColumnName("GW_VOLUME")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.InternalId)
                    .HasColumnName("INTERNAL_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Login)
                    .HasColumnName("LOGIN")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Magic)
                    .HasColumnName("MAGIC")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MarginRate).HasColumnName("MARGIN_RATE");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("MODIFY_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpenPrice).HasColumnName("OPEN_PRICE");

                entity.Property(e => e.OpenTime)
                    .HasColumnName("OPEN_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Profit).HasColumnName("PROFIT");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.Swaps).HasColumnName("SWAPS");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasColumnName("SYMBOL")
                    .HasColumnType("char(16)");

                entity.Property(e => e.Taxes).HasColumnName("TAXES");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tp).HasColumnName("TP");

                entity.Property(e => e.Volume)
                    .HasColumnName("VOLUME")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Mt4Users>(entity =>
            {
                entity.HasKey(e => e.Login);

                entity.ToTable("mt4_users");

                entity.HasIndex(e => e.Timestamp)
                    .HasName("INDEX_STAMP");

                entity.Property(e => e.Login)
                    .HasColumnName("LOGIN")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("ADDRESS")
                    .HasColumnType("char(128)");

                entity.Property(e => e.AgentAccount)
                    .HasColumnName("AGENT_ACCOUNT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApiData)
                    .HasColumnName("API_DATA")
                    .HasColumnType("blob");

                entity.Property(e => e.Balance).HasColumnName("BALANCE");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("CITY")
                    .HasColumnType("char(32)");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("COMMENT")
                    .HasColumnType("char(64)");

                entity.Property(e => e.ComplianceNotes)
                    .HasColumnName("COMPLIANCE_NOTES")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("COUNTRY")
                    .HasColumnType("char(32)");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("CURRENCY")
                    .HasColumnType("char(16)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("DATE_OF_BIRTH")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasColumnType("char(48)");

                entity.Property(e => e.Enable)
                    .HasColumnName("ENABLE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnableChangePass)
                    .HasColumnName("ENABLE_CHANGE_PASS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnableOtp)
                    .HasColumnName("ENABLE_OTP")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EnableReadonly)
                    .HasColumnName("ENABLE_READONLY")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Equity)
                    .HasColumnName("EQUITY")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Group)
                    .IsRequired()
                    .HasColumnName("GROUP")
                    .HasColumnType("char(16)");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("ID")
                    .HasColumnType("char(32)");

                entity.Property(e => e.Interestrate).HasColumnName("INTERESTRATE");

                entity.Property(e => e.Lastdate)
                    .HasColumnName("LASTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LeadSource)
                    .IsRequired()
                    .HasColumnName("LEAD_SOURCE")
                    .HasColumnType("char(32)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Leverage)
                    .HasColumnName("LEVERAGE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Margin)
                    .HasColumnName("MARGIN")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MarginFree)
                    .HasColumnName("MARGIN_FREE")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MarginLevel)
                    .HasColumnName("MARGIN_LEVEL")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("MODIFY_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mqid)
                    .HasColumnName("MQID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("char(128)");

                entity.Property(e => e.PasswordPhone)
                    .IsRequired()
                    .HasColumnName("PASSWORD_PHONE")
                    .HasColumnType("char(32)");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("PHONE")
                    .HasColumnType("char(32)");

                entity.Property(e => e.Prevbalance).HasColumnName("PREVBALANCE");

                entity.Property(e => e.Prevmonthbalance).HasColumnName("PREVMONTHBALANCE");

                entity.Property(e => e.Regdate)
                    .HasColumnName("REGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SendReports)
                    .HasColumnName("SEND_REPORTS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("STATE")
                    .HasColumnType("char(32)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasColumnType("char(16)");

                entity.Property(e => e.Taxes).HasColumnName("TAXES");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserColor)
                    .HasColumnName("USER_COLOR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Zipcode)
                    .IsRequired()
                    .HasColumnName("ZIPCODE")
                    .HasColumnType("char(16)");
            });
        }
    }
}
