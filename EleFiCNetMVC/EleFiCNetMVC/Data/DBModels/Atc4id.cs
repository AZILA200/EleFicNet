using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class Atc4id
{
    public string Atc4idid { get; set; } = null!;

    public string Atc3idid { get; set; } = null!;

    public string Atc4iddescriptionEl { get; set; } = null!;

    public string Atc4iddescriptionEn { get; set; } = null!;

    public virtual Atc3id Atc3id { get; set; } = null!;

    public virtual ICollection<Atc5id> Atc5ids { get; set; } = new List<Atc5id>();
}
