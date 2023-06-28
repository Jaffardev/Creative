using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("equ_tcontrct_cars")]
public partial class EquTcontrctCar
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("con_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ConType { get; set; }

    [Column("deprt_id", TypeName = "decimal(18, 0)")]
    public decimal? DeprtId { get; set; }

    [Column("car_id", TypeName = "decimal(18, 0)")]
    public decimal? CarId { get; set; }

    [Column("emp_driver_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpDriverId { get; set; }

    [Column("emp_manger_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpMangerId { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("from_time", TypeName = "datetime")]
    public DateTime? FromTime { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("to_time", TypeName = "datetime")]
    public DateTime? ToTime { get; set; }

    [Column("project_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    [Column("project_desc")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ProjectDesc { get; set; }

    [Column("used_in")]
    [StringLength(200)]
    [Unicode(false)]
    public string? UsedIn { get; set; }

    [Column("location")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Location { get; set; }

    [Column("exit_date", TypeName = "datetime")]
    public DateTime? ExitDate { get; set; }

    [Column("exit_time", TypeName = "datetime")]
    public DateTime? ExitTime { get; set; }

    [Column("return_date", TypeName = "datetime")]
    public DateTime? ReturnDate { get; set; }

    [Column("return_time", TypeName = "datetime")]
    public DateTime? ReturnTime { get; set; }

    [Column("price_km", TypeName = "decimal(18, 3)")]
    public decimal? PriceKm { get; set; }

    [Column("alow_km", TypeName = "decimal(18, 3)")]
    public decimal? AlowKm { get; set; }

    [Column("from_km", TypeName = "decimal(18, 3)")]
    public decimal? FromKm { get; set; }

    [Column("to_km", TypeName = "decimal(18, 0)")]
    public decimal? ToKm { get; set; }

    [Column("price_hours", TypeName = "decimal(18, 3)")]
    public decimal? PriceHours { get; set; }

    [Column("alow_hours", TypeName = "decimal(18, 3)")]
    public decimal? AlowHours { get; set; }

    [Column("from_hours", TypeName = "decimal(18, 3)")]
    public decimal? FromHours { get; set; }

    [Column("to_hours", TypeName = "decimal(18, 0)")]
    public decimal? ToHours { get; set; }

    [Column("day_rent")]
    public int? DayRent { get; set; }

    [Column("day_amount", TypeName = "decimal(18, 3)")]
    public decimal? DayAmount { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("rent_amount", TypeName = "decimal(18, 3)")]
    public decimal? RentAmount { get; set; }

    [Column("driver_amount", TypeName = "decimal(18, 3)")]
    public decimal? DriverAmount { get; set; }

    [Column("service_amount", TypeName = "decimal(18, 3)")]
    public decimal? ServiceAmount { get; set; }

    [Column("penalty_amount", TypeName = "decimal(18, 3)")]
    public decimal? PenaltyAmount { get; set; }

    [Column("other_amount", TypeName = "decimal(18, 3)")]
    public decimal? OtherAmount { get; set; }

    [Column("discount_rate", TypeName = "decimal(18, 5)")]
    public decimal? DiscountRate { get; set; }

    [Column("discount", TypeName = "decimal(18, 3)")]
    public decimal? Discount { get; set; }

    [Column("add_amount_1", TypeName = "decimal(18, 3)")]
    public decimal? AddAmount1 { get; set; }

    [Column("add_amount_2", TypeName = "decimal(18, 3)")]
    public decimal? AddAmount2 { get; set; }

    [Column("add_notes_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? AddNotes1 { get; set; }

    [Column("add_notes_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? AddNotes2 { get; set; }

    [Column("discount_1", TypeName = "decimal(18, 3)")]
    public decimal? Discount1 { get; set; }

    [Column("discount_2", TypeName = "decimal(18, 3)")]
    public decimal? Discount2 { get; set; }

    [Column("discount_notes_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? DiscountNotes1 { get; set; }

    [Column("discount_notes_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? DiscountNotes2 { get; set; }

    [Column("notes_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes1 { get; set; }

    [Column("notes_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes2 { get; set; }

    [Column("radio")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Radio { get; set; }

    [Column("jack")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Jack { get; set; }

    [Column("cigarette_lighter")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CigaretteLighter { get; set; }

    [Column("floor_mats")]
    [StringLength(1)]
    [Unicode(false)]
    public string? FloorMats { get; set; }

    [Column("wheel_cover")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WheelCover { get; set; }

    [Column("wheel_kit")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WheelKit { get; set; }

    [Column("spare_wheel")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SpareWheel { get; set; }

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

    [InverseProperty("DIdNavigation")]
    public virtual ICollection<EquTcontractD> EquTcontractDs { get; set; } = new List<EquTcontractD>();

    [ForeignKey("HId")]
    [InverseProperty("EquTcontrctCars")]
    public virtual EquTcontrctH? HIdNavigation { get; set; }
}
