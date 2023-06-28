using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_trans_4")]
public partial class PafnTrans4
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

    [Column("violation_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ViolationNo { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("list_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ListNo { get; set; }

    [Column("subject_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? SubjectNo { get; set; }

    [Column("part_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? PartNo { get; set; }

    [Column("issue_date", TypeName = "datetime")]
    public DateTime? IssueDate { get; set; }

    [Column("person_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? PersonName { get; set; }

    [Column("id_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("comm_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CommName { get; set; }

    [Column("comm_lincense_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CommLincenseNo { get; set; }

    [Column("activity_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ActivityName { get; set; }

    [Column("health_lincense_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? HealthLincenseNo { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("serial_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? SerialNo { get; set; }

    [Column("violation_type")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ViolationType { get; set; }

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

    [Column("gen_manager_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? GenManagerName { get; set; }

    [Column("decision_close_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? DecisionCloseNo { get; set; }

    [Column("decision_close_date", TypeName = "datetime")]
    public DateTime? DecisionCloseDate { get; set; }

    [Column("decision_open_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? DecisionOpenNo { get; set; }

    [Column("decision_open_date", TypeName = "datetime")]
    public DateTime? DecisionOpenDate { get; set; }

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
