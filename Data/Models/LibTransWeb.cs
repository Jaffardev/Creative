using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("lib_trans_web")]
public partial class LibTransWeb
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("lib_item_id", TypeName = "decimal(18, 0)")]
    public decimal? LibItemId { get; set; }

    [Column("lib_org_id", TypeName = "decimal(18, 0)")]
    public decimal? LibOrgId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }
}
