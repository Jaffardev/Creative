using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("gen_graph_d")]
public partial class GenGraphD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("level_no", TypeName = "decimal(18, 0)")]
    public decimal? LevelNo { get; set; }

    [Column("row_cat")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RowCat { get; set; }

    [Column("row_value", TypeName = "decimal(18, 3)")]
    public decimal? RowValue { get; set; }

    [Column("row_series")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RowSeries { get; set; }
}
