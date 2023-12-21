using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class PatientMedication
{
    public string PatientMedicationIdunique { get; set; } = null!;

    public string PatientMedicalDataIdunique { get; set; } = null!;

    public string MedicationIdunique { get; set; } = null!;

    public int MedicationTherapiesDuration { get; set; }

    public decimal MedicationShapeTherapy { get; set; }

    public string MedicationTherapiesNotes { get; set; } = null!;

    public int MedicationLotid { get; set; }

    public virtual Medication MedicationIduniqueNavigation { get; set; } = null!;

    public virtual MedicationLot MedicationLot { get; set; } = null!;

    public virtual PatientMedicalDatum PatientMedicalDataIduniqueNavigation { get; set; } = null!;
}
