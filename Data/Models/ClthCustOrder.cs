using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("clth_cust_order")]
public partial class ClthCustOrder
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

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("qty", TypeName = "decimal(18, 4)")]
    public decimal? Qty { get; set; }

    [Column("price", TypeName = "decimal(18, 4)")]
    public decimal? Price { get; set; }

    [Column("total", TypeName = "decimal(18, 4)")]
    public decimal? Total { get; set; }

    [Column("discount", TypeName = "decimal(18, 4)")]
    public decimal? Discount { get; set; }

    [Column("cost", TypeName = "decimal(18, 4)")]
    public decimal? Cost { get; set; }

    [Column("pay_")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pay { get; set; }

    [Column("pay_amount_", TypeName = "decimal(18, 4)")]
    public decimal? PayAmount { get; set; }

    [Column("pay_date_", TypeName = "datetime")]
    public DateTime? PayDate { get; set; }

    [Column("pay_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pay1 { get; set; }

    [Column("pay_amount_1", TypeName = "decimal(18, 4)")]
    public decimal? PayAmount1 { get; set; }

    [Column("pay_date_1", TypeName = "datetime")]
    public DateTime? PayDate1 { get; set; }

    [Column("pay_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pay2 { get; set; }

    [Column("pay_amount_2", TypeName = "decimal(18, 4)")]
    public decimal? PayAmount2 { get; set; }

    [Column("pay_date_2", TypeName = "datetime")]
    public DateTime? PayDate2 { get; set; }

    [Column("pay_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pay3 { get; set; }

    [Column("pay_amount_3", TypeName = "decimal(18, 4)")]
    public decimal? PayAmount3 { get; set; }

    [Column("pay_date_3", TypeName = "datetime")]
    public DateTime? PayDate3 { get; set; }

    [Column("pay_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pay4 { get; set; }

    [Column("pay_amount_4", TypeName = "decimal(18, 4)")]
    public decimal? PayAmount4 { get; set; }

    [Column("pay_date_4", TypeName = "datetime")]
    public DateTime? PayDate4 { get; set; }

    [Column("pay_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pay5 { get; set; }

    [Column("pay_amount_5", TypeName = "decimal(18, 4)")]
    public decimal? PayAmount5 { get; set; }

    [Column("pay_date_5", TypeName = "datetime")]
    public DateTime? PayDate5 { get; set; }

    [Column("prova_date_1", TypeName = "datetime")]
    public DateTime? ProvaDate1 { get; set; }

    [Column("prova_date_2", TypeName = "datetime")]
    public DateTime? ProvaDate2 { get; set; }

    [Column("receved_date", TypeName = "datetime")]
    public DateTime? RecevedDate { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("path_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Path1 { get; set; }

    [Column("path_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Path2 { get; set; }

    [Column("path_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Path3 { get; set; }

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
}
