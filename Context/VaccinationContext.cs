using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using VaccinationManagement.Models;

#nullable disable

namespace VaccinationManagement.Context
{
    public partial class VaccinationContext : DbContext
    {
        public VaccinationContext()
        {
        }

        public VaccinationContext(DbContextOptions<VaccinationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booth> Booths { get; set; }
        public virtual DbSet<Cite> Cites { get; set; }
        public virtual DbSet<CiteType> CiteTypes { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<LogIn> LogIns { get; set; }
        public virtual DbSet<PriorityGroup> PriorityGroups { get; set; }
        public virtual DbSet<SideEffect> SideEffects { get; set; }
        public virtual DbSet<SpecialInstitution> SpecialInstitutions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=VaccinationManagementDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Booth>(entity =>
            {
                entity.ToTable("BOOTH");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BoothAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("booth_address");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Manager)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("manager");

                entity.Property(e => e.Phone).HasColumnName("phone");
            });

            modelBuilder.Entity<Cite>(entity =>
            {
                entity.ToTable("CITE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CiteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cite_date");

                entity.Property(e => e.CiteLocation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cite_location");

                entity.Property(e => e.IdCiteType).HasColumnName("id_cite_type");

                entity.Property(e => e.IdCitizen).HasColumnName("id_citizen");

                entity.Property(e => e.Step2Date)
                    .HasColumnType("datetime")
                    .HasColumnName("step2_date");

                entity.Property(e => e.VaccineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("vaccine_date");

                entity.HasOne(d => d.IdCiteTypeNavigation)
                    .WithMany(p => p.Cites)
                    .HasForeignKey(d => d.IdCiteType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITE__id_cite_ty__440B1D61");

                entity.HasOne(d => d.IdCitizenNavigation)
                    .WithMany(p => p.Cites)
                    .HasForeignKey(d => d.IdCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITE__id_citizen__4222D4EF");
            });

            modelBuilder.Entity<CiteType>(entity =>
            {
                entity.ToTable("CITE_TYPE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CiteType1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cite_type");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__CITIZEN__D876F1BEF8101C16");

                entity.ToTable("CITIZEN");

                entity.Property(e => e.Dui)
                    .ValueGeneratedNever()
                    .HasColumnName("dui");

                entity.Property(e => e.CitizenAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("citizen_address");

                entity.Property(e => e.CitizenName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("citizen_name");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.IdPriorityGroup).HasColumnName("id_priority_group");

                entity.Property(e => e.IdSpecialInstitution).HasColumnName("id_special_institution");

                entity.Property(e => e.IntitutionCode).HasColumnName("intitution_code");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__id_empl__3E52440B");

                entity.HasOne(d => d.IdPriorityGroupNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdPriorityGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__id_prio__412EB0B6");

                entity.HasOne(d => d.IdSpecialInstitutionNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdSpecialInstitution)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__id_spec__403A8C7D");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.ToTable("DISEASE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Disease1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("disease");

                entity.Property(e => e.IdCitizen).HasColumnName("id_citizen");

                entity.HasOne(d => d.IdCitizenNavigation)
                    .WithMany(p => p.Diseases)
                    .HasForeignKey(d => d.IdCitizen)
                    .HasConstraintName("FK__DISEASE__id_citi__3F466844");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("employee_address");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("employee_name");

                entity.Property(e => e.EmployeeType).HasColumnName("employee_type");

                entity.Property(e => e.IdBooth).HasColumnName("id_booth");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.EmployeeTypeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmployeeType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEE__employ__398D8EEE");

                entity.HasOne(d => d.IdBoothNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdBooth)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEE__id_boo__3A81B327");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__EMPLOYEE__id_use__3C69FB99");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("EMPLOYEE_TYPE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EmployeeType1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("employee_type");
            });

            modelBuilder.Entity<LogIn>(entity =>
            {
                entity.HasKey(e => new { e.IdUser, e.IdBooth })
                    .HasName("PK_log_in");

                entity.ToTable("LOG_IN");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdBooth).HasColumnName("id_booth");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.HasOne(d => d.IdBoothNavigation)
                    .WithMany(p => p.LogIns)
                    .HasForeignKey(d => d.IdBooth)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOG_IN__id_booth__3B75D760");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.LogIns)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOG_IN__id_user__3D5E1FD2");
            });

            modelBuilder.Entity<PriorityGroup>(entity =>
            {
                entity.ToTable("PRIORITY_GROUP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.PriorityGroup1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("priority_group");
            });

            modelBuilder.Entity<SideEffect>(entity =>
            {
                entity.ToTable("SIDE_EFFECT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Effect)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("effect");

                entity.Property(e => e.EffectTime)
                    .HasColumnType("datetime")
                    .HasColumnName("effect_time");

                entity.Property(e => e.IdCite).HasColumnName("id_cite");

                entity.HasOne(d => d.IdCiteNavigation)
                    .WithMany(p => p.SideEffects)
                    .HasForeignKey(d => d.IdCite)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SIDE_EFFE__id_ci__4316F928");
            });

            modelBuilder.Entity<SpecialInstitution>(entity =>
            {
                entity.ToTable("SPECIAL_INSTITUTION");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.InstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inst_name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USERS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.PasswordUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("password_user");

                entity.Property(e => e.Users)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
