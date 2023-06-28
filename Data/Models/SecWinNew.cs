using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("sec_win_new")]
public partial class SecWinNew
{
    [Key]
    [Column("ID", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(100)]
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

    [Column("module_id", TypeName = "decimal(18, 0)")]
    public decimal? ModuleId { get; set; }

    [Column("win_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WinType { get; set; }

    [Column("win_sort")]
    public int? WinSort { get; set; }

    [Column("w_new")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WNew { get; set; }

    [Column("w_edit")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WEdit { get; set; }

    [Column("w_delete")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WDelete { get; set; }

    [Column("w_view")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WView { get; set; }

    [Column("w_print")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WPrint { get; set; }

    [Column("w_post")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WPost { get; set; }

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
