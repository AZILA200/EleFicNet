namespace EleFiCNetMVC.Data.DBModels;

public partial class ExaminationType
{
	public int ExaminationTypeId { get; set; }

	public string ExaminationTypeDescriptionEn { get; set; } = null!;

	public string ExaminationTypeDescriptionEl { get; set; } = null!;

	public virtual ICollection<Examination> Examinations { get; set; } = new List<Examination>();
}