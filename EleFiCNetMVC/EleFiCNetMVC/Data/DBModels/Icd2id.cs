namespace EleFiCNetMVC.Data.DBModels;

public partial class Icd2id
{
    public string Icd2idid { get; set; } = null!;

    public string Icd1idid { get; set; } = null!;

    public string Icd2iddescriptionEn { get; set; } = null!;

    public string Icd2iddescriptionEl { get; set; } = null!;
    public virtual ICollection<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>();

    public virtual Icd1id Icd1id { get; set; } = null!;
}