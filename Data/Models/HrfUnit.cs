using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hrf_unit")]
public partial class HrfUnit
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

    [Column("ref_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("unit_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? UnitNo { get; set; }

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("ven_id", TypeName = "decimal(18, 0)")]
    public decimal? VenId { get; set; }

    [Column("con_id", TypeName = "decimal(18, 0)")]
    public decimal? ConId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("team_id", TypeName = "decimal(18, 0)")]
    public decimal? TeamId { get; set; }

    [Column("rrel_unit_id", TypeName = "decimal(18, 0)")]
    public decimal? RrelUnitId { get; set; }

    [Column("floor")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Floor { get; set; }

    [Column("block_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BlockNo { get; set; }

    [Column("unit_type")]
    [StringLength(50)]
    [Unicode(false)]
    public string? UnitType { get; set; }

    [Column("air_type")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AirType { get; set; }

    [Column("area", TypeName = "decimal(18, 3)")]
    public decimal? Area { get; set; }

    [Column("room_no", TypeName = "decimal(18, 0)")]
    public decimal? RoomNo { get; set; }

    [Column("bathroom_no", TypeName = "decimal(18, 0)")]
    public decimal? BathroomNo { get; set; }

    [Column("balcony_no", TypeName = "decimal(18, 0)")]
    public decimal? BalconyNo { get; set; }

    [Column("chechen_no", TypeName = "decimal(18, 0)")]
    public decimal? ChechenNo { get; set; }

    [Column("hole_no", TypeName = "decimal(18, 0)")]
    public decimal? HoleNo { get; set; }

    [Column("servant")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Servant { get; set; }

    [Column("address")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("city")]
    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [Column("part_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PartNo { get; set; }

    [Column("street")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Street { get; set; }

    [Column("kasema_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? KasemaNo { get; set; }

    [Column("building_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BuildingNo { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("furnished")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Furnished { get; set; }

    [Column("furnished_desc")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? FurnishedDesc { get; set; }

    [Column("satellite")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Satellite { get; set; }

    [Column("satellite_desc")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? SatelliteDesc { get; set; }

    [Column("satellite_date", TypeName = "datetime")]
    public DateTime? SatelliteDate { get; set; }

    [Column("internet")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Internet { get; set; }

    [Column("golf")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Golf { get; set; }

    [Column("swimming")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Swimming { get; set; }

    [Column("gym")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Gym { get; set; }

    [Column("gym_date", TypeName = "datetime")]
    public DateTime? GymDate { get; set; }

    [Column("balcony")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Balcony { get; set; }

    [Column("barking_no", TypeName = "decimal(18, 0)")]
    public decimal? BarkingNo { get; set; }

    [Column("basement_no", TypeName = "decimal(18, 0)")]
    public decimal? BasementNo { get; set; }

    [Column("rent_cost", TypeName = "decimal(18, 3)")]
    public decimal? RentCost { get; set; }

    [Column("service_cost", TypeName = "decimal(18, 3)")]
    public decimal? ServiceCost { get; set; }

    [Column("other_cost", TypeName = "decimal(18, 3)")]
    public decimal? OtherCost { get; set; }

    [Column("rent_price", TypeName = "decimal(18, 3)")]
    public decimal? RentPrice { get; set; }

    [Column("service_price", TypeName = "decimal(18, 3)")]
    public decimal? ServicePrice { get; set; }

    [Column("other_price", TypeName = "decimal(18, 3)")]
    public decimal? OtherPrice { get; set; }

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

    [Column("building_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BuildingName { get; set; }

    [Column("furniture")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Furniture { get; set; }

    [Column("osn_cost", TypeName = "decimal(18, 3)")]
    public decimal? OsnCost { get; set; }

    [Column("person_no", TypeName = "decimal(18, 0)")]
    public decimal? PersonNo { get; set; }

    [Column("gym_name")]
    [StringLength(500)]
    [Unicode(false)]
    public string? GymName { get; set; }

    [Column("tel_end_date_1", TypeName = "datetime")]
    public DateTime? TelEndDate1 { get; set; }

    [Column("tel_end_date_2", TypeName = "datetime")]
    public DateTime? TelEndDate2 { get; set; }

    [Column("internet_end_date", TypeName = "datetime")]
    public DateTime? InternetEndDate { get; set; }

    [Column("router_4g_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Router4gNo { get; set; }

    [Column("router_4g_end_date", TypeName = "datetime")]
    public DateTime? Router4gEndDate { get; set; }

    [Column("keys_no", TypeName = "decimal(18, 0)")]
    public decimal? KeysNo { get; set; }

    [Column("maint_person")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MaintPerson { get; set; }

    [Column("maint_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? MaintTel { get; set; }

    [Column("maint_description")]
    [StringLength(500)]
    [Unicode(false)]
    public string? MaintDescription { get; set; }

    [Column("clearing_service")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ClearingService { get; set; }

    [Column("clearing_description")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ClearingDescription { get; set; }

    [Column("clearing_end_date", TypeName = "datetime")]
    public DateTime? ClearingEndDate { get; set; }

    [Column("clearing_cost", TypeName = "decimal(18, 3)")]
    public decimal? ClearingCost { get; set; }

    [Column("clearing_price", TypeName = "decimal(18, 3)")]
    public decimal? ClearingPrice { get; set; }

    [Column("others_service")]
    [StringLength(1)]
    [Unicode(false)]
    public string? OthersService { get; set; }

    [Column("others_description")]
    [StringLength(500)]
    [Unicode(false)]
    public string? OthersDescription { get; set; }

    [Column("others_end_date", TypeName = "datetime")]
    public DateTime? OthersEndDate { get; set; }

    [Column("others_cost", TypeName = "decimal(18, 3)")]
    public decimal? OthersCost { get; set; }

    [Column("others_price", TypeName = "decimal(18, 3)")]
    public decimal? OthersPrice { get; set; }

    [Column("unit_people")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? UnitPeople { get; set; }
}
