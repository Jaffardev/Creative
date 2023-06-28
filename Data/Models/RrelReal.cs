using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rrel_real")]
[Index("Code", Name = "ix_rrel_real", IsUnique = true)]
public partial class RrelReal
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

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("real_kind")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RealKind { get; set; }

    [Column("location")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Location { get; set; }

    [Column("portfolio_id", TypeName = "decimal(18, 0)")]
    public decimal? PortfolioId { get; set; }

    [Column("real_type_id")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RealTypeId { get; set; }

    [Column("floor_no", TypeName = "decimal(18, 0)")]
    public decimal? FloorNo { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("unit_no", TypeName = "decimal(18, 0)")]
    public decimal? UnitNo { get; set; }

    [Column("part_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PartNo { get; set; }

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

    [Column("fax_no")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FaxNo { get; set; }

    [Column("email")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("web_sit")]
    [StringLength(100)]
    [Unicode(false)]
    public string? WebSit { get; set; }

    [Column("air_type_id", TypeName = "decimal(18, 0)")]
    public decimal? AirTypeId { get; set; }

    [Column("emp_doorman_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpDoormanId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("satellite")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Satellite { get; set; }

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

    [Column("gam")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Gam { get; set; }

    [Column("balcony")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Balcony { get; set; }

    [Column("barking_no", TypeName = "decimal(18, 0)")]
    public decimal? BarkingNo { get; set; }

    [Column("basement_no", TypeName = "decimal(18, 0)")]
    public decimal? BasementNo { get; set; }

    [Column("build_date", TypeName = "datetime")]
    public DateTime? BuildDate { get; set; }

    [Column("area", TypeName = "decimal(18, 3)")]
    public decimal? Area { get; set; }

    [Column("out_view_id", TypeName = "decimal(18, 0)")]
    public decimal? OutViewId { get; set; }

    [Column("real_status_id", TypeName = "decimal(18, 0)")]
    public decimal? RealStatusId { get; set; }

    [Column("sales_ratio", TypeName = "decimal(18, 5)")]
    public decimal? SalesRatio { get; set; }

    [Column("real_market_amount", TypeName = "decimal(18, 3)")]
    public decimal? RealMarketAmount { get; set; }

    [Column("real_actual_amount", TypeName = "decimal(18, 3)")]
    public decimal? RealActualAmount { get; set; }

    [Column("real_income", TypeName = "decimal(18, 3)")]
    public decimal? RealIncome { get; set; }

    [Column("pur_date", TypeName = "datetime")]
    public DateTime? PurDate { get; set; }

    [Column("pur_con_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PurConNo { get; set; }

    [Column("reg_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RegNo { get; set; }

    [Column("reg_date", TypeName = "datetime")]
    public DateTime? RegDate { get; set; }

    [Column("owner")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Owner { get; set; }

    [Column("pur_by")]
    [StringLength(200)]
    [Unicode(false)]
    public string? PurBy { get; set; }

    [Column("pur_amount", TypeName = "decimal(18, 3)")]
    public decimal? PurAmount { get; set; }

    [Column("pur_commission", TypeName = "decimal(18, 3)")]
    public decimal? PurCommission { get; set; }

    [Column("pur_exp", TypeName = "decimal(18, 3)")]
    public decimal? PurExp { get; set; }

    [Column("sale_data")]
    [StringLength(200)]
    [Unicode(false)]
    public string? SaleData { get; set; }

    [Column("sales_date", TypeName = "datetime")]
    public DateTime? SalesDate { get; set; }

    [Column("sales_by")]
    [StringLength(200)]
    [Unicode(false)]
    public string? SalesBy { get; set; }

    [Column("buyer")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Buyer { get; set; }

    [Column("sales_amount", TypeName = "decimal(18, 3)")]
    public decimal? SalesAmount { get; set; }

    [Column("sales_commission", TypeName = "decimal(18, 3)")]
    public decimal? SalesCommission { get; set; }

    [Column("salse_exp", TypeName = "decimal(18, 3)")]
    public decimal? SalseExp { get; set; }

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

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }
}
