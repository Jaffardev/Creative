using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_trans_3")]
public partial class PafnTrans3
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("admin_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? AdminNo { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("date_1", TypeName = "datetime")]
    public DateTime? Date1 { get; set; }

    [Column("owner_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? OwnerName { get; set; }

    [Column("comm_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CommName { get; set; }

    [Column("comm_lincense_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CommLincenseNo { get; set; }

    [Column("health_lincense_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? HealthLincenseNo { get; set; }

    [Column("activity_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ActivityName { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("serial_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? SerialNo { get; set; }

    [Column("manager_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ManagerName { get; set; }

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

    [Column("agree_date", TypeName = "datetime")]
    public DateTime? AgreeDate { get; set; }

    [Column("agree_time", TypeName = "datetime")]
    public DateTime? AgreeTime { get; set; }

    [Column("inspector_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? InspectorName { get; set; }

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

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }
}
