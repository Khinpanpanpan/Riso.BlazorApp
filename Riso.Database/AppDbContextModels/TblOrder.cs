using System;
using System.Collections.Generic;

namespace Riso.Database.AppDbContextModels;

public partial class TblOrder
{
    public int OrderId { get; set; }

    public string OrderName { get; set; } = null!;

    public string OrderCode { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
