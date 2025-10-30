using System;
using System.Collections.Generic;

namespace Riso.Database.AppDbContextModels;

public partial class TblDiscount
{
    public int DiscountId { get; set; }

    public int ProductId { get; set; }

    public decimal DiscountPercentage { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
