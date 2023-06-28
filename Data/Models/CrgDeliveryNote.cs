using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("crg_delivery_note")]
public partial class CrgDeliveryNote
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

    [Column("border_id", TypeName = "decimal(18, 0)")]
    public decimal? BorderId { get; set; }

    [Column("shimpment_id", TypeName = "decimal(18, 0)")]
    public decimal? ShimpmentId { get; set; }

    [Column("driver_id", TypeName = "decimal(18, 0)")]
    public decimal? DriverId { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("country_id", TypeName = "decimal(18, 0)")]
    public decimal? CountryId { get; set; }

    [Column("consignee")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Consignee { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("trans_time", TypeName = "datetime")]
    public DateTime? TransTime { get; set; }

    [Column("cust_ref")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CustRef { get; set; }

    [Column("alert_date", TypeName = "datetime")]
    public DateTime? AlertDate { get; set; }

    [Column("rcv_org_date", TypeName = "datetime")]
    public DateTime? RcvOrgDate { get; set; }

    [Column("rcv_do_date", TypeName = "datetime")]
    public DateTime? RcvDoDate { get; set; }

    [Column("rcv_wtdo_date", TypeName = "datetime")]
    public DateTime? RcvWtdoDate { get; set; }

    [Column("arv_doc_date", TypeName = "datetime")]
    public DateTime? ArvDocDate { get; set; }

    [Column("delivery_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DeliveryType { get; set; }

    [Column("flight_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FlightNo { get; set; }

    [Column("package_no", TypeName = "decimal(18, 3)")]
    public decimal? PackageNo { get; set; }

    [Column("declaration_date", TypeName = "datetime")]
    public DateTime? DeclarationDate { get; set; }

    [Column("declaration_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeclarationNo { get; set; }

    [Column("delivery_place")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeliveryPlace { get; set; }

    [Column("cargo_description")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? CargoDescription { get; set; }

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

    [Column("photo_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

    [Column("torder_id", TypeName = "decimal(18, 0)")]
    public decimal? TorderId { get; set; }

    [Column("dispatch_id", TypeName = "decimal(18, 0)")]
    public decimal? DispatchId { get; set; }
}
