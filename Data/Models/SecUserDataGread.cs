using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("sec_user_data_gread")]
public partial class SecUserDataGread
{
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("user_id", TypeName = "numeric(18, 0)")]
    public decimal? UserId { get; set; }

    [Column("gread_id", TypeName = "numeric(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("admin")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Admin { get; set; }

    [Column("creation_by", TypeName = "numeric(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("chang_by", TypeName = "numeric(18, 0)")]
    public decimal? ChangBy { get; set; }

    [Column("chang_date", TypeName = "datetime")]
    public DateTime? ChangDate { get; set; }

    [Column("notes")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes { get; set; }
}
