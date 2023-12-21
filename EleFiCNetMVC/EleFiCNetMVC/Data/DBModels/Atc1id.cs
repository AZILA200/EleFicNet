using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class Atc1id
{
    public string Atc1idid { get; set; } = null!;

    public string Atc1iddescriptionEl { get; set; } = null!;

    public string Atc1iddescriptionEn { get; set; } = null!;

    public virtual ICollection<Atc2id> Atc2ids { get; set; } = new List<Atc2id>();
}
