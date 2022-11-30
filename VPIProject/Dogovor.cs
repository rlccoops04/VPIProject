using System;
using System.Collections.Generic;

namespace VPIProject;

public partial class Dogovor
{
    public int DogovorId { get; set; }

    public DateTime DataStartDogovor { get; set; }

    public DateTime DataEndDogovor { get; set; }

    public int? NumRoom { get; set; }

    public string? LoginArendator { get; set; }

    public string? LoginArendodatel { get; set; }

    public virtual Arendator? LoginArendatorNavigation { get; set; }

    public virtual Arendodatel? LoginArendodatelNavigation { get; set; }

    public virtual Room? NumRoomNavigation { get; set; }
}
