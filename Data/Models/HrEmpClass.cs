using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("hr_emp_class")]
public partial class HrEmpClass
{
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

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("acdmc_qulfc_id", TypeName = "decimal(18, 0)")]
    public decimal? AcdmcQulfcId { get; set; }

    [Column("bank_id", TypeName = "decimal(18, 0)")]
    public decimal? BankId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("deprt_id", TypeName = "decimal(18, 0)")]
    public decimal? DeprtId { get; set; }

    [Column("item_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemAccId { get; set; }

    [Column("alwnc_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AlwncAccId { get; set; }

    [Column("deduct_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? DeductAccId { get; set; }

    [Column("emp_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpAccId { get; set; }

    [Column("acc_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? AccCostId { get; set; }

    [Column("acc_exp_id", TypeName = "decimal(18, 0)")]
    public decimal? AccExpId { get; set; }

    [Column("acc_analysis_id")]
    [StringLength(10)]
    [Unicode(false)]
    public string? AccAnalysisId { get; set; }

    [Column("item_desc_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc1 { get; set; }

    [Column("item_amount_1", TypeName = "decimal(18, 4)")]
    public decimal? ItemAmount1 { get; set; }

    [Column("item_desc_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc2 { get; set; }

    [Column("item_amount_2", TypeName = "decimal(18, 4)")]
    public decimal? ItemAmount2 { get; set; }

    [Column("item_desc_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc3 { get; set; }

    [Column("item_amount_3", TypeName = "decimal(18, 4)")]
    public decimal? ItemAmount3 { get; set; }

    [Column("item_desc_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc4 { get; set; }

    [Column("item_amount_4", TypeName = "decimal(18, 4)")]
    public decimal? ItemAmount4 { get; set; }

    [Column("item_desc_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc5 { get; set; }

    [Column("item_amount_5", TypeName = "decimal(18, 4)")]
    public decimal? ItemAmount5 { get; set; }

    [Column("item_desc_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc6 { get; set; }

    [Column("item_amount_6", TypeName = "decimal(18, 4)")]
    public decimal? ItemAmount6 { get; set; }

    [Column("item_desc_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc7 { get; set; }

    [Column("item_amount_7", TypeName = "decimal(18, 4)")]
    public decimal? ItemAmount7 { get; set; }

    [Column("item_desc_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc8 { get; set; }

    [Column("item_amount_8", TypeName = "decimal(18, 4)")]
    public decimal? ItemAmount8 { get; set; }

    [Column("item_desc_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc9 { get; set; }

    [Column("item_amount_9", TypeName = "decimal(18, 4)")]
    public decimal? ItemAmount9 { get; set; }

    [Column("item_desc_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc10 { get; set; }

    [Column("item_amount_10", TypeName = "decimal(18, 4)")]
    public decimal? ItemAmount10 { get; set; }

    [Column("item_desc_11")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc11 { get; set; }

    [Column("item_amount_11", TypeName = "decimal(18, 4)")]
    public decimal? ItemAmount11 { get; set; }

    [Column("item_desc_12")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc12 { get; set; }

    [Column("item_amount_12", TypeName = "decimal(18, 4)")]
    public decimal? ItemAmount12 { get; set; }

    [Column("item_desc_13")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc13 { get; set; }

    [Column("item_amount_13", TypeName = "decimal(18, 4)")]
    public decimal? ItemAmount13 { get; set; }

    [Column("item_desc_14")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc14 { get; set; }

    [Column("item_amount_14", TypeName = "decimal(18, 4)")]
    public decimal? ItemAmount14 { get; set; }

    [Column("item_desc_15")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ItemDesc15 { get; set; }

    [Column("item_amount_15", TypeName = "decimal(18, 4)")]
    public decimal? ItemAmount15 { get; set; }

    [Column("alwnc_desc_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc1 { get; set; }

    [Column("alwnc_amount_1", TypeName = "decimal(18, 4)")]
    public decimal? AlwncAmount1 { get; set; }

    [Column("alwnc_desc_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc2 { get; set; }

    [Column("alwnc_amount_2", TypeName = "decimal(18, 4)")]
    public decimal? AlwncAmount2 { get; set; }

    [Column("alwnc_desc_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc3 { get; set; }

    [Column("alwnc_amount_3", TypeName = "decimal(18, 4)")]
    public decimal? AlwncAmount3 { get; set; }

    [Column("alwnc_desc_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc4 { get; set; }

    [Column("alwnc_amount_4", TypeName = "decimal(18, 4)")]
    public decimal? AlwncAmount4 { get; set; }

    [Column("alwnc_desc_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc5 { get; set; }

    [Column("alwnc_amount_5", TypeName = "decimal(18, 4)")]
    public decimal? AlwncAmount5 { get; set; }

    [Column("alwnc_desc_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc6 { get; set; }

    [Column("alwnc_amount_6", TypeName = "decimal(18, 4)")]
    public decimal? AlwncAmount6 { get; set; }

    [Column("alwnc_desc_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc7 { get; set; }

    [Column("alwnc_amount_7", TypeName = "decimal(18, 4)")]
    public decimal? AlwncAmount7 { get; set; }

    [Column("alwnc_desc_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc8 { get; set; }

    [Column("alwnc_amount_8", TypeName = "decimal(18, 4)")]
    public decimal? AlwncAmount8 { get; set; }

    [Column("alwnc_desc_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc9 { get; set; }

    [Column("alwnc_amount_9", TypeName = "decimal(18, 4)")]
    public decimal? AlwncAmount9 { get; set; }

    [Column("alwnc_desc_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc10 { get; set; }

    [Column("alwnc_amount_10", TypeName = "decimal(18, 4)")]
    public decimal? AlwncAmount10 { get; set; }

    [Column("alwnc_desc_11")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc11 { get; set; }

    [Column("alwnc_amount_11", TypeName = "decimal(18, 4)")]
    public decimal? AlwncAmount11 { get; set; }

    [Column("alwnc_desc_12")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc12 { get; set; }

    [Column("alwnc_amount_12", TypeName = "decimal(18, 4)")]
    public decimal? AlwncAmount12 { get; set; }

    [Column("alwnc_desc_13")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc13 { get; set; }

    [Column("alwnc_amount_13", TypeName = "decimal(18, 4)")]
    public decimal? AlwncAmount13 { get; set; }

    [Column("alwnc_desc_14")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc14 { get; set; }

    [Column("alwnc_amount_14", TypeName = "decimal(18, 4)")]
    public decimal? AlwncAmount14 { get; set; }

    [Column("alwnc_desc_15")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AlwncDesc15 { get; set; }

    [Column("alwnc_amount_15", TypeName = "decimal(18, 4)")]
    public decimal? AlwncAmount15 { get; set; }

    [Column("deduct_desc_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc1 { get; set; }

    [Column("deduct_amount_1", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount1 { get; set; }

    [Column("deduct_desc_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc2 { get; set; }

    [Column("deduct_amount_2", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount2 { get; set; }

    [Column("deduct_desc_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc3 { get; set; }

    [Column("deduct_amount_3", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount3 { get; set; }

    [Column("deduct_desc_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc4 { get; set; }

    [Column("deduct_amount_4", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount4 { get; set; }

    [Column("deduct_desc_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc5 { get; set; }

    [Column("deduct_amount_5", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount5 { get; set; }

    [Column("deduct_desc_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc6 { get; set; }

    [Column("deduct_amount_6", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount6 { get; set; }

    [Column("deduct_desc_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc7 { get; set; }

    [Column("deduct_amount_7", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount7 { get; set; }

    [Column("deduct_desc_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc8 { get; set; }

    [Column("deduct_amount_8", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount8 { get; set; }

    [Column("deduct_desc_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc9 { get; set; }

    [Column("deduct_amount_9", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount9 { get; set; }

    [Column("deduct_desc_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc10 { get; set; }

    [Column("deduct_amount_10", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount10 { get; set; }

    [Column("deduct_desc_11")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc11 { get; set; }

    [Column("deduct_amount_11", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount11 { get; set; }

    [Column("deduct_desc_12")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc12 { get; set; }

    [Column("deduct_amount_12", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount12 { get; set; }

    [Column("deduct_desc_13")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc13 { get; set; }

    [Column("deduct_amount_13", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount13 { get; set; }

    [Column("deduct_desc_14")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc14 { get; set; }

    [Column("deduct_amount_14", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount14 { get; set; }

    [Column("deduct_desc_15")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc15 { get; set; }

    [Column("deduct_amount_15", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount15 { get; set; }

    [Column("deduct_desc_16")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc16 { get; set; }

    [Column("deduct_amount_16", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount16 { get; set; }

    [Column("deduct_desc_17")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc17 { get; set; }

    [Column("deduct_amount_17", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount17 { get; set; }

    [Column("deduct_desc_18")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc18 { get; set; }

    [Column("deduct_amount_18", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount18 { get; set; }

    [Column("deduct_desc_19")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc19 { get; set; }

    [Column("deduct_amount_19", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount19 { get; set; }

    [Column("deduct_desc_20")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc20 { get; set; }

    [Column("deduct_amount_20", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount20 { get; set; }

    [Column("deduct_desc_21")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc21 { get; set; }

    [Column("deduct_amount_21", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount21 { get; set; }

    [Column("deduct_desc_22")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc22 { get; set; }

    [Column("deduct_amount_22", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount22 { get; set; }

    [Column("deduct_desc_23")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc23 { get; set; }

    [Column("deduct_amount_23", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount23 { get; set; }

    [Column("deduct_desc_24")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc24 { get; set; }

    [Column("deduct_amount_24", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount24 { get; set; }

    [Column("deduct_desc_25")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc25 { get; set; }

    [Column("deduct_amount_25", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount25 { get; set; }

    [Column("deduct_desc_26")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc26 { get; set; }

    [Column("deduct_amount_26", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount26 { get; set; }

    [Column("deduct_desc_27")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc27 { get; set; }

    [Column("deduct_amount_27", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount27 { get; set; }

    [Column("deduct_desc_28")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc28 { get; set; }

    [Column("deduct_amount_28", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount28 { get; set; }

    [Column("deduct_desc_29")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc29 { get; set; }

    [Column("deduct_amount_29", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount29 { get; set; }

    [Column("deduct_desc_30")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeductDesc30 { get; set; }

    [Column("deduct_amount_30", TypeName = "decimal(18, 4)")]
    public decimal? DeductAmount30 { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("alow_item_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowItem1 { get; set; }

    [Column("alow_item_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowItem2 { get; set; }

    [Column("alow_item_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowItem3 { get; set; }

    [Column("alow_item_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowItem4 { get; set; }

    [Column("alow_item_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowItem5 { get; set; }

    [Column("alow_item_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowItem6 { get; set; }

    [Column("alow_item_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowItem7 { get; set; }

    [Column("alow_item_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowItem8 { get; set; }

    [Column("alow_item_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowItem9 { get; set; }

    [Column("alow_item_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowItem10 { get; set; }

    [Column("alow_item_11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowItem11 { get; set; }

    [Column("alow_item_12")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowItem12 { get; set; }

    [Column("alow_item_13")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowItem13 { get; set; }

    [Column("alow_item_14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowItem14 { get; set; }

    [Column("alow_item_15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowItem15 { get; set; }

    [Column("alow_alwnc_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowAlwnc1 { get; set; }

    [Column("alow_alwnc_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowAlwnc2 { get; set; }

    [Column("alow_alwnc_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowAlwnc3 { get; set; }

    [Column("alow_alwnc_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowAlwnc4 { get; set; }

    [Column("alow_alwnc_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowAlwnc5 { get; set; }

    [Column("alow_alwnc_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowAlwnc6 { get; set; }

    [Column("alow_alwnc_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowAlwnc7 { get; set; }

    [Column("alow_alwnc_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowAlwnc8 { get; set; }

    [Column("alow_alwnc_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowAlwnc9 { get; set; }

    [Column("alow_alwnc_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowAlwnc10 { get; set; }

    [Column("alow_alwnc_11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowAlwnc11 { get; set; }

    [Column("alow_alwnc_12")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowAlwnc12 { get; set; }

    [Column("alow_alwnc_13")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowAlwnc13 { get; set; }

    [Column("alow_alwnc_14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowAlwnc14 { get; set; }

    [Column("alow_alwnc_15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowAlwnc15 { get; set; }

    [Column("alow_deduct_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct1 { get; set; }

    [Column("alow_deduct_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct2 { get; set; }

    [Column("alow_deduct_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct3 { get; set; }

    [Column("alow_deduct_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct4 { get; set; }

    [Column("alow_deduct_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct5 { get; set; }

    [Column("alow_deduct_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct6 { get; set; }

    [Column("alow_deduct_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct7 { get; set; }

    [Column("alow_deduct_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct8 { get; set; }

    [Column("alow_deduct_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct9 { get; set; }

    [Column("alow_deduct_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct10 { get; set; }

    [Column("alow_deduct_11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct11 { get; set; }

    [Column("alow_deduct_12")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct12 { get; set; }

    [Column("alow_deduct_13")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct13 { get; set; }

    [Column("alow_deduct_14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct14 { get; set; }

    [Column("alow_deduct_15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct15 { get; set; }

    [Column("alow_deduct_16")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct16 { get; set; }

    [Column("alow_deduct_17")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct17 { get; set; }

    [Column("alow_deduct_18")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct18 { get; set; }

    [Column("alow_deduct_19")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct19 { get; set; }

    [Column("alow_deduct_20")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct20 { get; set; }

    [Column("alow_deduct_21")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct21 { get; set; }

    [Column("alow_deduct_22")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct22 { get; set; }

    [Column("alow_deduct_23")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct23 { get; set; }

    [Column("alow_deduct_24")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct24 { get; set; }

    [Column("alow_deduct_25")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct25 { get; set; }

    [Column("alow_deduct_26")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct26 { get; set; }

    [Column("alow_deduct_27")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct27 { get; set; }

    [Column("alow_deduct_28")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct28 { get; set; }

    [Column("alow_deduct_29")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct29 { get; set; }

    [Column("alow_deduct_30")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDeduct30 { get; set; }

    [Column("work_day_leave", TypeName = "decimal(18, 4)")]
    public decimal? WorkDayLeave { get; set; }

    [Column("work_day_leave_rate", TypeName = "decimal(18, 5)")]
    public decimal? WorkDayLeaveRate { get; set; }

    [Column("work_day_vacation", TypeName = "decimal(18, 4)")]
    public decimal? WorkDayVacation { get; set; }

    [Column("work_day_late", TypeName = "decimal(18, 4)")]
    public decimal? WorkDayLate { get; set; }

    [Column("work_hour_late", TypeName = "decimal(18, 4)")]
    public decimal? WorkHourLate { get; set; }

    [Column("sick_first_leave", TypeName = "decimal(18, 4)")]
    public decimal? SickFirstLeave { get; set; }

    [Column("sick_scnd_leave", TypeName = "decimal(18, 4)")]
    public decimal? SickScndLeave { get; set; }

    [Column("sick_third_leave", TypeName = "decimal(18, 4)")]
    public decimal? SickThirdLeave { get; set; }

    [Column("sick_fourth_leave", TypeName = "decimal(18, 4)")]
    public decimal? SickFourthLeave { get; set; }

    [Column("first_Final_serviceb", TypeName = "decimal(18, 4)")]
    public decimal? FirstFinalServiceb { get; set; }

    [Column("scnd_Final_serviceb", TypeName = "decimal(18, 4)")]
    public decimal? ScndFinalServiceb { get; set; }

    [Column("day_vacation", TypeName = "decimal(18, 4)")]
    public decimal? DayVacation { get; set; }

    [Column("overtime_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? OvertimeType { get; set; }

    [Column("over1_from", TypeName = "decimal(18, 3)")]
    public decimal? Over1From { get; set; }

    [Column("over1_to", TypeName = "decimal(18, 3)")]
    public decimal? Over1To { get; set; }

    [Column("over1_rate", TypeName = "decimal(18, 3)")]
    public decimal? Over1Rate { get; set; }

    [Column("over2_from", TypeName = "decimal(18, 3)")]
    public decimal? Over2From { get; set; }

    [Column("over2_to", TypeName = "decimal(18, 3)")]
    public decimal? Over2To { get; set; }

    [Column("over2_rate", TypeName = "decimal(18, 3)")]
    public decimal? Over2Rate { get; set; }

    [Column("over3_from", TypeName = "decimal(18, 3)")]
    public decimal? Over3From { get; set; }

    [Column("over3_to", TypeName = "decimal(18, 3)")]
    public decimal? Over3To { get; set; }

    [Column("over3_rate", TypeName = "decimal(18, 3)")]
    public decimal? Over3Rate { get; set; }

    [Column("over4_from", TypeName = "decimal(18, 3)")]
    public decimal? Over4From { get; set; }

    [Column("over4_to", TypeName = "decimal(18, 3)")]
    public decimal? Over4To { get; set; }

    [Column("over4_rate", TypeName = "decimal(18, 3)")]
    public decimal? Over4Rate { get; set; }

    [Column("over5_from", TypeName = "decimal(18, 3)")]
    public decimal? Over5From { get; set; }

    [Column("over5_to", TypeName = "decimal(18, 3)")]
    public decimal? Over5To { get; set; }

    [Column("over5_rate", TypeName = "decimal(18, 3)")]
    public decimal? Over5Rate { get; set; }

    [Column("late_first_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LateFirstType { get; set; }

    [Column("late_first_reset", TypeName = "decimal(18, 3)")]
    public decimal? LateFirstReset { get; set; }

    [Column("late_first_from", TypeName = "decimal(18, 3)")]
    public decimal? LateFirstFrom { get; set; }

    [Column("late_first_to", TypeName = "decimal(18, 3)")]
    public decimal? LateFirstTo { get; set; }

    [Column("late_first_free", TypeName = "decimal(18, 3)")]
    public decimal? LateFirstFree { get; set; }

    [Column("late_first1_from", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst1From { get; set; }

    [Column("late_first1_to", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst1To { get; set; }

    [Column("late_first1_day", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst1Day { get; set; }

    [Column("late_first1_hour", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst1Hour { get; set; }

    [Column("late_first2_from", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst2From { get; set; }

    [Column("late_first2_to", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst2To { get; set; }

    [Column("late_first2_day", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst2Day { get; set; }

    [Column("late_first2_hour", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst2Hour { get; set; }

    [Column("late_first3_from", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst3From { get; set; }

    [Column("late_first3_to", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst3To { get; set; }

    [Column("late_first3_day", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst3Day { get; set; }

    [Column("late_first3_hour", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst3Hour { get; set; }

    [Column("late_first4_from", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst4From { get; set; }

    [Column("late_first4_to", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst4To { get; set; }

    [Column("late_first4_day", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst4Day { get; set; }

    [Column("late_first4_hour", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst4Hour { get; set; }

    [Column("late_first5_from", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst5From { get; set; }

    [Column("late_first5_to", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst5To { get; set; }

    [Column("late_first5_day", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst5Day { get; set; }

    [Column("late_first5_hour", TypeName = "decimal(18, 3)")]
    public decimal? LateFirst5Hour { get; set; }

    [Column("late_scnd_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LateScndType { get; set; }

    [Column("late_scnd_reset", TypeName = "decimal(18, 3)")]
    public decimal? LateScndReset { get; set; }

    [Column("late_scnd_from", TypeName = "decimal(18, 3)")]
    public decimal? LateScndFrom { get; set; }

    [Column("late_scnd_to", TypeName = "decimal(18, 3)")]
    public decimal? LateScndTo { get; set; }

    [Column("late_scnd_free", TypeName = "decimal(18, 3)")]
    public decimal? LateScndFree { get; set; }

    [Column("late_scnd1_from", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd1From { get; set; }

    [Column("late_scnd1_to", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd1To { get; set; }

    [Column("late_scnd1_day", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd1Day { get; set; }

    [Column("late_scnd1_hour", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd1Hour { get; set; }

    [Column("late_scnd2_from", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd2From { get; set; }

    [Column("late_scnd2_to", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd2To { get; set; }

    [Column("late_scnd2_day", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd2Day { get; set; }

    [Column("late_scnd2_hour", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd2Hour { get; set; }

    [Column("late_scnd3_from", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd3From { get; set; }

    [Column("late_scnd3_to", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd3To { get; set; }

    [Column("late_scnd3_day", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd3Day { get; set; }

    [Column("late_scnd3_hour", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd3Hour { get; set; }

    [Column("late_scnd4_from", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd4From { get; set; }

    [Column("late_scnd4_to", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd4To { get; set; }

    [Column("late_scnd4_day", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd4Day { get; set; }

    [Column("late_scnd4_hour", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd4Hour { get; set; }

    [Column("late_scnd5_from", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd5From { get; set; }

    [Column("late_scnd5_to", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd5To { get; set; }

    [Column("late_scnd5_day", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd5Day { get; set; }

    [Column("late_scnd5_hour", TypeName = "decimal(18, 3)")]
    public decimal? LateScnd5Hour { get; set; }

    [Column("permt_first_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PermtFirstType { get; set; }

    [Column("permt_first_reset", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirstReset { get; set; }

    [Column("permt_first_from", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirstFrom { get; set; }

    [Column("permt_first_to", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirstTo { get; set; }

    [Column("permt_first_free", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirstFree { get; set; }

    [Column("permt_first1_from", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst1From { get; set; }

    [Column("permt_first1_to", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst1To { get; set; }

    [Column("permt_first1_day", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst1Day { get; set; }

    [Column("permt_first1_hour", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst1Hour { get; set; }

    [Column("permt_first2_from", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst2From { get; set; }

    [Column("permt_first2_to", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst2To { get; set; }

    [Column("permt_first2_day", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst2Day { get; set; }

    [Column("permt_first2_hour", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst2Hour { get; set; }

    [Column("permt_first3_from", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst3From { get; set; }

    [Column("permt_first3_to", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst3To { get; set; }

    [Column("permt_first3_day", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst3Day { get; set; }

    [Column("permt_first3_hour", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst3Hour { get; set; }

    [Column("permt_first4_from", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst4From { get; set; }

    [Column("permt_first4_to", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst4To { get; set; }

    [Column("permt_first4_day", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst4Day { get; set; }

    [Column("permt_first4_hour", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst4Hour { get; set; }

    [Column("permt_first5_from", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst5From { get; set; }

    [Column("permt_first5_to", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst5To { get; set; }

    [Column("permt_first5_day", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst5Day { get; set; }

    [Column("permt_first5_hour", TypeName = "decimal(18, 3)")]
    public decimal? PermtFirst5Hour { get; set; }

    [Column("permt_scnd_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PermtScndType { get; set; }

    [Column("permt_scnd_reset", TypeName = "decimal(18, 3)")]
    public decimal? PermtScndReset { get; set; }

    [Column("permt_scnd_from", TypeName = "decimal(18, 3)")]
    public decimal? PermtScndFrom { get; set; }

    [Column("permt_scnd_to", TypeName = "decimal(18, 3)")]
    public decimal? PermtScndTo { get; set; }

    [Column("permt_scnd_free", TypeName = "decimal(18, 3)")]
    public decimal? PermtScndFree { get; set; }

    [Column("permt_scnd1_from", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd1From { get; set; }

    [Column("permt_scnd1_to", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd1To { get; set; }

    [Column("permt_scnd1_day", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd1Day { get; set; }

    [Column("permt_scnd1_hour", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd1Hour { get; set; }

    [Column("permt_scnd2_from", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd2From { get; set; }

    [Column("permt_scnd2_to", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd2To { get; set; }

    [Column("permt_scnd2_day", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd2Day { get; set; }

    [Column("permt_scnd2_hour", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd2Hour { get; set; }

    [Column("permt_scnd3_from", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd3From { get; set; }

    [Column("permt_scnd3_to", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd3To { get; set; }

    [Column("permt_scnd3_day", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd3Day { get; set; }

    [Column("permt_scnd3_hour", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd3Hour { get; set; }

    [Column("permt_scnd4_from", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd4From { get; set; }

    [Column("permt_scnd4_to", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd4To { get; set; }

    [Column("permt_scnd4_day", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd4Day { get; set; }

    [Column("permt_scnd4_hour", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd4Hour { get; set; }

    [Column("permt_scnd5_from", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd5From { get; set; }

    [Column("permt_scnd5_to", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd5To { get; set; }

    [Column("permt_scnd5_day", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd5Day { get; set; }

    [Column("permt_scnd5_hour", TypeName = "decimal(18, 3)")]
    public decimal? PermtScnd5Hour { get; set; }

    [Column("absn_first_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AbsnFirstType { get; set; }

    [Column("absn_first_reset", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirstReset { get; set; }

    [Column("absn_first_from", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirstFrom { get; set; }

    [Column("absn_first_to", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirstTo { get; set; }

    [Column("absn_first_free", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirstFree { get; set; }

    [Column("absn_first1_from", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst1From { get; set; }

    [Column("absn_first1_to", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst1To { get; set; }

    [Column("absn_first1_day", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst1Day { get; set; }

    [Column("absn_first1_hour", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst1Hour { get; set; }

    [Column("absn_first2_from", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst2From { get; set; }

    [Column("absn_first2_to", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst2To { get; set; }

    [Column("absn_first2_day", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst2Day { get; set; }

    [Column("absn_first2_hour", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst2Hour { get; set; }

    [Column("absn_first3_from", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst3From { get; set; }

    [Column("absn_first3_to", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst3To { get; set; }

    [Column("absn_first3_day", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst3Day { get; set; }

    [Column("absn_first3_hour", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst3Hour { get; set; }

    [Column("absn_first4_from", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst4From { get; set; }

    [Column("absn_first4_to", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst4To { get; set; }

    [Column("absn_first4_day", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst4Day { get; set; }

    [Column("absn_first4_hour", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst4Hour { get; set; }

    [Column("absn_first5_from", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst5From { get; set; }

    [Column("absn_first5_to", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst5To { get; set; }

    [Column("absn_first5_day", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst5Day { get; set; }

    [Column("absn_first5_hour", TypeName = "decimal(18, 3)")]
    public decimal? AbsnFirst5Hour { get; set; }

    [Column("absn_scnd_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AbsnScndType { get; set; }

    [Column("absn_scnd_reset", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScndReset { get; set; }

    [Column("absn_scnd_from", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScndFrom { get; set; }

    [Column("absn_scnd_to", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScndTo { get; set; }

    [Column("absn_scnd_free", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScndFree { get; set; }

    [Column("absn_scnd1_from", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd1From { get; set; }

    [Column("absn_scnd1_to", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd1To { get; set; }

    [Column("absn_scnd1_day", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd1Day { get; set; }

    [Column("absn_scnd1_hour", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd1Hour { get; set; }

    [Column("absn_scnd2_from", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd2From { get; set; }

    [Column("absn_scnd2_to", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd2To { get; set; }

    [Column("absn_scnd2_day", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd2Day { get; set; }

    [Column("absn_scnd2_hour", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd2Hour { get; set; }

    [Column("absn_scnd3_from", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd3From { get; set; }

    [Column("absn_scnd3_to", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd3To { get; set; }

    [Column("absn_scnd3_day", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd3Day { get; set; }

    [Column("absn_scnd3_hour", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd3Hour { get; set; }

    [Column("absn_scnd4_from", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd4From { get; set; }

    [Column("absn_scnd4_to", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd4To { get; set; }

    [Column("absn_scnd4_day", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd4Day { get; set; }

    [Column("absn_scnd4_hour", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd4Hour { get; set; }

    [Column("absn_scnd5_from", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd5From { get; set; }

    [Column("absn_scnd5_to", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd5To { get; set; }

    [Column("absn_scnd5_day", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd5Day { get; set; }

    [Column("absn_scnd5_hour", TypeName = "decimal(18, 3)")]
    public decimal? AbsnScnd5Hour { get; set; }

    [Column("comp_share", TypeName = "decimal(18, 5)")]
    public decimal? CompShare { get; set; }

    [Column("emp_share", TypeName = "decimal(18, 5)")]
    public decimal? EmpShare { get; set; }

    [Column("max_limit_indemnity", TypeName = "decimal(18, 3)")]
    public decimal? MaxLimitIndemnity { get; set; }

    [Column("insu_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? InsuType { get; set; }
}
