using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hr_emply_salary_plan")]
public partial class HrEmplySalaryPlan
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("acc_year_id", TypeName = "decimal(18, 0)")]
    public decimal? AccYearId { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

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

    [Column("job_id", TypeName = "decimal(18, 0)")]
    public decimal? JobId { get; set; }

    [Column("emp_group_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpGroupId { get; set; }

    [Column("signature_id", TypeName = "decimal(18, 0)")]
    public decimal? SignatureId { get; set; }

    [Column("company_license_id", TypeName = "decimal(18, 0)")]
    public decimal? CompanyLicenseId { get; set; }

    [Column("acdmc_qulfc_id", TypeName = "decimal(18, 0)")]
    public decimal? AcdmcQulfcId { get; set; }

    [Column("categry_id", TypeName = "decimal(18, 0)")]
    public decimal? CategryId { get; set; }

    [Column("work_start_date", TypeName = "datetime")]
    public DateTime? WorkStartDate { get; set; }

    [Column("workt_end_date", TypeName = "datetime")]
    public DateTime? WorktEndDate { get; set; }

    [Column("contract_start_date", TypeName = "datetime")]
    public DateTime? ContractStartDate { get; set; }

    [Column("contract_end_date", TypeName = "datetime")]
    public DateTime? ContractEndDate { get; set; }

    [Column("emp_class_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpClassId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("deprt_id", TypeName = "decimal(18, 0)")]
    public decimal? DeprtId { get; set; }

    [Column("item_desc_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc1 { get; set; }

    [Column("item_amount_1", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount1 { get; set; }

    [Column("item_desc_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc2 { get; set; }

    [Column("item_amount_2", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount2 { get; set; }

    [Column("item_desc_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc3 { get; set; }

    [Column("item_amount_3", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount3 { get; set; }

    [Column("item_desc_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc4 { get; set; }

    [Column("item_amount_4", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount4 { get; set; }

    [Column("item_desc_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc5 { get; set; }

    [Column("item_amount_5", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount5 { get; set; }

    [Column("item_desc_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc6 { get; set; }

    [Column("item_amount_6", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount6 { get; set; }

    [Column("item_desc_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc7 { get; set; }

    [Column("item_amount_7", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount7 { get; set; }

    [Column("item_desc_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc8 { get; set; }

    [Column("item_amount_8", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount8 { get; set; }

    [Column("item_desc_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc9 { get; set; }

    [Column("item_amount_9", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount9 { get; set; }

    [Column("item_desc_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc10 { get; set; }

    [Column("item_amount_10", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount10 { get; set; }

    [Column("item_desc_11")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc11 { get; set; }

    [Column("item_amount_11", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount11 { get; set; }

    [Column("item_desc_12")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc12 { get; set; }

    [Column("item_amount_12", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount12 { get; set; }

    [Column("item_desc_13")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc13 { get; set; }

    [Column("item_amount_13", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount13 { get; set; }

    [Column("item_desc_14")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc14 { get; set; }

    [Column("item_amount_14", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount14 { get; set; }

    [Column("item_desc_15")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc15 { get; set; }

    [Column("item_amount_15", TypeName = "decimal(18, 3)")]
    public decimal? ItemAmount15 { get; set; }

    [Column("alwnc_desc_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc1 { get; set; }

    [Column("alwnc_amount_1", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount1 { get; set; }

    [Column("alwnc_desc_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc2 { get; set; }

    [Column("alwnc_amount_2", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount2 { get; set; }

    [Column("alwnc_desc_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc3 { get; set; }

    [Column("alwnc_amount_3", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount3 { get; set; }

    [Column("alwnc_desc_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc4 { get; set; }

    [Column("alwnc_amount_4", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount4 { get; set; }

    [Column("alwnc_desc_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc5 { get; set; }

    [Column("alwnc_amount_5", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount5 { get; set; }

    [Column("alwnc_desc_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc6 { get; set; }

    [Column("alwnc_amount_6", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount6 { get; set; }

    [Column("alwnc_desc_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc7 { get; set; }

    [Column("alwnc_amount_7", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount7 { get; set; }

    [Column("alwnc_desc_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc8 { get; set; }

    [Column("alwnc_amount_8", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount8 { get; set; }

    [Column("alwnc_desc_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc9 { get; set; }

    [Column("alwnc_amount_9", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount9 { get; set; }

    [Column("alwnc_desc_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc10 { get; set; }

    [Column("alwnc_amount_10", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount10 { get; set; }

    [Column("alwnc_desc_11")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc11 { get; set; }

    [Column("alwnc_amount_11", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount11 { get; set; }

    [Column("alwnc_desc_12")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc12 { get; set; }

    [Column("alwnc_amount_12", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount12 { get; set; }

    [Column("alwnc_desc_13")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc13 { get; set; }

    [Column("alwnc_amount_13", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount13 { get; set; }

    [Column("alwnc_desc_14")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc14 { get; set; }

    [Column("alwnc_amount_14", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount14 { get; set; }

    [Column("alwnc_desc_15")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc15 { get; set; }

    [Column("alwnc_amount_15", TypeName = "decimal(18, 3)")]
    public decimal? AlwncAmount15 { get; set; }

    [Column("deduct_desc_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc1 { get; set; }

    [Column("deduct_amount_1", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount1 { get; set; }

    [Column("deduct_desc_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc2 { get; set; }

    [Column("deduct_amount_2", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount2 { get; set; }

    [Column("deduct_desc_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc3 { get; set; }

    [Column("deduct_amount_3", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount3 { get; set; }

    [Column("deduct_desc_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc4 { get; set; }

    [Column("deduct_amount_4", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount4 { get; set; }

    [Column("deduct_desc_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc5 { get; set; }

    [Column("deduct_amount_5", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount5 { get; set; }

    [Column("deduct_desc_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc6 { get; set; }

    [Column("deduct_amount_6", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount6 { get; set; }

    [Column("deduct_desc_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc7 { get; set; }

    [Column("deduct_amount_7", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount7 { get; set; }

    [Column("deduct_desc_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc8 { get; set; }

    [Column("deduct_amount_8", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount8 { get; set; }

    [Column("deduct_desc_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc9 { get; set; }

    [Column("deduct_amount_9", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount9 { get; set; }

    [Column("deduct_desc_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc10 { get; set; }

    [Column("deduct_amount_10", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount10 { get; set; }

    [Column("deduct_desc_11")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc11 { get; set; }

    [Column("deduct_amount_11", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount11 { get; set; }

    [Column("deduct_desc_12")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc12 { get; set; }

    [Column("deduct_amount_12", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount12 { get; set; }

    [Column("deduct_desc_13")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc13 { get; set; }

    [Column("deduct_amount_13", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount13 { get; set; }

    [Column("deduct_desc_14")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc14 { get; set; }

    [Column("deduct_amount_14", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount14 { get; set; }

    [Column("deduct_desc_15")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc15 { get; set; }

    [Column("deduct_amount_15", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount15 { get; set; }

    [Column("deduct_desc_16")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc16 { get; set; }

    [Column("deduct_amount_16", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount16 { get; set; }

    [Column("deduct_desc_17")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc17 { get; set; }

    [Column("deduct_amount_17", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount17 { get; set; }

    [Column("deduct_desc_18")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc18 { get; set; }

    [Column("deduct_amount_18", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount18 { get; set; }

    [Column("deduct_desc_19")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc19 { get; set; }

    [Column("deduct_amount_19", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount19 { get; set; }

    [Column("deduct_desc_20")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc20 { get; set; }

    [Column("deduct_amount_20", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount20 { get; set; }

    [Column("deduct_desc_21")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc21 { get; set; }

    [Column("deduct_amount_21", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount21 { get; set; }

    [Column("deduct_desc_22")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc22 { get; set; }

    [Column("deduct_amount_22", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount22 { get; set; }

    [Column("deduct_desc_23")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc23 { get; set; }

    [Column("deduct_amount_23", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount23 { get; set; }

    [Column("deduct_desc_24")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc24 { get; set; }

    [Column("deduct_amount_24", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount24 { get; set; }

    [Column("deduct_desc_25")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc25 { get; set; }

    [Column("deduct_amount_25", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount25 { get; set; }

    [Column("deduct_desc_26")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc26 { get; set; }

    [Column("deduct_amount_26", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount26 { get; set; }

    [Column("deduct_desc_27")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc27 { get; set; }

    [Column("deduct_amount_27", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount27 { get; set; }

    [Column("deduct_desc_28")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc28 { get; set; }

    [Column("deduct_amount_28", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount28 { get; set; }

    [Column("deduct_desc_29")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc29 { get; set; }

    [Column("deduct_amount_29", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount29 { get; set; }

    [Column("deduct_desc_30")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc30 { get; set; }

    [Column("deduct_amount_30", TypeName = "decimal(18, 3)")]
    public decimal? DeductAmount30 { get; set; }

    [Column("legal_salary", TypeName = "decimal(18, 3)")]
    public decimal? LegalSalary { get; set; }

    [Column("legal_job")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LegalJob { get; set; }

    [Column("work_day_leave", TypeName = "decimal(18, 3)")]
    public decimal? WorkDayLeave { get; set; }

    [Column("work_day_leave_rate", TypeName = "decimal(18, 5)")]
    public decimal? WorkDayLeaveRate { get; set; }

    [Column("work_day_vacation", TypeName = "decimal(18, 3)")]
    public decimal? WorkDayVacation { get; set; }

    [Column("work_day_late", TypeName = "decimal(18, 3)")]
    public decimal? WorkDayLate { get; set; }

    [Column("work_hour_late", TypeName = "decimal(18, 3)")]
    public decimal? WorkHourLate { get; set; }

    [Column("sick_first_leave", TypeName = "decimal(18, 3)")]
    public decimal? SickFirstLeave { get; set; }

    [Column("sick_scnd_leave", TypeName = "decimal(18, 3)")]
    public decimal? SickScndLeave { get; set; }

    [Column("sick_third_leave", TypeName = "decimal(18, 3)")]
    public decimal? SickThirdLeave { get; set; }

    [Column("sick_fourth_leave", TypeName = "decimal(18, 3)")]
    public decimal? SickFourthLeave { get; set; }

    [Column("first_final_serviceb", TypeName = "decimal(18, 3)")]
    public decimal? FirstFinalServiceb { get; set; }

    [Column("scnd_final_serviceb", TypeName = "decimal(18, 3)")]
    public decimal? ScndFinalServiceb { get; set; }

    [Column("day_vacation", TypeName = "decimal(18, 3)")]
    public decimal? DayVacation { get; set; }
}
