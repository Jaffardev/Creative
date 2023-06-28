using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("posr_price_list_h")]
public partial class PosrPriceListH
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

    [Column("disc_ratio", TypeName = "decimal(18, 3)")]
    public decimal? DiscRatio { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("section_id", TypeName = "decimal(18, 0)")]
    public decimal? SectionId { get; set; }

    [Column("table_id", TypeName = "decimal(18, 0)")]
    public decimal? TableId { get; set; }

    [Column("shift_id", TypeName = "decimal(18, 0)")]
    public decimal? ShiftId { get; set; }

    [Column("tax_ratio", TypeName = "decimal(18, 3)")]
    public decimal? TaxRatio { get; set; }

    [Column("tips_amount", TypeName = "decimal(18, 3)")]
    public decimal? TipsAmount { get; set; }

    [Column("serv_ratio", TypeName = "decimal(18, 3)")]
    public decimal? ServRatio { get; set; }

    [Column("sales_man_id", TypeName = "decimal(18, 0)")]
    public decimal? SalesManId { get; set; }

    [Column("reason_id", TypeName = "decimal(18, 0)")]
    public decimal? ReasonId { get; set; }

    [Column("disc_reason")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DiscReason { get; set; }

    [Column("reason_description")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ReasonDescription { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

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
