using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("crg_shipment")]
public partial class CrgShipment
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

    [Column("dispatch_id", TypeName = "decimal(18, 0)")]
    public decimal? DispatchId { get; set; }

    [Column("cargo_type_id", TypeName = "decimal(18, 0)")]
    public decimal? CargoTypeId { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("description")]
    [StringLength(5000)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("tax_amount", TypeName = "decimal(18, 3)")]
    public decimal? TaxAmount { get; set; }

    [Column("custom_amount", TypeName = "decimal(18, 3)")]
    public decimal? CustomAmount { get; set; }

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("reason")]
    [StringLength(5000)]
    [Unicode(false)]
    public string? Reason { get; set; }

    [Column("weight", TypeName = "decimal(18, 3)")]
    public decimal? Weight { get; set; }

    [Column("length", TypeName = "decimal(18, 3)")]
    public decimal? Length { get; set; }

    [Column("height", TypeName = "decimal(18, 3)")]
    public decimal? Height { get; set; }

    [Column("width", TypeName = "decimal(18, 3)")]
    public decimal? Width { get; set; }

    [Column("items")]
    [StringLength(5000)]
    [Unicode(false)]
    public string? Items { get; set; }

    [Column("coo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Coo { get; set; }

    [Column("shipment_way")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ShipmentWay { get; set; }

    [Column("type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("from_place")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? FromPlace { get; set; }

    [Column("to_place")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ToPlace { get; set; }

    [Column("from_port_id", TypeName = "decimal(18, 0)")]
    public decimal? FromPortId { get; set; }

    [Column("to_port_id", TypeName = "decimal(18, 0)")]
    public decimal? ToPortId { get; set; }

    [Column("shipment_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ShipmentStatus { get; set; }

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

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }
}
