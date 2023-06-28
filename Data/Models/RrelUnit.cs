using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rrel_unit")]
[Index("Code", "RealId", Name = "ix_rrel_unit", IsUnique = true)]
public partial class RrelUnit
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

    [Column("real_id", TypeName = "decimal(18, 0)")]
    public decimal? RealId { get; set; }

    [Column("floor_id", TypeName = "decimal(18, 0)")]
    public decimal? FloorId { get; set; }

    [Column("block_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BlockNo { get; set; }

    [Column("unit_type_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitTypeId { get; set; }

    [Column("air_type_id", TypeName = "decimal(18, 0)")]
    public decimal? AirTypeId { get; set; }

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

    [Column("rent_amount", TypeName = "decimal(18, 3)")]
    public decimal? RentAmount { get; set; }

    [Column("service_amount", TypeName = "decimal(18, 3)")]
    public decimal? ServiceAmount { get; set; }

    [Column("other_amount", TypeName = "decimal(18, 3)")]
    public decimal? OtherAmount { get; set; }

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

    [Column("owner_id", TypeName = "decimal(18, 0)")]
    public decimal? OwnerId { get; set; }
}
