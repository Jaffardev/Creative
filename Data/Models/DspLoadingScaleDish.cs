using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("dsp_loading_scale_dish")]
public partial class DspLoadingScaleDish
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("main_dish_id", TypeName = "decimal(18, 0)")]
    public decimal? MainDishId { get; set; }

    [Column("load_scal_id", TypeName = "decimal(18, 0)")]
    public decimal? LoadScalId { get; set; }

    [Column("row_type")]
    public int? RowType { get; set; }

    [Column("ratio", TypeName = "decimal(18, 5)")]
    public decimal? Ratio { get; set; }

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

    [Column("menu_id", TypeName = "decimal(18, 0)")]
    public decimal? MenuId { get; set; }

    [Column("sal_cust_id", TypeName = "decimal(18, 0)")]
    public decimal? SalCustId { get; set; }

    [Column("dish_id", TypeName = "decimal(18, 0)")]
    public decimal? DishId { get; set; }
}
