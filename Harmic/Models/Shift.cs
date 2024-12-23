﻿using System;
using System.Collections.Generic;

namespace Harmic.Models;

public partial class Shift
{
    public int ShiftId { get; set; }

    public int? EmployeeId { get; set; }

    public DateOnly? ShiftDate { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public virtual Employee? Employee { get; set; }
}
