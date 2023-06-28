using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("dsp_dispatch_spl")]
public partial class DspDispatchSpl
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("menu_id", TypeName = "decimal(18, 0)")]
    public decimal? MenuId { get; set; }

    [Column("dish_id", TypeName = "decimal(18, 0)")]
    public decimal? DishId { get; set; }

    [Column("qty", TypeName = "decimal(18, 5)")]
    public decimal? Qty { get; set; }

    [Column("sales_price", TypeName = "decimal(18, 5)")]
    public decimal? SalesPrice { get; set; }

    [Column("sal_cust_id", TypeName = "decimal(18, 0)")]
    public decimal? SalCustId { get; set; }

    [Column("cost", TypeName = "decimal(18, 5)")]
    public decimal? Cost { get; set; }

    [Column("meal_reduction_id", TypeName = "decimal(18, 0)")]
    public decimal? MealReductionId { get; set; }

    [Column("qty_reduction", TypeName = "decimal(18, 5)")]
    public decimal? QtyReduction { get; set; }

    [Column("item_category")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ItemCategory { get; set; }

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
