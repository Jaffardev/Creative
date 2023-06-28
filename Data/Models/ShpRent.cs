using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("shp_rent")]
public partial class ShpRent
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

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("trans_day", TypeName = "datetime")]
    public DateTime? TransDay { get; set; }

    [Column("ship_id", TypeName = "decimal(18, 0)")]
    public decimal? ShipId { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("status_01")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status01 { get; set; }

    [Column("con_id_01", TypeName = "decimal(18, 0)")]
    public decimal? ConId01 { get; set; }

    [Column("notes_01")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes01 { get; set; }

    [Column("status_02")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status02 { get; set; }

    [Column("con_id_02", TypeName = "decimal(18, 0)")]
    public decimal? ConId02 { get; set; }

    [Column("notes_02")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes02 { get; set; }

    [Column("status_03")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status03 { get; set; }

    [Column("con_id_03", TypeName = "decimal(18, 0)")]
    public decimal? ConId03 { get; set; }

    [Column("notes_03")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes03 { get; set; }

    [Column("status_04")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status04 { get; set; }

    [Column("con_id_04", TypeName = "decimal(18, 0)")]
    public decimal? ConId04 { get; set; }

    [Column("notes_04")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes04 { get; set; }

    [Column("status_05")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status05 { get; set; }

    [Column("con_id_05", TypeName = "decimal(18, 0)")]
    public decimal? ConId05 { get; set; }

    [Column("notes_05")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes05 { get; set; }

    [Column("status_06")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status06 { get; set; }

    [Column("con_id_06", TypeName = "decimal(18, 0)")]
    public decimal? ConId06 { get; set; }

    [Column("notes_06")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes06 { get; set; }

    [Column("status_07")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status07 { get; set; }

    [Column("con_id_07", TypeName = "decimal(18, 0)")]
    public decimal? ConId07 { get; set; }

    [Column("notes_07")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes07 { get; set; }

    [Column("status_08")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status08 { get; set; }

    [Column("con_id_08", TypeName = "decimal(18, 0)")]
    public decimal? ConId08 { get; set; }

    [Column("notes_08")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes08 { get; set; }

    [Column("status_09")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status09 { get; set; }

    [Column("con_id_09", TypeName = "decimal(18, 0)")]
    public decimal? ConId09 { get; set; }

    [Column("notes_09")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes09 { get; set; }

    [Column("status_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status10 { get; set; }

    [Column("con_id_10", TypeName = "decimal(18, 0)")]
    public decimal? ConId10 { get; set; }

    [Column("notes_10")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes10 { get; set; }

    [Column("status_11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status11 { get; set; }

    [Column("con_id_11", TypeName = "decimal(18, 0)")]
    public decimal? ConId11 { get; set; }

    [Column("notes_11")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes11 { get; set; }

    [Column("status_12")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status12 { get; set; }

    [Column("con_id_12", TypeName = "decimal(18, 0)")]
    public decimal? ConId12 { get; set; }

    [Column("notes_12")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes12 { get; set; }

    [Column("status_13")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status13 { get; set; }

    [Column("con_id_13", TypeName = "decimal(18, 0)")]
    public decimal? ConId13 { get; set; }

    [Column("notes_13")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes13 { get; set; }

    [Column("status_14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status14 { get; set; }

    [Column("con_id_14", TypeName = "decimal(18, 0)")]
    public decimal? ConId14 { get; set; }

    [Column("notes_14")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes14 { get; set; }

    [Column("status_15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status15 { get; set; }

    [Column("con_id_15", TypeName = "decimal(18, 0)")]
    public decimal? ConId15 { get; set; }

    [Column("notes_15")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes15 { get; set; }

    [Column("status_16")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status16 { get; set; }

    [Column("con_id_16", TypeName = "decimal(18, 0)")]
    public decimal? ConId16 { get; set; }

    [Column("notes_16")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes16 { get; set; }

    [Column("status_17")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status17 { get; set; }

    [Column("con_id_17", TypeName = "decimal(18, 0)")]
    public decimal? ConId17 { get; set; }

    [Column("notes_17")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes17 { get; set; }

    [Column("status_18")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status18 { get; set; }

    [Column("con_id_18", TypeName = "decimal(18, 0)")]
    public decimal? ConId18 { get; set; }

    [Column("notes_18")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes18 { get; set; }

    [Column("status_19")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status19 { get; set; }

    [Column("con_id_19", TypeName = "decimal(18, 0)")]
    public decimal? ConId19 { get; set; }

    [Column("notes_19")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes19 { get; set; }

    [Column("status_20")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status20 { get; set; }

    [Column("con_id_20", TypeName = "decimal(18, 0)")]
    public decimal? ConId20 { get; set; }

    [Column("notes_20")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes20 { get; set; }

    [Column("status_21")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status21 { get; set; }

    [Column("con_id_21", TypeName = "decimal(18, 0)")]
    public decimal? ConId21 { get; set; }

    [Column("notes_21")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes21 { get; set; }

    [Column("status_22")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status22 { get; set; }

    [Column("con_id_22", TypeName = "decimal(18, 0)")]
    public decimal? ConId22 { get; set; }

    [Column("notes_22")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes22 { get; set; }

    [Column("status_23")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status23 { get; set; }

    [Column("con_id_23", TypeName = "decimal(18, 0)")]
    public decimal? ConId23 { get; set; }

    [Column("notes_23")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes23 { get; set; }

    [Column("status_24")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status24 { get; set; }

    [Column("con_id_24", TypeName = "decimal(18, 0)")]
    public decimal? ConId24 { get; set; }

    [Column("notes_24")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes24 { get; set; }
}
