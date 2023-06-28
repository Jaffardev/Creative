using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("crg_dispatch")]
public partial class CrgDispatch
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

    [Column("order_h_id", TypeName = "decimal(18, 0)")]
    public decimal? OrderHId { get; set; }

    [Column("con_id", TypeName = "decimal(18, 0)")]
    public decimal? ConId { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("from_port_id", TypeName = "decimal(18, 0)")]
    public decimal? FromPortId { get; set; }

    [Column("to_port_id", TypeName = "decimal(18, 0)")]
    public decimal? ToPortId { get; set; }

    [Column("load_date", TypeName = "datetime")]
    public DateTime? LoadDate { get; set; }

    [Column("load_from")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LoadFrom { get; set; }

    [Column("load_to")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LoadTo { get; set; }

    [Column("transload")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Transload { get; set; }

    [Column("qty", TypeName = "decimal(18, 3)")]
    public decimal? Qty { get; set; }

    [Column("cust_job_ref")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CustJobRef { get; set; }

    [Column("car_gcc_no", TypeName = "decimal(18, 3)")]
    public decimal? CarGccNo { get; set; }

    [Column("est_delivery_date", TypeName = "datetime")]
    public DateTime? EstDeliveryDate { get; set; }

    [Column("est_delivery_time", TypeName = "datetime")]
    public DateTime? EstDeliveryTime { get; set; }

    [Column("delivery_date", TypeName = "datetime")]
    public DateTime? DeliveryDate { get; set; }

    [Column("delivery_time", TypeName = "datetime")]
    public DateTime? DeliveryTime { get; set; }

    [Column("est_arrive_date", TypeName = "datetime")]
    public DateTime? EstArriveDate { get; set; }

    [Column("est_arrive_time", TypeName = "datetime")]
    public DateTime? EstArriveTime { get; set; }

    [Column("arrive_date", TypeName = "datetime")]
    public DateTime? ArriveDate { get; set; }

    [Column("arrive_time", TypeName = "datetime")]
    public DateTime? ArriveTime { get; set; }

    [Column("bill_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BillNo { get; set; }

    [Column("ref_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("ref_date", TypeName = "datetime")]
    public DateTime? RefDate { get; set; }

    [Column("weight", TypeName = "decimal(18, 3)")]
    public decimal? Weight { get; set; }

    [Column("volume", TypeName = "decimal(18, 3)")]
    public decimal? Volume { get; set; }

    [Column("comr_inv_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ComrInvNo { get; set; }

    [Column("iraq_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? IraqNo { get; set; }

    [Column("doc_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

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
}
