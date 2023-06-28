using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("sec_user_win")]
public partial class SecUserWin
{
    [Key]
    [Column("ID", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("user_id", TypeName = "decimal(18, 0)")]
    public decimal? UserId { get; set; }

    [Column("win_id", TypeName = "decimal(18, 0)")]
    public decimal? WinId { get; set; }

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
