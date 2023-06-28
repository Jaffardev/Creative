using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("posr_cust_address")]
public partial class PosrCustAddress
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal CustId { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("area")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Area { get; set; }

    [Column("block")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Block { get; set; }

    [Column("street")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Street { get; set; }

    [Column("avenue")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Avenue { get; set; }

    [Column("build")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Build { get; set; }

    [Column("floor")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Floor { get; set; }

    [Column("flat")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Flat { get; set; }

    [Column("adderes")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Adderes { get; set; }

    [Column("map_location")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? MapLocation { get; set; }

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }
}
