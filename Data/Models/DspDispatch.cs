using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("dsp_dispatch")]
public partial class DspDispatch
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("aircarft_id", TypeName = "decimal(18, 0)")]
    public decimal? AircarftId { get; set; }

    [Column("sector_id", TypeName = "decimal(18, 0)")]
    public decimal? SectorId { get; set; }

    [Column("flight_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FlightNo { get; set; }

    [Column("daparture_date", TypeName = "datetime")]
    public DateTime? DapartureDate { get; set; }

    [Column("sal_cust_id", TypeName = "decimal(18, 0)")]
    public decimal? SalCustId { get; set; }

    [Column("edit_date", TypeName = "datetime")]
    public DateTime? EditDate { get; set; }

    [Column("ddt_date", TypeName = "datetime")]
    public DateTime? DdtDate { get; set; }

    [Column("kdt_date", TypeName = "datetime")]
    public DateTime? KdtDate { get; set; }

    [Column("f_00", TypeName = "decimal(18, 0)")]
    public decimal? F00 { get; set; }

    [Column("f_spl_00", TypeName = "decimal(18, 0)")]
    public decimal? FSpl00 { get; set; }

    [Column("j_00", TypeName = "decimal(18, 0)")]
    public decimal? J00 { get; set; }

    [Column("j_spl_00", TypeName = "decimal(18, 0)")]
    public decimal? JSpl00 { get; set; }

    [Column("y_00", TypeName = "decimal(18, 0)")]
    public decimal? Y00 { get; set; }

    [Column("y_spl_00", TypeName = "decimal(18, 0)")]
    public decimal? YSpl00 { get; set; }

    [Column("w_00", TypeName = "decimal(18, 0)")]
    public decimal? W00 { get; set; }

    [Column("w_spl_00", TypeName = "decimal(18, 0)")]
    public decimal? WSpl00 { get; set; }

    [Column("cc_00", TypeName = "decimal(18, 0)")]
    public decimal? Cc00 { get; set; }

    [Column("dc_00", TypeName = "decimal(18, 0)")]
    public decimal? Dc00 { get; set; }

    [Column("f_48", TypeName = "decimal(18, 0)")]
    public decimal? F48 { get; set; }

    [Column("f_spl_48", TypeName = "decimal(18, 0)")]
    public decimal? FSpl48 { get; set; }

    [Column("j_48", TypeName = "decimal(18, 0)")]
    public decimal? J48 { get; set; }

    [Column("j_spl48", TypeName = "decimal(18, 0)")]
    public decimal? JSpl48 { get; set; }

    [Column("y_48", TypeName = "decimal(18, 0)")]
    public decimal? Y48 { get; set; }

    [Column("y_spl_48", TypeName = "decimal(18, 0)")]
    public decimal? YSpl48 { get; set; }

    [Column("w_48", TypeName = "decimal(18, 0)")]
    public decimal? W48 { get; set; }

    [Column("w_spl_48", TypeName = "decimal(18, 0)")]
    public decimal? WSpl48 { get; set; }

    [Column("cc_48", TypeName = "decimal(18, 0)")]
    public decimal? Cc48 { get; set; }

    [Column("dc_48", TypeName = "decimal(18, 0)")]
    public decimal? Dc48 { get; set; }

    [Column("f_24", TypeName = "decimal(18, 0)")]
    public decimal? F24 { get; set; }

    [Column("f_spl_24", TypeName = "decimal(18, 0)")]
    public decimal? FSpl24 { get; set; }

    [Column("j_24", TypeName = "decimal(18, 0)")]
    public decimal? J24 { get; set; }

    [Column("j_spl_24", TypeName = "decimal(18, 0)")]
    public decimal? JSpl24 { get; set; }

    [Column("y_24", TypeName = "decimal(18, 0)")]
    public decimal? Y24 { get; set; }

    [Column("y_spl_24", TypeName = "decimal(18, 0)")]
    public decimal? YSpl24 { get; set; }

    [Column("w_spl_24", TypeName = "decimal(18, 0)")]
    public decimal? WSpl24 { get; set; }

    [Column("w_24", TypeName = "decimal(18, 0)")]
    public decimal? W24 { get; set; }

    [Column("cc_24", TypeName = "decimal(18, 0)")]
    public decimal? Cc24 { get; set; }

    [Column("dc_24", TypeName = "decimal(18, 0)")]
    public decimal? Dc24 { get; set; }

    [Column("f_12", TypeName = "decimal(18, 0)")]
    public decimal? F12 { get; set; }

    [Column("f_spl_12", TypeName = "decimal(18, 0)")]
    public decimal? FSpl12 { get; set; }

    [Column("j_12", TypeName = "decimal(18, 0)")]
    public decimal? J12 { get; set; }

    [Column("j_spl_12", TypeName = "decimal(18, 0)")]
    public decimal? JSpl12 { get; set; }

    [Column("y_12", TypeName = "decimal(18, 0)")]
    public decimal? Y12 { get; set; }

    [Column("y_spl_12", TypeName = "decimal(18, 0)")]
    public decimal? YSpl12 { get; set; }

    [Column("w_12", TypeName = "decimal(18, 0)")]
    public decimal? W12 { get; set; }

    [Column("w_spl_12", TypeName = "decimal(18, 0)")]
    public decimal? WSpl12 { get; set; }

    [Column("cc_12", TypeName = "decimal(18, 0)")]
    public decimal? Cc12 { get; set; }

    [Column("dc_12", TypeName = "decimal(18, 0)")]
    public decimal? Dc12 { get; set; }

    [Column("f_6", TypeName = "decimal(18, 0)")]
    public decimal? F6 { get; set; }

    [Column("f_spl_6", TypeName = "decimal(18, 0)")]
    public decimal? FSpl6 { get; set; }

    [Column("j_6", TypeName = "decimal(18, 0)")]
    public decimal? J6 { get; set; }

    [Column("j_spl_6", TypeName = "decimal(18, 0)")]
    public decimal? JSpl6 { get; set; }

    [Column("y_6", TypeName = "decimal(18, 0)")]
    public decimal? Y6 { get; set; }

    [Column("y_spl_6", TypeName = "decimal(18, 0)")]
    public decimal? YSpl6 { get; set; }

    [Column("w_6", TypeName = "decimal(18, 0)")]
    public decimal? W6 { get; set; }

    [Column("w_spl_6", TypeName = "decimal(18, 0)")]
    public decimal? WSpl6 { get; set; }

    [Column("cc_6", TypeName = "decimal(18, 0)")]
    public decimal? Cc6 { get; set; }

    [Column("dc_6", TypeName = "decimal(18, 0)")]
    public decimal? Dc6 { get; set; }

    [Column("f_3", TypeName = "decimal(18, 0)")]
    public decimal? F3 { get; set; }

    [Column("f_spl_3", TypeName = "decimal(18, 0)")]
    public decimal? FSpl3 { get; set; }

    [Column("j_3", TypeName = "decimal(18, 0)")]
    public decimal? J3 { get; set; }

    [Column("j_spl_3", TypeName = "decimal(18, 0)")]
    public decimal? JSpl3 { get; set; }

    [Column("y_3", TypeName = "decimal(18, 0)")]
    public decimal? Y3 { get; set; }

    [Column("y_spl_3", TypeName = "decimal(18, 0)")]
    public decimal? YSpl3 { get; set; }

    [Column("w_3", TypeName = "decimal(18, 0)")]
    public decimal? W3 { get; set; }

    [Column("w_spl_3", TypeName = "decimal(18, 0)")]
    public decimal? WSpl3 { get; set; }

    [Column("cc_3", TypeName = "decimal(18, 0)")]
    public decimal? Cc3 { get; set; }

    [Column("dc_3", TypeName = "decimal(18, 0)")]
    public decimal? Dc3 { get; set; }

    [Column("f_l", TypeName = "decimal(18, 0)")]
    public decimal? FL { get; set; }

    [Column("f_spl_l", TypeName = "decimal(18, 0)")]
    public decimal? FSplL { get; set; }

    [Column("j_l", TypeName = "decimal(18, 0)")]
    public decimal? JL { get; set; }

    [Column("j_spl_l", TypeName = "decimal(18, 0)")]
    public decimal? JSplL { get; set; }

    [Column("y_l", TypeName = "decimal(18, 0)")]
    public decimal? YL { get; set; }

    [Column("y_spl_l", TypeName = "decimal(18, 0)")]
    public decimal? YSplL { get; set; }

    [Column("w_l", TypeName = "decimal(18, 0)")]
    public decimal? WL { get; set; }

    [Column("w_spl_l", TypeName = "decimal(18, 0)")]
    public decimal? WSplL { get; set; }

    [Column("cc_l", TypeName = "decimal(18, 0)")]
    public decimal? CcL { get; set; }

    [Column("dc_l", TypeName = "decimal(18, 0)")]
    public decimal? DcL { get; set; }

    [Column("meal_uplift")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MealUplift { get; set; }

    [Column("special_meal")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SpecialMeal { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

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

    [Column("schedule_id", TypeName = "decimal(18, 0)")]
    public decimal? ScheduleId { get; set; }
}
