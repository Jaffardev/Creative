using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("cnt_twork_card")]
public partial class CntTworkCard
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

    [Column("card_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CardType { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("cont_id", TypeName = "decimal(18, 0)")]
    public decimal? ContId { get; set; }

    [Column("car_id", TypeName = "decimal(18, 0)")]
    public decimal? CarId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 4)")]
    public decimal? EmpId { get; set; }

    [Column("equipment_id", TypeName = "decimal(18, 0)")]
    public decimal? EquipmentId { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("from_time", TypeName = "datetime")]
    public DateTime? FromTime { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("to_time", TypeName = "datetime")]
    public DateTime? ToTime { get; set; }

    [Column("commission_amount", TypeName = "decimal(18, 4)")]
    public decimal? CommissionAmount { get; set; }

    [Column("track_no", TypeName = "decimal(18, 4)")]
    public decimal? TrackNo { get; set; }

    [Column("from_km", TypeName = "decimal(18, 4)")]
    public decimal? FromKm { get; set; }

    [Column("to_km", TypeName = "decimal(18, 4)")]
    public decimal? ToKm { get; set; }

    [Column("from_place")]
    [StringLength(200)]
    [Unicode(false)]
    public string? FromPlace { get; set; }

    [Column("to_place")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ToPlace { get; set; }

    [Column("load_type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LoadType { get; set; }

    [Column("load_date", TypeName = "datetime")]
    public DateTime? LoadDate { get; set; }

    [Column("work_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WorkType { get; set; }

    [Column("exp_item_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpItem1 { get; set; }

    [Column("exp_amount_1", TypeName = "decimal(18, 4)")]
    public decimal? ExpAmount1 { get; set; }

    [Column("exp_item_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpItem2 { get; set; }

    [Column("exp_amount_2", TypeName = "decimal(18, 4)")]
    public decimal? ExpAmount2 { get; set; }

    [Column("exp_item_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpItem3 { get; set; }

    [Column("exp_amount_3", TypeName = "decimal(18, 4)")]
    public decimal? ExpAmount3 { get; set; }

    [Column("exp_item_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpItem4 { get; set; }

    [Column("exp_amount_4", TypeName = "decimal(18, 4)")]
    public decimal? ExpAmount4 { get; set; }

    [Column("exp_item_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpItem5 { get; set; }

    [Column("exp_amount_5", TypeName = "decimal(18, 4)")]
    public decimal? ExpAmount5 { get; set; }

    [Column("exp_item_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpItem6 { get; set; }

    [Column("exp_amount_6", TypeName = "decimal(18, 4)")]
    public decimal? ExpAmount6 { get; set; }

    [Column("exp_item_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpItem7 { get; set; }

    [Column("exp_amount_7", TypeName = "decimal(18, 4)")]
    public decimal? ExpAmount7 { get; set; }

    [Column("exp_item_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpItem8 { get; set; }

    [Column("exp_amount_8", TypeName = "decimal(18, 4)")]
    public decimal? ExpAmount8 { get; set; }

    [Column("exp_item_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpItem9 { get; set; }

    [Column("exp_amount_9", TypeName = "decimal(18, 4)")]
    public decimal? ExpAmount9 { get; set; }

    [Column("exp_item_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpItem10 { get; set; }

    [Column("exp_amount_10", TypeName = "decimal(18, 4)")]
    public decimal? ExpAmount10 { get; set; }

    [Column("income_item_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IncomeItem1 { get; set; }

    [Column("income_amount_1", TypeName = "decimal(18, 4)")]
    public decimal? IncomeAmount1 { get; set; }

    [Column("income_item_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IncomeItem2 { get; set; }

    [Column("income_amount_2", TypeName = "decimal(18, 4)")]
    public decimal? IncomeAmount2 { get; set; }

    [Column("income_item_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IncomeItem3 { get; set; }

    [Column("income_amount_3", TypeName = "decimal(18, 4)")]
    public decimal? IncomeAmount3 { get; set; }

    [Column("income_item_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IncomeItem4 { get; set; }

    [Column("income_amount_4", TypeName = "decimal(18, 4)")]
    public decimal? IncomeAmount4 { get; set; }

    [Column("income_item_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IncomeItem5 { get; set; }

    [Column("income_amount_5", TypeName = "decimal(18, 4)")]
    public decimal? IncomeAmount5 { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

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

    [Column("qty", TypeName = "decimal(18, 3)")]
    public decimal? Qty { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("Unit_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("sal_cust_id", TypeName = "decimal(18, 0)")]
    public decimal? SalCustId { get; set; }
}
