using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("equ_cars")]
public partial class EquCar
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

    [Column("no_kt")]
    [StringLength(15)]
    [Unicode(false)]
    public string? NoKt { get; set; }

    [Column("class_id", TypeName = "decimal(18, 0)")]
    public decimal? ClassId { get; set; }

    [Column("make_id", TypeName = "decimal(18, 0)")]
    public decimal? MakeId { get; set; }

    [Column("inv_item_id", TypeName = "decimal(18, 0)")]
    public decimal? InvItemId { get; set; }

    [Column("car_type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CarType { get; set; }

    [Column("color")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Color { get; set; }

    [Column("model", TypeName = "decimal(18, 0)")]
    public decimal? Model { get; set; }

    [Column("shassy_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ShassyNo { get; set; }

    [Column("equipment_id", TypeName = "decimal(18, 0)")]
    public decimal? EquipmentId { get; set; }

    [Column("licen_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LicenNo { get; set; }

    [Column("licen_end_date", TypeName = "datetime")]
    public DateTime? LicenEndDate { get; set; }

    [Column("oil_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? OilType { get; set; }

    [Column("passenger_no")]
    public int? PassengerNo { get; set; }

    [Column("insu_company")]
    [StringLength(100)]
    [Unicode(false)]
    public string? InsuCompany { get; set; }

    [Column("insu_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InsuNo { get; set; }

    [Column("insu_from_date", TypeName = "datetime")]
    public DateTime? InsuFromDate { get; set; }

    [Column("insu_to_date", TypeName = "datetime")]
    public DateTime? InsuToDate { get; set; }

    [Column("income_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? IncomeAccId { get; set; }

    [Column("income_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? IncomeCostId { get; set; }

    [Column("income_exp_id", TypeName = "decimal(18, 0)")]
    public decimal? IncomeExpId { get; set; }

    [Column("income_analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? IncomeAnalysisId { get; set; }

    [Column("expenses_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpensesAccId { get; set; }

    [Column("expenses_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpensesCostId { get; set; }

    [Column("expenses_exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpensesExpId { get; set; }

    [Column("expenses_analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpensesAnalysisId { get; set; }

    [Column("work_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WorkStatus { get; set; }

    [Column("pur_date", TypeName = "datetime")]
    public DateTime? PurDate { get; set; }

    [Column("vendor_id", TypeName = "decimal(18, 0)")]
    public decimal? VendorId { get; set; }

    [Column("vendor_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? VendorName { get; set; }

    [Column("cat1_id", TypeName = "decimal(18, 0)")]
    public decimal? Cat1Id { get; set; }

    [Column("cat2_id", TypeName = "decimal(18, 0)")]
    public decimal? Cat2Id { get; set; }

    [Column("cat3_id", TypeName = "decimal(18, 0)")]
    public decimal? Cat3Id { get; set; }

    [Column("cat4_id", TypeName = "decimal(18, 0)")]
    public decimal? Cat4Id { get; set; }

    [Column("cat5_id", TypeName = "decimal(18, 0)")]
    public decimal? Cat5Id { get; set; }

    [Column("rent_amount_hours", TypeName = "decimal(18, 3)")]
    public decimal? RentAmountHours { get; set; }

    [Column("rent_amount_day", TypeName = "decimal(18, 3)")]
    public decimal? RentAmountDay { get; set; }

    [Column("rent_amount_week", TypeName = "decimal(18, 3)")]
    public decimal? RentAmountWeek { get; set; }

    [Column("rent_amount_moth", TypeName = "decimal(18, 3)")]
    public decimal? RentAmountMoth { get; set; }

    [Column("car_size")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CarSize { get; set; }

    [Column("ref_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RefNo { get; set; }

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

    [InverseProperty("Car")]
    public virtual ICollection<EquTmaintananceD> EquTmaintananceDs { get; set; } = new List<EquTmaintananceD>();
}
