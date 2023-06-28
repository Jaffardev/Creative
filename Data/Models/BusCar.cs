using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("bus_car")]
public partial class BusCar
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("file_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FileNo { get; set; }

    [Column("ref_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

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

    [Column("insu_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InsuNo { get; set; }

    [Column("insu_from_date", TypeName = "datetime")]
    public DateTime? InsuFromDate { get; set; }

    [Column("insu_to_date", TypeName = "datetime")]
    public DateTime? InsuToDate { get; set; }

    [Column("insu_amount", TypeName = "decimal(18, 3)")]
    public decimal? InsuAmount { get; set; }

    [Column("insu_gold_company")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InsuGoldCompany { get; set; }

    [Column("insu_gold_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InsuGoldNo { get; set; }

    [Column("insu_gold_from_date", TypeName = "datetime")]
    public DateTime? InsuGoldFromDate { get; set; }

    [Column("insu_gold_to_date", TypeName = "datetime")]
    public DateTime? InsuGoldToDate { get; set; }

    [Column("insu_gold_amount", TypeName = "decimal(18, 3)")]
    public decimal? InsuGoldAmount { get; set; }

    [Column("ven_id", TypeName = "decimal(18, 0)")]
    public decimal? VenId { get; set; }

    [Column("con_id", TypeName = "decimal(18, 0)")]
    public decimal? ConId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("po_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PoNo { get; set; }

    [Column("con_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ConNo { get; set; }

    [Column("con_start_date", TypeName = "datetime")]
    public DateTime? ConStartDate { get; set; }

    [Column("con_end_date", TypeName = "datetime")]
    public DateTime? ConEndDate { get; set; }

    [Column("delivery_date", TypeName = "datetime")]
    public DateTime? DeliveryDate { get; set; }

    [Column("return_date", TypeName = "datetime")]
    public DateTime? ReturnDate { get; set; }

    [Column("day_cost", TypeName = "decimal(18, 3)")]
    public decimal? DayCost { get; set; }

    [Column("day_price", TypeName = "decimal(18, 3)")]
    public decimal? DayPrice { get; set; }

    [Column("month_cost", TypeName = "decimal(18, 3)")]
    public decimal? MonthCost { get; set; }

    [Column("month_price", TypeName = "decimal(18, 3)")]
    public decimal? MonthPrice { get; set; }

    [Column("con_cost", TypeName = "decimal(18, 3)")]
    public decimal? ConCost { get; set; }

    [Column("con_price", TypeName = "decimal(18, 3)")]
    public decimal? ConPrice { get; set; }

    [Column("allow_km", TypeName = "decimal(18, 3)")]
    public decimal? AllowKm { get; set; }

    [Column("cost_km", TypeName = "decimal(18, 3)")]
    public decimal? CostKm { get; set; }

    [Column("car_counter", TypeName = "decimal(18, 0)")]
    public decimal? CarCounter { get; set; }

    [Column("maintenance_all")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MaintenanceAll { get; set; }

    [Column("maintenance_next_date", TypeName = "datetime")]
    public DateTime? MaintenanceNextDate { get; set; }

    [Column("maintenance_place")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MaintenancePlace { get; set; }

    [Column("access_card")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AccessCard { get; set; }

    [Column("term_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term1 { get; set; }

    [Column("term_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term2 { get; set; }

    [Column("term_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term3 { get; set; }

    [Column("term_4")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term4 { get; set; }

    [Column("term_5")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term5 { get; set; }

    [Column("term_6")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term6 { get; set; }

    [Column("term_7")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term7 { get; set; }

    [Column("term_8")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term8 { get; set; }

    [Column("term_9")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term9 { get; set; }

    [Column("photo_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("photo_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo2 { get; set; }

    [Column("photo_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo3 { get; set; }

    [Column("photo_4")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo4 { get; set; }

    [Column("photo_5")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo5 { get; set; }

    [Column("photo_6")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo6 { get; set; }

    [Column("photo_7")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo7 { get; set; }

    [Column("photo_8")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo8 { get; set; }

    [Column("photo_9")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo9 { get; set; }

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

    [Column("desc_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc1 { get; set; }

    [Column("desc_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc2 { get; set; }

    [Column("desc_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc3 { get; set; }

    [Column("desc_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc4 { get; set; }

    [Column("desc_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc5 { get; set; }

    [Column("desc_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc6 { get; set; }

    [Column("desc_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc7 { get; set; }

    [Column("desc_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc8 { get; set; }

    [Column("desc_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc9 { get; set; }

    [Column("desc_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Desc10 { get; set; }

    [Column("cont_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ContStatus { get; set; }

    [Column("ven_recived_by")]
    [StringLength(100)]
    [Unicode(false)]
    public string? VenRecivedBy { get; set; }

    [Column("ven_recived_date", TypeName = "datetime")]
    public DateTime? VenRecivedDate { get; set; }

    [Column("ven_recived_time", TypeName = "datetime")]
    public DateTime? VenRecivedTime { get; set; }

    [Column("cust_recived_by")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CustRecivedBy { get; set; }

    [Column("cust_recived_date", TypeName = "datetime")]
    public DateTime? CustRecivedDate { get; set; }

    [Column("cust_recived_time", TypeName = "datetime")]
    public DateTime? CustRecivedTime { get; set; }
}
