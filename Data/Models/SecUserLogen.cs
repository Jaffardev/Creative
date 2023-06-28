using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("sec_user_logen")]
public partial class SecUserLogen
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("user_id", TypeName = "decimal(18, 0)")]
    public decimal? UserId { get; set; }

    [Column("win_id", TypeName = "decimal(18, 0)")]
    public decimal? WinId { get; set; }

    [Column("log_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LogType { get; set; }

    [Column("long_date", TypeName = "datetime")]
    public DateTime? LongDate { get; set; }

    [Column("notes")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes { get; set; }
}
