namespace EleFiCNetMVC.Data.DBModels;

public partial class Examination
{
    public string ExaminationIdunique { get; set; } = null!;

    public string MedicalExaminationsIdunique { get; set; } = null!;

    public int ExaminationTypeId { get; set; }

    public decimal ExaminationValue { get; set; }

    public string ExaminationMeasuremetUnit { get; set; } = null!;

    public string ExaminationFolderPath { get; set; } = null!;

    public string ExaminationInfoEn { get; set; } = null!;

    public string ExaminationInfoEl { get; set; } = null!;

    public virtual ExaminationType ExaminationType { get; set; } = null!;

    public virtual MedicalExamination MedicalExaminationsIduniqueNavigation { get; set; } = null!;
}