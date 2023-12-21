using System;
using System.Collections.Generic;

namespace EleFiCNetMVC.Data.DBModels;

public partial class VarityQuantity
{
    public int VarityQuantitiesCode { get; set; }

    public string VarityQuantitiesDescriptionEl { get; set; } = null!;

    public string VarityQuantitiesDescriptionEn { get; set; } = null!;

    public virtual ICollection<Medication> Medications { get; set; } = new List<Medication>();
}
