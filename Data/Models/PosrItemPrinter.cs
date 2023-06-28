using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("posr_item_printer")]
public partial class PosrItemPrinter
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

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("print_ord_01")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd01 { get; set; }

    [Column("print_ord_02")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd02 { get; set; }

    [Column("print_ord_03")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd03 { get; set; }

    [Column("print_ord_04")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd04 { get; set; }

    [Column("print_ord_05")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd05 { get; set; }

    [Column("print_ord_06")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd06 { get; set; }

    [Column("print_ord_07")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd07 { get; set; }

    [Column("print_ord_08")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd08 { get; set; }

    [Column("print_ord_09")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd09 { get; set; }

    [Column("print_ord_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintOrd10 { get; set; }

    [Column("print_inv_01")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv01 { get; set; }

    [Column("print_inv_02")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv02 { get; set; }

    [Column("print_inv_03")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv03 { get; set; }

    [Column("print_inv_04")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv04 { get; set; }

    [Column("print_inv_05")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv05 { get; set; }

    [Column("print_inv_06")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv06 { get; set; }

    [Column("print_inv_07")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv07 { get; set; }

    [Column("print_inv_08")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv08 { get; set; }

    [Column("print_inv_09")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv09 { get; set; }

    [Column("print_inv_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PrintInv10 { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("unit_price", TypeName = "decimal(18, 3)")]
    public decimal? UnitPrice { get; set; }

    [Column("sel_unit_id", TypeName = "decimal(18, 0)")]
    public decimal? SelUnitId { get; set; }
}
