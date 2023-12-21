using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class Medication
{
    public string MedicationIdunique { get; set; } = null!;

    public string MedicationImageId { get; set; } = null!;

    public string Atc5idid { get; set; } = null!;

    public string? MedicationComments { get; set; }

    public string MedicationName { get; set; } = null!;

    public string MedicationBarCode1 { get; set; } = null!;

    public string MedicationBarCode2 { get; set; } = null!;

    public string MedicationBarCode3 { get; set; } = null!;

    public string MedicationInfo { get; set; } = null!;

    public int MedicationQuantities { get; set; }

    public int VarityQuantitiesCode { get; set; }

    public virtual MedicationImage MedicationImage { get; set; } = null!;

    public virtual ICollection<PatientMedication> PatientMedications { get; set; } = new List<PatientMedication>();

    public virtual VarityQuantity VarityQuantitiesCodeNavigation { get; set; } = null!;
}
