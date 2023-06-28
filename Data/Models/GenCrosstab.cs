using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("gen_crosstab")]
public partial class GenCrosstab
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("rep_no", TypeName = "decimal(18, 0)")]
    public decimal? RepNo { get; set; }

    [Column("row_code")]
    [StringLength(500)]
    [Unicode(false)]
    public string? RowCode { get; set; }

    [Column("row_data")]
    [StringLength(500)]
    [Unicode(false)]
    public string? RowData { get; set; }

    [Column("column_code")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ColumnCode { get; set; }

    [Column("column_data")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ColumnData { get; set; }

    [Column("value_data")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ValueData { get; set; }

    [Column("value_amount", TypeName = "decimal(18, 3)")]
    public decimal? ValueAmount { get; set; }

    [Column("group_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Group1 { get; set; }

    [Column("group_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Group2 { get; set; }

    [Column("group_3")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Group3 { get; set; }

    [Column("group_4")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Group4 { get; set; }

    [Column("group_5")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Group5 { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }
}
