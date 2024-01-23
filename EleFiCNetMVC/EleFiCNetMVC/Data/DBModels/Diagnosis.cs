namespace EleFiCNetMVC.Data.DBModels;

public partial class Diagnosis
{
    public string MedicalExaminationsDiagnosisIdunique { get; set; } = null!;

    public string Icd2id { get; set; } = null!;

    public string DiagnosisDescriptionEl { get; set; } = null!;

    public string DiagnosisDescriptionEn { get; set; } = null!;

    public string DiagnosisCommentEl { get; set; } = null!;

    public string DiagnosisCommentEn { get; set; } = null!;

    public virtual Icd2id Icd2 { get; set; } = null!;

    public virtual ICollection<MedicalExamination> MedicalExaminations { get; set; } = new List<MedicalExamination>();
}