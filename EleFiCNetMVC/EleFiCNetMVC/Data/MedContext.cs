using System;
using System.Collections.Generic;
using EleFiCNetMVC.Data.DBModels;
using Microsoft.EntityFrameworkCore;

namespace EleFiCNetMVC.Data;

public partial class MedContext : DbContext
{
    public MedContext()
    {
    }

    public MedContext(DbContextOptions<MedContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Atc1id> Atc1ids { get; set; }

    public virtual DbSet<Atc2id> Atc2ids { get; set; }

    public virtual DbSet<Atc3id> Atc3ids { get; set; }

    public virtual DbSet<Atc4id> Atc4ids { get; set; }

    public virtual DbSet<Atc5id> Atc5ids { get; set; }

    public virtual DbSet<MedicalStaff> MedicalStaffs { get; set; }

    public virtual DbSet<MedicalStaffSpeciality> MedicalStaffSpecialities { get; set; }

    public virtual DbSet<Medication> Medications { get; set; }

    public virtual DbSet<MedicationImage> MedicationImages { get; set; }

    public virtual DbSet<MedicationLot> MedicationLots { get; set; }

    public virtual DbSet<PatientMedicalDatum> PatientMedicalData { get; set; }

    public virtual DbSet<PatientMedication> PatientMedications { get; set; }

    public virtual DbSet<PatientPersonalDatum> PatientPersonalData { get; set; }

    public virtual DbSet<PrivateClinic> PrivateClinics { get; set; }

    public virtual DbSet<PrivateClinicDescription> PrivateClinicDescriptions { get; set; }

    public virtual DbSet<VarityQuantity> VarityQuantities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=H-SOFO-009;Database=EleFiCNetMVC;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Atc1id>(entity =>
        {
            entity.HasKey(e => e.Atc1idid).HasName("PK_ATC1ID_ATC1ID");

            entity.ToTable("ATC1ID");

            entity.Property(e => e.Atc1idid)
                .HasMaxLength(1)
                .HasColumnName("ATC1IDID");
            entity.Property(e => e.Atc1iddescriptionEl)
                .HasMaxLength(150)
                .HasColumnName("ATC1IDDescriptionEL");
            entity.Property(e => e.Atc1iddescriptionEn)
                .HasMaxLength(150)
                .HasColumnName("ATC1IDDescriptionEN");
        });

        modelBuilder.Entity<Atc2id>(entity =>
        {
            entity.HasKey(e => e.Atc2idid).HasName("PK_ATC2ID_ATC2IDID");

            entity.ToTable("ATC2ID");

            entity.Property(e => e.Atc2idid)
                .HasMaxLength(3)
                .HasColumnName("ATC2IDID");
            entity.Property(e => e.Atc1idid)
                .HasMaxLength(1)
                .HasColumnName("ATC1IDID");
            entity.Property(e => e.Atc2iddescriptionEl)
                .HasMaxLength(150)
                .HasColumnName("ATC2IDDescriptionEL");
            entity.Property(e => e.Atc2iddescriptionEn)
                .HasMaxLength(150)
                .HasColumnName("ATC2IDDescriptionEN");

            entity.HasOne(d => d.Atc1id).WithMany(p => p.Atc2ids)
                .HasForeignKey(d => d.Atc1idid)
                .HasConstraintName("FK_ATC2ID_ATC1ID");
        });

        modelBuilder.Entity<Atc3id>(entity =>
        {
            entity.HasKey(e => e.Atc3idid).HasName("PK_ATC3ID_ATC3IDID");

            entity.ToTable("ATC3ID");

            entity.Property(e => e.Atc3idid)
                .HasMaxLength(4)
                .HasColumnName("ATC3IDID");
            entity.Property(e => e.Atc2idid)
                .HasMaxLength(3)
                .HasColumnName("ATC2IDID");
            entity.Property(e => e.Atc3iddescriptionEl)
                .HasMaxLength(150)
                .HasColumnName("ATC3IDDescriptionEL");
            entity.Property(e => e.Atc3iddescriptionEn)
                .HasMaxLength(150)
                .HasColumnName("ATC3IDDescriptionEN");

            entity.HasOne(d => d.Atc2id).WithMany(p => p.Atc3ids)
                .HasForeignKey(d => d.Atc2idid)
                .HasConstraintName("FK_ATC3ID_ATC2ID");
        });

        modelBuilder.Entity<Atc4id>(entity =>
        {
            entity.HasKey(e => e.Atc4idid).HasName("PK_ATC4ID_ATC3IDID");

            entity.ToTable("ATC4ID");

            entity.Property(e => e.Atc4idid)
                .HasMaxLength(5)
                .HasColumnName("ATC4IDID");
            entity.Property(e => e.Atc3idid)
                .HasMaxLength(4)
                .HasColumnName("ATC3IDID");
            entity.Property(e => e.Atc4iddescriptionEl)
                .HasMaxLength(150)
                .HasColumnName("ATC4IDDescriptionEL");
            entity.Property(e => e.Atc4iddescriptionEn)
                .HasMaxLength(150)
                .HasColumnName("ATC4IDDescriptionEN");

            entity.HasOne(d => d.Atc3id).WithMany(p => p.Atc4ids)
                .HasForeignKey(d => d.Atc3idid)
                .HasConstraintName("FK_ATC4ID_ATC3ID");
        });

        modelBuilder.Entity<Atc5id>(entity =>
        {
            entity.HasKey(e => e.Atc5idid).HasName("PK_ATC5ID_ATC4IDID");

            entity.ToTable("ATC5ID");

            entity.Property(e => e.Atc5idid)
                .HasMaxLength(7)
                .HasColumnName("ATC5IDID");
            entity.Property(e => e.Atc4idid)
                .HasMaxLength(5)
                .HasColumnName("ATC4IDID");
            entity.Property(e => e.Atc5iddescriptionEl)
                .HasMaxLength(150)
                .HasColumnName("ATC5IDDescriptionEL");
            entity.Property(e => e.Atc5iddescriptionEn)
                .HasMaxLength(150)
                .HasColumnName("ATC5IDDescriptionEN");

            entity.HasOne(d => d.Atc4id).WithMany(p => p.Atc5ids)
                .HasForeignKey(d => d.Atc4idid)
                .HasConstraintName("FK_ATC5ID_ATC4ID");
        });

        modelBuilder.Entity<MedicalStaff>(entity =>
        {
            entity.HasKey(e => e.MedicalStaffIdunique).HasName("PK__MedicalS__A2A86DF72ECB843F");

            entity.ToTable("MedicalStaff");

            entity.Property(e => e.MedicalStaffIdunique)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("medicalStaffIDUnique");
            entity.Property(e => e.Afm)
                .HasMaxLength(15)
                .HasColumnName("AFM");
            entity.Property(e => e.Amka)
                .HasMaxLength(15)
                .HasColumnName("AMKA");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("dateOfBirth");
            entity.Property(e => e.EmedicalStaffEmail)
                .HasMaxLength(150)
                .HasColumnName("emedicalStaffEMail");
            entity.Property(e => e.MedicalStaffAddress)
                .HasMaxLength(150)
                .HasColumnName("medicalStaffAddress");
            entity.Property(e => e.MedicalStaffEmergencyPhone)
                .HasMaxLength(25)
                .HasColumnName("medicalStaffEmergencyPhone");
            entity.Property(e => e.MedicalStaffFatherName)
                .HasMaxLength(150)
                .HasColumnName("medicalStaffFatherName");
            entity.Property(e => e.MedicalStaffIduserUnique)
                .HasMaxLength(450)
                .HasColumnName("medicalStaffIDUserUnique");
            entity.Property(e => e.MedicalStaffName)
                .HasMaxLength(150)
                .HasColumnName("medicalStaffName");
            entity.Property(e => e.MedicalStaffPostcode)
                .HasMaxLength(10)
                .HasColumnName("medicalStaffPostcode");
            entity.Property(e => e.MedicalStaffPrivateClinicId)
                .HasMaxLength(450)
                .HasColumnName("medicalStaffPrivateClinicID");
            entity.Property(e => e.MedicalStaffSpecialityId).HasColumnName("medicalStaffSpecialityID");
            entity.Property(e => e.MedicalStaffSurname)
                .HasMaxLength(150)
                .HasColumnName("medicalStaffSurname");
            entity.Property(e => e.MedicalStaffTelephone)
                .HasMaxLength(25)
                .HasColumnName("medicalStaffTelephone");
            entity.Property(e => e.MedicalStaffTown)
                .HasMaxLength(25)
                .HasColumnName("medicalStaffTown");
            entity.Property(e => e.MedicalStaffWorkTelephone)
                .HasMaxLength(25)
                .HasColumnName("medicalStaffWorkTelephone");
            entity.Property(e => e.MedicalStaffmobile)
                .HasMaxLength(25)
                .HasColumnName("medicalStaffmobile");

            entity.HasOne(d => d.MedicalStaffPrivateClinic).WithMany(p => p.MedicalStaffs)
                .HasForeignKey(d => d.MedicalStaffPrivateClinicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicalStaff_PrivateClinic");

            entity.HasOne(d => d.MedicalStaffSpeciality).WithMany(p => p.MedicalStaffs)
                .HasForeignKey(d => d.MedicalStaffSpecialityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicalStaff_MedicalStaffSpeciality");
        });

        modelBuilder.Entity<MedicalStaffSpeciality>(entity =>
        {
            entity.ToTable("MedicalStaffSpeciality");

            entity.Property(e => e.MedicalStaffSpecialityId).HasColumnName("medicalStaffSpecialityID");
            entity.Property(e => e.MedicalStaffSpecialityDescriptionEl)
                .HasMaxLength(150)
                .HasColumnName("medicalStaffSpecialityDescriptionEL");
            entity.Property(e => e.MedicalStaffSpecialityDescriptionEn)
                .HasMaxLength(150)
                .HasColumnName("medicalStaffSpecialityDescriptionEN");
        });

        modelBuilder.Entity<Medication>(entity =>
        {
            entity.HasKey(e => e.MedicationIdunique).HasName("PK__Medicati__31D842F3F4E8F17D");

            entity.ToTable("Medication");

            entity.Property(e => e.MedicationIdunique)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("medicationIDUnique");
            entity.Property(e => e.Atc5idid)
                .HasMaxLength(7)
                .HasColumnName("ATC5IDID");
            entity.Property(e => e.MedicationBarCode1)
                .HasMaxLength(100)
                .HasColumnName("medicationBarCode1");
            entity.Property(e => e.MedicationBarCode2)
                .HasMaxLength(100)
                .HasColumnName("medicationBarCode2");
            entity.Property(e => e.MedicationBarCode3)
                .HasMaxLength(100)
                .HasColumnName("medicationBarCode3");
            entity.Property(e => e.MedicationComments).HasColumnName("medicationComments");
            entity.Property(e => e.MedicationImageId)
                .HasMaxLength(450)
                .HasColumnName("medicationImageID");
            entity.Property(e => e.MedicationInfo)
                .HasMaxLength(225)
                .HasColumnName("medicationInfo");
            entity.Property(e => e.MedicationName)
                .HasMaxLength(225)
                .HasColumnName("medicationName");
            entity.Property(e => e.MedicationQuantities).HasColumnName("medicationQuantities");
            entity.Property(e => e.VarityQuantitiesCode).HasColumnName("varityQuantitiesCode");

            entity.HasOne(d => d.MedicationImage).WithMany(p => p.Medications)
                .HasForeignKey(d => d.MedicationImageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Medication_MedicationImage");

            entity.HasOne(d => d.VarityQuantitiesCodeNavigation).WithMany(p => p.Medications)
                .HasForeignKey(d => d.VarityQuantitiesCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Medication_VarityQuantities");
        });

        modelBuilder.Entity<MedicationImage>(entity =>
        {
            entity.HasKey(e => e.MedicationImageId).HasName("PK__Medicati__E48A33ADE2990553");

            entity.ToTable("MedicationImage");

            entity.Property(e => e.MedicationImageId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("medicationImageID");
            entity.Property(e => e.MedicationImageFileName)
                .HasMaxLength(150)
                .HasColumnName("medicationImageFileName");
            entity.Property(e => e.MedicationImageFolderPath)
                .HasMaxLength(100)
                .HasColumnName("medicationImageFolderPath");
            entity.Property(e => e.MedicationImageInfo)
                .HasMaxLength(255)
                .HasColumnName("medicationImageInfo");
        });

        modelBuilder.Entity<MedicationLot>(entity =>
        {
            entity.ToTable("MedicationLOT");

            entity.Property(e => e.MedicationLotid).HasColumnName("medicationLOTID");
            entity.Property(e => e.MedicationExp)
                .HasColumnType("date")
                .HasColumnName("medicationEXP");
            entity.Property(e => e.MedicationLot1)
                .HasMaxLength(50)
                .HasColumnName("medicationLOT");
            entity.Property(e => e.MedicationLotinfo)
                .HasMaxLength(255)
                .HasColumnName("medicationLOTInfo");
            entity.Property(e => e.MedicationPrice)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("medicationPrice");
        });

        modelBuilder.Entity<PatientMedicalDatum>(entity =>
        {
            entity.HasKey(e => e.PatientMedicalDataIdunique).HasName("PK__PatientM__83C5DB00324A2100");

            entity.Property(e => e.PatientMedicalDataIdunique)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("patientMedicalDataIDUnique");
            entity.Property(e => e.PatientPersonalDataAmka)
                .HasMaxLength(15)
                .HasColumnName("patientPersonalDataAMKA");
            entity.Property(e => e.PatientPersonalDataIdunique)
                .HasMaxLength(450)
                .HasColumnName("patientPersonalDataIDUnique");

            entity.HasOne(d => d.PatientPersonalDataIduniqueNavigation).WithMany(p => p.PatientMedicalData)
                .HasForeignKey(d => d.PatientPersonalDataIdunique)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientMedicalData_PatientPersonalData");
        });

        modelBuilder.Entity<PatientMedication>(entity =>
        {
            entity.HasKey(e => e.PatientMedicationIdunique).HasName("PK__PatientM__B4C99570F15BA586");

            entity.ToTable("PatientMedication");

            entity.Property(e => e.PatientMedicationIdunique)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("patientMedicationIDUnique");
            entity.Property(e => e.MedicationIdunique)
                .HasMaxLength(450)
                .HasColumnName("medicationIDUnique");
            entity.Property(e => e.MedicationLotid).HasColumnName("medicationLOTID");
            entity.Property(e => e.MedicationShapeTherapy)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("medicationShapeTherapy");
            entity.Property(e => e.MedicationTherapiesDuration).HasColumnName("medicationTherapiesDuration");
            entity.Property(e => e.MedicationTherapiesNotes).HasColumnName("medicationTherapiesNotes");
            entity.Property(e => e.PatientMedicalDataIdunique)
                .HasMaxLength(450)
                .HasColumnName("patientMedicalDataIDUnique");

            entity.HasOne(d => d.MedicationIduniqueNavigation).WithMany(p => p.PatientMedications)
                .HasForeignKey(d => d.MedicationIdunique)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientMedication_Medication");

            entity.HasOne(d => d.MedicationLot).WithMany(p => p.PatientMedications)
                .HasForeignKey(d => d.MedicationLotid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientMedication_MedicationLOT");

            entity.HasOne(d => d.PatientMedicalDataIduniqueNavigation).WithMany(p => p.PatientMedications)
                .HasForeignKey(d => d.PatientMedicalDataIdunique)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientMedication_PatientMedicalData");
        });

        modelBuilder.Entity<PatientPersonalDatum>(entity =>
        {
            entity.HasKey(e => e.PatientPersonalDataIdunique).HasName("PK__PatientP__53E4737F8B0DC92A");

            entity.Property(e => e.PatientPersonalDataIdunique)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("patientPersonalDataIDUnique");
            entity.Property(e => e.PatientPersonalDataAddress)
                .HasMaxLength(150)
                .HasColumnName("patientPersonalDataAddress");
            entity.Property(e => e.PatientPersonalDataAfm)
                .HasMaxLength(15)
                .HasColumnName("patientPersonalDataAFM");
            entity.Property(e => e.PatientPersonalDataCountry)
                .HasMaxLength(55)
                .HasColumnName("patientPersonalDataCountry");
            entity.Property(e => e.PatientPersonalDataCounty)
                .HasMaxLength(55)
                .HasColumnName("patientPersonalDataCounty");
            entity.Property(e => e.PatientPersonalDataDateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("patientPersonalDataDateOfBirth");
            entity.Property(e => e.PatientPersonalDataEmail)
                .HasMaxLength(150)
                .HasColumnName("patientPersonalDataEMail");
            entity.Property(e => e.PatientPersonalDataEmergencyPhone)
                .HasMaxLength(25)
                .HasColumnName("patientPersonalDataEmergencyPhone");
            entity.Property(e => e.PatientPersonalDataFatherName)
                .HasMaxLength(150)
                .HasColumnName("patientPersonalDataFatherName");
            entity.Property(e => e.PatientPersonalDataForename)
                .HasMaxLength(150)
                .HasColumnName("patientPersonalDataForename");
            entity.Property(e => e.PatientPersonalDataIduserUnique)
                .HasMaxLength(450)
                .HasColumnName("patientPersonalDataIDUserUnique");
            entity.Property(e => e.PatientPersonalDataMobile)
                .HasMaxLength(25)
                .HasColumnName("patientPersonalDataMobile");
            entity.Property(e => e.PatientPersonalDataPostcode)
                .HasMaxLength(10)
                .HasColumnName("patientPersonalDataPostcode");
            entity.Property(e => e.PatientPersonalDataSurname)
                .HasMaxLength(150)
                .HasColumnName("patientPersonalDataSurname");
            entity.Property(e => e.PatientPersonalDataTown)
                .HasMaxLength(55)
                .HasColumnName("patientPersonalDataTown");
        });

        modelBuilder.Entity<PrivateClinic>(entity =>
        {
            entity.HasKey(e => e.PrivateClinicId).HasName("PK__PrivateC__AE2D2D8FEE27B1BF");

            entity.ToTable("PrivateClinic");

            entity.Property(e => e.PrivateClinicId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("privateClinicID");
            entity.Property(e => e.PrivateClinicAddress)
                .HasMaxLength(150)
                .HasColumnName("privateClinicAddress");
            entity.Property(e => e.PrivateClinicDescriptionId).HasColumnName("privateClinicDescriptionID");
            entity.Property(e => e.PrivateClinicEmail)
                .HasMaxLength(150)
                .HasColumnName("privateClinicEMail");
            entity.Property(e => e.PrivateClinicEmergencyPhone)
                .HasMaxLength(25)
                .HasColumnName("privateClinicEmergencyPhone");
            entity.Property(e => e.PrivateClinicMobile)
                .HasMaxLength(25)
                .HasColumnName("privateClinicMobile");
            entity.Property(e => e.PrivateClinicPostcode)
                .HasMaxLength(10)
                .HasColumnName("privateClinicPostcode");
            entity.Property(e => e.PrivateClinicTelephone)
                .HasMaxLength(25)
                .HasColumnName("privateClinicTelephone");
            entity.Property(e => e.PrivateClinicTown)
                .HasMaxLength(25)
                .HasColumnName("privateClinicTown");
            entity.Property(e => e.PrivateClinicWorkTelephone)
                .HasMaxLength(25)
                .HasColumnName("privateClinicWorkTelephone");

            entity.HasOne(d => d.PrivateClinicDescription).WithMany(p => p.PrivateClinics)
                .HasForeignKey(d => d.PrivateClinicDescriptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrivateClinic_PrivateClinicDescription");
        });

        modelBuilder.Entity<PrivateClinicDescription>(entity =>
        {
            entity.ToTable("PrivateClinicDescription");

            entity.Property(e => e.PrivateClinicDescriptionId)
                .ValueGeneratedNever()
                .HasColumnName("privateClinicDescriptionID");
            entity.Property(e => e.PrivateClinicDescriptionEl)
                .HasMaxLength(150)
                .HasColumnName("privateClinicDescriptionEL");
            entity.Property(e => e.PrivateClinicDescriptionEn)
                .HasMaxLength(150)
                .HasColumnName("privateClinicDescriptionEN");
        });

        modelBuilder.Entity<VarityQuantity>(entity =>
        {
            entity.HasKey(e => e.VarityQuantitiesCode);

            entity.Property(e => e.VarityQuantitiesCode).HasColumnName("varityQuantitiesCode");
            entity.Property(e => e.VarityQuantitiesDescriptionEl)
                .HasMaxLength(225)
                .HasColumnName("varityQuantitiesDescriptionEL");
            entity.Property(e => e.VarityQuantitiesDescriptionEn)
                .HasMaxLength(225)
                .HasColumnName("varityQuantitiesDescriptionEN");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
