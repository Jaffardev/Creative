﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("cnt_responser")]
public partial class CntResponser
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

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("mobile")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [Column("fax")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("email")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("titel")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Titel { get; set; }

    [Column("id_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

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
