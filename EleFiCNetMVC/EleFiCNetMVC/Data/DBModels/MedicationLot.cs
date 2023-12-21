using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class MedicationLot
{
    public int MedicationLotid { get; set; }

    public string MedicationLot1 { get; set; } = null!;

    public DateTime MedicationExp { get; set; }

    public decimal MedicationPrice { get; set; }

    public string MedicationLotinfo { get; set; } = null!;

    public virtual ICollection<PatientMedication> PatientMedications { get; set; } = new List<PatientMedication>();
}
