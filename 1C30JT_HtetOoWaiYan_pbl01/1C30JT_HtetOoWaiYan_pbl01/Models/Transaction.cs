using System;
using System.Collections.Generic;

namespace _1C30JT_HtetOoWaiYan_pbl01.Models;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public DateTime TransactionDate { get; set; }

    public string Type { get; set; } = null!;

    public decimal Amount { get; set; }

    public string? Memo { get; set; }
}
