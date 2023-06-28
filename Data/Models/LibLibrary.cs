﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("lib_library")]
public partial class LibLibrary
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

    [Column("acc_inv_id", TypeName = "decimal(18, 0)")]
    public decimal? AccInvId { get; set; }

    [Column("acc_pur_id", TypeName = "decimal(18, 0)")]
    public decimal? AccPurId { get; set; }

    [Column("acc_sal_id", TypeName = "decimal(18, 0)")]
    public decimal? AccSalId { get; set; }

    [Column("acc_sal_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? AccSalCostId { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("fax")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("address")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("manger")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Manger { get; set; }

    [Column("allow_extrnal")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowExtrnal { get; set; }

    [Column("serialize")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Serialize { get; set; }

    [Column("max_item_no", TypeName = "decimal(18, 0)")]
    public decimal? MaxItemNo { get; set; }

    [Column("max_visitor", TypeName = "decimal(18, 0)")]
    public decimal? MaxVisitor { get; set; }

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
