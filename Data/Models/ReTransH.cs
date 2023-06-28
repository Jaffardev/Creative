using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("re_trans_h")]
public partial class ReTransH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
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

    [Column("evaluation_h_id", TypeName = "decimal(18, 0)")]
    public decimal? EvaluationHId { get; set; }

    [Column("emp_appraisal_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpAppraisalId { get; set; }

    [Column("emp_evaluated_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpEvaluatedId { get; set; }

    [Column("adress")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Adress { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("job_id", TypeName = "decimal(18, 0)")]
    public decimal? JobId { get; set; }

    [Column("deprt_id", TypeName = "decimal(18, 0)")]
    public decimal? DeprtId { get; set; }

    [Column("emp_class_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpClassId { get; set; }

    [Column("emp_group_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpGroupId { get; set; }

    [Column("acdmc_qulfc_id", TypeName = "decimal(18, 0)")]
    public decimal? AcdmcQulfcId { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

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
