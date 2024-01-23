namespace EleFiCNetMVC.Data.DBModels;

public partial class MedicalExamination
{
    public string MedicalExaminationsIdunique { get; set; } = null!;

    public DateTime MedicalExaminationsDate { get; set; }

    public string MedicalExaminationsResponsiblePerson { get; set; } = null!;

    public string MedicalExaminationsDiagnosisIdunique { get; set; } = null!;

    public string MedicalExaminationsFolderPath { get; set; } = null!;

    public string MedicalExaminationsInfoEn { get; set; } = null!;

    public string MedicalExaminationsInfoEl { get; set; } = null!;

    public virtual ICollection<Examination> Examinations { get; set; } = new List<Examination>();

    public virtual Diagnosis MedicalExaminationsDiagnosisIduniqueNavigation { get; set; } = null!;
}