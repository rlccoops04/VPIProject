using System;
using System.Collections.Generic;

namespace VPIProject;

public partial class Arendator
{
    public string LoginArendator { get; set; } = null!;

    public string PasswordArendator { get; set; } = null!;

    public string NameArendator { get; set; } = null!;

    public string SurNameArendator { get; set; } = null!;

    public string MobTelArendator { get; set; } = null!;

    public virtual ICollection<Dogovor> Dogovors { get; } = new List<Dogovor>();
}
