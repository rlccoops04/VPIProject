using System;
using System.Collections.Generic;

namespace VPIProject;

public partial class Room
{
    public int NumRoom { get; set; }

    public double GeneralSpace { get; set; }

    public int NumFloor { get; set; }

    public string Furniture { get; set; } = null!;

    public string AirCondition { get; set; } = null!;

    public decimal MonthPrice { get; set; }

    public virtual ICollection<Dogovor> Dogovors { get; } = new List<Dogovor>();
}
