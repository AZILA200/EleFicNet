using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class Atc2id
{
    public string Atc2idid { get; set; } = null!;

    public string Atc1idid { get; set; } = null!;

    public string Atc2iddescriptionEl { get; set; } = null!;

    public string Atc2iddescriptionEn { get; set; } = null!;

    public virtual Atc1id Atc1id { get; set; } = null!;

    public virtual ICollection<Atc3id> Atc3ids { get; set; } = new List<Atc3id>();
}
