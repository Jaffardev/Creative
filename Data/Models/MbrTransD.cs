using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("mbr_trans_d")]
public partial class MbrTransD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("qty", TypeName = "decimal(18, 4)")]
    public decimal? Qty { get; set; }

    [Column("price", TypeName = "decimal(18, 4)")]
    public decimal? Price { get; set; }

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

    [Column("pay_qty", TypeName = "decimal(18, 4)")]
    public decimal? PayQty { get; set; }

    [Column("pay_amount", TypeName = "decimal(18, 4)")]
    public decimal? PayAmount { get; set; }

    [Column("tel_comtion", TypeName = "decimal(18, 4)")]
    public decimal? TelComtion { get; set; }

    [Column("driver_comtion", TypeName = "decimal(18, 4)")]
    public decimal? DriverComtion { get; set; }

    [Column("return_reson")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ReturnReson { get; set; }

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
}
