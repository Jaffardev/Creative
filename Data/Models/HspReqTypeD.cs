using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hsp_req_type_d")]
public partial class HspReqTypeD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("row_type")]
    [StringLength(3)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("label_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Label1 { get; set; }

    [Column("label_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Label2 { get; set; }

    [Column("normal_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Normal1 { get; set; }

    [Column("normal_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Normal2 { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("notes_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes1 { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }
}
