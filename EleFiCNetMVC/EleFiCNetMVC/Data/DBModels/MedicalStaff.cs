using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class MedicalStaff
{
    public string MedicalStaffIdunique { get; set; } = null!;

    public string MedicalStaffIduserUnique { get; set; } = null!;

    public string MedicalStaffPrivateClinicId { get; set; } = null!;

    public int MedicalStaffSpecialityId { get; set; }

    public string? MedicalStaffAddress { get; set; }

    public string? MedicalStaffPostcode { get; set; }

    public string? MedicalStaffTown { get; set; }

    public string? MedicalStaffTelephone { get; set; }

    public string? MedicalStaffWorkTelephone { get; set; }

    public string MedicalStaffmobile { get; set; } = null!;

    public string MedicalStaffEmergencyPhone { get; set; } = null!;

    public string EmedicalStaffEmail { get; set; } = null!;

    public string MedicalStaffName { get; set; } = null!;

    public string MedicalStaffSurname { get; set; } = null!;

    public string? MedicalStaffFatherName { get; set; }

    public string? Amka { get; set; }

    public string? Afm { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public virtual PrivateClinic MedicalStaffPrivateClinic { get; set; } = null!;

    public virtual MedicalStaffSpeciality MedicalStaffSpeciality { get; set; } = null!;
}
