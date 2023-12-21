using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class PatientPersonalDatum
{
    public string PatientPersonalDataIdunique { get; set; } = null!;

    public string PatientPersonalDataIduserUnique { get; set; } = null!;

    public string PatientPersonalDataAddress { get; set; } = null!;

    public string PatientPersonalDataPostcode { get; set; } = null!;

    public string PatientPersonalDataTown { get; set; } = null!;

    public string? PatientPersonalDataCounty { get; set; }

    public string PatientPersonalDataCountry { get; set; } = null!;

    public string PatientPersonalDataMobile { get; set; } = null!;

    public string PatientPersonalDataEmergencyPhone { get; set; } = null!;

    public string PatientPersonalDataEmail { get; set; } = null!;

    public string PatientPersonalDataForename { get; set; } = null!;

    public string PatientPersonalDataSurname { get; set; } = null!;

    public string PatientPersonalDataFatherName { get; set; } = null!;

    public string PatientPersonalDataAfm { get; set; } = null!;

    public DateTime PatientPersonalDataDateOfBirth { get; set; }

    public virtual ICollection<PatientMedicalDatum> PatientMedicalData { get; set; } = new List<PatientMedicalDatum>();
}
