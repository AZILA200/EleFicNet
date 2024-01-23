namespace EleFiCNetMVC.Data.DBModels;

public partial class Icd1id
{
    public string Icd1id1 { get; set; } = null!;

    public string Icd1iddescriptionEn { get; set; } = null!;

    public string Icd1iddescriptionEl { get; set; } = null!;

    public virtual ICollection<Icd2id> Icd2ids { get; set; } = new List<Icd2id>();
}