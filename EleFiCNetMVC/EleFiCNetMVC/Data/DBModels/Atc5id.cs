using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class Atc5id
{
    public string Atc5idid { get; set; } = null!;

    public string Atc4idid { get; set; } = null!;

    public string Atc5iddescriptionEl { get; set; } = null!;

    public string Atc5iddescriptionEn { get; set; } = null!;

    public virtual Atc4id Atc4id { get; set; } = null!;
}
