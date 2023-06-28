﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hra_trans")]
public partial class HraTran
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("emp_old_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpOldId { get; set; }

    [Column("deprt_id", TypeName = "decimal(18, 0)")]
    public decimal? DeprtId { get; set; }

    [Column("deprt_old_id", TypeName = "decimal(18, 0)")]
    public decimal? DeprtOldId { get; set; }

    [Column("emp_class_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpClassId { get; set; }

    [Column("emp_class_old_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpClassOldId { get; set; }

    [Column("job_id", TypeName = "decimal(18, 0)")]
    public decimal? JobId { get; set; }

    [Column("job_old_id", TypeName = "decimal(18, 0)")]
    public decimal? JobOldId { get; set; }

    [Column("categry_id", TypeName = "decimal(18, 0)")]
    public decimal? CategryId { get; set; }

    [Column("categry_old_id", TypeName = "decimal(18, 0)")]
    public decimal? CategryOldId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("branch_old_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchOldId { get; set; }

    [Column("bank_id", TypeName = "decimal(18, 0)")]
    public decimal? BankId { get; set; }

    [Column("stage_id", TypeName = "decimal(18, 0)")]
    public decimal? StageId { get; set; }

    [Column("stage_old_id", TypeName = "decimal(18, 0)")]
    public decimal? StageOldId { get; set; }

    [Column("acdmc_qulfc_id", TypeName = "decimal(18, 0)")]
    public decimal? AcdmcQulfcId { get; set; }

    [Column("acdmc_qulfc_old_id", TypeName = "decimal(18, 0)")]
    public decimal? AcdmcQulfcOldId { get; set; }

    [Column("emp_group_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpGroupId { get; set; }

    [Column("emp_group_old_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpGroupOldId { get; set; }

    [Column("degree_id", TypeName = "decimal(18, 3)")]
    public decimal? DegreeId { get; set; }

    [Column("degree_old_id", TypeName = "decimal(18, 0)")]
    public decimal? DegreeOldId { get; set; }

    [Column("company_license_id", TypeName = "decimal(18, 0)")]
    public decimal? CompanyLicenseId { get; set; }

    [Column("company_license_old_id", TypeName = "decimal(18, 0)")]
    public decimal? CompanyLicenseOldId { get; set; }

    [Column("transfer_reson_id", TypeName = "decimal(18, 0)")]
    public decimal? TransferResonId { get; set; }

    [Column("promoted_type_id", TypeName = "decimal(18, 0)")]
    public decimal? PromotedTypeId { get; set; }

    [Column("bonus_type_id", TypeName = "decimal(18, 0)")]
    public decimal? BonusTypeId { get; set; }

    [Column("penalties_type_id", TypeName = "decimal(18, 0)")]
    public decimal? PenaltiesTypeId { get; set; }

    [Column("add_sub")]
    [MaxLength(1)]
    public byte[]? AddSub { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("year_id", TypeName = "decimal(18, 0)")]
    public decimal? YearId { get; set; }

    [Column("period_id", TypeName = "decimal(18, 0)")]
    public decimal? PeriodId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("trans_year")]
    public int? TransYear { get; set; }

    [Column("trans_month")]
    public int? TransMonth { get; set; }

    [Column("day_no", TypeName = "decimal(18, 0)")]
    public decimal? DayNo { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("hour_no", TypeName = "decimal(18, 0)")]
    public decimal? HourNo { get; set; }

    [Column("month_no", TypeName = "decimal(18, 0)")]
    public decimal? MonthNo { get; set; }

    [Column("year_no", TypeName = "decimal(18, 0)")]
    public decimal? YearNo { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

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

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }
}
