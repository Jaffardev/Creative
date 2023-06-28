using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("c_car_tcontract")]
public partial class CCarTcontract
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

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("con_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ConStatus { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("car_id", TypeName = "decimal(18, 0)")]
    public decimal? CarId { get; set; }

    [Column("exit_date", TypeName = "datetime")]
    public DateTime? ExitDate { get; set; }

    [Column("exit_time", TypeName = "datetime")]
    public DateTime? ExitTime { get; set; }

    [Column("return_date", TypeName = "datetime")]
    public DateTime? ReturnDate { get; set; }

    [Column("return_time", TypeName = "datetime")]
    public DateTime? ReturnTime { get; set; }

    [Column("day_amount", TypeName = "decimal(18, 4)")]
    public decimal? DayAmount { get; set; }

    [Column("day_rent")]
    public int? DayRent { get; set; }

    [Column("rent_to_1", TypeName = "datetime")]
    public DateTime? RentTo1 { get; set; }

    [Column("rent_to_2", TypeName = "datetime")]
    public DateTime? RentTo2 { get; set; }

    [Column("rent_to_3", TypeName = "datetime")]
    public DateTime? RentTo3 { get; set; }

    [Column("rent_to_4", TypeName = "datetime")]
    public DateTime? RentTo4 { get; set; }

    [Column("notes_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes1 { get; set; }

    [Column("notes_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes2 { get; set; }

    [Column("notes_3")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes3 { get; set; }

    [Column("notes_4")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes4 { get; set; }

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

    [Column("alow_km", TypeName = "decimal(18, 4)")]
    public decimal? AlowKm { get; set; }

    [Column("from_km", TypeName = "decimal(18, 4)")]
    public decimal? FromKm { get; set; }

    [Column("to_km", TypeName = "decimal(18, 0)")]
    public decimal? ToKm { get; set; }

    [Column("price_km", TypeName = "decimal(18, 4)")]
    public decimal? PriceKm { get; set; }

    [Column("con_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ConType { get; set; }

    [Column("add_amount_1", TypeName = "decimal(18, 4)")]
    public decimal? AddAmount1 { get; set; }

    [Column("add_notes_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? AddNotes1 { get; set; }

    [Column("add_amount_2", TypeName = "decimal(18, 4)")]
    public decimal? AddAmount2 { get; set; }

    [Column("add_notes_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? AddNotes2 { get; set; }

    [Column("add_amount_3", TypeName = "decimal(18, 4)")]
    public decimal? AddAmount3 { get; set; }

    [Column("add_notes_3")]
    [StringLength(500)]
    [Unicode(false)]
    public string? AddNotes3 { get; set; }

    [Column("discount_1", TypeName = "decimal(18, 4)")]
    public decimal? Discount1 { get; set; }

    [Column("discount_notes_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? DiscountNotes1 { get; set; }

    [Column("discount_2", TypeName = "decimal(18, 4)")]
    public decimal? Discount2 { get; set; }

    [Column("discount_notes_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? DiscountNotes2 { get; set; }
}
