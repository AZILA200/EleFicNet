using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class PrivateClinicDescription
{
    public int PrivateClinicDescriptionId { get; set; }

    public string PrivateClinicDescriptionEn { get; set; } = null!;

    public string PrivateClinicDescriptionEl { get; set; } = null!;

    public virtual ICollection<PrivateClinic> PrivateClinics { get; set; } = new List<PrivateClinic>();
}
