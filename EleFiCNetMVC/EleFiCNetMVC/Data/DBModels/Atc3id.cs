using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class Atc3id
{
    public string Atc3idid { get; set; } = null!;

    public string Atc2idid { get; set; } = null!;

    public string Atc3iddescriptionEl { get; set; } = null!;

    public string Atc3iddescriptionEn { get; set; } = null!;

    public virtual Atc2id Atc2id { get; set; } = null!;

    public virtual ICollection<Atc4id> Atc4ids { get; set; } = new List<Atc4id>();
}
