using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class PrivateClinic
{
    public string PrivateClinicId { get; set; } = null!;

    public int PrivateClinicDescriptionId { get; set; }

    public string? PrivateClinicAddress { get; set; }

    public string PrivateClinicPostcode { get; set; } = null!;

    public string PrivateClinicTown { get; set; } = null!;

    public string? PrivateClinicTelephone { get; set; }

    public string PrivateClinicWorkTelephone { get; set; } = null!;

    public string? PrivateClinicMobile { get; set; }

    public string PrivateClinicEmergencyPhone { get; set; } = null!;

    public string PrivateClinicEmail { get; set; } = null!;

    public virtual ICollection<MedicalStaff> MedicalStaffs { get; set; } = new List<MedicalStaff>();

    public virtual PrivateClinicDescription PrivateClinicDescription { get; set; } = null!;
}
