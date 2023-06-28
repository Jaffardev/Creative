using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("c_car_cars")]
public partial class CCarCar
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

    [Column("make_id", TypeName = "decimal(18, 0)")]
    public decimal? MakeId { get; set; }

    [Column("type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("color")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Color { get; set; }

    [Column("model", TypeName = "decimal(18, 0)")]
    public decimal? Model { get; set; }

    [Column("shassy_no", TypeName = "decimal(18, 0)")]
    public decimal? ShassyNo { get; set; }

    [Column("licen_to_date", TypeName = "datetime")]
    public DateTime? LicenToDate { get; set; }

    [Column("oil_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? OilType { get; set; }

    [Column("passenger_no")]
    public int? PassengerNo { get; set; }

    [Column("insu_company")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InsuCompany { get; set; }

    [Column("insu_no", TypeName = "decimal(18, 0)")]
    public decimal? InsuNo { get; set; }

    [Column("insu_from_date", TypeName = "datetime")]
    public DateTime? InsuFromDate { get; set; }

    [Column("insu_to_date", TypeName = "datetime")]
    public DateTime? InsuToDate { get; set; }

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

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("rent_amount", TypeName = "decimal(18, 3)")]
    public decimal? RentAmount { get; set; }

    [Column("rent_cost", TypeName = "decimal(18, 3)")]
    public decimal? RentCost { get; set; }
}
