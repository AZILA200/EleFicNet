using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class MedicalStaffSpeciality
{
    public int MedicalStaffSpecialityId { get; set; }

    public string MedicalStaffSpecialityDescriptionEn { get; set; } = null!;

    public string MedicalStaffSpecialityDescriptionEl { get; set; } = null!;

    public virtual ICollection<MedicalStaff> MedicalStaffs { get; set; } = new List<MedicalStaff>();
}
