using System;
using System.Collections.Generic;

namespace VPIProject;

public partial class Arendodatel
{
    public string LoginArendodatel { get; set; } = null!;

    public string PasswordArendodatel { get; set; } = null!;

    public string NameArendodatel { get; set; } = null!;

    public string SurNameArendodatel { get; set; } = null!;

    public string MobTelArendodatel { get; set; } = null!;

    public virtual ICollection<Dogovor> Dogovors { get; } = new List<Dogovor>();
}
