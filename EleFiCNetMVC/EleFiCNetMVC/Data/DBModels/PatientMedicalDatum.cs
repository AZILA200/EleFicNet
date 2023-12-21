using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class PatientMedicalDatum
{
    public string PatientMedicalDataIdunique { get; set; } = null!;

    public string PatientPersonalDataIdunique { get; set; } = null!;

    public string PatientPersonalDataAmka { get; set; } = null!;

    public virtual ICollection<PatientMedication> PatientMedications { get; set; } = new List<PatientMedication>();

    public virtual PatientPersonalDatum PatientPersonalDataIduniqueNavigation { get; set; } = null!;
}
