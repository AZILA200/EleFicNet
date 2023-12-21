using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class MedicationImage
{
    public string MedicationImageId { get; set; } = null!;

    public string MedicationImageFileName { get; set; } = null!;

    public string MedicationImageFolderPath { get; set; } = null!;

    public string MedicationImageInfo { get; set; } = null!;

    public virtual ICollection<Medication> Medications { get; set; } = new List<Medication>();
}
