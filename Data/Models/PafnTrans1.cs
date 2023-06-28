using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_trans_1")]
public partial class PafnTrans1
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("request_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RequestType { get; set; }

    [Column("comm_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CommName { get; set; }

    [Column("health_lincense_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? HealthLincenseNo { get; set; }

    [Column("health_lincense_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? HealthLincenseName { get; set; }

    [Column("id_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("tel_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("owner_work_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? OwnerWorkName { get; set; }

    [Column("transfer_to")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransferTo { get; set; }

    [Column("gover_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? GoverName { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("inspector_notes")]
    [StringLength(200)]
    [Unicode(false)]
    public string? InspectorNotes { get; set; }

    [Column("emp_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpNo { get; set; }

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
