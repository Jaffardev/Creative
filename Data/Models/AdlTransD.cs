using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("adl_trans_d")]
public partial class AdlTransD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("resio", TypeName = "decimal(18, 4)")]
    public decimal? Resio { get; set; }

    [Column("amount", TypeName = "decimal(18, 4)")]
    public decimal? Amount { get; set; }

    [Column("install_type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? InstallType { get; set; }

    [Column("install_desc")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? InstallDesc { get; set; }

    [Column("finshed")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Finshed { get; set; }

    [Column("payed")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Payed { get; set; }

    [Column("req_date", TypeName = "datetime")]
    public DateTime? ReqDate { get; set; }

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
