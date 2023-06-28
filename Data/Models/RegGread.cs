using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("reg_gread")]
public partial class RegGread
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("emp_id")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmpId { get; set; }

    [Column("stage_id", TypeName = "decimal(18, 0)")]
    public decimal? StageId { get; set; }

    [Column("up_to_gread", TypeName = "decimal(18, 0)")]
    public decimal? UpToGread { get; set; }

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

    [Column("stu_code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? StuCode { get; set; }

    [Column("class_no", TypeName = "decimal(18, 0)")]
    public decimal? ClassNo { get; set; }

    [Column("allow_class_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass1 { get; set; }

    [Column("class_id_1", TypeName = "decimal(18, 0)")]
    public decimal? ClassId1 { get; set; }

    [Column("allow_class_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass2 { get; set; }

    [Column("class_id_2", TypeName = "decimal(18, 0)")]
    public decimal? ClassId2 { get; set; }

    [Column("allow_class_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass3 { get; set; }

    [Column("class_id_3", TypeName = "decimal(18, 0)")]
    public decimal? ClassId3 { get; set; }

    [Column("allow_class_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass4 { get; set; }

    [Column("class_id_4", TypeName = "decimal(18, 0)")]
    public decimal? ClassId4 { get; set; }

    [Column("allow_class_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass5 { get; set; }

    [Column("class_id_5", TypeName = "decimal(18, 0)")]
    public decimal? ClassId5 { get; set; }

    [Column("allow_class_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass6 { get; set; }

    [Column("class_id_6", TypeName = "decimal(18, 0)")]
    public decimal? ClassId6 { get; set; }

    [Column("allow_class_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass7 { get; set; }

    [Column("class_id_7", TypeName = "decimal(18, 0)")]
    public decimal? ClassId7 { get; set; }

    [Column("allow_class_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass8 { get; set; }

    [Column("class_id_8", TypeName = "decimal(18, 0)")]
    public decimal? ClassId8 { get; set; }

    [Column("allow_class_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass9 { get; set; }

    [Column("class_id_9", TypeName = "decimal(18, 0)")]
    public decimal? ClassId9 { get; set; }

    [Column("allow_class_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass10 { get; set; }

    [Column("class_id_10", TypeName = "decimal(18, 0)")]
    public decimal? ClassId10 { get; set; }

    [Column("allow_class_11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass11 { get; set; }

    [Column("class_id_11", TypeName = "decimal(18, 0)")]
    public decimal? ClassId11 { get; set; }

    [Column("allow_class_12")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass12 { get; set; }

    [Column("class_id_12", TypeName = "decimal(18, 0)")]
    public decimal? ClassId12 { get; set; }

    [Column("allow_class_13")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass13 { get; set; }

    [Column("class_id_13", TypeName = "decimal(18, 0)")]
    public decimal? ClassId13 { get; set; }

    [Column("allow_class_14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass14 { get; set; }

    [Column("class_id_14", TypeName = "decimal(18, 0)")]
    public decimal? ClassId14 { get; set; }

    [Column("allow_class_15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowClass15 { get; set; }

    [Column("class_id_15", TypeName = "decimal(18, 0)")]
    public decimal? ClassId15 { get; set; }

    [Column("m_sort")]
    public int? MSort { get; set; }

    [Column("icon_name")]
    [StringLength(500)]
    [Unicode(false)]
    public string? IconName { get; set; }

    [Column("acp_from_date", TypeName = "datetime")]
    public DateTime? AcpFromDate { get; set; }

    [Column("acp_to_date", TypeName = "datetime")]
    public DateTime? AcpToDate { get; set; }

    [Column("acc_exp_id", TypeName = "decimal(18, 0)")]
    public decimal? AccExpId { get; set; }

    [Column("acc_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? AccCostId { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("acc_analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AccAnalysisId { get; set; }

    [Column("notes_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes1 { get; set; }
}
