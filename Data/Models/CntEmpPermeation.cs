using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("cnt_emp_permeation")]
public partial class CntEmpPermeation
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

    [Column("p_approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PApprove { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("permeation_id", TypeName = "decimal(18, 0)")]
    public decimal? PermeationId { get; set; }

    [Column("p_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PNo { get; set; }

    [Column("p_start_date", TypeName = "datetime")]
    public DateTime? PStartDate { get; set; }

    [Column("p_end_date", TypeName = "datetime")]
    public DateTime? PEndDate { get; set; }

    [Column("p_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PTel { get; set; }

    [Column("p_other")]
    [StringLength(100)]
    [Unicode(false)]
    public string? POther { get; set; }

    [Column("p_cost", TypeName = "decimal(18, 4)")]
    public decimal? PCost { get; set; }
}
