using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_record_h_1")]
public partial class PafnRecordH1
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("gover_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? GoverName { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("deliver_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? DeliverNo { get; set; }

    [Column("center_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CenterName { get; set; }

    [Column("deliver_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? DeliverName { get; set; }

    [Column("emp_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

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

    [Column("user_post_id", TypeName = "decimal(18, 0)")]
    public decimal? UserPostId { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }
}
