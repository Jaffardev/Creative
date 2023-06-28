using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rprt_portfolio_owner")]
public partial class RprtPortfolioOwner
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("owner_id", TypeName = "decimal(18, 0)")]
    public decimal? OwnerId { get; set; }

    [Column("shar_ratio", TypeName = "decimal(18, 0)")]
    public decimal? SharRatio { get; set; }

    [Column("shar_amount", TypeName = "decimal(18, 3)")]
    public decimal? SharAmount { get; set; }

    [Column("profit_ratio", TypeName = "decimal(18, 3)")]
    public decimal? ProfitRatio { get; set; }

    [Column("reference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Reference { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }
}
