using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("sec_log")]
public partial class SecLog
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("user_id", TypeName = "decimal(18, 0)")]
    public decimal? UserId { get; set; }

    [Column("win_id", TypeName = "decimal(18, 0)")]
    public decimal? WinId { get; set; }

    [Column("win_code")]
    [StringLength(100)]
    [Unicode(false)]
    public string? WinCode { get; set; }

    [Column("action_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ActionType { get; set; }

    [Column("action_date", TypeName = "datetime")]
    public DateTime? ActionDate { get; set; }

    [Column("row_id", TypeName = "decimal(18, 0)")]
    public decimal? RowId { get; set; }

    [Column("row_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RowCode { get; set; }

    [Column("notes")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes { get; set; }
}
